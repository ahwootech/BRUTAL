using System.Net;
using CommunityToolkit.HighPerformance;

namespace Brutal.RakNetApi.Utility;

/// <summary>
/// A utility struct for reading and writing unmanaged types to and from a buffer.
///</summary>
/// <warning>
///  This is a ref struct. So if you pass it to a method it will be copied so writes
///  will not be visible in the caller's instance of the stream. Either pass by ref, or have your
///  method return the stream so you can go stream = DoWriting(stream);
/// </warning>
public ref struct Stream
{
    /// <summary>
    /// Provides a high-performance structure to manage a mutable buffer using spans,
    /// allowing read and write operations for both primitive types and byte spans.
    /// Enables efficient serialization and deserialization of data directly into the buffer.
    /// </summary>
    public Stream(Span<byte> buffer)
    {
        _buffer = buffer;
    }

    #region Write

    /// <summary>
    /// Writes the provided value of unmanaged type <typeparamref name="T"/> into the stream at the current position.
    /// Advances the writing position by the size of <typeparamref name="T"/> after writing.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to write. Must be unmanaged and may allow usage in a ref struct.
    /// </typeparam>
    /// <param name="data">
    /// The value to write into the stream. Passed by reference for efficient handling of unmanaged types.
    /// </param>
    public unsafe void Write<T>(in T data)
        where T : unmanaged
    {
        EnsureRemaining(sizeof(T));
        RemainingAs<T>()[0] = data;
        _pos += sizeof(T);
    }

    /// <summary>
    /// Writes a sequence of bytes from the specified read-only span into the current stream.
    /// Ensures that the data being written does not exceed the available buffer space.
    /// </summary>
    /// <param name="data">The read-only span of bytes containing the data to be written.</param>
    public void Write(ReadOnlySpan<byte> data)
    {
        data.CopyTo(Remaining());
        _pos += data.Length;
    }

    /// <summary>
    /// Writes a message with a specified timestamp and a unique message identifier to the stream.
    /// This method adds a predefined ID for timestamp messages, followed by the timestamp (converted to network byte order)
    /// and the message ID, ensuring proper format for timestamped messages in the communication protocol.
    /// </summary>
    /// <param name="hostOrderTimestamp">The timestamp in host byte order to be included in the message.</param>
    /// <param name="messageId">The unique identifier of the message being written.</param>
    public void WriteTimestampMessageId(long hostOrderTimestamp, byte messageId)
    {
        Write((byte)DefaultMessageIDTypes.Timestamp);
        Write(IPAddress.HostToNetworkOrder(hostOrderTimestamp));
        Write(messageId);
    }

    #endregion


    #region Read

    /// <summary>
    /// Reads data of a specified unmanaged type from the current position in the buffer
    /// and writes it into the provided reference. Updates the buffer's position after reading.
    /// </summary>
    /// <param name="destination">The reference to write the read data into.</param>
    /// <typeparam name="T">The unmanaged type of the data to read.</typeparam>
    public unsafe void Read<T>(ref T destination)
        where T : unmanaged
    {
        EnsureRemaining(sizeof(T));
        destination = RemainingAs<T>()[0];
        _pos += sizeof(T);
    }

    /// <summary>
    /// Reads and returns data of a specified unmanaged type from the current position in the buffer.
    /// Updates the buffer's position after reading.
    /// </summary>
    /// <typeparam name="T">The unmanaged type of the data to read.</typeparam>
    /// <returns>The data of the specified type read from the buffer.</returns>
    public T Read<T>()
        where T : unmanaged
    {
        T t = default;
        Read(ref t);
        return t;
    }

    /// <summary>
    /// Reads a timestamp from the stream, converting it from network byte order to host byte order.
    /// </summary>
    /// <returns>
    /// The timestamp as a <see cref="long"/> value in host byte order.
    /// </returns>
    public long ReadTimestamp()
    {
        return IPAddress.NetworkToHostOrder(Read<long>());
    }

    /// <summary>
    /// Reads a single byte from the stream and interprets it as a message identifier.
    /// The method is typically used to parse and handle serialized message data.
    /// </summary>
    /// <returns>The message identifier as a byte.</returns>
    public byte ReadMessageId()
    {
        return Read<byte>();
    }

    /// <summary>
    /// Attempts to read a timestamped message from the stream. If the message contains a timestamp, it is converted from network byte order to host byte order.
    ///
    /// </summary>
    /// <param name="messageId">The message Id of the underlying message</param>
    /// <param name="hostOrderTimestamp">When this method returns, contains the timestamp in host byte order if the message was timestamped; otherwise, contains 0.</param>
    /// <returns>
    /// <see langword="true"/> if the stream contained a timestamped message; otherwise, <see langword="false"/>.
    /// </returns>
    public bool TryReadTimestampedMessageId(out byte messageId, out long hostOrderTimestamp)
    {
        messageId = ReadMessageId();
        if (messageId == (byte)DefaultMessageIDTypes.Timestamp)
        {
            hostOrderTimestamp = ReadTimestamp();
            messageId = ReadMessageId();
            return true;
        }

        hostOrderTimestamp = 0;
        return false;
    }

    #endregion

    /// <summary>
    /// Returns a span representing the remaining writable portion of the buffer managed by the stream.
    /// The returned span starts at the current position within the buffer and extends to the end of the buffer.
    /// </summary>
    /// <returns>
    /// A span of bytes representing the unwritten portion of the buffer, allowing direct access to the remaining space.
    /// </returns>
    public Span<byte> Remaining()
    {
        return _buffer[_pos..];
    }

    /// <summary>
    /// Returns a read-only span of bytes representing the segment of the buffer
    /// that has been written to. This enables access to the data written
    /// without modifying the underlying buffer.
    /// </summary>
    /// <returns>
    /// A ReadOnlySpan representing the written portion of the buffer.
    /// </returns>
    public ReadOnlySpan<byte> Written()
    {
        return _buffer[.._pos];
    }

    private Span<T> RemainingAs<T>()
        where T : unmanaged
    {
        return Remaining().Cast<byte, T>();
    }

    private void EnsureRemaining(int requiredBytes)
    {
        var remaining = _buffer.Length - _pos;
        if (remaining < requiredBytes)
            throw new ArgumentException($"Buffer has {remaining} byte(s) remaining but {requiredBytes} are required.");
    }

    private int _pos;
    private readonly Span<byte> _buffer;
}
