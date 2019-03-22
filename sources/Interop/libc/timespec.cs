// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>A time specification.</summary>
    [Unmanaged]
    public struct timespec
    {
        #region Fields
        /// <summary>Seconds.</summary>
        [ComAliasName("time_t")]
        public nint tv_sec;

        /// <summary>Nanoseconds.</summary>
        public nint tv_nsec;
        #endregion
    }
}
