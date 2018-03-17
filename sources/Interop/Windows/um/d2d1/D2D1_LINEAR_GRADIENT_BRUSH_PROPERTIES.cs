// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Contains the starting point and endpoint of the gradient axis for an ID2D1LinearGradientBrush.</summary>
    public /* blittable */ struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
    {
        #region Fields
        [ComAliasName("D2D1_POINT_2F")]
        public D2D_POINT_2F startPoint;

        [ComAliasName("D2D1_POINT_2F")]
        public D2D_POINT_2F endPoint;
        #endregion
    }
}