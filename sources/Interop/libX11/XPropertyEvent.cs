// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct XPropertyEvent
    {
        #region Fields
        public int type;

        public nuint serial;

        [ComAliasName("Bool")]
        public int send_event;

        [ComAliasName("Display")]
        public IntPtr display;

        [ComAliasName("Window")]
        public nuint window;

        [ComAliasName("Atom")]
        public nuint atom;

        [ComAliasName("Time")]
        public nuint time;

        public int state;
        #endregion
    }
}
