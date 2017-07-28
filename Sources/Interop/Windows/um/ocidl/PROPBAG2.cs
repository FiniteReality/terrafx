// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\ocidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    unsafe public /* blittable */ struct PROPBAG2
    {
        #region Fields
        [ComAliasName("DWORD")]
        public uint dwType;

        [ComAliasName("VARTYPE")]
        public ushort vt;

        [ComAliasName("CLIPFORMAT")]
        public ushort cfType;

        [ComAliasName("DWORD")]
        public uint dwHint;

        [ComAliasName("LPOLESTR")]
        public char* pstrName;

        [ComAliasName("CLSID")]
        public Guid clsid;
        #endregion
    }
}
