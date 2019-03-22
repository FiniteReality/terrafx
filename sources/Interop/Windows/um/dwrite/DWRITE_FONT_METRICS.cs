// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_FONT_METRICS structure specifies the metrics of a font face that are applicable to all glyphs within the font face.</summary>
    [Unmanaged]
    public struct DWRITE_FONT_METRICS
    {
        #region Fields
        /// <summary>The number of font design units per em unit. Font files use their own coordinate system of font design units. A font design unit is the smallest measurable unit in the em square, an imaginary square that is used to size and align glyphs. The concept of em square is used as a reference scale factor when defining font size and device transformation semantics. The size of one em square is also commonly used to compute the paragraph indentation value.</summary>
        [ComAliasName("UINT16")]
        public ushort designUnitsPerEm;

        /// <summary>Ascent value of the font face in font design units. Ascent is the distance from the top of font character alignment box to English baseline.</summary>
        [ComAliasName("UINT16")]
        public ushort ascent;

        /// <summary>Descent value of the font face in font design units. Descent is the distance from the bottom of font character alignment box to English baseline.</summary>
        [ComAliasName("UINT16")]
        public ushort descent;

        /// <summary>Line gap in font design units. Recommended additional white space to add between lines to improve legibility. The recommended line spacing (baseline-to-baseline distance) is thus the sum of ascent, descent, and lineGap. The line gap is usually positive or zero but can be negative, in which case the recommended line spacing is less than the height of the character alignment box.</summary>
        [ComAliasName("INT16")]
        public short lineGap;

        /// <summary>Cap height value of the font face in font design units. Cap height is the distance from English baseline to the top of a typical English capital. Capital "H" is often used as a reference character for the purpose of calculating the cap height value.</summary>
        [ComAliasName("UINT16")]
        public ushort capHeight;

        /// <summary>x-height value of the font face in font design units. x-height is the distance from English baseline to the top of lowercase letter "x", or a similar lowercase character.</summary>
        [ComAliasName("UINT16")]
        public ushort xHeight;

        /// <summary>The underline position value of the font face in font design units. Underline position is the position of underline relative to the English baseline. The value is usually made negative in order to place the underline below the baseline.</summary>
        [ComAliasName("INT16")]
        public short underlinePosition;

        /// <summary>The suggested underline thickness value of the font face in font design units.</summary>
        [ComAliasName("UINT16")]
        public ushort underlineThickness;

        /// <summary>The strikethrough position value of the font face in font design units. Strikethrough position is the position of strikethrough relative to the English baseline. The value is usually made positive in order to place the strikethrough above the baseline.</summary>
        [ComAliasName("INT16")]
        public short strikethroughPosition;

        /// <summary>The suggested strikethrough thickness value of the font face in font design units.</summary>
        [ComAliasName("UINT16")]
        public ushort strikethroughThickness;
        #endregion
    }
}
