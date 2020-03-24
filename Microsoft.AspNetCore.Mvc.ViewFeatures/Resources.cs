using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
    internal class Resources
    {
        internal static string FormatViewComponent_AmbiguousTypeMatch(string s0, string s1, string s2) => string.Format("The view component name '{0}' matched multiple types:{1}{2}", s0, s1, s2);
        internal static string FormatViewComponent_AsyncMethod_ShouldReturnTask(string s0, string s1, string s2) => string.Format("Method '{0}' of view component '{1}' should be declared to return {2}<T>.", s0, s1, s2);
        internal static string ViewComponent_MustReturnValue = "A view component must return a non-null value.";
        internal static string FormatViewComponent_SyncMethod_ShouldReturnValue(string s0, string s1) => string.Format("Method '{0}' of view component '{1}' should be declared to return a value.", s0, s1);
        internal static string FormatViewComponent_CannotFindComponent(string s0, string s1, string s2, string s3) => string.Format("A view component named '{0}' could not be found. A view component must be a public non-abstract class, not contain any generic parameters, and either be decorated with '{1}' or have a class name ending with the '{2}' suffix. A view component must not be decorated with '{3}'.", s0, s1, s2, s3);
        internal static string FormatViewComponent_IViewComponentFactory_ReturnedNull(string s0) => string.Format("An invoker could not be created for the view component '{0}'.", s0);
        internal static string FormatViewComponent_CannotFindMethod(string s0, string s1, string s2) => string.Format("Could not find an '{0}' or '{1}' method for the view component '{2}'.", s0, s1, s2);
        internal static string FormatViewComponent_InvalidReturnValue(string s0, string s1, string s2) => string.Format("View components only support returning {0}, {1} or {2}.", s0, s1, s2);
        internal static string ArgumentCannotBeNullOrEmpty = "Value cannot be null or empty.";
        internal static string FormatPropertyOfTypeCannotBeNull(string s0, Type s1) => string.Format("The '{0}' property of '{1}' must not be null.", s0, s1);

        internal static string FormatPropertyOfTypeCannotBeNull(string s0, string s1) => string.Format("The '{0}' property of '{1}' must not be null.", s0, s1);
        internal static string FormatTypeMethodMustReturnNotNullValue(string s0, string s1) => string.Format("The '{0}' method of type '{1}' cannot return a null value.", s0, s1);
        internal static string FormatArgumentPropertyUnexpectedType(string s0, string s1, string s2) => string.Format("Property '{0}' is of type '{1}', but this method requires a value of type '{2}'.", s0, s1, s2);
        internal static string FormatCommon_PartialViewNotFound(string s0, string s1) => string.Format("The partial view '{0}' was not found or no view engine supports the searched locations. The following locations were searched:{1}", s0, s1);
        internal static string Common_TriState_False = "False";
        internal static string Common_TriState_NotSet = "Not Set";
        internal static string Common_TriState_True = "True";
        internal static string DynamicViewData_ViewDataNull = "ViewData value must not be null.";
        internal static string FormatExpressionHelper_InvalidIndexerExpression(Expression s0, string s1) => string.Format("The expression compiler was unable to evaluate the indexer expression '{0}' because it references the model parameter '{1}' which is unavailable.", s0, s1);
        internal static string FormatHtmlHelper_NullModelMetadata(string s0) => string.Format("The IModelMetadataProvider was unable to provide metadata for expression '{0}'.", s0);
        internal static string HtmlHelper_NotContextualized = "Must call 'Contextualize' method before using this HtmlHelper instance.";
        internal static string FormatHtmlHelper_MissingSelectData(string s0, string s1) => string.Format("There is no ViewData item of type '{0}' that has the key '{1}'.", s0, s1);
        internal static string FormatHtmlHelper_SelectExpressionNotEnumerable(string s0) => string.Format("The parameter '{0}' must evaluate to an IEnumerable when multiple selection is allowed.", s0);
        internal static string FormatHtmlHelper_TypeNotSupported_ForGetEnumSelectList(string s0, string s1, string s2) => string.Format("The type '{0}' is not supported. Type must be an {1} that does not have an associated {2}.", s0, s1, s2);
        internal static string FormatHtmlHelper_WrongSelectDataType(string s0, string s1, string s2) => string.Format("The ViewData item that has the key '{0}' is of type '{1}' but must be of type '{2}'.", s0, s1, s2);
        internal static string FormatTemplates_TypeMustImplementIEnumerable(string s0, string s1, string s2) => string.Format("The '{0}' template was used with an object of type '{1}', which does not implement '{2}'.", s0, s1, s2);
        internal static string TemplateHelpers_TemplateLimitations = "Templates can be used only with field access, property access, single-dimension array index, or single-parameter custom indexer expressions.";
        internal static string FormatTemplateHelpers_NoTemplate(string s0) => string.Format("Unable to locate an appropriate template for type {0}.", s0);
        internal static string FormatViewData_ModelCannotBeNull(Type s0) => string.Format("The model item passed is null, but this ViewDataDictionary instance requires a non-null model item of type '{0}'.", s0);
        internal static string FormatViewData_WrongTModelType(Type s0, Type s1) => string.Format("The model item passed into the ViewDataDictionary is of type '{0}', but this ViewDataDictionary instance requires a model item of type '{1}'.", s0, s1);
        internal static string FormatViewEngine_PartialViewNotFound(string s0, string s1) => string.Format("The partial view '{0}' was not found. The following locations were searched:{1}", s0, s1);
        internal static string FormatViewEngine_ViewNotFound(string s0, string s1) => string.Format("The view '{0}' was not found. The following locations were searched:{1}", s0, s1);
        internal static string HtmlHelper_TextAreaParameterOutOfRange = "The value must be greater than or equal to zero.";
        internal static string FormatUnobtrusiveJavascript_ValidationParameterCannotBeEmpty(string s0) => string.Format("Validation parameter names in unobtrusive client validation rules cannot be empty. Client rule type: {0}", s0);
        internal static string FormatUnobtrusiveJavascript_ValidationParameterMustBeLegal(string s0, string s1) => string.Format("Validation parameter names in unobtrusive client validation rules must start with a lowercase letter and consist of only lowercase letters or digits. Validation parameter name: {0}, client rule type: {1}", s0, s1);
        internal static string FormatUnobtrusiveJavascript_ValidationTypeCannotBeEmpty(string s0) => string.Format("Validation type names in unobtrusive client validation rules cannot be empty. Client rule type: {0}", s0);
        internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeLegal(string s0, string s1) => string.Format("Validation type names in unobtrusive client validation rules must consist of only lowercase letters. Invalid name: \"{0}\", client rule type: {1}", s0, s1);
        internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeUnique(string s0) => string.Format("Validation type names in unobtrusive client validation rules must be unique. The following validation type was seen more than once: {0}", s0);
        internal static string FormatTypeMustDeriveFromType(Type s0, Type s1) => string.Format("The type '{0}' must derive from '{1}'.", s0, s1);
        internal static string FormatTemplatedViewLocationExpander_NoReplacementToken(string s0) => string.Format("Could not find a replacement for view expansion token '{0}'.", s0);
        internal static string FormatTemplatedExpander_PopulateValuesMustBeInvokedFirst(string s0, string s1) => string.Format("{0} must be executed before {1} can be invoked.", s0, s1);
        internal static string TemplatedExpander_ValueFactoryCannotReturnNull = "The result of value factory cannot be null.";
        internal static string FormatViewComponent_AmbiguousTypeMatch_Item(string s0, string s1) => string.Format("Type: '{0}' - Name: '{1}'", s0, s1);
        internal static string FormatCommon_PropertyNotFound(string s0, string s1) => string.Format("The property {0}.{1} could not be found.", s0, s1);
        internal static string RemoteAttribute_NoUrlFound = "No URL for remote validation could be found.";
        internal static string RemoteAttribute_RemoteValidationFailed = "'{0}' is invalid.";
        internal static string FormatHtmlGenerator_FieldNameCannotBeNullOrEmpty(string s0, string s1, string s2, string s3, string s4) => string.Format("The name of an HTML field cannot be null or empty. Instead use methods {0}.{1} or {2}.{3} with a non-empty {4} argument value.", s0, s1, s2, s3, s4);
        internal static string FormatViewComponentResult_NameOrTypeMustBeSet(string s0, string s1) => string.Format("Either the '{0}' or '{1}' property must be set in order to invoke a view component.", s0, s1);
        internal static string FormatDictionary_DuplicateKey(string s0) => string.Format("The collection already contains an entry with key '{0}'.", s0);
        internal static string FormatViewComponent_SyncMethod_CannotReturnTask(string s0, string s1, string s2) => string.Format("Method '{0}' of view component '{1}' cannot return a {2}.", s0, s1, s2);
        internal static string FormatViewComponent_AmbiguousMethods(string s0, string s1, string s2) => string.Format("View component '{0}' must have exactly one public method named '{1}' or '{2}'.", s0, s1, s2);
        internal static string FormatValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated(string s0, string s1) => string.Format("The type '{0}' cannot be activated by '{1}' because it is either a value type, an interface, an abstract class or an open generic type.", s0, s1);
        internal static string FormatCreateModelExpression_NullModelMetadata(string s0, string s1) => string.Format("The {0} was unable to provide metadata for expression '{1}'.", s0, s1);
        internal static string FormatViewEnginesAreRequired(string s0, string s1, string s2) => string.Format("'{0}.{1}' must not be empty. At least one '{2}' is required to locate a view for rendering.", s0, s1, s2);
        internal static string FormatTempDataProperties_PublicGetterSetter(string s0, string s1, string s2) => string.Format("The '{0}.{1}' property with {2} is invalid. A property using {2} must have a public getter and setter.", s0, s1, s2);
        internal static string FormatTempDataProperties_InvalidType(string s0, string s1, string s2, string s3) => string.Format("TempData serializer '{0}' cannot serialize property '{1}.{2}' of type '{3}'.", s0, s1, s2, s3);
        internal static string DeserializingTempData = "Deserializing TempDataDictionary";
        internal static string SerializingTempData = "Serializing TempDataDictionary";
        internal static string FormatTempData_CannotSerializeType(string s0, Type s1) => string.Format("The '{0}' cannot serialize an object of type '{1}'.", s0, s1);
        internal static string FormatTempData_CannotDeserializeType(JsonValueKind s0) => string.Format("Unsupported data type '{0}'.", s0);
        internal static string FormatUnsupportedRenderMode(RenderMode s0) => string.Format("Unsupported RenderMode '{0}'.", s0);
    }
}
