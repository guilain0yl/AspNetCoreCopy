using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Microsoft.AspNetCore.JsonPatch
{
    internal class Resources
    {
        internal static string FormatCannotCopyProperty(string s0) => string.Format("The property at '{0}' could not be copied.", s0);
        internal static string FormatCannotDeterminePropertyType(string s0) => string.Format("The type of the property at path '{0}' could not be determined.", s0);
        internal static string FormatCannotPerformOperation(string s0, string s1) => string.Format("The '{0}' operation at path '{1}' could not be performed.", s0, s1);
        internal static string FormatCannotReadProperty(string s0) => string.Format("The property at '{0}' could not be read.", s0);
        internal static string FormatCannotUpdateProperty(string s0) => string.Format("The property at path '{0}' could not be updated.", s0);
        internal static string FormatExpressionTypeNotSupported(Expression s0) => string.Format("The expression '{0}' is not supported. Supported expressions include member access and indexer expressions.", s0);
        internal static string FormatIndexOutOfBounds(string s0) => string.Format("The index value provided by path segment '{0}' is out of bounds of the array size.", s0);
        internal static string FormatInvalidIndexValue(string s0) => string.Format("The path segment '{0}' is invalid for an array index.", s0);
        internal static string InvalidJsonPatchDocument = "The JSON patch document was malformed and could not be parsed.";
        internal static string FormatInvalidJsonPatchOperation(string s0) => string.Format("Invalid JsonPatch operation '{0}'.", s0);
        internal static string FormatInvalidPathSegment(string s0) => string.Format("The provided path segment '{0}' cannot be converted to the target type.", s0);
        internal static string FormatInvalidValueForPath(string s0) => string.Format("The provided string '{0}' is an invalid path.", s0);
        internal static string FormatInvalidValueForProperty(object s0) => string.Format("The value '{0}' is invalid for target location.", s0);
        internal static string FormatParameterMustMatchType(string s0, string s1) => string.Format("'{0}' must be of type '{1}'.", s0, s1);
        internal static string FormatPatchNotSupportedForArrays(string s0) => string.Format("The type '{0}' which is an array is not supported for json patch operations as it has a fixed size.", s0);
        internal static string FormatPatchNotSupportedForNonGenericLists(string s0) => string.Format("The type '{0}' which is a non generic list is not supported for json patch operations. Only generic list types are supported.", s0);
        internal static string FormatTargetLocationAtPathSegmentNotFound(string s0) => string.Format("The target location specified by path segment '{0}' was not found.", s0);
        internal static string FormatTargetLocationNotFound(string s0, string s1) => string.Format("For operation '{0}', the target location specified by path '{1}' was not found.", s0, s1);
        internal static string TestOperationNotSupported = "The test operation is not supported.";
        internal static string FormatValueAtListPositionNotEqualToTestValue(object s0, object s1, int s2) => string.Format("The current value '{0}' at position '{2}' is not equal to the test value '{1}'.", s0, s1, s2);
        internal static string FormatValueForTargetSegmentCannotBeNullOrEmpty(string s0) => string.Format("The value at '{0}' cannot be null or empty to perform the test operation.", s0);
        internal static string FormatValueNotEqualToTestValue(object s0, object s1, string s2) => string.Format("The current value '{0}' at path '{2}' is not equal to the test value '{1}'.", s0, s1, s2);
    }
}
