// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a collection of style properties to be used by methods like ID2D1DeviceContext2::DrawInk when rendering ink. The ink style defines the nib (pen tip) shape and transform.</summary>
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    [Unmanaged]
    public unsafe struct ID2D1InkStyle
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1InkStyle* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1InkStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1InkStyle* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1InkStyle* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetNibTransform(
            [In] ID2D1InkStyle* This,
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetNibTransform(
            [In] ID2D1InkStyle* This,
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetNibShape(
            [In] ID2D1InkStyle* This,
            [In] D2D1_INK_NIB_SHAPE nibShape
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_INK_NIB_SHAPE _GetNibShape(
            [In] ID2D1InkStyle* This
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region Methods
        public void SetNibTransform(
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                MarshalFunction<_SetNibTransform>(lpVtbl->SetNibTransform)(
                    This,
                    transform
                );
            }
        }

        public void GetNibTransform(
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                MarshalFunction<_GetNibTransform>(lpVtbl->GetNibTransform)(
                    This,
                    transform
                );
            }
        }

        public void SetNibShape(
            [In] D2D1_INK_NIB_SHAPE nibShape
        )
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                MarshalFunction<_SetNibShape>(lpVtbl->SetNibShape)(
                    This,
                    nibShape
                );
            }
        }

        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return MarshalFunction<_GetNibShape>(lpVtbl->GetNibShape)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region Fields
            public IntPtr SetNibTransform;

            public IntPtr GetNibTransform;

            public IntPtr SetNibShape;

            public IntPtr GetNibShape;
            #endregion
        }
        #endregion
    }
}

