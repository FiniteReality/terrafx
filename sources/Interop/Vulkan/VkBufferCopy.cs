// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct VkBufferCopy
    {
        #region Fields
        [ComAliasName("VkDeviceSize")]
        public ulong srcOffset;

        [ComAliasName("VkDeviceSize")]
        public ulong dstOffset;

        [ComAliasName("VkDeviceSize")]
        public ulong size;
        #endregion
    }
}
