// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a 3-by-2 matrix.</summary>
    [StructLayout(LayoutKind.Explicit)]
    public /* blittable */ struct D2D_MATRIX_3X2_F
    {
        #region Fields
        #region struct
        /// <summary>Horizontal scaling / cosine of rotation</summary>
        [FieldOffset(0)]
        public float m11;

        /// <summary>Vertical shear / sine of rotation</summary>
        [FieldOffset(4)]
        public float m12;

        /// <summary>Horizontal shear / negative sine of rotation</summary>
        [FieldOffset(8)]
        public float m21;

        /// <summary>Vertical scaling / cosine of rotation</summary>
        [FieldOffset(12)]
        public float m22;

        /// <summary>Horizontal shift (always orthogonal regardless of rotation)</summary>
        [FieldOffset(16)]
        public float dx;

        /// <summary>Vertical shift (always orthogonal regardless of rotation)</summary>
        [FieldOffset(20)]
        public float dy;
        #endregion

        #region struct
        [FieldOffset(0)]
        [ComAliasName("FLOAT")]
        public float _11;

        [FieldOffset(4)]
        [ComAliasName("FLOAT")]
        public float _12;

        [FieldOffset(8)]
        [ComAliasName("FLOAT")]
        public float _21;

        [FieldOffset(12)]
        [ComAliasName("FLOAT")]
        public float _22;

        [FieldOffset(16)]
        [ComAliasName("FLOAT")]
        public float _31;

        [FieldOffset(20)]
        [ComAliasName("FLOAT")]
        public float _32;
        #endregion

        [FieldOffset(0)]
        [ComAliasName("FLOAT[3][2]")]
        public _m_e__FixedBuffer m;
        #endregion

        #region Structs
        unsafe public /* blittable */ struct _m_e__FixedBuffer
        {
            #region Fields
            public float e0_0, e0_1;

            public float e1_0, e1_1;

            public float e2_0, e2_1;
            #endregion

            #region Properties
            public float this[int index1, int index2]
            {
                get
                {
                    if ((uint)(index1) > 2) // (index1 < 0) || (index1 > 2)
                    {
                        ThrowArgumentOutOfRangeException(nameof(index1), index1);
                    }

                    if ((uint)(index2) > 1) // (index2 < 0) || (index2 > 1)
                    {
                        ThrowArgumentOutOfRangeException(nameof(index2), index2);
                    }

                    fixed (float* e = &e0_0)
                    {
                        return e[(index1 * 2) + index2];
                    }
                }
            }
            #endregion
        }
        #endregion
    }
}
