using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PublicKey
    {
        /// <summary>How to interpret the public key, see above</summary>
        public PublicKeyMode PublicKeyMode;

        /// <summary>Pointer to a public key of length cat::EasyHandshake::PUBLIC_KEY_BYTES. See the Encryption sample.</summary>
        public byte* RemoteServerPublicKey;

        /// <summary>(Optional) Pointer to a public key of length cat::EasyHandshake::PUBLIC_KEY_BYTES</summary>
        public byte* MyPublicKey;

        /// <summary>(Optional) Pointer to a private key of length cat::EasyHandshake::PRIVATE_KEY_BYTES</summary>
        public byte* MyPrivateKey;
    }
}
