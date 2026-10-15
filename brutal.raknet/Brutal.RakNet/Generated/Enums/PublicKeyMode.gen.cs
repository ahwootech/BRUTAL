namespace Brutal.RakNetApi
{
    public enum PublicKeyMode
    {
        /// <summary>The connection is insecure. You can also just pass 0 for the pointer to PublicKey in RakPeerInterface::Connect()</summary>
        InsecureConnection,

        /// <summary>Accept whatever public key the server gives us. This is vulnerable to man in the middle, but does not requiredistribution of the public key in advance of connecting.</summary>
        AcceptAnyPublicKey,

        /// <summary>Use a known remote server public key. PublicKey::remoteServerPublicKey must be non-zero.This is the recommended mode for secure connections.</summary>
        UseKnownPublicKey,

        /// <summary>Use a known remote server public key AND provide a public key for the connecting client.PublicKey::remoteServerPublicKey, myPublicKey and myPrivateKey must be all be non-zero.The server must cooperate for this mode to work.I recommend not using this mode except for server-to-server communication as it significantly increases the CPU requirements during connections for both sides.Furthermore, when it is used, a connection password should be used as well to avoid DoS attacks.</summary>
        UseTwoWayAuthentication,
    }
}
