using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Antiforgery
{
    internal class Resources
    {
        internal static string FormatAntiforgeryTokenValidator_AuthenticatedUserWithoutUsername(Type s0, string s1, string s2, string s3, string s4, string s5) => string.Format("The provided identity of type '{0}' is marked {1} = {2} but does not have a value for {3}. By default, the antiforgery system requires that all authenticated identities have a unique {3}. If it is not possible to provide a unique {3} for this identity, consider extending {4} by overriding the {5} or a custom type that can provide some form of unique identifier for the current user.", s0, s1, s2, s3, s4, s5);
        internal static string AntiforgeryToken_AdditionalDataCheckFailed = "The provided antiforgery token failed a custom data check.";
        internal static string AntiforgeryToken_ClaimUidMismatch = "The provided antiforgery token was meant for a different claims-based user than the current user.";
        internal static string AntiforgeryToken_DeserializationFailed = "The antiforgery token could not be decrypted.";
        internal static string AntiforgeryToken_SecurityTokenMismatch = "The antiforgery cookie token and request token do not match.";
        internal static string AntiforgeryToken_TokensSwapped = "Validation of the provided antiforgery token failed. The cookie token and the request token were swapped.";
        internal static string FormatAntiforgeryToken_UsernameMismatch(string s0, string s1) => string.Format("The provided antiforgery token was meant for user \"{0}\", but the current user is \"{1}\".", s0, s1);
        internal static string Antiforgery_CookieToken_IsInvalid = "The antiforgery cookie token is invalid.";
        internal static string FormatAntiforgery_CookieToken_MustBeProvided(string s0) => string.Format("The required antiforgery cookie \"{0}\" is not present.", s0);
        internal static string Antiforgery_CookieToken_MustBeProvided_Generic = "The required antiforgery cookie token must be provided.";
        internal static string FormatAntiforgery_FormToken_MustBeProvided(string s0) => string.Format("The required antiforgery form field \"{0}\" is not present.", s0);
        internal static string FormatAntiforgery_HeaderToken_MustBeProvided(string s0) => string.Format("The required antiforgery header value \"{0}\" is not present.", s0);
        internal static string FormatAntiforgery_RequestToken_MustBeProvided(string s0, string s1) => string.Format("The required antiforgery request token was not provided in either form field \"{0}\" or header value \"{1}\".", s0, s1);
        internal static string Antiforgery_RequestToken_MustBeProvided_Generic = "The required antiforgery request token must be provided.";
        internal static string FormatAntiforgery_RequiresSSL(string optionName, string value) => $"The antiforgery system has the configuration value {optionName} = {value}, but the current request is not an SSL request.";
        internal static string ArgumentCannotBeNullOrEmpty = "Value cannot be null or empty.";
    }
}
