using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.Abstractions
{
    public class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty = "Value cannot be null or empty.";
        internal static string ModelBindingContext_ModelMetadataMustBeSet = "The ModelMetadata property must be set before accessing this property.";
        internal static string Validation_InvalidFieldCannotBeReset = "A field previously marked invalid should not be marked valid.";
        internal static string Validation_InvalidFieldCannotBeReset_ToSkipped = "A field previously marked invalid should not be marked skipped.";
        internal static string ModelStateDictionary_MaxModelStateErrors = "The maximum number of allowed model errors has been reached.";
        internal static string BindingSource_Body = "Body";
        internal static string BindingSource_Custom = "Custom";
        internal static string BindingSource_Form = "Form";
        internal static string BindingSource_Header = "Header";
        internal static string BindingSource_Services = "Services";
        internal static string BindingSource_ModelBinding = "ModelBinding";
        internal static string BindingSource_Path = "Path";
        internal static string BindingSource_Query = "Query";
        internal static string FormatBindingSource_CannotBeComposite(string s1, string s2) => string.Format("The provided binding source '{0}' is a composite. '{1}' requires that the source must represent a single type of input.", s1, s2);
        internal static string FormatBindingSource_MustBeFromRequest(string s1, string s2) => string.Format("The provided binding source '{0}' is not a request-based binding source. '{1}' requires that the source must represent data from an HTTP request.", s1, s2);
        internal static string FormatBindingSource_CannotBeGreedy(string s1, string s2) => string.Format("The provided binding source '{0}' is a greedy data source. '{1}' does not support greedy data sources.", s1, s2);
        internal static string BindingSource_MustBeGreedy = "The provided binding source '{0}' is not a greedy data source. '{1}' only supports greedy data sources.";
        internal static string BindingSource_Special = "Special";
        internal static string BindingSource_FormFile = "FormFile";
        internal static string FormatBinderType_MustBeIModelBinder(string s1, string s2) => string.Format("The type '{0}' must implement '{1}' to be used as a model binder.", s1, s2);
    }
}
