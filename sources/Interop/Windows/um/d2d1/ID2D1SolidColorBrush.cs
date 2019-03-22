// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Paints an area with a solid color.</summary>
    [Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
    [Unmanaged]
    public unsafe struct ID2D1SolidColorBrush
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SolidColorBrush* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SolidColorBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SolidColorBrush* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SolidColorBrush* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Brush Delegates
        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1SolidColorBrush* This,
            [In, ComAliasName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1SolidColorBrush* This,
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1SolidColorBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1SolidColorBrush* This,
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetColor(
            [In] ID2D1SolidColorBrush* This,
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetColor(
            [In] ID2D1SolidColorBrush* This,
            [Out, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* pColor
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
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
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
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
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Brush Methods
        public void SetOpacity(
            [In, ComAliasName("FLOAT")] float opacity
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_SetOpacity>(lpVtbl->SetOpacity)(
                    This,
                    opacity
                );
            }
        }

        public void SetTransform(
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: ComAliasName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return MarshalFunction<_GetOpacity>(lpVtbl->GetOpacity)(
                    This
                );
            }
        }

        public void GetTransform(
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }
        #endregion

        #region Methods
        public void SetColor(
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_SetColor>(lpVtbl->SetColor)(
                    This,
                    color
                );
            }
        }

        public void GetColor(
            [Out, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* pColor
        )
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                MarshalFunction<_GetColor>(lpVtbl->GetColor)(
                    This,
                    pColor
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

            #region ID2D1Brush Fields
            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;
            #endregion

            #region Fields
            public IntPtr SetColor;

            public IntPtr GetColor;
            #endregion
        }
        #endregion
    }
}

