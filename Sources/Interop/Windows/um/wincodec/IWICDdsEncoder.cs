// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    unsafe public /* blittable */ struct IWICDdsEncoder
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int SetParameters(
            [In] IWICDdsEncoder* This,
            [In] WICDdsParameters* pParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int GetParameters(
            [In] IWICDdsEncoder* This,
            [Out] WICDdsParameters* pParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int CreateNewFrame(
            [In] IWICDdsEncoder* This,
            [Out, Optional] IWICBitmapFrameEncode** ppIFrameEncode,
            [Out, Optional, ComAliasName("UINT")] uint* pArrayIndex,
            [Out, Optional, ComAliasName("UINT")] uint* pMipLevel,
            [Out, Optional, ComAliasName("UINT")] uint* pSliceIndex
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IUnknown.Vtbl BaseVtbl;

            public SetParameters SetParameters;

            public GetParameters GetParameters;

            public CreateNewFrame CreateNewFrame;
            #endregion
        }
        #endregion
    }
}
