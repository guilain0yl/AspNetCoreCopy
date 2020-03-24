// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection
{
    internal static class Error
    {
        public static InvalidOperationException CertificateXmlEncryptor_CertificateNotFound(string thumbprint)
        {
            var message = $"A certificate with the thumbprint '{thumbprint}' could not be found.";
            return new InvalidOperationException(message);
        }

        public static ArgumentException Common_ArgumentCannotBeNullOrEmpty(string parameterName)
        {
            return new ArgumentException("Argument cannot be null or empty.", parameterName);
        }

        public static ArgumentException Common_BufferIncorrectlySized(string parameterName, int actualSize, int expectedSize)
        {
            var message = $"The provided buffer is of length {actualSize} byte(s). It must instead be exactly {expectedSize} byte(s) in length.";
            return new ArgumentException(message, parameterName);
        }

        public static CryptographicException CryptCommon_GenericError(Exception inner = null)
        {
            return new CryptographicException("An error occurred during a cryptographic operation.", inner);
        }

        public static CryptographicException CryptCommon_PayloadInvalid()
        {
            var message = "The payload was invalid.";
            return new CryptographicException(message);
        }

        public static InvalidOperationException Common_PropertyCannotBeNullOrEmpty(string propertyName)
        {
            var message = string.Format(CultureInfo.CurrentCulture, "Property {0} cannot be null or empty.", propertyName);
            return new InvalidOperationException(message);
        }

        public static InvalidOperationException Common_PropertyMustBeNonNegative(string propertyName)
        {
            var message = string.Format(CultureInfo.CurrentCulture, "Property {0} must have a non-negative value.", propertyName);
            return new InvalidOperationException(message);
        }

        public static CryptographicException Common_EncryptionFailed(Exception inner = null)
        {
            return new CryptographicException("An error occurred while trying to encrypt the provided data. Refer to the inner exception for more information.", inner);
        }

        public static CryptographicException Common_KeyNotFound(Guid id)
        {
            var message = string.Format(CultureInfo.CurrentCulture, "The key {0:B} was not found in the key ring.", id);
            return new CryptographicException(message);
        }

        public static CryptographicException Common_KeyRevoked(Guid id)
        {
            var message = string.Format(CultureInfo.CurrentCulture, "The key {0:B} has been revoked.", id);
            return new CryptographicException(message);
        }

        public static ArgumentOutOfRangeException Common_ValueMustBeNonNegative(string paramName)
        {
            return new ArgumentOutOfRangeException(paramName, "Property {0} must have a non-negative value.");
        }

        public static CryptographicException DecryptionFailed(Exception inner)
        {
            return new CryptographicException("The provided payload could not be decrypted. Refer to the inner exception for more information.", inner);
        }

        public static CryptographicException ProtectionProvider_BadMagicHeader()
        {
            return new CryptographicException("The provided payload cannot be decrypted because it was not protected with this protection provider.");
        }

        public static CryptographicException ProtectionProvider_BadVersion()
        {
            return new CryptographicException("The provided payload cannot be decrypted because it was protected with a newer version of the protection provider.");
        }

        public static InvalidOperationException XmlKeyManager_DuplicateKey(Guid keyId)
        {
            var message = string.Format(CultureInfo.CurrentCulture, "The key {0:B} already exists in the keyring.", keyId);
            return new InvalidOperationException(message);
        }
    }
}
