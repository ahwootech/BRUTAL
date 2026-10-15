using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    public static partial class RakPeerInterface
    {
        /// <summary>--------------------------------------------------------------------------------------------Major Low Level Functions - Functions needed by most users--------------------------------------------------------------------------------------------</summary>
        /// <summary>Starts the network threads, opens the listen port.</summary>
        /// <remarks>You must call this before calling Connect().</remarks>
        /// <remarks>On the PS3, call Startup() after Client_Login()</remarks>
        /// <remarks>On Android, add the necessary permission to your application's androidmanifest.xml: <uses-permission android:name="android.permission.INTERNET" />Multiple calls while already active are ignored.  To call this function again with different settings, you must first call Shutdown().</remarks>
        /// Call SetMaximumIncomingConnections if you want to accept incoming connections
        /// <param name = "maxConnections">The maximum number of connections between this instance of RakPeer and another instance of RakPeer. Required so the network can preallocate and for thread safety. A pure client would set this to 1.  A pure server would set it to the number of allowed clients.- A hybrid would set it to the sum of both types of connections</param>
        /// <param name = "localPort">The port to listen for connections on. On linux the system may be set up so thast ports under 1024 are restricted for everything but the root user. Use a higher port for maximum compatibility. </param>
        /// <param name = "socketDescriptors">An array of SocketDescriptor structures to force RakNet to listen on a particular IP address or port (or both).  Each SocketDescriptor will represent one unique socket.  Do not pass redundant structures.  To listen on a specific port, you can pass SocketDescriptor(myPort,0); such as for a server.  For a client, it is usually OK to just pass SocketDescriptor(); However, on the XBOX be sure to use IPPROTO_VDP</param>
        /// <param name = "socketDescriptorCount">The size of the @a socketDescriptors array.  Pass 1 if you are not sure what to pass.</param>
        /// <param name = "threadPriority">Passed to the thread creation routine. Use THREAD_PRIORITY_NORMAL for Windows. For Linux based systems, you MUST pass something reasonable based on the thread priorities for your application.</param>
        /// <returns>RAKNET_STARTED on success, otherwise appropriate failure enumeration.</returns>
        public static StartupResult Startup(
            this RakPeerInstance instance,
            uint maxConnections,
            Span<SocketDescriptor> socketDescriptors,
            int threadPriority = (int)-99999
        )
        {
            return instance.StartupShim(
                maxConnections,
                socketDescriptors,
                (uint)socketDescriptors.Length,
                threadPriority
            );
        }

        [LibraryImport("RakNetDLL", EntryPoint = "Startup")]
        private static partial StartupResult StartupShim(
            this RakPeerInstance instance,
            uint maxConnections,
            Span<SocketDescriptor> socketDescriptors,
            uint socketDescriptorCount,
            int threadPriority = (int)-99999
        );

        /// <summary>Sets how many incoming connections are allowed. If this is less than the number of players currently connected,no more players will be allowed to connect.  If this is greater than the maximum number of peers allowed,it will be reduced to the maximum number of peers allowed.Defaults to 0, meaning by default, nobody can connect to you</summary>
        /// <param name = "numberAllowed">Maximum number of incoming connections allowed.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetMaximumIncomingConnections")]
        public static partial void SetMaximumIncomingConnections(this RakPeerInstance instance, ushort numberAllowed);

        /// <summary>Returns the value passed to SetMaximumIncomingConnections()</summary>
        /// <returns>the maximum number of incoming connections, which is always <= maxConnections</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetMaximumIncomingConnections")]
        public static partial uint GetMaximumIncomingConnections(this RakPeerInstance instance);

        /// <summary>Returns how many open connections there are at this time</summary>
        /// <returns>the number of open connections</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "NumberOfConnections")]
        public static partial ushort NumberOfConnections(this RakPeerInstance instance);

        /// <summary>Sets the password incoming connections must match in the call to Connect (defaults to none). Pass 0 to passwordData to specify no passwordThis is a way to set a low level password for all incoming connections.  To selectively reject connections, implement your own scheme using CloseConnection() to remove unwanted connections</summary>
        /// <param name = "passwordData">A data block that incoming connections must match.  This can be just a password, or can be a stream of data. Specify 0 for no password data</param>
        /// <param name = "passwordDataLength">The length in bytes of passwordData</param>
        public static void SetIncomingPassword(this RakPeerInstance instance, ReadOnlySpan<byte> passwordData)
        {
            instance.SetIncomingPasswordShim(passwordData, passwordData.Length);
        }

        [LibraryImport("RakNetDLL", EntryPoint = "SetIncomingPassword")]
        private static partial void SetIncomingPasswordShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> passwordData,
            int passwordDataLength
        );

        /// <summary>Gets the password passed to SetIncomingPassword</summary>
        /// <param name = "passwordData">Should point to a block large enough to hold the password data you passed to SetIncomingPassword()</param>
        /// <param name = "passwordDataLength">Maximum size of the array passwordData.  Modified to hold the number of bytes actually written</param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetIncomingPassword")]
        public static unsafe partial void GetIncomingPassword(
            this RakPeerInstance instance,
            byte* passwordData,
            ref int passwordDataLength
        );

        /// <summary>Connect to the specified host (ip or domain name) and server port.Calling Connect and not calling SetMaximumIncomingConnections acts as a dedicated client.Calling both acts as a true peer. This is a non-blocking connection.You know the connection is successful when GetConnectionState() returns IS_CONNECTED or Receive() gets a message with the type identifier ID_CONNECTION_REQUEST_ACCEPTED.If the connection is not successful, such as a rejected connection or no response then neither of these things will happen.</summary>
        /// <remarks>Requires that you first call Startup()</remarks>
        /// <param name = "host">Either a dotted IP address or a domain name</param>
        /// <param name = "remotePort">Which port to connect to on the remote machine.</param>
        /// <param name = "passwordData">A data block that must match the data block on the server passed to SetIncomingPassword.  This can be a string or can be a stream of data.  Use 0 for no password.</param>
        /// <param name = "passwordDataLength">The length in bytes of passwordData</param>
        /// <param name = "publicKey">The public key the server is using. If 0, the server is not using security. If non-zero, the publicKeyMode member determines how to connect</param>
        /// <param name = "connectionSocketIndex">Index into the array of socket descriptors passed to socketDescriptors in RakPeer::Startup() to send on.</param>
        /// <param name = "sendConnectionAttemptCount">How many datagrams to send to the other system to try to connect.</param>
        /// <param name = "timeBetweenSendConnectionAttemptsMS">Time to elapse before a datagram is sent to the other system to try to connect. After sendConnectionAttemptCount number of attempts, ID_CONNECTION_ATTEMPT_FAILED is returned. Under low bandwidth conditions with multiple simultaneous outgoing connections, this value should be raised to 1000 or higher, or else the MTU detection can overrun the available bandwidth.</param>
        /// <param name = "timeoutTime">How long to keep the connection alive before dropping it on unable to send a reliable message. 0 to use the default from SetTimeoutTime(UNASSIGNED_SYSTEM_ADDRESS);</param>
        /// <returns>CONNECTION_ATTEMPT_STARTED on successful initiation. Otherwise, an appropriate enumeration indicating failure.</returns>
        /// CONNECTION_ATTEMPT_STARTED does not mean you are already connected!
        /// It is possible to immediately get back ID_CONNECTION_ATTEMPT_FAILED if you exceed the maxConnections parameter passed to Startup(). This could happen if you call CloseConnection() with sendDisconnectionNotificaiton true, then immediately call Connect() before the connection has closed.
        public static unsafe ConnectionAttemptResult Connect(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> passwordData,
            PublicKey* publicKey,
            uint connectionSocketIndex = (uint)0,
            uint sendConnectionAttemptCount = (uint)12,
            uint timeBetweenSendConnectionAttemptsMS = (uint)500,
            uint timeoutTime = (uint)0
        )
        {
            return instance.ConnectShim(
                host,
                remotePort,
                passwordData,
                passwordData.Length,
                publicKey,
                connectionSocketIndex,
                sendConnectionAttemptCount,
                timeBetweenSendConnectionAttemptsMS,
                timeoutTime
            );
        }

        [LibraryImport("RakNetDLL", EntryPoint = "Connect")]
        private static unsafe partial ConnectionAttemptResult ConnectShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> passwordData,
            int passwordDataLength,
            PublicKey* publicKey,
            uint connectionSocketIndex = (uint)0,
            uint sendConnectionAttemptCount = (uint)12,
            uint timeBetweenSendConnectionAttemptsMS = (uint)500,
            uint timeoutTime = (uint)0
        );

        /// <summary>Connect to the specified host (ip or domain name) and server port, using a shared socket from another instance of RakNet</summary>
        /// <param name = "host">Either a dotted IP address or a domain name</param>
        /// <param name = "remotePort">Which port to connect to on the remote machine.</param>
        /// <param name = "passwordData">A data block that must match the data block on the server passed to SetIncomingPassword.  This can be a string or can be a stream of data.  Use 0 for no password.</param>
        /// <param name = "passwordDataLength">The length in bytes of passwordData</param>
        /// <param name = "socket">A bound socket returned by another instance of RakPeerInterface</param>
        /// <param name = "sendConnectionAttemptCount">How many datagrams to send to the other system to try to connect.</param>
        /// <param name = "timeBetweenSendConnectionAttemptsMS">Time to elapse before a datagram is sent to the other system to try to connect. After sendConnectionAttemptCount number of attempts, ID_CONNECTION_ATTEMPT_FAILED is returned. Under low bandwidth conditions with multiple simultaneous outgoing connections, this value should be raised to 1000 or higher, or else the MTU detection can overrun the available bandwidth.</param>
        /// <param name = "timeoutTime">How long to keep the connection alive before dropping it on unable to send a reliable message. 0 to use the default from SetTimeoutTime(UNASSIGNED_SYSTEM_ADDRESS);</param>
        /// <returns>CONNECTION_ATTEMPT_STARTED on successful initiation. Otherwise, an appropriate enumeration indicating failure.</returns>
        /// CONNECTION_ATTEMPT_STARTED does not mean you are already connected!
        public static unsafe ConnectionAttemptResult ConnectWithSocket(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> passwordData,
            ref RakNetSocket2 socket,
            PublicKey* publicKey,
            uint sendConnectionAttemptCount = (uint)12,
            uint timeBetweenSendConnectionAttemptsMS = (uint)500,
            uint timeoutTime = (uint)0
        )
        {
            return instance.ConnectWithSocketShim(
                host,
                remotePort,
                passwordData,
                passwordData.Length,
                ref socket,
                publicKey,
                sendConnectionAttemptCount,
                timeBetweenSendConnectionAttemptsMS,
                timeoutTime
            );
        }

        [LibraryImport("RakNetDLL", EntryPoint = "ConnectWithSocket")]
        private static unsafe partial ConnectionAttemptResult ConnectWithSocketShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> passwordData,
            int passwordDataLength,
            ref RakNetSocket2 socket,
            PublicKey* publicKey,
            uint sendConnectionAttemptCount = (uint)12,
            uint timeBetweenSendConnectionAttemptsMS = (uint)500,
            uint timeoutTime = (uint)0
        );

        /// <summary>Stops the network threads and closes all connections.</summary>
        /// <param name = "blockDuration">How long, in milliseconds, you should wait for all remaining messages to go out, including ID_DISCONNECTION_NOTIFICATION.  If 0, it doesn't wait at all.</param>
        /// <param name = "orderingChannel">If blockDuration > 0, ID_DISCONNECTION_NOTIFICATION will be sent on this channel</param>
        /// <param name = "disconnectionNotificationPriority">Priority to send ID_DISCONNECTION_NOTIFICATION on.If you set it to 0 then the disconnection notification won't be sent</param>
        [LibraryImport("RakNetDLL", EntryPoint = "Shutdown")]
        public static partial void Shutdown(
            this RakPeerInstance instance,
            uint blockDuration,
            byte orderingChannel = (byte)0,
            PacketPriority disconnectionNotificationPriority = (PacketPriority)3
        );

        /// <summary>Returns if the network thread is running</summary>
        /// <returns>true if the network thread is running, false otherwise</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "IsActive")]
        public static partial Bool8 IsActive(this RakPeerInstance instance);

        /// <summary>Fills the array remoteSystems with the SystemAddress of all the systems we are connected to</summary>
        /// <param name = "remoteSystems">An array of SystemAddress structures to be filled with the SystemAddresss of the systems we are connected to. Pass 0 to remoteSystems to only get the number of systems we are connected to</param>
        /// <param name = "numberOfSystems">As input, the size of remoteSystems array.  As output, the number of elements put into the array </param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetConnectionList")]
        public static unsafe partial Bool8 GetConnectionList(
            this RakPeerInstance instance,
            SystemAddress* remoteSystems,
            ref ushort numberOfSystems
        );

        /// <summary>Returns the next uint32_t that Send() will return</summary>
        /// If using RakPeer from multiple threads, this may not be accurate for your thread. Use IncrementNextSendReceipt() in that case.
        /// <returns>The next uint32_t that Send() or SendList will return</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetNextSendReceipt")]
        public static partial uint GetNextSendReceipt(this RakPeerInstance instance);

        /// <summary>Returns the next uint32_t that Send() will return, and increments the value by one</summary>
        /// If using RakPeer from multiple threads, pass this to forceReceipt in the send function
        /// <returns>The next uint32_t that Send() or SendList will return</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "IncrementNextSendReceipt")]
        public static partial uint IncrementNextSendReceipt(this RakPeerInstance instance);

        /// <summary>Sends a block of data to the specified system that you are connected to.This function only works while connectedThe first byte should be a message identifier starting at ID_USER_PACKET_ENUM</summary>
        /// <param name = "data">The block of data to send</param>
        /// <param name = "length">The size in bytes of the data to send</param>
        /// <param name = "priority">What priority level to send on.  See PacketPriority.h</param>
        /// <param name = "reliability">How reliability to send this data.  See PacketPriority.h</param>
        /// <param name = "orderingChannel">When using ordered or sequenced messages, what channel to order these on. Messages are only ordered relative to other messages on the same stream</param>
        /// <param name = "systemIdentifier">Who to send this packet to, or in the case of broadcasting who not to send it to.  Pass either a SystemAddress structure or a RakNetGUID structure. Use UNASSIGNED_SYSTEM_ADDRESS or to specify none</param>
        /// <param name = "broadcast">True to send this packet to all connected systems. If true, then systemAddress specifies who not to send the packet to.</param>
        /// <param name = "forceReceipt">If 0, will automatically determine the receipt number to return. If non-zero, will return what you give it.</param>
        /// <returns>0 on bad input. Otherwise a number that identifies this message. If @a reliability is a type that returns a receipt, on a later call to Receive() you will get ID_SND_RECEIPT_ACKED or ID_SND_RECEIPT_LOSS with bytes 1-4 inclusive containing this number</returns>
        public static uint Send(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> data,
            PacketPriority priority,
            PacketReliability reliability,
            byte orderingChannel,
            AddressOrGUID systemIdentifier,
            Bool8 broadcast,
            uint forceReceiptNumber = (uint)0
        )
        {
            return instance.SendShim(
                data,
                data.Length,
                priority,
                reliability,
                orderingChannel,
                systemIdentifier,
                broadcast,
                forceReceiptNumber
            );
        }

        [LibraryImport("RakNetDLL", EntryPoint = "Send")]
        private static partial uint SendShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> data,
            int length,
            PacketPriority priority,
            PacketReliability reliability,
            byte orderingChannel,
            AddressOrGUID systemIdentifier,
            Bool8 broadcast,
            uint forceReceiptNumber = (uint)0
        );

        /// <summary>"Send" to yourself rather than a remote system. The message will be processed through the plugins and returned to the game as usualThis function works anytimeThe first byte should be a message identifier starting at ID_USER_PACKET_ENUM</summary>
        /// <param name = "data">The block of data to send</param>
        /// <param name = "length">The size in bytes of the data to send</param>
        public static void SendLoopback(this RakPeerInstance instance, ReadOnlySpan<byte> data)
        {
            instance.SendLoopbackShim(data, data.Length);
        }

        [LibraryImport("RakNetDLL", EntryPoint = "SendLoopback")]
        private static partial void SendLoopbackShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> data,
            int length
        );

        /// <summary>Gets a message from the incoming message queue.Use DeallocatePacket() to deallocate the message after you are done with it.User-thread functions, such as RPC calls and the plugin function PluginInterface::Update occur here.</summary>
        /// <returns>0 if no packets are waiting to be handled, otherwise a pointer to a packet.</returns>
        /// COMMON MISTAKE: Be sure to call this in a loop, once per game tick, until it returns 0. If you only process one packet per game tick they will buffer up.sa RakNetTypes.h contains struct Packet
        [LibraryImport("RakNetDLL", EntryPoint = "Receive")]
        public static unsafe partial Packet* Receive(this RakPeerInstance instance);

        /// <summary>Call this to deallocate a message returned by Receive() when you are done handling it.</summary>
        /// <param name = "packet">The message to deallocate.	</param>
        [LibraryImport("RakNetDLL", EntryPoint = "DeallocatePacket")]
        public static unsafe partial void DeallocatePacket(this RakPeerInstance instance, Packet* packet);

        /// <summary>Return the total number of connections we are allowed</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "GetMaximumNumberOfPeers")]
        public static partial uint GetMaximumNumberOfPeers(this RakPeerInstance instance);

        /// <summary>-------------------------------------------------------------------------------------------- Connection Management Functions--------------------------------------------------------------------------------------------Close the connection to another host (if we initiated the connection it will disconnect, if they did it will kick them out).</summary>
        /// <param name = "target">Which system to close the connection to.</param>
        /// <param name = "sendDisconnectionNotification">True to send ID_DISCONNECTION_NOTIFICATION to the recipient.  False to close it silently.</param>
        /// <param name = "channel">Which ordering channel to send the disconnection notification on, if any</param>
        /// <param name = "disconnectionNotificationPriority">Priority to send ID_DISCONNECTION_NOTIFICATION on.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "CloseConnection")]
        public static partial void CloseConnection(
            this RakPeerInstance instance,
            AddressOrGUID target,
            Bool8 sendDisconnectionNotification,
            byte orderingChannel = (byte)0,
            PacketPriority disconnectionNotificationPriority = (PacketPriority)3
        );

        /// <summary>Returns if a system is connected, disconnected, connecting in progress, or various other states</summary>
        /// <param name = "systemIdentifier">The system we are referring to</param>
        /// This locks a mutex, do not call too frequently during connection attempts or the attempt will take longer and possibly even timeout
        /// <returns>What state the remote system is in</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetConnectionState")]
        public static partial ConnectionState GetConnectionState(
            this RakPeerInstance instance,
            AddressOrGUID systemIdentifier
        );

        /// <summary>Cancel a pending connection attemptIf we are already connected, the connection stays open</summary>
        /// <param name = "target">Which system to cancel</param>
        [LibraryImport("RakNetDLL", EntryPoint = "CancelConnectionAttempt")]
        public static partial void CancelConnectionAttempt(this RakPeerInstance instance, SystemAddress target);

        /// <summary>Given a systemAddress, returns an index from 0 to the maximum number of players allowed - 1.</summary>
        /// <param name = "systemAddress">The SystemAddress we are referring to</param>
        /// <returns>The index of this SystemAddress or -1 on system not found.</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetIndexFromSystemAddress")]
        public static partial int GetIndexFromSystemAddress(this RakPeerInstance instance, SystemAddress systemAddress);

        /// <summary>This function is only useful for looping through all systemsGiven an index, will return a SystemAddress.</summary>
        /// <param name = "index">Index should range between 0 and the maximum number of players allowed - 1.</param>
        /// <returns>The SystemAddress</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetSystemAddressFromIndex")]
        public static partial SystemAddress GetSystemAddressFromIndex(this RakPeerInstance instance, uint index);

        /// <summary>Same as GetSystemAddressFromIndex but returns RakNetGUID</summary>
        /// <param name = "index">Index should range between 0 and the maximum number of players allowed - 1.</param>
        /// <returns>The RakNetGUID</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetGUIDFromIndex")]
        public static partial RakNetGUID GetGUIDFromIndex(this RakPeerInstance instance, uint index);

        /// <summary>Bans an IP from connecting.  Banned IPs persist between connections but are not saved on shutdown nor loaded on startup.param[in] IP Dotted IP address. Can use * as a wildcard, such as 128.0.0.* will ban all IP addresses starting with 128.0.0</summary>
        /// <param name = "milliseconds">how many ms for a temporary ban.  Use 0 for a permanent ban</param>
        [LibraryImport("RakNetDLL", EntryPoint = "AddToBanList")]
        public static partial void AddToBanList(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> IP,
            uint milliseconds = (uint)0
        );

        /// <summary>Allows a previously banned IP to connect. param[in] Dotted IP address. Can use * as a wildcard, such as 128.0.0.* will banAll IP addresses starting with 128.0.0</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "RemoveFromBanList")]
        public static partial void RemoveFromBanList(this RakPeerInstance instance, ReadOnlySpan<byte> IP);

        /// <summary>Allows all previously banned IPs to connect.</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "ClearBanList")]
        public static partial void ClearBanList(this RakPeerInstance instance);

        /// <summary>Returns true or false indicating if a particular IP is banned.</summary>
        /// <param name = "IP">- Dotted IP address.</param>
        /// <returns>true if IP matches any IPs in the ban list, accounting for any wildcards. False otherwise.</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "IsBanned")]
        public static partial Bool8 IsBanned(this RakPeerInstance instance, ReadOnlySpan<byte> IP);

        /// <summary>Enable or disable allowing frequent connections from the same IP adderssThis is a security measure which is disabled by default, but can be set to true to prevent attackers from using up all connection slots</summary>
        /// <param name = "b">True to limit connections from the same ip to at most 1 per 100 milliseconds.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetLimitIPConnectionFrequency")]
        public static partial void SetLimitIPConnectionFrequency(this RakPeerInstance instance, Bool8 b);

        /// <summary>--------------------------------------------------------------------------------------------Pinging Functions - Functions dealing with the automatic ping mechanism--------------------------------------------------------------------------------------------Send a ping to the specified connected system.</summary>
        /// <remarks>The sender and recipient must already be started via a successful call to Startup()</remarks>
        /// <param name = "target">Which system to ping</param>
        [LibraryImport("RakNetDLL", EntryPoint = "Ping")]
        public static partial void Ping(this RakPeerInstance instance, SystemAddress target);

        /// <summary>Send a ping to the specified unconnected system. The remote system, if it is Initialized, will respond with ID_PONG followed by sizeof(RakNet::TimeMS) containing the system time the ping was sent.(Default is 4 bytes - See __GET_TIME_64BIT in RakNetTypes.hSystem should reply with ID_PONG if it is active</summary>
        /// <param name = "host">Either a dotted IP address or a domain name.  Can be 255.255.255.255 for LAN broadcast.</param>
        /// <param name = "remotePort">Which port to connect to on the remote machine.</param>
        /// <param name = "onlyReplyOnAcceptingConnections">Only request a reply if the remote system is accepting connections</param>
        /// <param name = "connectionSocketIndex">Index into the array of socket descriptors passed to socketDescriptors in RakPeer::Startup() to send on.</param>
        /// <returns>true on success, false on failure (unknown hostname)</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "Ping1")]
        public static partial Bool8 Ping(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            Bool8 onlyReplyOnAcceptingConnections,
            uint connectionSocketIndex = (uint)0
        );

        /// <summary>Returns the average of all ping times read for the specific system or -1 if none read yet</summary>
        /// <param name = "systemAddress">Which system we are referring to</param>
        /// <returns>The ping time for this system, or -1</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetAveragePing")]
        public static partial int GetAveragePing(this RakPeerInstance instance, AddressOrGUID systemIdentifier);

        /// <summary>Returns the last ping time read for the specific system or -1 if none read yet</summary>
        /// <param name = "systemAddress">Which system we are referring to</param>
        /// <returns>The last ping time for this system, or -1</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetLastPing")]
        public static partial int GetLastPing(this RakPeerInstance instance, AddressOrGUID systemIdentifier);

        /// <summary>Returns the lowest ping time read or -1 if none read yet</summary>
        /// <param name = "systemAddress">Which system we are referring to</param>
        /// <returns>The lowest ping time for this system, or -1</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetLowestPing")]
        public static partial int GetLowestPing(this RakPeerInstance instance, AddressOrGUID systemIdentifier);

        /// <summary>Ping the remote systems every so often, or not. Can be called anytime.By default this is true. Recommended to leave on, because congestion control uses it to determine how often to resend lost packets.It would be true by default to prevent timestamp drift, since in the event of a clock spike, the timestamp deltas would no longer be accurate</summary>
        /// <param name = "doPing">True to start occasional pings.  False to stop them.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetOccasionalPing")]
        public static partial void SetOccasionalPing(this RakPeerInstance instance, Bool8 doPing);

        /// <summary>Return the clock difference between your system and the specified systemSubtract GetClockDifferential() from a time returned by the remote system to get that time relative to your own systemReturns 0 if the system is unknown</summary>
        /// <param name = "systemIdentifier">Which system we are referring to</param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetClockDifferential")]
        public static partial ulong GetClockDifferential(this RakPeerInstance instance, AddressOrGUID systemIdentifier);

        /// <summary>--------------------------------------------------------------------------------------------Static Data Functions - Functions dealing with API defined synchronized memory--------------------------------------------------------------------------------------------Sets the data to send along with a LAN server discovery or offline ping reply.@a length should be under 400 bytes, as a security measure against flood attacks</summary>
        /// <param name = "data">a block of data to store, or 0 for none</param>
        /// <param name = "length">The length of data in bytes, or 0 for none</param>
        /// Ping.cpp
        public static void SetOfflinePingResponse(this RakPeerInstance instance, ReadOnlySpan<byte> data)
        {
            instance.SetOfflinePingResponseShim(data, (uint)data.Length);
        }

        [LibraryImport("RakNetDLL", EntryPoint = "SetOfflinePingResponse")]
        private static partial void SetOfflinePingResponseShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> data,
            uint length
        );

        /// <summary>Returns pointers to a copy of the data passed to SetOfflinePingResponse</summary>
        /// <param name = "data">A pointer to a copy of the data passed to @a SetOfflinePingResponse() </param>
        /// <param name = "length">A pointer filled in with the length parameter passed to SetOfflinePingResponse()</param>
        /// SetOfflinePingResponse
        [LibraryImport("RakNetDLL", EntryPoint = "GetOfflinePingResponse")]
        public static unsafe partial void GetOfflinePingResponse(
            this RakPeerInstance instance,
            byte** data,
            ref uint length
        );

        /// <summary>--------------------------------------------------------------------------------------------Network Functions - Functions dealing with the network in general--------------------------------------------------------------------------------------------Return the unique address identifier that represents you or another system on the the network and is based on your local IP / port.</summary>
        /// Not supported by the XBOX
        /// <param name = "systemAddress">Use UNASSIGNED_SYSTEM_ADDRESS to get your behind-LAN address. Use a connected system to get their behind-LAN address</param>
        /// <param name = "index">When you have multiple internal IDs, which index to return? Currently limited to MAXIMUM_NUMBER_OF_INTERNAL_IDS (so the maximum value of this variable is MAXIMUM_NUMBER_OF_INTERNAL_IDS-1)</param>
        /// <returns>the identifier of your system internally, which may not be how other systems see if you if you are behind a NAT or proxy</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetInternalID")]
        public static partial SystemAddress GetInternalID(
            this RakPeerInstance instance,
            SystemAddress systemAddress,
            int index = (int)0
        );

        /// <summary>Sets your internal IP address, for platforms that do not support reading it, or to override a value</summary>
        /// <param name = "systemAddress.">The address to set. Use SystemAddress::FromString() if you want to use a dotted string</param>
        /// <param name = "index">When you have multiple internal IDs, which index to set?</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetInternalID")]
        public static partial void SetInternalID(
            this RakPeerInstance instance,
            SystemAddress systemAddress,
            int index = (int)0
        );

        /// <summary>Return the unique address identifier that represents you on the the network and is based on your externalIP / port(the IP / port the specified player uses to communicate with you)</summary>
        /// <param name = "target">Which remote system you are referring to for your external ID.  Usually the same for all systems, unless you have two or more network cards.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetExternalID")]
        public static partial SystemAddress GetExternalID(this RakPeerInstance instance, SystemAddress target);

        /// <summary>Return my own GUID</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "GetMyGUID")]
        public static partial RakNetGUID GetMyGUID(this RakPeerInstance instance);

        /// <summary>Return the address bound to a socket at the specified index</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "GetMyBoundAddress")]
        public static partial SystemAddress GetMyBoundAddress(this RakPeerInstance instance, int socketIndex = (int)0);

        /// <summary>Get a random number (to generate a GUID)</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "Get64BitUniqueRandomNumber")]
        public static partial ulong Get64BitUniqueRandomNumber();

        /// <summary>Given a connected system, give us the unique GUID representing that instance of RakPeer.This will be the same on all systems connected to that instance of RakPeer, even if the external system addresses are differentCurrently O(log(n)), but this may be improved in the future. If you use this frequently, you may want to cache the value as it won't change.Returns UNASSIGNED_RAKNET_GUID if system address can't be found.If @a input is UNASSIGNED_SYSTEM_ADDRESS, will return your own GUID</summary>
        /// <remarks>Call Startup() first, or the function will return UNASSIGNED_RAKNET_GUID</remarks>
        /// <param name = "input">The system address of the system we are connected to</param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetGuidFromSystemAddress")]
        public static partial RakNetGUID GetGuidFromSystemAddress(this RakPeerInstance instance, SystemAddress input);

        /// <summary>Given the GUID of a connected system, give us the system address of that system.The GUID will be the same on all systems connected to that instance of RakPeer, even if the external system addresses are differentCurrently O(log(n)), but this may be improved in the future. If you use this frequently, you may want to cache the value as it won't change.If @a input is UNASSIGNED_RAKNET_GUID, will return UNASSIGNED_SYSTEM_ADDRESS</summary>
        /// <param name = "input">The RakNetGUID of the system we are checking to see if we are connected to</param>
        [LibraryImport("RakNetDLL", EntryPoint = "GetSystemAddressFromGuid")]
        public static partial SystemAddress GetSystemAddressFromGuid(this RakPeerInstance instance, RakNetGUID input);

        /// <summary>Set the time, in MS, to use before considering ourselves disconnected after not being able to deliver a reliable message.Default time is 10,000 or 10 seconds in release and 30,000 or 30 seconds in debug.Do not set different values for different computers that are connected to each other, or you won't be able to reconnect after ID_CONNECTION_LOST</summary>
        /// <param name = "timeMS">Time, in MS</param>
        /// <param name = "target">Which system to do this for. Pass UNASSIGNED_SYSTEM_ADDRESS for all systems.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetTimeoutTime")]
        public static partial void SetTimeoutTime(this RakPeerInstance instance, uint timeMS, SystemAddress target);

        /// <summary><param name = "target">Which system to do this for. Pass UNASSIGNED_SYSTEM_ADDRESS to get the default value</param></summary>
        /// <returns>timeoutTime for a given system.</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetTimeoutTime")]
        public static partial uint GetTimeoutTime(this RakPeerInstance instance, SystemAddress target);

        /// <summary>Returns the current MTU size</summary>
        /// <param name = "target">Which system to get this for.  UNASSIGNED_SYSTEM_ADDRESS to get the default</param>
        /// <returns>The current MTU size</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetMTUSize")]
        public static partial int GetMTUSize(this RakPeerInstance instance, SystemAddress target);

        /// <summary>Returns the number of IP addresses this system has internally. Get the actual addresses from GetLocalIP()</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "GetNumberOfAddresses")]
        public static partial uint GetNumberOfAddresses(this RakPeerInstance instance);

        /// <summary>Returns an IP address at index 0 to GetNumberOfAddresses-1</summary>
        /// <param name = "index">index into the list of IP addresses</param>
        /// <returns>The local IP address at this index</returns>
        [LibraryImport(
            "RakNetDLL",
            EntryPoint = "GetLocalIP",
            StringMarshalling = StringMarshalling.Custom,
            StringMarshallingCustomType = typeof(Brutal.Interop.InteropStringMarshaller)
        )]
        public static partial string GetLocalIP(this RakPeerInstance instance, uint index);

        /// <summary>Is this a local IP?</summary>
        /// <param name = "An">IP address to check, excluding the port</param>
        /// <returns>True if this is one of the IP addresses returned by GetLocalIP</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "IsLocalIP")]
        public static partial Bool8 IsLocalIP(this RakPeerInstance instance, ReadOnlySpan<byte> ip);

        /// <summary>Allow or disallow connection responses from any IP. Normally this should be false, but may be necessarywhen connecting to servers with multiple IP addresses.</summary>
        /// <param name = "allow">- True to allow this behavior, false to not allow. Defaults to false. Value persists between connections</param>
        [LibraryImport("RakNetDLL", EntryPoint = "AllowConnectionResponseIPMigration")]
        public static partial void AllowConnectionResponseIPMigration(this RakPeerInstance instance, Bool8 allow);

        /// <summary>Sends a one byte message ID_ADVERTISE_SYSTEM to the remote unconnected system.This will tell the remote system our external IP outside the LAN along with some user data.</summary>
        /// <remarks>The sender and recipient must already be started via a successful call to Initialize</remarks>
        /// <param name = "host">Either a dotted IP address or a domain name</param>
        /// <param name = "remotePort">Which port to connect to on the remote machine.</param>
        /// <param name = "data">Optional data to append to the packet.</param>
        /// <param name = "dataLength">length of data in bytes.  Use 0 if no data.</param>
        /// <param name = "connectionSocketIndex">Index into the array of socket descriptors passed to socketDescriptors in RakPeer::Startup() to send on.</param>
        /// <returns>false if IsActive()==false or the host is unresolvable. True otherwise</returns>
        public static Bool8 AdvertiseSystem(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> data,
            uint connectionSocketIndex = (uint)0
        )
        {
            return instance.AdvertiseSystemShim(host, remotePort, data, data.Length, connectionSocketIndex);
        }

        [LibraryImport("RakNetDLL", EntryPoint = "AdvertiseSystem")]
        private static partial Bool8 AdvertiseSystemShim(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            ReadOnlySpan<byte> data,
            int dataLength,
            uint connectionSocketIndex = (uint)0
        );

        /// <summary>Controls how often to return ID_DOWNLOAD_PROGRESS for large message downloads.ID_DOWNLOAD_PROGRESS is returned to indicate a new partial message chunk, roughly the MTU size, has arrivedAs it can be slow or cumbersome to get this notification for every chunk, you can set the interval at which it is returned.Defaults to 0 (never return this notification)</summary>
        /// <param name = "interval">How many messages to use as an interval</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetSplitMessageProgressInterval")]
        public static partial void SetSplitMessageProgressInterval(this RakPeerInstance instance, int interval);

        /// <summary>Returns what was passed to SetSplitMessageProgressInterval()</summary>
        /// <returns>What was passed to SetSplitMessageProgressInterval(). Default to 0.</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetSplitMessageProgressInterval")]
        public static partial int GetSplitMessageProgressInterval(this RakPeerInstance instance);

        /// <summary>Set how long to wait before giving up on sending an unreliable messageUseful if the network is clogged up.Set to 0 or less to never timeout.  Defaults to 0.</summary>
        /// <param name = "timeoutMS">How many ms to wait before simply not sending an unreliable message.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetUnreliableTimeout")]
        public static partial void SetUnreliableTimeout(this RakPeerInstance instance, uint timeoutMS);

        /// <summary>Send a message to host, with the IP socket option TTL set to 3This message will not reach the host, but will open the router.Used for NAT-Punchthrough</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "SendTTL")]
        public static partial void SendTTL(
            this RakPeerInstance instance,
            ReadOnlySpan<byte> host,
            ushort remotePort,
            int ttl,
            uint connectionSocketIndex = (uint)0
        );

        /// <summary>--------------------------------------------------------------------------------------------Miscellaneous Functions--------------------------------------------------------------------------------------------Put a message back at the end of the receive queue in case you don't want to deal with it immediately</summary>
        /// <param name = "packet">The packet you want to push back.</param>
        /// <param name = "pushAtHead">True to push the packet so that the next receive call returns it.  False to push it at the end of the queue (obviously pushing it at the end makes the packets out of order)</param>
        [LibraryImport("RakNetDLL", EntryPoint = "PushBackPacket")]
        public static unsafe partial void PushBackPacket(
            this RakPeerInstance instance,
            ref Packet packet,
            Bool8 pushAtHead
        );

        [LibraryImport("RakNetDLL", EntryPoint = "ChangeSystemAddress")]
        public static unsafe partial void ChangeSystemAddress(
            this RakPeerInstance instance,
            RakNetGUID guid,
            SystemAddress systemAddress
        );

        /// <summary>Get the socket used with a particular active connectionThe smart pointer reference counts the RakNetSocket2 object, so the socket will remain active as long as the smart pointer does, even if RakNet were to shutdown or close the connection.</summary>
        /// This sends a query to the thread and blocks on the return value for up to one second. In practice it should only take a millisecond or so.
        /// <param name = "target">Which system</param>
        /// <returns>A smart pointer object containing the socket information about the socket. Be sure to check IsNull() which is returned if the update thread is unresponsive, shutting down, or if this system is not connected</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetSocket")]
        public static unsafe partial RakNetSocket2* GetSocket(this RakPeerInstance instance, SystemAddress target);

        /// <summary>--------------------------------------------------------------------------------------------Network Simulator Functions--------------------------------------------------------------------------------------------Adds simulated ping and packet loss to the outgoing data flow.To simulate bi-directional ping and packet loss, you should call this on both the sender and the recipient, with half the total ping and packetloss value on each.The network simulator is compiled in for debug builds, or for any build that defines RAKNET_ENABLE_NETWORK_SIMULATOR. Otherwise these calls are no-ops.</summary>
        /// Historically debug-only. For higher-fidelity simulation prefer an OS-level tool (clumsy on Windows, Network Link Conditioner on macOS, netem on Linux), which degrades the real socket traffic.
        /// <param name = "packetloss">Chance to lose a packet. Ranges from 0 to 1.</param>
        /// <param name = "minExtraPing">The minimum time to delay sends.</param>
        /// <param name = "extraPingVariance">The additional random time to delay sends.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "ApplyNetworkSimulator")]
        public static partial void ApplyNetworkSimulator(
            this RakPeerInstance instance,
            float packetloss,
            ushort minExtraPing,
            ushort extraPingVariance
        );

        /// <summary>Limits how much outgoing bandwidth can be sent per-connection.This limit does not apply to the sum of all connections!Exceeding the limit queues up outgoing traffic</summary>
        /// <param name = "maxBitsPerSecond">Maximum bits per second to send.  Use 0 for unlimited (default). Once set, it takes effect immedately and persists until called again.</param>
        [LibraryImport("RakNetDLL", EntryPoint = "SetPerConnectionOutgoingBandwidthLimit")]
        public static partial void SetPerConnectionOutgoingBandwidthLimit(
            this RakPeerInstance instance,
            uint maxBitsPerSecond
        );

        /// <summary>Returns if you previously called ApplyNetworkSimulator</summary>
        /// <returns>If you previously called ApplyNetworkSimulator</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "IsNetworkSimulatorActive")]
        public static partial Bool8 IsNetworkSimulatorActive(this RakPeerInstance instance);

        /// <summary>Returns a structure containing a large set of network statistics for the specified system.You can map this data to a string using the C style StatisticsToString() function</summary>
        /// <param name = "systemAddress:">Which connected system to get statistics for</param>
        /// <param name = "rns">If you supply this structure, it will be written to it.  Otherwise it will use a static struct, which is not threadsafe</param>
        /// <returns>0 on can't find the specified system.  A pointer to a set of data otherwise.</returns>
        /// RakNetStatistics.h
        [LibraryImport("RakNetDLL", EntryPoint = "GetStatistics")]
        public static unsafe partial RakNetStatistics* GetStatistics(
            this RakPeerInstance instance,
            SystemAddress systemAddress,
            RakNetStatistics* rns
        );

        /// <summary>Returns the network statistics of the system at the given index in the remoteSystemList.</summary>
        /// <returns>True if the index is less than the maximum number of peers allowed and the system is active. False otherwise.</returns>
        [LibraryImport("RakNetDLL", EntryPoint = "GetStatistics1")]
        public static unsafe partial Bool8 GetStatistics(
            this RakPeerInstance instance,
            uint index,
            ref RakNetStatistics rns
        );

        /// <summary>how many messages are waiting when you call Receive()</summary>
        [LibraryImport("RakNetDLL", EntryPoint = "GetReceiveBufferSize")]
        public static partial uint GetReceiveBufferSize(this RakPeerInstance instance);

        [LibraryImport("RakNetDLL", EntryPoint = "DestroyInstance")]
        public static unsafe partial void DestroyInstance(RakPeerInstance instance);
    }
}
