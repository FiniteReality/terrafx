// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_CLUSTER_METRICS public structure contains information about a glyph cluster.</summary>
    public /* blittable */ struct DWRITE_CLUSTER_METRICS
    {
        #region Fields
        /// <summary>The total advance width of all glyphs in the cluster.</summary>>
        public FLOAT width;

        /// <summary>The number of text positions in the cluster.</summary>>
        public UINT16 length;

        internal UINT16 _bitField;
        #endregion

        #region Properties
        /// <summary>Indicate whether line can be broken right after the cluster.</summary>>
        public UINT16 canWrapLineAfter
        {
            get
            {
                return (ushort)(_bitField & 0b0000_0000_0000_0001);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1111_1110) | (value & 0b0000_0000_0000_0001));
            }
        }

        /// <summary>Indicate whether the cluster corresponds to whitespace character.</summary>>
        public UINT16 isWhitespace
        {
            get
            {
                return (ushort)((_bitField & 0b0000_0000_0000_0010) >> 1);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1111_1101) | ((value << 1) & 0b0000_0000_0000_0010));
            }
        }

        /// <summary>Indicate whether the cluster corresponds to a newline character.</summary>>
        public UINT16 isNewline
        {
            get
            {
                return (ushort)((_bitField & 0b0000_0000_0000_0100) >> 2);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1111_1011) | ((value << 2) & 0b0000_0000_0000_0100));
            }
        }

        /// <summary>Indicate whether the cluster corresponds to soft hyphen character.</summary>>
        public UINT16 isSoftHyphen
        {
            get
            {
                return (ushort)((_bitField & 0b0000_0000_0000_1000) >> 3);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1111_0111) | ((value << 3) & 0b0000_0000_0000_1000));
            }
        }

        /// <summary>Indicate whether the cluster is read from right to left.</summary>>
        public UINT16 isRightToLeft
        {
            get
            {
                return (ushort)((_bitField & 0b0000_0000_0001_0000) >> 4);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1110_1111) | ((value << 4) & 0b0000_0000_0001_0000));
            }
        }

        public UINT16 padding
        {
            get
            {
                return (ushort)((_bitField & 0b1111_1111_1110_0000) >> 5);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b0000_0000_0001_1111) | ((value << 5) & 0b1111_1111_1110_0000));
            }
        }
        #endregion
    }
}