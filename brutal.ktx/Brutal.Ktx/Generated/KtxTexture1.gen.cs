#pragma warning disable 1591
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Pointers.Extensions;

namespace Brutal.KtxApi
{
    public static unsafe partial class KtxTexture1
    {
        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_CreateFromNamedFile1")]
        public static unsafe partial KtxErrorCode CreateFromNamedFile(
            ReadOnlySpan<byte> filename,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture1Handle newTex
        );

        public static unsafe KtxErrorCode CreateFromMemory(
            ReadOnlySpan<byte> bytes,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture1Handle newTex
        )
        {
            return CreateFromMemoryRealInterop(
                ref Unsafe.AsRef<byte>(bytes.AsPointer()),
                bytes.AsPointer() is not null ? (ulong)bytes.Length : 0,
                createFlags,
                out newTex
            );
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_CreateFromMemory1")]
        private static unsafe partial KtxErrorCode CreateFromMemoryRealInterop(
            ref readonly byte bytes,
            ulong size,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture1Handle newTex
        );

        /// <summary>Create a new ktxTexture1.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_Create1")]
        public static unsafe partial KtxErrorCode Create(
            ref readonly KtxTextureCreateInfo createInfo,
            KtxTextureCreateStorageEnum storageAllocation,
            out KtxTexture1Handle newTex
        );

        /// <summary>Returns a pointer to the image data of a ktxTexture object.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetData1")]
        public static unsafe partial byte* GetData(this KtxTexture1Handle thisParam);

        /// <summary>Returns the pitch of a row of an image at the specified level.Similar to the rowPitch in a VkSubResourceLayout.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetRowPitch1")]
        public static unsafe partial uint GetRowPitch(this KtxTexture1Handle thisParam, uint level);

        /// <summary>Return the element size of the texture's images.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetElementSize1")]
        public static unsafe partial uint GetElementSize(this KtxTexture1Handle thisParam);

        /// <summary>Returns the size of all the image data of a ktxTexture object in bytes.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetDataSize1")]
        public static unsafe partial ulong GetDataSize(this KtxTexture1Handle thisParam);

        /// <summary>Iterate over the levels or faces in a ktxTexture object.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLevelFaces1")]
        public static unsafe partial KtxErrorCode IterateLevelFaces(
            this KtxTexture1Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_GetVkFormat1")]
        public static unsafe partial VkFormat GetVkFormat(this KtxTexture1Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_Destroy1")]
        public static unsafe partial void Destroy(this KtxTexture1Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetImageOffset1")]
        public static unsafe partial KtxErrorCode GetImageOffset(
            this KtxTexture1Handle thisParam,
            uint level,
            uint layer,
            uint faceSlice,
            out ulong pOffset
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetDataSizeUncompressed1")]
        public static unsafe partial ulong GetDataSizeUncompressed(this KtxTexture1Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetImageSize1")]
        public static unsafe partial ulong GetImageSize(this KtxTexture1Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetLevelSize1")]
        public static unsafe partial ulong GetLevelSize(this KtxTexture1Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLevels1")]
        public static unsafe partial KtxErrorCode IterateLevels(
            this KtxTexture1Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLoadLevelFaces1")]
        public static unsafe partial KtxErrorCode IterateLoadLevelFaces(
            this KtxTexture1Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_NeedsTranscoding1")]
        public static unsafe partial Bool8 NeedsTranscoding(this KtxTexture1Handle thisParam);

        public static unsafe KtxErrorCode LoadImageData(this KtxTexture1Handle thisParam, Span<byte> pBuffer)
        {
            return LoadImageDataRealInterop(
                thisParam,
                ref *pBuffer.AsPointer(),
                pBuffer.AsPointer() is not null ? (ulong)pBuffer.Length : 0
            );
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_LoadImageData1")]
        private static unsafe partial KtxErrorCode LoadImageDataRealInterop(
            this KtxTexture1Handle thisParam,
            ref byte pBuffer,
            ulong bufSize
        );

        public static unsafe KtxErrorCode SetImageFromMemory(
            this KtxTexture1Handle thisParam,
            uint level,
            uint layer,
            uint faceSlice,
            ReadOnlySpan<byte> src
        )
        {
            return SetImageFromMemoryRealInterop(
                thisParam,
                level,
                layer,
                faceSlice,
                ref *src.AsPointer(),
                (ulong)src.Length
            );
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_SetImageFromMemory1")]
        private static unsafe partial KtxErrorCode SetImageFromMemoryRealInterop(
            this KtxTexture1Handle thisParam,
            uint level,
            uint layer,
            uint faceSlice,
            ref readonly byte src,
            ulong srcSize
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_WriteToNamedFile1")]
        public static unsafe partial KtxErrorCode WriteToNamedFile(
            this KtxTexture1Handle thisParam,
            ReadOnlySpan<byte> dstname
        );

        public static unsafe KtxErrorCode WriteToMemory(this KtxTexture1Handle thisParam, out KtxNativeBuffer bytes)
        {
            byte* mem;
            ulong size;
            var returnValue = WriteToMemoryRealInterop(thisParam, out mem, out size);
            bytes = new KtxNativeBuffer(mem, size);
            return returnValue;
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_WriteToMemory1")]
        private static unsafe partial KtxErrorCode WriteToMemoryRealInterop(
            this KtxTexture1Handle thisParam,
            out byte* bytes,
            out ulong size
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_WriteKTX2ToNamedFile1")]
        public static unsafe partial KtxErrorCode WriteKtx2ToNamedFile(
            this KtxTexture1Handle thisParam,
            ReadOnlySpan<byte> dstname
        );

        public static unsafe KtxErrorCode WriteKtx2ToMemory(this KtxTexture1Handle thisParam, out KtxNativeBuffer bytes)
        {
            byte* mem;
            ulong size;
            var returnValue = WriteKtx2ToMemoryRealInterop(thisParam, out mem, out size);
            bytes = new KtxNativeBuffer(mem, size);
            return returnValue;
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture1_WriteKTX2ToMemory1")]
        private static unsafe partial KtxErrorCode WriteKtx2ToMemoryRealInterop(
            this KtxTexture1Handle thisParam,
            out byte* bytes,
            out ulong size
        );
    }
}
#pragma warning restore 1591
