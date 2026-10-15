#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public static unsafe partial class Strings
    {
        /// <summary>Returns a string corresponding to a KTX error code.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxErrorString1")]
        public static partial byte* KtxErrorString(KtxErrorCode error);

        /// <summary>Returns a string corresponding to a supercompression scheme.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxSupercompressionSchemeString1")]
        public static partial byte* KtxSupercompressionSchemeString(KtxSupercmpScheme scheme);

        /// <summary>Returns a string corresponding to a transcode target format.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTranscodeFormatString1")]
        public static partial byte* KtxTranscodeFormatString(KtxTranscodeFmt format);
    }
}
#pragma warning restore 1591
