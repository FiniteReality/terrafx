// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.Vulkan;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Graphics.Providers.Vulkan
{
    /// <summary>Represents a graphics adapter.</summary>
    public sealed unsafe class GraphicsAdapter : IGraphicsAdapter
    {
        private readonly GraphicsProvider _graphicsProvider;
        private readonly VkPhysicalDevice _physicalDevice;
        private readonly string _deviceName;
        private readonly uint _vendorId;
        private readonly uint _deviceId;

        internal GraphicsAdapter(GraphicsProvider graphicsProvider, VkPhysicalDevice physicalDevice)
        {
            _graphicsProvider = graphicsProvider;
            _physicalDevice = physicalDevice;

            VkPhysicalDeviceProperties properties;
            vkGetPhysicalDeviceProperties(physicalDevice, &properties);

            _deviceName = Marshal.PtrToStringAnsi((IntPtr)properties.deviceName)!;
            _vendorId = properties.vendorID;
            _deviceId = properties.deviceID;
        }

        /// <inheritdoc />
        public uint DeviceId => _deviceId;

        /// <inheritdoc />
        public string DeviceName => _deviceName;

        /// <inheritdoc />
        public IGraphicsProvider GraphicsProvider => _graphicsProvider;

        /// <summary>Gets the physical device for the instance.</summary>
        public VkPhysicalDevice PhysicalDevice => _physicalDevice;

        /// <inheritdoc />
        public uint VendorId => _vendorId;

        /// <inheritdoc />
        public IGraphicsContext CreateGraphicsContext(IGraphicsSurface graphicsSurface)
        {
            ThrowIfNull(graphicsSurface, nameof(graphicsSurface));
            return new GraphicsContext(this, graphicsSurface);
        }
    }
}