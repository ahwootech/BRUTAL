namespace Brutal.RakNetApi
{
    public enum DefaultMessageIDTypes
    {
        /// <summary>RESERVED TYPES - DO NOT CHANGE THESEAll types from RakPeer</summary>
        /// These types are never returned to the user.Ping from a connected system.  Update timestamps (internal use only)
        ConnectedPing,

        /// <summary>Ping from an unconnected system.  Reply but do not update timestamps. (internal use only)</summary>
        UnconnectedPing,

        /// <summary>Ping from an unconnected system.  Only reply if we have open connections. Do not update timestamps. (internal use only)</summary>
        UnconnectedPingOpenConnections,

        /// <summary>Pong from a connected system.  Update timestamps (internal use only)</summary>
        ConnectedPong,

        /// <summary>A reliable packet to detect lost connections (internal use only)</summary>
        DetectLostConnections,

        /// <summary>C2S: Initial query: Header(1), OfflineMesageID(16), Protocol number(1), Pad(toMTU), sent with no fragment set.If protocol fails on server, returns ID_INCOMPATIBLE_PROTOCOL_VERSION to client</summary>
        OpenConnectionRequest1,

        /// <summary>S2C: Header(1), OfflineMesageID(16), server GUID(8), HasSecurity(1), Cookie(4, if HasSecurity), public key (if do security is true), MTU(2). If public key fails on client, returns ID_PUBLIC_KEY_MISMATCH</summary>
        OpenConnectionReply1,

        /// <summary>C2S: Header(1), OfflineMesageID(16), Cookie(4, if HasSecurity is true on the server), clientSupportsSecurity(1 bit),handshakeChallenge (if has security on both server and client), remoteBindingAddress(6), MTU(2), client GUID(8)Connection slot allocated if cookie is valid, server is not full, GUID and IP not already in use.</summary>
        OpenConnectionRequest2,

        /// <summary>S2C: Header(1), OfflineMesageID(16), server GUID(8), mtu(2), doSecurity(1 bit), handshakeAnswer (if do security is true)</summary>
        OpenConnectionReply2,

        /// <summary>C2S: Header(1), GUID(8), Timestamp, HasSecurity(1), Proof(32)</summary>
        ConnectionRequest,

        /// <summary>RakPeer - Remote system requires secure connections, pass a public key to RakPeerInterface::Connect()</summary>
        RemoteSystemRequiresPublicKey,

        /// <summary>RakPeer - We passed a public key to RakPeerInterface::Connect(), but the other system did not have security turned on</summary>
        OurSystemRequiresSecurity,

        /// <summary>RakPeer - Wrong public key passed to RakPeerInterface::Connect()</summary>
        PublicKeyMismatch,

        /// <summary>RakPeer - Same as ID_ADVERTISE_SYSTEM, but intended for internal use rather than being passed to the user.Second byte indicates type. Used currently for NAT punchthrough for receiver port advertisement. See ID_NAT_ADVERTISE_RECIPIENT_PORT</summary>
        OutOfBandInternal,

        /// <summary>If RakPeerInterface::Send() is called where PacketReliability contains _WITH_ACK_RECEIPT, then on a later call toRakPeerInterface::Receive() you will get ID_SND_RECEIPT_ACKED or ID_SND_RECEIPT_LOSS. The message will be 5 bytes long,and bytes 1-4 inclusive will contain a number in native order containing a number that identifies this message.This number will be returned by RakPeerInterface::Send() or RakPeerInterface::SendList(). ID_SND_RECEIPT_ACKED means thatthe message arrived</summary>
        SndReceiptAcked,

        /// <summary>If RakPeerInterface::Send() is called where PacketReliability contains UNRELIABLE_WITH_ACK_RECEIPT, then on a later call toRakPeerInterface::Receive() you will get ID_SND_RECEIPT_ACKED or ID_SND_RECEIPT_LOSS. The message will be 5 bytes long,and bytes 1-4 inclusive will contain a number in native order containing a number that identifies this message. This numberwill be returned by RakPeerInterface::Send() or RakPeerInterface::SendList(). ID_SND_RECEIPT_LOSS means that an ack for themessage did not arrive (it may or may not have been delivered, probably not). On disconnect or shutdown, you will not getID_SND_RECEIPT_LOSS for unsent messages, you should consider those messages as all lost.</summary>
        SndReceiptLoss,

        /// <summary>RakPeer - In a client/server environment, our connection request to the server has been accepted.</summary>
        ConnectionRequestAccepted,

        /// <summary>RakPeer - Sent to the player when a connection request cannot be completed due to inability to connect.</summary>
        ConnectionAttemptFailed,

        /// <summary>RakPeer - Sent a connect request to a system we are currently connected to.</summary>
        AlreadyConnected,

        /// <summary>RakPeer - A remote system has successfully connected.</summary>
        NewIncomingConnection,

        /// <summary>RakPeer - The system we attempted to connect to is not accepting new connections.</summary>
        NoFreeIncomingConnections,

        /// <summary>RakPeer - The system specified in Packet::systemAddress has disconnected from us.  For the client, this would mean theserver has shutdown.</summary>
        DisconnectionNotification,

        /// <summary>RakPeer - Reliable packets cannot be delivered to the system specified in Packet::systemAddress.  The connection to thatsystem has been closed.</summary>
        ConnectionLost,

        /// <summary>RakPeer - We are banned from the system we attempted to connect to.</summary>
        ConnectionBanned,

        /// <summary>RakPeer - The remote system is using a password and has refused our connection because we did not set the correct password.</summary>
        InvalidPassword,

        /// <summary>RAKNET_PROTOCOL_VERSION in RakNetVersion.h does not match on the remote system what we have on our systemThis means the two systems cannot communicate.The 2nd byte of the message contains the value of RAKNET_PROTOCOL_VERSION for the remote system</summary>
        IncompatibleProtocolVersion,

        /// <summary>Means that this IP address connected recently, and can't connect again as a security measure. SeeRakPeer::SetLimitIPConnectionFrequency()</summary>
        IpRecentlyConnected,

        /// <summary>RakPeer - The sizeof(RakNetTime) bytes following this byte represent a value which is automatically modified by the differencein system times between the sender and the recipient. Requires that you call SetOccasionalPing.</summary>
        Timestamp,

        /// <summary>RakPeer - Pong from an unconnected system.  First byte is ID_UNCONNECTED_PONG, second sizeof(RakNet::TimeMS) bytes is the ping,following bytes is system specific enumeration data.Read using bitstreams</summary>
        UnconnectedPong,

        /// <summary>RakPeer - Inform a remote system of our IP/Port. On the recipient, all data past ID_ADVERTISE_SYSTEM is whatever was passed tothe data parameter</summary>
        AdvertiseSystem,

        /// <summary>RakPeer - Downloading a large message. Format is ID_DOWNLOAD_PROGRESS (MessageID), partCount (unsigned int),partTotal (unsigned int),partLength (unsigned int), first part data (length <= MAX_MTU_SIZE). See the three parameters partCount, partTotaland partLength in OnFileProgress in FileListTransferCBInterface.h</summary>
        DownloadProgress,

        /// <summary>ConnectionGraph2 plugin - In a client/server environment, a client other than ourselves has disconnected gracefully.Packet::systemAddress is modified to reflect the systemAddress of this client.</summary>
        RemoteDisconnectionNotification,

        /// <summary>ConnectionGraph2 plugin - In a client/server environment, a client other than ourselves has been forcefully dropped.Packet::systemAddress is modified to reflect the systemAddress of this client.</summary>
        RemoteConnectionLost,

        /// <summary>ConnectionGraph2 plugin: Bytes 1-4 = count. for (count items) contains {SystemAddress, RakNetGUID, 2 byte ping}</summary>
        RemoteNewIncomingConnection,

        /// <summary>FileListTransfer plugin - Setup data</summary>
        FileListTransferHeader,

        /// <summary>FileListTransfer plugin - A file</summary>
        FileListTransferFile,

        /// <summary>Ack for reference push, to send more of the file</summary>
        FileListReferencePushAck,

        /// <summary>DirectoryDeltaTransfer plugin - Request from a remote system for a download of a directory</summary>
        DdtDownloadRequest,

        /// <summary>RakNetTransport plugin - Transport provider message, used for remote console</summary>
        TransportString,

        /// <summary>ReplicaManager plugin - Create an object</summary>
        ReplicaManagerConstruction,

        /// <summary>ReplicaManager plugin - Changed scope of an object</summary>
        ReplicaManagerScopeChange,

        /// <summary>ReplicaManager plugin - Serialized data of an object</summary>
        ReplicaManagerSerialize,

        /// <summary>ReplicaManager plugin - New connection, about to send all world objects</summary>
        ReplicaManagerDownloadStarted,

        /// <summary>ReplicaManager plugin - Finished downloading all serialized objects</summary>
        ReplicaManagerDownloadComplete,

        /// <summary>RakVoice plugin - Open a communication channel</summary>
        RakvoiceOpenChannelRequest,

        /// <summary>RakVoice plugin - Communication channel accepted</summary>
        RakvoiceOpenChannelReply,

        /// <summary>RakVoice plugin - Close a communication channel</summary>
        RakvoiceCloseChannel,

        /// <summary>RakVoice plugin - Voice data</summary>
        RakvoiceData,

        /// <summary>Autopatcher plugin - Get a list of files that have changed since a certain date</summary>
        AutopatcherGetChangelistSinceDate,

        /// <summary>Autopatcher plugin - A list of files to create</summary>
        AutopatcherCreationList,

        /// <summary>Autopatcher plugin - A list of files to delete</summary>
        AutopatcherDeletionList,

        /// <summary>Autopatcher plugin - A list of files to get patches for</summary>
        AutopatcherGetPatch,

        /// <summary>Autopatcher plugin - A list of patches for a list of files</summary>
        AutopatcherPatchList,

        /// <summary>Autopatcher plugin - Returned to the user: An error from the database repository for the autopatcher.</summary>
        AutopatcherRepositoryFatalError,

        /// <summary>Autopatcher plugin - Returned to the user: The server does not allow downloading unmodified game files.</summary>
        AutopatcherCannotDownloadOriginalUnmodifiedFiles,

        /// <summary>Autopatcher plugin - Finished getting all files from the autopatcher</summary>
        AutopatcherFinishedInternal,

        /// <summary>Autopatcher plugin - Finished getting all files from the autopatcher</summary>
        AutopatcherFinished,

        /// <summary>Autopatcher plugin - Returned to the user: You must restart the application to finish patching.</summary>
        AutopatcherRestartApplication,

        /// <summary>NATPunchthrough plugin: internal</summary>
        NatPunchthroughRequest,

        /// <summary>NATPunchthrough plugin: internalID_NAT_GROUP_PUNCHTHROUGH_REQUEST,NATPunchthrough plugin: internalID_NAT_GROUP_PUNCHTHROUGH_REPLY,NATPunchthrough plugin: internal</summary>
        NatConnectAtTime,

        /// <summary>NATPunchthrough plugin: internal</summary>
        NatGetMostRecentPort,

        /// <summary>NATPunchthrough plugin: internal</summary>
        NatClientReady,

        /// <summary>NATPunchthrough plugin: Destination system is not connected to the server. Bytes starting at offset 1 contains theRakNetGUID destination field of NatPunchthroughClient::OpenNAT().</summary>
        NatTargetNotConnected,

        /// <summary>NATPunchthrough plugin: Destination system is not responding to ID_NAT_GET_MOST_RECENT_PORT. Possibly the plugin is not installed.Bytes starting at offset 1 contains the RakNetGUID  destination field of NatPunchthroughClient::OpenNAT().</summary>
        NatTargetUnresponsive,

        /// <summary>NATPunchthrough plugin: The server lost the connection to the destination system while setting up punchthrough.Possibly the plugin is not installed. Bytes starting at offset 1 contains the RakNetGUID  destinationfield of NatPunchthroughClient::OpenNAT().</summary>
        NatConnectionToTargetLost,

        /// <summary>NATPunchthrough plugin: This punchthrough is already in progress. Possibly the plugin is not installed.Bytes starting at offset 1 contains the RakNetGUID destination field of NatPunchthroughClient::OpenNAT().</summary>
        NatAlreadyInProgress,

        /// <summary>NATPunchthrough plugin: This message is generated on the local system, and does not come from the network.packet::guid contains the destination field of NatPunchthroughClient::OpenNAT(). Byte 1 contains 1 if you are the sender, 0 if not</summary>
        NatPunchthroughFailed,

        /// <summary>NATPunchthrough plugin: Punchthrough succeeded. See packet::systemAddress and packet::guid. Byte 1 contains 1 if you are the sender,0 if not. You can now use RakPeer::Connect() or other calls to communicate with this system.</summary>
        NatPunchthroughSucceeded,

        /// <summary>ReadyEvent plugin - Set the ready state for a particular systemFirst 4 bytes after the message contains the id</summary>
        ReadyEventSet,

        /// <summary>ReadyEvent plugin - Unset the ready state for a particular systemFirst 4 bytes after the message contains the id</summary>
        ReadyEventUnset,

        /// <summary>All systems are in state ID_READY_EVENT_SETFirst 4 bytes after the message contains the id</summary>
        ReadyEventAllSet,
        ReadyEventQuery,

        /// <summary>Lobby packets. Second byte indicates type.</summary>
        LobbyGeneral,

        /// <summary>RPC3, RPC4 error</summary>
        RpcRemoteError,

        /// <summary>Plugin based replacement for RPC system</summary>
        RpcPlugin,

        /// <summary>FileListTransfer transferring large files in chunks that are read only when needed, to save memory</summary>
        FileListReferencePush,

        /// <summary>Force the ready event to all set</summary>
        ReadyEventForceAllSet,

        /// <summary>Rooms function</summary>
        RoomsExecuteFunc,

        /// <summary>Rooms function</summary>
        RoomsLogonStatus,

        /// <summary>Rooms function</summary>
        RoomsHandleChange,

        /// <summary>Lobby2 message</summary>
        Lobby2SendMessage,

        /// <summary>Lobby2 message</summary>
        Lobby2ServerError,

        /// <summary>Informs user of a new host GUID. Packet::Guid contains this new host RakNetGuid. The old host can be read out using BitStream->Read(RakNetGuid) starting on byte 1This is not returned until connected to a remote systemIf the oldHost is UNASSIGNED_RAKNET_GUID, then this is the first time the host has been determined</summary>
        Fcm2NewHost,
        Fcm2RequestFcmguid,
        Fcm2RespondConnectionCount,
        Fcm2InformFcmguid,
        Fcm2UpdateMinTotalConnectionCount,

        /// <summary>A remote system (not necessarily the host) called FullyConnectedMesh2::StartVerifiedJoin() with our system as the clientUse FullyConnectedMesh2::GetVerifiedJoinRequiredProcessingList() to read systemsFor each system, attempt NatPunchthroughClient::OpenNAT() and/or RakPeerInterface::Connect()When this has been done for all systems, the remote system will automatically be informed of the results</summary>
        /// Only the designated client gets this message
        /// You won't get this message if you are already connected to all target systems
        /// If you fail to connect to a system, this does not automatically mean you will get ID_FCM2_VERIFIED_JOIN_FAILED as that system may have been shutting down from the host too
        /// FullyConnectedMesh2::StartVerifiedJoin()
        Fcm2VerifiedJoinStart,
        Fcm2VerifiedJoinCapable,

        /// <summary>Client failed to connect to a required systems notified via FullyConnectedMesh2::StartVerifiedJoin()RakPeerInterface::CloseConnection() was automatically called for all systems connected due to ID_FCM2_VERIFIED_JOIN_START Programmer should inform the player via the UI that they cannot join this session, and to choose a different session</summary>
        /// Server normally sends us this message, however if connection to the server was lost, message will be returned locally
        /// Only the designated client gets this message
        Fcm2VerifiedJoinFailed,

        /// <summary>The system that called StartVerifiedJoin() got ID_FCM2_VERIFIED_JOIN_CAPABLE from the client and then called RespondOnVerifiedJoinCapable() with trueAddParticipant() has automatically been called for this systemUse GetVerifiedJoinAcceptedAdditionalData() to read any additional data passed to RespondOnVerifiedJoinCapable()</summary>
        /// All systems in the mesh get this message
        /// RespondOnVerifiedJoinCapable()
        Fcm2VerifiedJoinAccepted,

        /// <summary>The system that called StartVerifiedJoin() got ID_FCM2_VERIFIED_JOIN_CAPABLE from the client and then called RespondOnVerifiedJoinCapable() with falseCloseConnection() has been automatically called for each system connected to since ID_FCM2_VERIFIED_JOIN_START.The connection is NOT automatically closed to the original host that sent StartVerifiedJoin()Use GetVerifiedJoinRejectedAdditionalData() to read any additional data passed to RespondOnVerifiedJoinCapable()</summary>
        /// Only the designated client gets this message
        /// RespondOnVerifiedJoinCapable()
        Fcm2VerifiedJoinRejected,

        /// <summary>UDP proxy messages. Second byte indicates type.</summary>
        UdpProxyGeneral,

        /// <summary>SQLite3Plugin - execute</summary>
        Sqlite3Exec,

        /// <summary>SQLite3Plugin - Remote database is unknown</summary>
        Sqlite3UnknownDb,

        /// <summary>Events happening with SQLiteClientLoggerPlugin</summary>
        SqlliteLogger,

        /// <summary>Sent to NatTypeDetectionServer</summary>
        NatTypeDetectionRequest,

        /// <summary>Sent to NatTypeDetectionClient. Byte 1 contains the type of NAT detected.</summary>
        NatTypeDetectionResult,

        /// <summary>Used by the router2 plugin</summary>
        Router2Internal,

        /// <summary>No path is available or can be established to the remote systemPacket::guid contains the endpoint guid that we were trying to reach</summary>
        Router2ForwardingNoPath,

        /// <summary>You can now call connect, ping, or other operations to the destination system.</summary>
        /// Connect as follows:
        /// RakNet::BitStream bs(packet->data, packet->length, false);bs.IgnoreBytes(sizeof(MessageID));RakNetGUID endpointGuid;bs.Read(endpointGuid);unsigned short sourceToDestPort;bs.Read(sourceToDestPort);char ipAddressString[32];packet->systemAddress.ToString(false, ipAddressString);rakPeerInterface->Connect(ipAddressString, sourceToDestPort, 0,0);
        Router2ForwardingEstablished,

        /// <summary>The IP address for a forwarded connection has changedRead endpointGuid and port as per ID_ROUTER_2_FORWARDING_ESTABLISHED</summary>
        Router2Rerouted,
        TeamBalancerInternal,

        /// <summary>Cannot switch to the desired team because it is full. However, if someone on that team leaves, you willget ID_TEAM_BALANCER_TEAM_ASSIGNED later.For TeamBalancer: Byte 1 contains the team you requested to join. Following bytes contain NetworkID of which member</summary>
        TeamBalancerRequestedTeamFull,

        /// <summary>Cannot switch to the desired team because all teams are locked. However, if someone on that team leaves,you will get ID_TEAM_BALANCER_SET_TEAM later.For TeamBalancer: Byte 1 contains the team you requested to join.</summary>
        TeamBalancerRequestedTeamLocked,

        /// <summary>Cannot switch to the desired team because all teams are locked. However, if someone on that team leaves,you will get ID_TEAM_BALANCER_SET_TEAM later.For TeamBalancer: Byte 1 contains the team you requested to join.</summary>
        TeamBalancerTeamRequestedCancelled,

        /// <summary>Team balancer plugin informing you of your team. Byte 1 contains the team you requested to join. Following bytes contain NetworkID of which member.</summary>
        TeamBalancerTeamAssigned,

        /// <summary>Gamebryo Lightspeed integration</summary>
        LightspeedIntegration,

        /// <summary>XBOX integration</summary>
        XboxLobby,

        /// <summary>The password we used to challenge the other system passed, meaning the other system has called TwoWayAuthentication::AddPassword() with the same password we passed to TwoWayAuthentication::Challenge()You can read the identifier used to challenge as follows:RakNet::BitStream bs(packet->data, packet->length, false); bs.IgnoreBytes(sizeof(RakNet::MessageID)); RakNet::RakString password; bs.Read(password);</summary>
        TwoWayAuthenticationIncomingChallengeSuccess,

        /// <summary>The password we used to challenge the other system passed, meaning the other system has called TwoWayAuthentication::AddPassword() with the same password we passed to TwoWayAuthentication::Challenge()You can read the identifier used to challenge as follows:RakNet::BitStream bs(packet->data, packet->length, false); bs.IgnoreBytes(sizeof(RakNet::MessageID)); RakNet::RakString password; bs.Read(password);</summary>
        TwoWayAuthenticationOutgoingChallengeSuccess,

        /// <summary>A remote system sent us a challenge using TwoWayAuthentication::Challenge(), and the challenge failed.If the other system must pass the challenge to stay connected, you should call RakPeer::CloseConnection() to terminate the connection to the other system.</summary>
        TwoWayAuthenticationIncomingChallengeFailure,

        /// <summary>The other system did not add the password we used to TwoWayAuthentication::AddPassword()You can read the identifier used to challenge as follows:RakNet::BitStream bs(packet->data, packet->length, false); bs.IgnoreBytes(sizeof(MessageID)); RakNet::RakString password; bs.Read(password);</summary>
        TwoWayAuthenticationOutgoingChallengeFailure,

        /// <summary>The other system did not respond within a timeout threshhold. Either the other system is not running the plugin or the other system was blocking on some operation for a long time.You can read the identifier used to challenge as follows:RakNet::BitStream bs(packet->data, packet->length, false); bs.IgnoreBytes(sizeof(MessageID)); RakNet::RakString password; bs.Read(password);</summary>
        TwoWayAuthenticationOutgoingChallengeTimeout,
        TwoWayAuthenticationNegotiation,

        /// <summary>CloudClient / CloudServer</summary>
        CloudPostRequest,

        /// <summary>CloudClient / CloudServer</summary>
        CloudReleaseRequest,

        /// <summary>CloudClient / CloudServer</summary>
        CloudGetRequest,

        /// <summary>CloudClient / CloudServer</summary>
        CloudGetResponse,

        /// <summary>CloudClient / CloudServer</summary>
        CloudUnsubscribeRequest,

        /// <summary>CloudClient / CloudServer</summary>
        CloudServerToServerCommand,

        /// <summary>CloudClient / CloudServer</summary>
        CloudSubscriptionNotification,

        /// <summary>LibVoice</summary>
        LibVoice,

        /// <summary>LibVoice</summary>
        RelayPlugin,

        /// <summary>LibVoice</summary>
        NatRequestBoundAddresses,

        /// <summary>LibVoice</summary>
        NatRespondBoundAddresses,

        /// <summary>LibVoice</summary>
        Fcm2UpdateUserContext,

        /// <summary>LibVoice</summary>
        Reserved3,

        /// <summary>LibVoice</summary>
        Reserved4,

        /// <summary>LibVoice</summary>
        Reserved5,

        /// <summary>LibVoice</summary>
        Reserved6,

        /// <summary>LibVoice</summary>
        Reserved7,

        /// <summary>LibVoice</summary>
        Reserved8,

        /// <summary>LibVoice</summary>
        Reserved9,

        /// <summary>For the user to use.  Start your first enumeration at this value.</summary>
        UserPacketEnum,
    }
}
