// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Function pointer that sets a property on an effect.</summary>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
    [return: ComAliasName("HRESULT")]
    unsafe public /* static */ delegate int PD2D1_PROPERTY_SET_FUNCTION(
        [In] IUnknown* effect,
        [In, ComAliasName("BYTE")] /* readonly */ byte* data,
        [In, ComAliasName("UINT32")] uint dataSize
    );
}
