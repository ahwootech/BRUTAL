#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KtxErrorCode : int
    {
        /// <summary>Operation was successful.</summary>
        Success = 0,

        /// <summary>The data in the file is inconsistent with the spec.</summary>
        FileDataError,

        /// <summary>The file is a pipe or named pipe.</summary>
        FileIspipe,

        /// <summary>The target file could not be opened.</summary>
        FileOpenFailed,

        /// <summary>The operation would exceed the max file size.</summary>
        FileOverflow,

        /// <summary>An error occurred while reading from the file.</summary>
        FileReadError,

        /// <summary>An error occurred while seeking in the file.</summary>
        FileSeekError,

        /// <summary>File does not have enough data to satisfy request.</summary>
        FileUnexpectedEof,

        /// <summary>An error occurred while writing to the file.</summary>
        FileWriteError,

        /// <summary>GL operations resulted in an error.</summary>
        GlError,

        /// <summary>The operation is not allowed in the current state.</summary>
        InvalidOperation,

        /// <summary>A parameter value was not valid.</summary>
        InvalidValue,

        /// <summary>Requested metadata key or required dynamically loaded GPU function was not found.</summary>
        NotFound,

        /// <summary>Not enough memory to complete the operation.</summary>
        OutOfMemory,

        /// <summary>Transcoding of block compressed texture failed.</summary>
        TranscodeFailed,

        /// <summary>The file not a KTX file</summary>
        UnknownFileFormat,

        /// <summary>The KTX file specifies an unsupported texture type.</summary>
        UnsupportedTextureType,

        /// <summary>Feature not included in in-use library or not yet implemented.</summary>
        UnsupportedFeature,

        /// <summary>Library dependency (OpenGL or Vulkan) not linked into application.</summary>
        LibraryNotLinked,

        /// <summary>Decompressed byte count does not match expected byte size</summary>
        DecompressLengthError,

        /// <summary>Checksum mismatch when decompressing</summary>
        DecompressChecksumError,

        /// <summary>For safety checks.</summary>
        ErrorMaxEnum = 20,
    }
}
#pragma warning restore 1591
