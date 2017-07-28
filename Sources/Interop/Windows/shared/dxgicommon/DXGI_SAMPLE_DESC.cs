// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgicommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* blittable */ struct DXGI_SAMPLE_DESC
    {
        #region Fields
        [ComAliasName("UINT")]
        public uint Count;

        [ComAliasName("UINT")]
        public uint Quality;
        #endregion
    }
}
