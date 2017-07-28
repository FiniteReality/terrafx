// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Describes mapped memory from the ID2D1Bitmap1::Map API.</summary>
    unsafe public /* blittable */ struct D2D1_MAPPED_RECT
    {
        #region Fields
        [ComAliasName("UINT32")]
        public uint pitch;

        [ComAliasName("BYTE")]
        public byte* bits;
        #endregion
    }
}
