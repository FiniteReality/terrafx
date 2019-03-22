// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct D3D12_COMMAND_SIGNATURE_DESC
    {
        #region Fields
        [ComAliasName("UINT")]
        public uint ByteStride;

        [ComAliasName("UINT")]
        public uint NumArgumentDescs;

        [ComAliasName("D3D12_INDIRECT_ARGUMENT_DESC[]")]
        public D3D12_INDIRECT_ARGUMENT_DESC* pArgumentDescs;

        [ComAliasName("UINT")]
        public uint NodeMask;
        #endregion
    }
}
