// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Collections.Generic
{
    internal static class StackExtensions
    {
        public static bool TryPop<T>(this Stack<T?> stack, out T? item)
        {
            if (stack.Count > 0)
            {
                item = stack.Pop();
                return true;
            }
            item = default;
            return false;
        }
    }
}
