// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Enumerator for an ordered collection of color glyph runs.</summary>
    [Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
    [Unmanaged]
    public unsafe struct IDWriteColorGlyphRunEnumerator1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteColorGlyphRunEnumerator1* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteColorGlyphRunEnumerator1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteColorGlyphRunEnumerator1* This
        );
        #endregion

        #region IDWriteColorGlyphRunEnumerator Delegates
        /// <summary>Advances to the first or next color run. The runs are enumerated in order from back to front.</summary>
        /// <param name="hasRun">Receives TRUE if there is a current run or FALSE if the end of the sequence has been reached.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _MoveNext(
            [In] IDWriteColorGlyphRunEnumerator1* This,
            [Out, ComAliasName("BOOL")] int* hasRun
        );

        /// <summary>Gets the current color glyph run.</summary>
        /// <param name="colorGlyphRun">Receives a pointer to the color glyph run. The pointer remains valid until the next call to MoveNext or until the interface is released.</param>
        /// <returns> Standard HRESULT error code. An error is returned if there is no current glyph run, i.e., if MoveNext has not yet been called or if the end of the sequence has been reached.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetCurrentRun(
            [In] IDWriteColorGlyphRunEnumerator1* This,
            [Out] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun
        );
        #endregion

        #region Delegates
        /// <summary>Gets the current color glyph run.</summary>
        /// <param name="colorGlyphRun">Receives a pointer to the color glyph run. The pointer remains valid until the next call to MoveNext or until the interface is released.</param>
        /// <returns> Standard HRESULT error code. An error is returned if there is no current glyph run, i.e., if MoveNext has not yet been called or if the end of the sequence has been reached.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetCurrentRun1(
            [In] IDWriteColorGlyphRunEnumerator1* This,
            [Out] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
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
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteColorGlyphRunEnumerator Methods
        [return: ComAliasName("HRESULT")]
        public int MoveNext(
            [Out, ComAliasName("BOOL")] int* hasRun
        )
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return MarshalFunction<_MoveNext>(lpVtbl->MoveNext)(
                    This,
                    hasRun
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetCurrentRun(
            [Out] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun
        )
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return MarshalFunction<_GetCurrentRun>(lpVtbl->GetCurrentRun)(
                    This,
                    colorGlyphRun
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int GetCurrentRun1(
            [Out] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun
        )
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return MarshalFunction<_GetCurrentRun1>(lpVtbl->GetCurrentRun1)(
                    This,
                    colorGlyphRun
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

            #region IDWriteColorGlyphRunEnumerator Fields
            public IntPtr MoveNext;

            public IntPtr GetCurrentRun;
            #endregion

            #region Fields
            public IntPtr GetCurrentRun1;
            #endregion
        }
        #endregion
    }
}

