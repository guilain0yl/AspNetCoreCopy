using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    internal class Resources
    {
        internal static string FormatPropertyOfTypeCannotBeNull(string s0, string s1) => string.Format("The '{0}' property of '{1}' must not be null.", s0, s1);
        internal static string FormatActivatedInstance_MustBeAnInstanceOf(string s0, string s1) => string.Format("Page created by '{0}' must be an instance of '{1}'.", s0, s1);
        internal static string FormatPageViewResult_ContextIsInvalid(string s0, string s1, string s2) => string.Format("The context used to execute '{0}' must be an instance of '{1}'. Returning a '{2}' from a controller is a not supported.", s0, s1, s2);
        internal static string ArgumentCannotBeNullOrEmpty = "Value cannot be null or empty.";
        internal static string FormatUnsupportedHandlerMethodType(Type s0) => string.Format("Unsupported handler method return type '{0}'.", s0);
        internal static string FormatAmbiguousHandler(string s0, string s1) => string.Format("Multiple handlers matched. The following handlers matched route data and had all constraints satisfied:{0}{0}{1}", s0, s1);
        internal static string PathMustBeRootRelativePath = "Path must be a root relative path that starts with a forward slash '/'.";
        internal static string FormatAsyncPageFilter_InvalidShortCircuit(string s0, string s1, string s2, string s3) => string.Format("If an {0} provides a result value by setting the {1} property of {2} to a non-null value, then it cannot call the next filter by invoking {3}.", s0, s1, s2, s3);
        internal static string FormatInvalidPageType_WrongBase(string s0, string s1) => string.Format("The type '{0}' is not a valid page. A page must inherit from '{1}'.", s0, s1);
        internal static string FormatInvalidPageType_NoModelProperty(string s0, string s1) => string.Format("The type '{0}' is not a valid page. A page must define a public, non-static '{1}' property.", s0, s1);
        internal static string FormatInvalidValidPageName(string s0) => string.Format("'{0}' is not a valid page name. A page name is path relative to the Razor Pages root directory that starts with a leading forward slash ('/') and does not contain the file extension e.g \"/Users/Edit\".", s0);
        internal static string FormatInvalidActionDescriptorModelType(string s0, string s1, string s2) => string.Format("The model type for '{0}' is of type '{1}' which is not assignable to its declared model type '{2}'.", s0, s1, s2);
    }
}
