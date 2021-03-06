// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Collections.Generic;
using System.Threading;

namespace TerraFX.UI
{
    /// <summary>Provides access to a window subsystem.</summary>
    public interface IWindowProvider
    {
        /// <summary>Gets the <see cref="IDispatchProvider" /> for the instance.</summary>
        IDispatchProvider DispatchProvider { get; }

        /// <summary>Gets the <see cref="IWindow" /> objects created by the instance which are associated with <see cref="Thread.CurrentThread" />.</summary>
        IEnumerable<IWindow> WindowsForCurrentThread { get; }

        /// <summary>Create a new <see cref="IWindow" /> instance.</summary>
        /// <returns>A new <see cref="IWindow" /> instance</returns>
        IWindow CreateWindow();
    }
}
