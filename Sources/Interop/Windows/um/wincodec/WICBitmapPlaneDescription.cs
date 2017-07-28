// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* blittable */ struct WICBitmapPlaneDescription
    {
        #region Fields
        [ComAliasName("WICPixelFormatGUID")]
        public Guid Format;

        [ComAliasName("UINT")]
        public uint Width;

        [ComAliasName("UINT")]
        public uint Height;
        #endregion
    }
}
