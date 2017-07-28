// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    unsafe public /* blittable */ struct DXGI_PRESENT_PARAMETERS
    {
        #region Fields
        [ComAliasName("UINT")]
        public uint DirtyRectsCount;

        public RECT* pDirtyRects;

        public RECT* pScrollRect;

        public POINT* pScrollOffset;
        #endregion
    }
}
