// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace Microsoft.Extensions.Primitives
{
    internal static class ThrowHelper
    {
        internal static void ThrowArgumentNullException(ExceptionArgument argument)
        {
            throw new ArgumentNullException(GetArgumentName(argument));
        }

        internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
        {
            throw new ArgumentOutOfRangeException(GetArgumentName(argument));
        }

        internal static void ThrowArgumentException(ExceptionResource resource)
        {
            throw new ArgumentException(GetResourceText(resource));
        }

        internal static void ThrowInvalidOperationException(ExceptionResource resource)
        {
            throw new InvalidOperationException(GetResourceText(resource));
        }

        internal static void ThrowInvalidOperationException(ExceptionResource resource, params object[] args)
        {
            var message = string.Format(GetResourceText(resource), args);

            throw new InvalidOperationException(message);
        }

        internal static ArgumentNullException GetArgumentNullException(ExceptionArgument argument)
        {
            return new ArgumentNullException(GetArgumentName(argument));
        }

        internal static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument)
        {
            return new ArgumentOutOfRangeException(GetArgumentName(argument));
        }

        internal static ArgumentException GetArgumentException(ExceptionResource resource)
        {
            return new ArgumentException(GetResourceText(resource));
        }

        private static string GetResourceText(ExceptionResource resource)
        {
            switch (resource)
            {
                case ExceptionResource.Argument_InvalidOffsetLength:
                    return "Offset and length are out of bounds for the string or length is greater than the number of characters from index to the end of the string.";
                case ExceptionResource.Argument_InvalidOffsetLengthStringSegment:
                    return "Offset and length are out of bounds for this StringSegment or length is greater than the number of characters to the end of this StringSegment.";
                case ExceptionResource.Capacity_CannotChangeAfterWriteStarted:
                    return "Cannot change capacity after write started.";
                case ExceptionResource.Capacity_NotEnough:
                    return "Not enough capacity to write '{0}' characters, only '{1}' left.";
                case ExceptionResource.Capacity_NotUsedEntirely:
                    return "Entire reserved capacity was not used. Capacity: '{0}', written '{1}'.";
                default: return "";
            }
        }

        private static string GetArgumentName(ExceptionArgument argument)
        {
            Debug.Assert(Enum.IsDefined(typeof(ExceptionArgument), argument),
                "The enum value is not defined, please check the ExceptionArgument Enum.");

            return argument.ToString();
        }

        private static string GetResourceName(ExceptionResource resource)
        {
            Debug.Assert(Enum.IsDefined(typeof(ExceptionResource), resource),
                "The enum value is not defined, please check the ExceptionResource Enum.");

            return resource.ToString();
        }
    }

    internal enum ExceptionArgument
    {
        buffer,
        offset,
        length,
        text,
        start,
        count,
        index,
        value,
        capacity,
        separators
    }

    internal enum ExceptionResource
    {
        Argument_InvalidOffsetLength,
        Argument_InvalidOffsetLengthStringSegment,
        Capacity_CannotChangeAfterWriteStarted,
        Capacity_NotEnough,
        Capacity_NotUsedEntirely
    }
}
