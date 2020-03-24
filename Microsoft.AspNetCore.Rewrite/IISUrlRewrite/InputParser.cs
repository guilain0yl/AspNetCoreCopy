// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Rewrite.PatternSegments;

namespace Microsoft.AspNetCore.Rewrite.IISUrlRewrite
{
    internal class InputParser
    {
        private const char Colon = ':';
        private const char OpenBrace = '{';
        private const char CloseBrace = '}';
        private readonly IISRewriteMapCollection _rewriteMaps;
        private readonly bool _alwaysUseManagedServerVariables;

        public InputParser()
        {
        }

        public InputParser(IISRewriteMapCollection rewriteMaps, bool alwaysUseManagedServerVariables)
        {
            _rewriteMaps = rewriteMaps;
            _alwaysUseManagedServerVariables = alwaysUseManagedServerVariables;
        }

        /// <summary>
        /// Creates a pattern, which is a template to create a new test string to
        /// compare to the condition. Can contain server variables, back references, etc.
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>A new <see cref="Pattern"/>, containing a list of <see cref="PatternSegment"/></returns>
        public Pattern ParseInputString(string testString)
        {
            return ParseInputString(testString, UriMatchPart.Path);
        }

        /// <summary>
        /// Creates a pattern, which is a template to create a new test string to
        /// compare to the condition. Can contain server variables, back references, etc.
        /// </summary>
        /// <param name="testString"></param>
        /// <param name="uriMatchPart">When testString evaluates to a URL segment, specify which part of the URI to evaluate.</param>
        /// <returns>A new <see cref="Pattern"/>, containing a list of <see cref="PatternSegment"/></returns>
        public Pattern ParseInputString(string testString, UriMatchPart uriMatchPart)
        {
            if (testString == null)
            {
                testString = string.Empty;
            }

            var context = new ParserContext(testString);
            return ParseString(context, uriMatchPart);
        }

        private Pattern ParseString(ParserContext context, UriMatchPart uriMatchPart)
        {
            var results = new List<PatternSegment>();
            while (context.Next())
            {
                if (context.Current == OpenBrace)
                {
                    // This is a server parameter, parse for a condition variable
                    if (!context.Next())
                    {
                        // missing {
                        throw new FormatException($"Missing close brace for parameter at string index: '{context.Index}'");
                    }
                    ParseParameter(context, results, uriMatchPart);
                }
                else if (context.Current == CloseBrace)
                {
                    return new Pattern(results);
                }
                else
                {
                    // Parse for literals, which will return on either the end of the test string 
                    // or when it hits a special character
                    ParseLiteral(context, results);
                }
            }
            return new Pattern(results);
        }

        private void ParseParameter(ParserContext context, IList<PatternSegment> results, UriMatchPart uriMatchPart)
        {
            context.Mark();
            // Four main cases:
            // 1. {NAME} - Server Variable, create lambda to get the part of the context
            // 2. {R:1}  - IRule parameter
            // 3. {C:1}  - Condition Parameter
            // 4. {function:xxx} - String function 
            // (unless we support Reload)
            string parameter;
            while (context.Next())
            {
                if (context.Current == CloseBrace)
                {
                    // This is just a server variable, so we do a lookup and verify the server variable exists.
                    parameter = context.Capture();
                    results.Add(ServerVariables.FindServerVariable(parameter, context, uriMatchPart, _alwaysUseManagedServerVariables));
                    return;
                }
                else if (context.Current == Colon)
                {
                    parameter = context.Capture();

                    // Only 5 strings to expect here. Case sensitive.
                    switch (parameter)
                    {
                        case "ToLower":
                            {
                                var pattern = ParseString(context, uriMatchPart);
                                results.Add(new ToLowerSegment(pattern));

                                // at this point, we expect our context to be on the ending closing brace,
                                // because the ParseString() call will increment the context until it 
                                // has processed the new string.
                                if (context.Current != CloseBrace)
                                {
                                    throw new FormatException($"Missing close brace for parameter at string index: '{context.Index}'");
                                }
                                return;
                            }
                        case "UrlDecode":
                            {
                                throw new NotImplementedException("UrlDecode is not implemented because of no great library available");
                            }
                        case "UrlEncode":
                            {
                                var pattern = ParseString(context, uriMatchPart);
                                results.Add(new UrlEncodeSegment(pattern));

                                if (context.Current != CloseBrace)
                                {
                                    throw new FormatException($"Missing close brace for parameter at string index: '{context.Index}'");
                                }
                                return;
                            }
                        case "R":
                            {
                                var index = GetBackReferenceIndex(context);
                                results.Add(new RuleMatchSegment(index));
                                return;
                            }
                        case "C":
                            {
                                var index = GetBackReferenceIndex(context);
                                results.Add(new ConditionMatchSegment(index));
                                return;
                            }
                        default:
                            var rewriteMap = _rewriteMaps?[parameter];
                            if (rewriteMap != null)
                            {
                                var pattern = ParseString(context, uriMatchPart);
                                results.Add(new RewriteMapSegment(rewriteMap, pattern));
                                return;
                            }
                            throw new FormatException($"Unrecognized parameter type: '{parameter}', terminated at string index: '{context.Index}'");
                    }
                }
            }
            throw new FormatException($"Missing close brace for parameter at string index: '{context.Index}'");
        }

        private static int GetBackReferenceIndex(ParserContext context)
        {
            if (!context.Next())
            {
                throw new FormatException($"Missing backreference for parameter at string index: '{context.Index}'");
            }

            context.Mark();
            while (context.Current != CloseBrace)
            {
                if (!context.Next())
                {
                    throw new FormatException($"Missing close brace for parameter at string index: '{context.Index}'");
                }
            }

            var res = context.Capture();
            int index;
            if (!int.TryParse(res, NumberStyles.None, CultureInfo.InvariantCulture, out index))
            {
                throw new FormatException($"Cannot parse '{res}' to integer at string index: '{context.Index}'");
            }

            if (index > 9 || index < 0)
            {
                throw new FormatException($"Index out of range for backreference: '{res}' at string index: '{context.Index}'");
            }
            return index;
        }

        private static void ParseLiteral(ParserContext context, IList<PatternSegment> results)
        {
            context.Mark();
            string literal;
            while (true)
            {
                if (context.Current == OpenBrace || context.Current == CloseBrace)
                {
                    literal = context.Capture();
                    context.Back();
                    break;
                }

                if (!context.Next())
                {
                    literal = context.Capture();
                    break;
                }
            }

            results.Add(new LiteralSegment(literal));
        }
    }
}