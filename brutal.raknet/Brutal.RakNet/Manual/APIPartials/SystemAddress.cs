using System.Buffers.Binary;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi;

public partial struct SystemAddress
{
    public SystemAddress()
    {
        // All other fields should be initialised to their default values, which will be 0.
        Address.Addr4.SinFamily = (ushort)AddressFamily.InterNetwork;
        SystemIndex = unchecked((ushort)(-1));
        DebugPort = 0;
    }

    [Pure]
    public string ToString(bool includePort = false, char portDelimiter = ':')
    {
        unsafe
        {
            fixed (byte* b = &Address.Addr4.SinAddr.SUn.SUnB.SB1)
            {
                var ip = new IPAddress(new ReadOnlySpan<byte>(b, sizeof(SUnBSUnInAddr)));
                var port = BinaryPrimitives.ReverseEndianness(Address.Addr4.SinPort);
                return ip + (includePort ? $"{portDelimiter}{port}" : "");
            }
        }
    }

    public static readonly SystemAddress UNASSIGNED_SYSTEM_ADDRESS = new();
}
