﻿namespace System.DirectoryServices.ActiveDirectory
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal sealed class DS_REPL_CURSOR_3
    {
        public Guid uuidSourceDsaInvocationID;
        public long usnAttributeFilter;
        public long ftimeLastSyncSuccess;
        public IntPtr pszSourceDsaDN;
    }
}

