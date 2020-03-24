using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Server.HttpSys
{
    internal class Resources
    {
        internal static string Exception_ArrayTooSmall = "The destination array is too small.";
        internal static string Exception_EndCalledMultipleTimes = "End has already been called.";
        internal static string Exception_InvalidStatusCode = "The status code '{0}' is not supported.";
        internal static string Exception_NoSeek = "The stream is not seekable.";
        internal static string Exception_PrefixAlreadyRegistered = "The prefix '{0}' is already registered.";
        internal static string Exception_ReadOnlyStream = "This stream only supports read operations.";
        internal static string Exception_TooMuchWritten = "More data written than specified in the Content-Length header.";
        internal static string Exception_UnsupportedScheme = "Only the http and https schemes are supported.";
        internal static string Exception_WriteOnlyStream = "This stream only supports write operations.";
        internal static string Exception_WrongIAsyncResult = "The given IAsyncResult does not match this opperation.";
        internal static string Warning_ExceptionInOnResponseCompletedAction = "An exception occured while running an action registered with {0}.";
    }
}
