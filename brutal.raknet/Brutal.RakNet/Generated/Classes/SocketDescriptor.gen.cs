using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct SocketDescriptor
    {
        /// <summary>The local port to bind to.  Pass 0 to have the OS autoassign a port.</summary>
        public ushort Port;

        /// <summary>The local network card address to bind to, such as "127.0.0.1".  Pass an empty string to use INADDR_ANY.</summary>
        public fixed byte HostAddress[32];

        /// <summary>IP version: For IPV4, use AF_INET (default). For IPV6, use AF_INET6. To autoselect, use AF_UNSPEC.IPV6 is the newer internet protocol. Instead of addresses such as natpunch.jenkinssoftware.com, you may have an address such as fe80::7c:31f7:fec4:27de%14.Encoding takes 16 bytes instead of 4, so IPV6 is less efficient for bandwidth.On the positive side, NAT Punchthrough is not needed and should not be used with IPV6 because there are enough addresses that routers do not need to create address mappings.RakPeer::Startup() will fail if this IP version is not supported.</summary>
        /// <remarks>RAKNET_SUPPORT_IPV6 must be set to 1 in RakNetDefines.h for AF_INET6</remarks>
        public short SocketFamily;
        public ushort RemotePortRakNetWasStartedOnPS3PSP2;

        /// <summary>Required for Google chrome</summary>
        public int ChromeInstance;

        /// <summary>Set to true to use a blocking socket (default, do not change unless you have a reason to)</summary>
        public Bool8 BlockingSocket;

        /// <summary>XBOX only: set IPPROTO_VDP if you want to use VDP. If enabled, this socket does not support broadcast to 255.255.255.255</summary>
        public uint ExtraSocketOptions;
    }
}
