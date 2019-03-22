// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    [Unmanaged]
    public struct D3D12_INDIRECT_ARGUMENT_DESC
    {
        #region Fields
        [FieldOffset(0)]
        public D3D12_INDIRECT_ARGUMENT_TYPE Type;

        #region union
        [FieldOffset(4)]
        public _VertexBuffer_e__Struct VertexBuffer;

        [FieldOffset(4)]
        public _Constant_e__Struct Constant;

        [FieldOffset(4)]
        public _ConstantBufferView_e__Struct ConstantBufferView;

        [FieldOffset(4)]
        public _ShaderResourceView_e__Struct ShaderResourceView;

        [FieldOffset(4)]
        public _UnorderedAccessView_e__Struct UnorderedAccessView;
        #endregion
        #endregion

        #region Structs
        [Unmanaged]
        public struct _VertexBuffer_e__Struct
        {
            #region Fields
            public uint Slot;
            #endregion
        }

        [Unmanaged]
        public struct _Constant_e__Struct
        {
            #region Fields
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
            public uint Num32BitValuesToSet;
            #endregion
        }

        [Unmanaged]
        public struct _ConstantBufferView_e__Struct
        {
            #region Fields
            public uint RootParameterIndex;
            #endregion
        }

        [Unmanaged]
        public struct _ShaderResourceView_e__Struct
        {
            #region Fields
            public uint RootParameterIndex;
            #endregion
        }

        [Unmanaged]
        public struct _UnorderedAccessView_e__Struct
        {
            #region Fields
            public uint RootParameterIndex;
            #endregion
        }
        #endregion
    }
}
