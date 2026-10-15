using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct RakNetStatistics
    {
        /// <summary>For each type in RNSPerSecondMetrics, what is the value over the last 1 second?</summary>
        public fixed ulong ValueOverLastSecond[7];

        /// <summary>For each type in RNSPerSecondMetrics, what is the total value over the lifetime of the connection?</summary>
        public fixed ulong RunningTotal[7];

        /// <summary>When did the connection start?</summary>
        /// RakNet::GetTimeUS()
        public ulong ConnectionStartTime;

        /// <summary>Is our current send rate throttled by congestion control?This value should be true if you send more data per second than your bandwidth capacity</summary>
        public Bool8 IsLimitedByCongestionControl;

        /// <summary>If @a isLimitedByCongestionControl is true, what is the limit, in bytes per second?</summary>
        public ulong BPSLimitByCongestionControl;

        /// <summary>Is our current send rate throttled by a call to RakPeer::SetPerConnectionOutgoingBandwidthLimit()?</summary>
        public Bool8 IsLimitedByOutgoingBandwidthLimit;

        /// <summary>If @a isLimitedByOutgoingBandwidthLimit is true, what is the limit, in bytes per second?</summary>
        public ulong BPSLimitByOutgoingBandwidthLimit;

        /// <summary>For each priority level, how many messages are waiting to be sent out?</summary>
        public fixed uint MessageInSendBuffer[4];

        /// <summary>For each priority level, how many bytes are waiting to be sent out?</summary>
        public fixed double BytesInSendBuffer[4];

        /// <summary>How many messages are waiting in the resend buffer? This includes messages waiting for an ack, so should normally be a small valueIf the value is rising over time, you are exceeding the bandwidth capacity. See BPSLimitByCongestionControl</summary>
        public uint MessagesInResendBuffer;

        /// <summary>How many bytes are waiting in the resend buffer. See also messagesInResendBuffer</summary>
        public ulong BytesInResendBuffer;

        /// <summary>Over the last second, what was our packetloss? This number will range from 0.0 (for none) to 1.0 (for 100%)</summary>
        public float PacketlossLastSecond;

        /// <summary>What is the average total packetloss over the lifetime of the connection?</summary>
        public float PacketlossTotal;
    }
}
