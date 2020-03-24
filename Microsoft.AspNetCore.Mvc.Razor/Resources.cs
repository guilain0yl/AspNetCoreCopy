using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.Razor
{
    class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty = "Value cannot be null or empty.";
        internal static string CompilationFailed = "One or more compilation failures occurred:";
        internal static string FormatFlushPointCannotBeInvoked(string s0) => string.Format("'{0}' cannot be invoked when a Layout page is set to be executed.", s0);
        internal static string FormatLayoutCannotBeLocated(string s0, string s1) => string.Format("The layout view '{0}' could not be located. The following locations were searched:{1}", s0, s1);
        internal static string FormatLayoutCannotBeRendered(string s0, string s1) => string.Format("Layout page '{0}' cannot be rendered after '{1}' has been invoked.", s0, s1);
        internal static string RazorPage_ThereIsNoActiveWritingScopeToEnd = "There is no active writing scope to end.";
        internal static string FormatRazorPage_CannotFlushWhileInAWritingScope(string s0, string s1) => string.Format("The {0} operation cannot be performed while inside a writing scope in '{1}'.", s0, s1);
        internal static string FormatRazorPage_MethodCannotBeCalled(string s0, string s1) => string.Format("{0} invocation in '{1}' is invalid. {0} can only be called from a layout page.", s0, s1);
        internal static string FormatRenderBodyNotCalled(string s0, string s1, string s2) => string.Format("{0} has not been called for the page at '{1}'. To ignore call {2}().", s0, s1, s2);
        internal static string FormatSectionAlreadyDefined(string s0) => string.Format("Section '{0}' is already defined.", s0);
        internal static string FormatSectionAlreadyRendered(string s0, string s1, string s2) => string.Format("{0} invocation in '{1}' is invalid. The section '{2}' has already been rendered.", s0, s1, s2);
        internal static string FormatSectionNotDefined(string s0, string s1, string s2) => string.Format("The layout page '{0}' cannot find the section '{1}' in the content page '{2}'.", s0, s1, s2);
        internal static string FormatSectionsNotRendered(string s0, string s1, string s2) => string.Format("The following sections have been defined but have not been rendered by the page at '{0}': '{1}'. To ignore an unrendered section call {2}(\"sectionName\").", s0, s1, s2);
        internal static string FormatViewContextMustBeSet(string s0, string s1) => string.Format("'{0} must be set to access '{1}'.", s0, s1);
        internal static string GeneratedCodeFileName = "Generated Code";
        internal static string FormatRazorPage_InvalidTagHelperIndexerAssignment(string s0, string s1, string s2) => string.Format("Unable to perform '{0}' assignment. Tag helper property '{1}.{2}' must not be null.", s0, s1, s2);
        internal static string FormatCouldNotResolveApplicationRelativeUrl_TagHelper(string s0, string s1, string s2, string s3, string s4, string s5) => string.Format("Unexpected return value from '{1}.{2}' for URL '{0}'. If the '{1}' service has been overridden, change '{2}' to replace only the '~/' prefix. Otherwise, add the following directive to the Razor page to disable URL resolution relative to the application's 'webroot' setting:@{3} \"{4}, {5}\"", s0, s1, s2, s3, s4, s5);
        internal static string FormatLayoutHasCircularReference(string s0, string s1) => string.Format("A circular layout reference was detected when rendering '{0}'. The layout page '{1}' has already been rendered.", s0, s1);
        internal static string FormatCompilation_MissingReferences(string s0) => string.Format("One or more compilation references may be missing. If you're seeing this in a published application, set '{0}' to true in your project file to ensure files in the refs directory are published.", s0);
        internal static string FormatViewLocationFormatsIsRequired(string s0) => string.Format("'{0}' cannot be empty. These locations are required to locate a view for rendering.", s0);
        internal static string RazorPage_NestingAttributeWritingScopesNotSupported = "Nesting of TagHelper attribute writing scopes is not supported.";
        internal static string FormatFileProvidersAreRequired(string s0, string s1, string s2) => string.Format("'{0}.{1}' must not be empty. At least one '{2}' is required to locate a view for rendering.", s0, s1, s2);
        internal static string RazorProject_PathMustStartWithForwardSlash = "Path must begin with a forward slash '/'.";
        internal static string FormatPropertyMustBeSet(string s0, string s1) => string.Format("The property '{0}' of '{1}' must not be null.", s0, s1);
        internal static string RazorViewCompiler_ViewPathsDifferOnlyInCase = "The following precompiled view paths differ only in case, which is not supported:";
        internal static string FormatUnsupportedDebugInformationFormat(string s0) => string.Format("The debug type specified in the dependency context could be parsed. The debug type value '{0}' is not supported.", s0);
        internal static string FormatCompiledViewDescriptor_NoData(string s0, string s1) => string.Format("At least one of the '{0}' or '{1}' values must be non-null.", s0, s1);
    }
}
