using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.TagHelpers
{
    internal class Resources
    {
        internal static string FormatCannotDetermineAttributeFor(string s0, string s1) => string.Format("Cannot determine the '{0}' attribute for {1}. The following attributes are mutually exclusive:", s0, s1);
        internal static string FormatAnchorTagHelper_CannotOverrideHref(string s0, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11) => string.Format("Cannot override the '{0}' attribute for {1}. An {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}' or '{11}' attribute.", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
        internal static string FormatFormTagHelper_CannotOverrideAction(string s0, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9) => string.Format("Cannot override the '{0}' attribute for {1}. A {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9);
        internal static string FormatInputTagHelper_InvalidExpressionResult(string s0, string s1, string s2, string s3, string s4, string s5, string s6) => string.Format("Unexpected '{1}' expression result type '{2}' for {0}. '{1}' must be of type '{3}' or '{4}' that can be parsed as a '{3}' if '{5}' is '{6}'.", s0, s1, s2, s3, s4, s5, s6);
        internal static string FormatInputTagHelper_InvalidStringResult(string s0, string s1, string s2) => string.Format("Unexpected expression result value '{1}' for {0}. '{1}' cannot be parsed as a '{2}'.", s0, s1, s2);
        internal static string FormatInputTagHelper_ValueRequired(string s0, string s1, string s2, string s3) => string.Format("'{1}' must not be null for {0} if '{2}' is '{3}'.", s0, s1, s2, s3);
        internal static string FormatTagHelpers_NoProvidedMetadata(string s0, string s1, string s2, string s3) => string.Format("The {2} was unable to provide metadata about '{1}' expression value '{3}' for {0}.", s0, s1, s2, s3);
        internal static string FormatInvalidEnumArgument(string s0, RenderMode s1, string s2) => string.Format("The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.", s0, s1, s2);
        internal static string FormatInvalidEnumArgument(string s0, ValidationSummary s1, string s2) => string.Format("The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.", s0, s1, s2);
        internal static string FormatTagHelperOutput_AttributeDoesNotExist(string s0, string s1) => string.Format("The attribute '{0}' does not exist in the {1}.", s0, s1);
        internal static string FormatPropertyOfTypeCannotBeNull(string s0, string s1) => string.Format("The '{0}' property of '{1}' must not be null.", s0, s1);
        internal static string FormatFormActionTagHelper_CannotOverrideFormAction(string s0, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9) => string.Format("Cannot override the '{0}' attribute for <{1}>. <{1}> elements with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.", s0, s1, s2, s3, s4, s5, s6, s7, s8, s9);
        internal static string ArgumentCannotContainHtmlSpace = "Value cannot contain HTML space characters.";
        internal static string FormatViewEngine_PartialViewNotFound(string s0, string s1) => string.Format("The partial view '{0}' was not found. The following locations were searched:{1}", s0, s1);
        internal static string FormatPartialTagHelper_InvalidModelAttributes(string s0, string s1, string s2) => string.Format("Cannot use '{0}' with both '{1}' and '{2}' attributes.", s0, s1, s2);
        internal static string FormatViewEngine_FallbackViewNotFound(string s0, string s1) => string.Format("The fallback partial view '{0}' was not found. The following locations were searched:{1}", s0, s1);
        internal static string FormatAttributeIsRequired(string s0, string s1) => string.Format("A value for the '{0}' attribute must be supplied to the '{1}' tag helper.", s0, s1);
    }
}
