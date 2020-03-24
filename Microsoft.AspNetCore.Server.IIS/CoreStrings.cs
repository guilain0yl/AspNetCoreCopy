using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Server.IIS
{
    internal class CoreStrings
    {
        internal static string ResponseStreamWasUpgraded = "Cannot write to response body after connection has been upgraded.";
        internal static string UnhandledApplicationException = "The response has been aborted due to an unhandled application exception.";
        internal static string CannotUpgradeNonUpgradableRequest = "Cannot upgrade a non-upgradable request. Check IHttpUpgradeFeature.IsUpgradableRequest to determine if a request can be upgraded.";
        internal static string UpgradeCannotBeCalledMultipleTimes = "IHttpUpgradeFeature.UpgradeAsync was already called and can only be called once per connection.";
        internal static string SynchronousReadsDisallowed = "Synchronous operations are disallowed. Call ReadAsync or set AllowSynchronousIO to true instead.";
        internal static string SynchronousWritesDisallowed = "Synchronous operations are disallowed. Call WriteAsync or set AllowSynchronousIO to true instead.";
        internal static string WritingToResponseBodyAfterResponseCompleted = "Cannot write to the response body, the response has completed.";
        internal static string ConnectionAbortedByApplication = "The connection was aborted by the application.";
        internal static string ConnectionOrStreamAbortedByCancellationToken = "The connection or stream was aborted because a write operation was aborted with a CancellationToken.";
        internal static string FormatParameterReadOnlyAfterResponseStarted(string name) => $"{name} cannot be set because the response has already started.";
        internal static string BadRequest_RequestBodyTooLarge = "Request body too large.";
        internal static string MaxRequestBodySizeCannotBeModifiedAfterRead = "The maximum request body size cannot be modified after the app has already started reading from the request body.";
        internal static string MaxRequestBodySizeCannotBeModifiedForUpgradedRequests = "The maximum request body size cannot be modified after the request has been upgraded.";
        internal static string NonNegativeNumberOrNullRequired = "Value must be null or a non-negative number.";
        internal static string BadRequest = "Bad request.";
        internal static string MaxRequestLimitWarning = "Increasing the MaxRequestBodySize conflicts with the max value for IIS limit maxAllowedContentLength. HTTP requests that have a content length greater than maxAllowedContentLength will still be rejected by IIS. You can disable the limit by either removing or setting the maxAllowedContentLength value to a higher limit.";
    }
}
