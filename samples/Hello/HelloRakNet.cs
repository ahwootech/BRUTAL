/*
 * HelloRakNet
 *
 * Starts a RakNet server and client in one process, connects them on localhost and sends a message.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.RakNet@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Strings@2026.10.2

// RIAN: I believe this package is about to get a refresh with full plugin support (NAT punchthrough, etc).

using Brutal.RakNetApi;
using Brutal.Strings;

const ushort PORT = 60_000;

Run();

static void Run()
{
    // Disposing a peer destroys it, which happens after it has been shut down at the end.
    using var server = RakNetLibrary.CreateInstance();
    using var client = RakNetLibrary.CreateInstance();

    // The server can fail to start if something else is already using the port.
    var serverSocket = new SocketDescriptor(PORT);
    var serverStartup = server.Startup(4, new Span<SocketDescriptor>(ref serverSocket));
    if (serverStartup != StartupResult.RaknetStarted)
        throw new InvalidOperationException($"Server failed to start on port {PORT}: {serverStartup}");
    server.SetMaximumIncomingConnections(4);

    var clientSocket = new SocketDescriptor(0); // Any free port.
    client.Startup(1, new Span<SocketDescriptor>(ref clientSocket));

    unsafe
    {
        client.Connect("127.0.0.1"u8, PORT, default, null);

        // Everything is local, so give up if the exchange takes more than a few seconds.
        var deadline = DateTime.UtcNow + TimeSpan.FromSeconds(5);
        var running = true;
        while (running)
        {
            if (DateTime.UtcNow > deadline)
                throw new TimeoutException("Timed out connecting and exchanging a message over localhost");

            for (var packet = client.Receive(); packet != null; packet = client.Receive())
            {
                if ((DefaultMessageIDTypes)packet->Data[0] == DefaultMessageIDTypes.ConnectionRequestAccepted)
                {
                    Console.WriteLine("Client: connected to server");

                    byte[] message = [(byte)DefaultMessageIDTypes.UserPacketEnum, .. "Hello, RakNet!"u8];
                    client.Send(
                        message,
                        PacketPriority.HighPriority,
                        PacketReliability.ReliableOrdered,
                        0,
                        new AddressOrGUID(packet->SystemAddress),
                        false
                    );
                }
                client.DeallocatePacket(packet);
            }

            for (var packet = server.Receive(); packet != null; packet = server.Receive())
            {
                if ((DefaultMessageIDTypes)packet->Data[0] == DefaultMessageIDTypes.UserPacketEnum)
                {
                    var text = Utf8.GetString(packet->Data + 1, (int)packet->Length - 1);
                    Console.WriteLine($"Server: received \"{text}\"");
                    running = false;
                }
                server.DeallocatePacket(packet);
            }

            Thread.Sleep(10);
        }
    }

    client.Shutdown(300);
    server.Shutdown(300);
}
