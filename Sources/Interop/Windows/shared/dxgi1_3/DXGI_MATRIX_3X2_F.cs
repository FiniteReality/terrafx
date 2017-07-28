// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* blittable */ struct DXGI_MATRIX_3X2_F
    {
        #region Fields
        [ComAliasName("FLOAT")]
        public float _11;

        [ComAliasName("FLOAT")]
        public float _12;

        [ComAliasName("FLOAT")]
        public float _21;

        [ComAliasName("FLOAT")]
        public float _22;

        [ComAliasName("FLOAT")]
        public float _31;

        [ComAliasName("FLOAT")]
        public float _32;
        #endregion
    }
}
