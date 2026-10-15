namespace Brutal.RakNetApi
{
    public enum ConnectionState
    {
        /// <summary>Connect() was called, but the process hasn't started yet</summary>
        IsPending,

        /// <summary>Processing the connection attempt</summary>
        IsConnecting,

        /// <summary>Is connected and able to communicate</summary>
        IsConnected,

        /// <summary>Was connected, but will disconnect as soon as the remaining messages are delivered</summary>
        IsDisconnecting,

        /// <summary>A connection attempt failed and will be aborted</summary>
        IsSilentlyDisconnecting,

        /// <summary>No longer connected</summary>
        IsDisconnected,

        /// <summary>Was never connected, or else was disconnected long enough ago that the entry has been discarded</summary>
        IsNotConnected,
    }
}
