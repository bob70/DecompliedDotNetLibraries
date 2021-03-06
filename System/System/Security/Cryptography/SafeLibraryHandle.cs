﻿namespace System.Security.Cryptography
{
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.InteropServices;
    using System.Security;

    internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeLibraryHandle() : base(true)
        {
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [SuppressUnmanagedCodeSecurity, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), DllImport("kernel32.dll", SetLastError=true)]
        private static extern bool FreeLibrary([In] IntPtr hModule);
        protected override bool ReleaseHandle()
        {
            return FreeLibrary(base.handle);
        }
    }
}

