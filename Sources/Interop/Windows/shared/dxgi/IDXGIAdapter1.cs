// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("29038F61-3839-4626-91FD-086879011A05")]
    unsafe public /* blittable */ struct IDXGIAdapter1
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int GetDesc1(
            [In] IDXGIAdapter1* This,
            [Out] DXGI_ADAPTER_DESC1* pDesc
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IDXGIAdapter.Vtbl BaseVtbl;

            public GetDesc1 GetDesc1;
            #endregion
        }
        #endregion
    }
}
