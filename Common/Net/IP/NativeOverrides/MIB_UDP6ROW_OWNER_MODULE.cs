﻿using System;

using Wokhan.WindowsFirewallNotifier.Common.Net.IP;

namespace Windows.Win32.NetworkManagement.IpHelper;

/// <summary>
/// IMPORTANT: Never add any field or setter to this struct, as it is PARTIAL and relies on fields generated by CsWin32 P/Invoke source generator.
/// If you do this, fields order might be broken and P/Invoke will fail (the struct layout in memory being unpredictable for partial structs).
/// </summary>
internal partial struct MIB_UDP6ROW_OWNER_MODULE : IConnectionOwnerInfo
{
    unsafe uint IConnectionOwnerInfo.GetOwnerModule(IntPtr buffer, ref uint buffSize)
    {
        return NativeMethods.GetOwnerModuleFromUdp6Entry(this, TCPIP_OWNER_MODULE_INFO_CLASS.TCPIP_OWNER_MODULE_INFO_BASIC, buffer.ToPointer(), ref buffSize);
    }
}
