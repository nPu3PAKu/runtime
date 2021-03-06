// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Internal.TypeSystem
{
    // Holds code for canonicalizing a parameterized type
    partial class ParameterizedType
    {
        public sealed override bool IsCanonicalSubtype(CanonicalFormKind policy)
        {
            return ParameterType.IsCanonicalSubtype(policy);
        }
    }
}