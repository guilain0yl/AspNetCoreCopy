// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection
{
    internal static class Error
    {
        public static CryptographicException CryptCommon_GenericError(Exception inner = null)
        {
            return new CryptographicException("An error occurred during a cryptographic operation.", inner);
        }

        public static CryptographicException CryptCommon_PayloadInvalid()
        {
            string message = "The payload was invalid.";
            return new CryptographicException(message);
        }
    }
}
