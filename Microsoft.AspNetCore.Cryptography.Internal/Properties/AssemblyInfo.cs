// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// we only ever p/invoke into DLLs known to be in the System32 folder
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32)]

[assembly: InternalsVisibleTo("Microsoft.AspNetCore.Cryptography.Internal.Tests")]
[assembly: InternalsVisibleTo("Microsoft.AspNetCore.Cryptography.KeyDerivation")]
[assembly: InternalsVisibleTo("Microsoft.AspNetCore.DataProtection")]
