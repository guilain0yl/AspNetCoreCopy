// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    internal class ConstantCallSite : ServiceCallSite
    {
        internal object DefaultValue { get; }

        public ConstantCallSite(Type serviceType, object defaultValue): base(ResultCache.None)
        {
            if (defaultValue != null && !serviceType.IsInstanceOfType(defaultValue))
            {
                throw new ArgumentException($"Constant value of type '{defaultValue.GetType()}' can't be converted to service type '{serviceType}'");
            }

            DefaultValue = defaultValue;
        }

        public override Type ServiceType => DefaultValue.GetType();
        public override Type ImplementationType => DefaultValue.GetType();
        public override CallSiteKind Kind { get; } = CallSiteKind.Constant;
    }
}
