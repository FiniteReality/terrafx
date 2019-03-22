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
    /// <summary>The GDI interop interface provides interoperability with GDI.</summary>
    [Guid("4556BE70-3ABD-4F70-90BE-421780A6F515")]
    [Unmanaged]
    public unsafe struct IDWriteGdiInterop1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteGdiInterop1* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteGdiInterop1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteGdiInterop1* This
        );
        #endregion

        #region IDWriteGdiInterop Delegates
        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public structure in the system font collection (GetSystemFontCollection).</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateFontFromLOGFONT(
            [In] IDWriteGdiInterop1* This,
            [In] LOGFONT* logFont,
            [Out] IDWriteFont** font
        );

        /// <summary>Initializes a LOGFONT public structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <param name="isSystemFont">Contains TRUE if the specified font object is part of the system font collection or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ConvertFontToLOGFONT(
            [In] IDWriteGdiInterop1* This,
            [In] IDWriteFont* font,
            [Out] LOGFONT* logFont,
            [Out, ComAliasName("BOOL")] int* isSystemFont
        );

        /// <summary>Initializes a LOGFONT public structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font face.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ConvertFontFaceToLOGFONT(
            [In] IDWriteGdiInterop1* This,
            [In] IDWriteFontFace* font,
            [Out] LOGFONT* logFont
        );

        /// <summary>Creates a font face object that corresponds to the currently selected HFONT.</summary>
        /// <param name="hdc">Handle to a device context into which a font has been selected. It is assumed that the client has already performed font mapping and that the font selected into the DC is the actual font that would be used for rendering glyphs.</param>
        /// <param name="fontFace">Contains the newly created font face object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateFontFaceFromHdc(
            [In] IDWriteGdiInterop1* This,
            [In, ComAliasName("HDC")] IntPtr hdc,
            [Out] IDWriteFontFace** fontFace
        );

        /// <summary>Creates an object that encapsulates a bitmap and memory DC which can be used for rendering glyphs.</summary>
        /// <param name="hdc">Optional device context used to create a compatible memory DC.</param>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="renderTarget">Receives a pointer to the newly created render target.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateBitmapRenderTarget(
            [In] IDWriteGdiInterop1* This,
            [In, Optional, ComAliasName("HDC")] IntPtr hdc,
            [In, ComAliasName("UINT32")] uint width,
            [In, ComAliasName("UINT32")] uint height,
            [Out] IDWriteBitmapRenderTarget** renderTarget
        );
        #endregion

        #region Delegates
        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public structure.</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="fontCollection">The font collection to search. If NULL, the local system font collection is used.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> The only fields that matter include: lfFaceName, lfCharSet, lfWeight, lfItalic. Font size and rendering mode are a rendering time property, not a font property, and text decorations like underline are drawn separately from the text. If no font matches the given weight, slope, and character set, the best match within the given GDI family name will be returned. DWRITE_E_NOFONT is returned if there is no matching font name using either the GDI family name (e.g. Arial) or the full font name (e.g. Arial Bold Italic).</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateFontFromLOGFONT1(
            [In] IDWriteGdiInterop1* This,
            [In] LOGFONT* logFont,
            [In, Optional] IDWriteFontCollection* fontCollection,
            [Out] IDWriteFont** font
        );

        /// <summary>Reads the font signature from the given font.</summary>
        /// <param name="font">Font to read font signature from.</param>
        /// <param name="fontSignature">Font signature from the OS/2 table, ulUnicodeRange and ulCodePageRange.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetFontSignature(
            [In] IDWriteGdiInterop1* This,
            [In] IDWriteFont* font,
            [Out] FONTSIGNATURE* fontSignature
        );

        /// <summary>Reads the font signature from the given font.</summary>
        /// <param name="fontFace">Font to read font signature from.</param>
        /// <param name="fontSignature">Font signature from the OS/2 table, ulUnicodeRange and ulCodePageRange.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetFontSignature1(
            [In] IDWriteGdiInterop1* This,
            [In] IDWriteFontFace* fontFace,
            [Out] FONTSIGNATURE* fontSignature
        );

        /// <summary>Get a list of matching fonts based on the LOGFONT values. Only fonts of that family name will be returned.</summary>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetMatchingFontsByLOGFONT(
            [In] IDWriteGdiInterop1* This,
            [In] LOGFONT* logFont,
            [In] IDWriteFontSet* fontSet,
            [Out] IDWriteFontSet** filteredSet
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
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
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteGdiInterop Methods
        [return: ComAliasName("HRESULT")]
        public int CreateFontFromLOGFONT(
            [In] LOGFONT* logFont,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_CreateFontFromLOGFONT>(lpVtbl->CreateFontFromLOGFONT)(
                    This,
                    logFont,
                    font
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int ConvertFontToLOGFONT(
            [In] IDWriteFont* font,
            [Out] LOGFONT* logFont,
            [Out, ComAliasName("BOOL")] int* isSystemFont
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_ConvertFontToLOGFONT>(lpVtbl->ConvertFontToLOGFONT)(
                    This,
                    font,
                    logFont,
                    isSystemFont
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int ConvertFontFaceToLOGFONT(
            [In] IDWriteFontFace* font,
            [Out] LOGFONT* logFont
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_ConvertFontFaceToLOGFONT>(lpVtbl->ConvertFontFaceToLOGFONT)(
                    This,
                    font,
                    logFont
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateFontFaceFromHdc(
            [In, ComAliasName("HDC")] IntPtr hdc,
            [Out] IDWriteFontFace** fontFace
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_CreateFontFaceFromHdc>(lpVtbl->CreateFontFaceFromHdc)(
                    This,
                    hdc,
                    fontFace
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateBitmapRenderTarget(
            [In, Optional, ComAliasName("HDC")] IntPtr hdc,
            [In, ComAliasName("UINT32")] uint width,
            [In, ComAliasName("UINT32")] uint height,
            [Out] IDWriteBitmapRenderTarget** renderTarget
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_CreateBitmapRenderTarget>(lpVtbl->CreateBitmapRenderTarget)(
                    This,
                    hdc,
                    width,
                    height,
                    renderTarget
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int CreateFontFromLOGFONT1(
            [In] LOGFONT* logFont,
            [In, Optional] IDWriteFontCollection* fontCollection,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_CreateFontFromLOGFONT1>(lpVtbl->CreateFontFromLOGFONT1)(
                    This,
                    logFont,
                    fontCollection,
                    font
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetFontSignature(
            [In] IDWriteFont* font,
            [Out] FONTSIGNATURE* fontSignature
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_GetFontSignature>(lpVtbl->GetFontSignature)(
                    This,
                    font,
                    fontSignature
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetFontSignature1(
            [In] IDWriteFontFace* fontFace,
            [Out] FONTSIGNATURE* fontSignature
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_GetFontSignature1>(lpVtbl->GetFontSignature1)(
                    This,
                    fontFace,
                    fontSignature
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetMatchingFontsByLOGFONT(
            [In] LOGFONT* logFont,
            [In] IDWriteFontSet* fontSet,
            [Out] IDWriteFontSet** filteredSet
        )
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return MarshalFunction<_GetMatchingFontsByLOGFONT>(lpVtbl->GetMatchingFontsByLOGFONT)(
                    This,
                    logFont,
                    fontSet,
                    filteredSet
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

            #region IDWriteGdiInterop Fields
            public IntPtr CreateFontFromLOGFONT;

            public IntPtr ConvertFontToLOGFONT;

            public IntPtr ConvertFontFaceToLOGFONT;

            public IntPtr CreateFontFaceFromHdc;

            public IntPtr CreateBitmapRenderTarget;
            #endregion

            #region Fields
            public IntPtr CreateFontFromLOGFONT1;

            public IntPtr GetFontSignature;

            public IntPtr GetFontSignature1;

            public IntPtr GetMatchingFontsByLOGFONT;
            #endregion
        }
        #endregion
    }
}

