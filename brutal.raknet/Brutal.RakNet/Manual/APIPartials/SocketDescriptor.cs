using System.Net.Sockets;
using System.Text;
using Brutal.Strings;

namespace Brutal.RakNetApi;

/// <summary>
/// Partial struct for SocketDescriptor that provides useful functionality.
/// </summary>
public unsafe partial struct SocketDescriptor
{
    /// <summary>
    /// Create a SocketDescriptor with an IPV4 address family.
    /// </summary>
    public SocketDescriptor()
        : this(AddressFamily.InterNetwork) { }

    /// <summary>
    /// Create a socket descriptor for IPV4 with port and AddressFamily
    /// </summary>
    /// <param name="port">Port to use</param>
    /// <param name="family">Address family to use</param>
    public SocketDescriptor(int port, AddressFamily family = AddressFamily.InterNetwork)
        : this("", port, family) { }

    /// <summary>
    /// Create a SocketDescriptor with an AddressFamily
    /// </summary>
    public SocketDescriptor(AddressFamily addressFamily)
        : this(0, addressFamily) { }

    /// <summary>
    /// Create a SocketDescriptor with a host, port and optional AddressFamily.
    /// </summary>
    /// <param name="host">Host address or name</param>
    /// <param name="port">Port to use</param>
    /// <param name="family">The Address Family to use, defaults to IPV4</param>
    public SocketDescriptor(string host, int port, AddressFamily family = AddressFamily.InterNetwork)
    {
        SetHostAddress(host);
        Port = (ushort)port;
        SocketFamily = (short)family;
        BlockingSocket = true;
        RemotePortRakNetWasStartedOnPS3PSP2 = 0;
        ExtraSocketOptions = 0;
    }

    /// <summary>
    /// Sets the host address for the socket descriptor. The address must encode to at most
    /// <see cref="HostAddressLength"/> - 1 UTF-8 bytes so the buffer stays null-terminated;
    /// any remaining buffer space is cleared. On failure the existing address is left unchanged.
    /// </summary>
    /// <param name="host">The host address as a string.</param>
    /// <exception cref="ArgumentException">The encoded address does not fit.</exception>
    public void SetHostAddress(string host)
    {
        Span<byte> encoded = stackalloc byte[HostAddressLength - 1];
        if (!Utf8.TryGetBytes(host, encoded, out var bytesWritten))
            throw new ArgumentException(
                $"Host address must encode to at most {HostAddressLength - 1} UTF-8 bytes to leave room for the null terminator.",
                nameof(host)
            );

        fixed (byte* ptr = HostAddress)
        {
            var buffer = new Span<byte>(ptr, HostAddressLength);
            encoded[..bytesWritten].CopyTo(buffer);
            buffer[bytesWritten..].Clear();
        }
    }

    /// <summary>
    /// Sets the host address for the socket descriptor using a Utf8String instance.
    /// Trailing null bytes in <paramref name="host"/> are ignored; the content must be at most
    /// <see cref="HostAddressLength"/> - 1 bytes so the buffer stays null-terminated, and any
    /// remaining buffer space is cleared. On failure the existing address is left unchanged.
    /// </summary>
    /// <param name="host">The new host address</param>
    /// <exception cref="ArgumentException">The address content does not fit.</exception>
    public void SetHostAddress(ReadOnlySpan<byte> host)
    {
        var content = host.TrimEnd((byte)0);
        if (content.Length >= HostAddressLength)
            throw new ArgumentException(
                $"Host address must be at most {HostAddressLength - 1} bytes to leave room for the null terminator.",
                nameof(host)
            );

        fixed (byte* ptr = HostAddress)
        {
            var buffer = new Span<byte>(ptr, HostAddressLength);
            content.CopyTo(buffer);
            buffer[content.Length..].Clear();
        }
    }

    public override string ToString()
    {
        if (HostAddress[0] != 0)
        {
            fixed (byte* ptr = HostAddress)
            {
                var length = 0;
                while (length < HostAddressLength && ptr[length] != 0)
                    length++;
                var s = Encoding.UTF8.GetString(ptr, length);
                return $"{s}:{Port}";
            }
        }
        return $"{Port}";
    }

    // Convenience value useful when you're copying into or out of the HostAddress array.
    public const int HostAddressLength = 32;
}
