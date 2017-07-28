// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Describes the opacity and transformation of a brush.</summary>
    public /* blittable */ struct D2D1_BRUSH_PROPERTIES
    {
        #region Fields
        [ComAliasName("FLOAT")]
        public float opacity;

        [ComAliasName("D2D1_MATRIX_3X2_F")]
        public D2D_MATRIX_3X2_F transform;
        #endregion
    }
}
