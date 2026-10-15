using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    public partial struct SockaddrIn
    {
        [FieldOffset(1)]
        private byte SinFamilyBsd;

        public ushort SinFamily
        {
            get => SockAddrUtility.Layout == SockAddrUtility.SockAddrLayout.Bsd ? SinFamilyBsd : SinFamilyNonBsd;
            set
            {
                if (SockAddrUtility.Layout == SockAddrUtility.SockAddrLayout.Bsd)
                    SinFamilyBsd = (byte)value;
                else
                    SinFamilyNonBsd = value;
            }
        }
    }

    public static partial class SockAddrUtility
    {
        static SockAddrUtility()
        {
            Layout = IsNonBsdSockAddrLayout() ? SockAddrLayout.NonBsd : SockAddrLayout.Bsd;
        }

        public enum SockAddrLayout : byte
        {
            Bsd = 0,
            NonBsd = 1,
        };

        [LibraryImport("RakNetDLL", EntryPoint = "IsNonBsdSockAddrLayout")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static partial bool IsNonBsdSockAddrLayout();

        public static SockAddrLayout Layout { get; }
    }
}
