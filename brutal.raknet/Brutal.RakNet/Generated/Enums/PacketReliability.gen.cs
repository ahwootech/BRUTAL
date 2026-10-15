namespace Brutal.RakNetApi
{
    public enum PacketReliability
    {
        /// <summary>Same as regular UDP, except that it will also discard duplicate datagrams.  RakNet adds (6 to 17) + 21 bits of overhead, 16 of which is used to detect duplicate packets and 6 to 17 of which is used for message length.</summary>
        Unreliable,

        /// <summary>Regular UDP with a sequence counter.  Out of order messages will be discarded.Sequenced and ordered messages sent on the same channel will arrive in the order sent.</summary>
        UnreliableSequenced,

        /// <summary>The message is sent reliably, but not necessarily in any order.  Same overhead as UNRELIABLE.</summary>
        Reliable,

        /// <summary>This message is reliable and will arrive in the order you sent it.  Messages will be delayed while waiting for out of order messages.  Same overhead as UNRELIABLE_SEQUENCED.Sequenced and ordered messages sent on the same channel will arrive in the order sent.</summary>
        ReliableOrdered,

        /// <summary>This message is reliable and will arrive in the sequence you sent it.  Out or order messages will be dropped.  Same overhead as UNRELIABLE_SEQUENCED.Sequenced and ordered messages sent on the same channel will arrive in the order sent.</summary>
        ReliableSequenced,

        /// <summary>Same as UNRELIABLE, however the user will get either ID_SND_RECEIPT_ACKED or ID_SND_RECEIPT_LOSS based on the result of sending this message when calling RakPeerInterface::Receive(). Bytes 1-4 will contain the number returned from the Send() function. On disconnect or shutdown, all messages not previously acked should be considered lost.</summary>
        UnreliableWithAckReceipt,

        /// <summary>Same as RELIABLE. The user will also get ID_SND_RECEIPT_ACKED after the message is delivered when calling RakPeerInterface::Receive(). ID_SND_RECEIPT_ACKED is returned when the message arrives, not necessarily the order when it was sent. Bytes 1-4 will contain the number returned from the Send() function. On disconnect or shutdown, all messages not previously acked should be considered lost. This does not return ID_SND_RECEIPT_LOSS.</summary>
        ReliableWithAckReceipt,

        /// <summary>Same as RELIABLE_ORDERED_ACK_RECEIPT. The user will also get ID_SND_RECEIPT_ACKED after the message is delivered when calling RakPeerInterface::Receive(). ID_SND_RECEIPT_ACKED is returned when the message arrives, not necessarily the order when it was sent. Bytes 1-4 will contain the number returned from the Send() function. On disconnect or shutdown, all messages not previously acked should be considered lost. This does not return ID_SND_RECEIPT_LOSS.</summary>
        ReliableOrderedWithAckReceipt,
        NumberOfReliabilities,
    }
}
