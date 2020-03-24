using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.NewtonsoftJson
{
    internal class Resources
    {
        internal static string FormatContractResolverCannotBeNull(string s0) => string.Format("{0} cannot be null.", s0);
        internal static string FormatInvalidContractResolverForJsonCasingConfiguration(string s0, string s1) => string.Format("Cannot configure JSON casing behavior on '{0}' contract resolver. The supported contract resolver is {1}.", s0, s1);
        internal static string FormatJsonHelperMustBeAnInstanceOfNewtonsoftJson(string s0, string s1, string s2, string s3) => string.Format("Parameter '{0}' must be an instance of {1} provided by the '{2}' package. Configure the correct instance using '{3}' in your startup.", s0, s1, s2, s3);
        internal static string FormatObjectResultExecutor_MaxEnumerationExceeded(string s0, Type s1) => string.Format("'{0}' reached the configured maximum size of the buffer when enumerating a value of type '{1}'. This limit is in place to prevent infinite streams of 'IAsyncEnumerable<>' from continuing indefinitely. If this is not a programming mistake, consider ways to reduce the collection size, or consider manually converting '{1}' into a list rather than increasing the limit.", s0, s1);
        internal static string FormatProperty_MustBeInstanceOfType(string s0, string s1, Type s2) => string.Format("Property '{0}.{1}' must be an instance of type '{2}'.", s0, s1, s2);
        internal static string FormatTempData_CannotDeserializeToken(string s0, JTokenType s1) => string.Format("Cannot deserialize {0} of type '{1}'.", s0, s1);
        internal static string FormatTempData_CannotSerializeDictionary(string s0, Type s1, string s2) => string.Format("The '{0}' cannot serialize a dictionary with a key of type '{1}'. The key must be of type '{2}'.", s0, s1, s2);
        internal static string FormatTempData_CannotSerializeType(string s0, Type s1) => string.Format("The '{0}' cannot serialize an object of type '{1}'.", s0, s1);
    }
}
