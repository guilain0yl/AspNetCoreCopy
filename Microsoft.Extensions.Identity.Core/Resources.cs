using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Identity.Core
{
    internal class Resources
    {
        internal static string ConcurrencyFailure = "Optimistic concurrency failure, object has been modified.";
        internal static string DefaultError = "An unknown failure has occurred.";
        internal static string FormatDuplicateEmail(string s0) => string.Format("Email '{0}' is already taken.", s0);
        internal static string FormatDuplicateRoleName(string s0) => string.Format("Role name '{0}' is already taken.", s0);
        internal static string FormatDuplicateUserName(string s0) => string.Format("User name '{0}' is already taken.", s0);
        internal static string FormatInvalidEmail(string s0) => string.Format("Email '{0}' is invalid.", s0);
        internal static string FormatInvalidManagerType(string s0, string s1, string s2) => string.Format("Type {0} must derive from {1}<{2}>.", s0, s1, s2);
        internal static string InvalidPasswordHasherCompatibilityMode = "The provided PasswordHasherCompatibilityMode is invalid.";
        internal static string InvalidPasswordHasherIterationCount = "The iteration count must be a positive integer.";
        internal static string FormatInvalidRoleName(string s0) => string.Format("Role name '{0}' is invalid.", s0);
        internal static string InvalidToken = "Invalid token.";
        internal static string FormatInvalidUserName(string s0) => string.Format("User name '{0}' is invalid, can only contain letters or digits.", s0);
        internal static string LoginAlreadyAssociated = "A user with this login already exists.";
        internal static string MustCallAddIdentity = "AddIdentity must be called on the service collection.";
        internal static string FormatNoTokenProvider(string s0, string s1) => string.Format("No IUserTwoFactorTokenProvider<{0}> named '{1}' is registered.", s0, s1);
        internal static string NullSecurityStamp = "User security stamp cannot be null.";
        internal static string PasswordMismatch = "Incorrect password.";
        internal static string PasswordRequiresDigit = "Passwords must have at least one digit ('0'-'9').";
        internal static string PasswordRequiresLower = "Passwords must have at least one lowercase ('a'-'z').";
        internal static string PasswordRequiresNonAlphanumeric = "Passwords must have at least one non alphanumeric character.";
        internal static string PasswordRequiresUpper = "Passwords must have at least one uppercase ('A'-'Z').";
        internal static string FormatPasswordTooShort(int s0) => string.Format("Passwords must be at least {0} characters.", s0);
        internal static string FormatRoleNotFound(string s0) => string.Format("Role {0} does not exist.", s0);
        internal static string StoreNotIQueryableRoleStore = "Store does not implement IQueryableRoleStore<TRole>.";
        internal static string StoreNotIQueryableUserStore = "Store does not implement IQueryableUserStore<TUser>.";
        internal static string StoreNotIRoleClaimStore = "Store does not implement IRoleClaimStore<TRole>.";
        internal static string StoreNotIUserAuthenticationTokenStore = "Store does not implement IUserAuthenticationTokenStore<User>.";
        internal static string StoreNotIUserClaimStore = "Store does not implement IUserClaimStore<TUser>.";
        internal static string StoreNotIUserConfirmationStore = "Store does not implement IUserConfirmationStore<TUser>.";
        internal static string StoreNotIUserEmailStore = "Store does not implement IUserEmailStore<TUser>.";
        internal static string StoreNotIUserLockoutStore = "Store does not implement IUserLockoutStore<TUser>.";
        internal static string StoreNotIUserLoginStore = "Store does not implement IUserLoginStore<TUser>.";
        internal static string StoreNotIUserPasswordStore = "Store does not implement IUserPasswordStore<TUser>.";
        internal static string StoreNotIUserPhoneNumberStore = "Store does not implement IUserPhoneNumberStore<TUser>.";
        internal static string StoreNotIUserRoleStore = "Store does not implement IUserRoleStore<TUser>.";
        internal static string StoreNotIUserSecurityStampStore = "Store does not implement IUserSecurityStampStore<TUser>.";
        internal static string StoreNotIUserAuthenticatorKeyStore = "Store does not implement IUserAuthenticatorKeyStore<User>.";
        internal static string StoreNotIUserTwoFactorStore = "Store does not implement IUserTwoFactorStore<TUser>.";
        internal static string RecoveryCodeRedemptionFailed = "Recovery code redemption failed.";
        internal static string UserAlreadyHasPassword = "User already has a password set.";
        internal static string FormatUserAlreadyInRole(string s0) => string.Format("User already in role '{0}'.", s0);
        internal static string UserLockedOut = "User is locked out.";
        internal static string UserLockoutNotEnabled = "Lockout is not enabled for this user.";
        internal static string FormatUserNameNotFound(string s0) => string.Format("User {0} does not exist.", s0);
        internal static string FormatUserNotInRole(string s0) => string.Format("User is not in role '{0}'.", s0);
        internal static string StoreNotIUserTwoFactorRecoveryCodeStore = "Store does not implement IUserTwoFactorRecoveryCodeStore<User>.";
        internal static string FormatPasswordRequiresUniqueChars(int s0) => string.Format("Passwords must use at least {0} different characters.", s0);
        internal static string NoRoleType = "No RoleType was specified, try AddRoles<TRole>().";
        internal static string StoreNotIProtectedUserStore = "Store does not implement IProtectedUserStore<TUser> which is required when ProtectPersonalData = true.";
        internal static string NoPersonalDataProtector = "No IPersonalDataProtector service was registered, this is required when ProtectPersonalData = true.";
    }
}
