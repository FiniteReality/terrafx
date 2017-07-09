// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public  /* blittable */ struct TLIBATTR
    {
        #region Fields
        public GUID guid;

        public LCID lcid;

        public SYSKIND syskind;

        public WORD wMajorVerNum;

        public WORD wMinorVerNum;

        public WORD wLibFlags;
        #endregion
    }
}
