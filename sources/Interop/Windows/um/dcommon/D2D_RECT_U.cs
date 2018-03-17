// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a rectangle defined by the coordinates of the upper-left corner (left, top) and the coordinates of the lower-right corner (right, bottom).</summary>
    public /* blittable */ struct D2D_RECT_U
    {
        #region Fields
        [ComAliasName("UINT32")]
        public uint left;

        [ComAliasName("UINT32")]
        public uint top;

        [ComAliasName("UINT32")]
        public uint right;

        [ComAliasName("UINT32")]
        public uint bottom;
        #endregion
    }
}