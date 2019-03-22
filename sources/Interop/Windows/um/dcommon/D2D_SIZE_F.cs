// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Stores an ordered pair of floats, typically the width and height of a rectangle.</summary>
    [Unmanaged]
    public struct D2D_SIZE_F
    {
        #region Fields
        [ComAliasName("FLOAT")]
        public float width;

        [ComAliasName("FLOAT")]
        public float height;
        #endregion
    }
}
