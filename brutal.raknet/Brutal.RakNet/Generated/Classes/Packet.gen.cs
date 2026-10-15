using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct Packet
    {
        /// <summary>The system that send this packet.</summary>
        public SystemAddress SystemAddress;

        /// <summary>A unique identifier for the system that sent this packet, regardless of IP address (internal / external / remote system)Only valid once a connection has been established (ID_CONNECTION_REQUEST_ACCEPTED, or ID_NEW_INCOMING_CONNECTION)Until that time, will be UNASSIGNED_RAKNET_GUID</summary>
        public RakNetGUID Guid;

        /// <summary>The length of the data in bytes</summary>
        public uint Length;

        /// <summary>The length of the data in bits</summary>
        public uint BitSize;

        /// <summary>The data from the sender</summary>
        public byte* Data;
        public Bool8 DeleteData;
        public Bool8 WasGeneratedLocally;
    }
}
