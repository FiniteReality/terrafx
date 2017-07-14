// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("2F642AFE-9C68-4F40-B8BE-457401AFCB3D")]
    unsafe public /* blittable */ struct IDWriteFontSetBuilder
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        /// <summary>Adds a reference to a font to the set being built. The necessary metadata will automatically be extracted from the font upon calling CreateFontSet.</summary>>
        /// <param name="fontFaceReference">Font face reference object to add to the set.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT AddFontFaceReference(
            [In] IDWriteFontSetBuilder* This,
            [In] IDWriteFontFaceReference* fontFaceReference
        );

        /// <summary>Adds a reference to a font to the set being built. The caller supplies enough information to search on, avoiding the need to open the potentially non-local font. Any properties not supplied by the caller will be missing, and those properties will not be available as filters in GetMatchingFonts. GetPropertyValues for missing properties will return an empty string list. The properties passed should generally be consistent with the actual font contents, but they need not be. You could, for example, alias a font using a different name or unique identifier, or you could set custom tags not present in the actual font.</summary>>
        /// <param name="fontFaceReference">Reference to the font.</param>
        /// <param name="properties">List of properties to associate with the reference.</param>
        /// <param name="propertyCount">How many properties are defined.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT AddFontFaceReference1(
            [In] IDWriteFontSetBuilder* This,
            [In] IDWriteFontFaceReference* fontFaceReference,
            [In] /* readonly */ DWRITE_FONT_PROPERTY* properties,
            [In] UINT32 propertyCount
        );

        /// <summary>Appends an existing font set to the one being built, allowing one to aggregate two sets or to essentially extend an existing one.</summary>>
        /// <param name="fontSet">Font set to append font face references from.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT AddFontSet(
            [In] IDWriteFontSetBuilder* This,
            [In] IDWriteFontSet* fontSet
        );

        /// <summary>Creates a font set from all the font face references added so far via AddFontFaceReference.</summary>>
        /// <param name="fontSet">Contains newly created font set object, or nullptr in case of failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Creating a font set takes less time if the references were added with metadata rather than needing to extract the metadata from the font file.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateFontSet(
            [In] IDWriteFontSetBuilder* This,
            [Out] IDWriteFontSet** fontSet
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IUnknown.Vtbl BaseVtbl;

            public AddFontFaceReference AddFontFaceReference;

            public AddFontFaceReference1 AddFontFaceReference1;

            public AddFontSet AddFontSet;

            public CreateFontSet CreateFontSet;
            #endregion
        }
        #endregion
    }
}