// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    unsafe public /* blittable */ struct D3D12_CLEAR_VALUE
    {
        #region Fields
        [FieldOffset(0)]
        public DXGI_FORMAT Format;

        #region union
        [FieldOffset(4)]
        [ComAliasName("FLOAT[4]")]
        public _Color_e__FixedBuffer Color;

        [FieldOffset(4)]
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil;
        #endregion
        #endregion

        #region Structs
        public /* blittable */ struct _Color_e__FixedBuffer
        {
            #region Fields
            public float e0;

            public float e1;

            public float e2;

            public float e3;
            #endregion

            #region Properties
            public float this[int index]
            {
                get
                {
                    if ((uint)(index) > 3) // (index < 0) || (index > 3)
                    {
                        ThrowArgumentOutOfRangeException(nameof(index), index);
                    }

                    fixed (float* e = &e0)
                    {
                        return e[index];
                    }
                }
            }
            #endregion
        }
        #endregion
    }
}
