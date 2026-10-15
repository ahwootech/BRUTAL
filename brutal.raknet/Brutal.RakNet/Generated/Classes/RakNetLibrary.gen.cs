using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public partial class RakNetLibrary
    {
        [LibraryImport("RakNetDLL", EntryPoint = "CreateInstance")]
        public static unsafe partial RakPeerInstance CreateInstance();
    }
}
