#pragma warning disable 1591
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Pointers.Extensions;

namespace Brutal.KtxApi
{
    public static unsafe partial class KtxTexture2
    {
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CreateFromNamedFile1")]
        public static unsafe partial KtxErrorCode CreateFromNamedFile(
            ReadOnlySpan<byte> filename,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture2Handle newTex
        );

        public static unsafe KtxErrorCode CreateFromMemory(
            ReadOnlySpan<byte> bytes,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture2Handle newTex
        )
        {
            return CreateFromMemoryRealInterop(
                ref Unsafe.AsRef<byte>(bytes.AsPointer()),
                bytes.AsPointer() is not null ? (ulong)bytes.Length : 0,
                createFlags,
                out newTex
            );
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CreateFromMemory1")]
        private static unsafe partial KtxErrorCode CreateFromMemoryRealInterop(
            ref readonly byte bytes,
            ulong size,
            KtxTextureCreateFlagBits createFlags,
            out KtxTexture2Handle newTex
        );

        /// <summary>Create a new ktxTexture2.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_Create1")]
        public static unsafe partial KtxErrorCode Create(
            ref readonly KtxTextureCreateInfo createInfo,
            KtxTextureCreateStorageEnum storageAllocation,
            out KtxTexture2Handle newTex
        );

        /// <summary>Returns a pointer to the image data of a ktxTexture object.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetData1")]
        public static unsafe partial byte* GetData(this KtxTexture2Handle thisParam);

        /// <summary>Returns the pitch of a row of an image at the specified level.Similar to the rowPitch in a VkSubResourceLayout.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetRowPitch1")]
        public static unsafe partial uint GetRowPitch(this KtxTexture2Handle thisParam, uint level);

        /// <summary>Return the element size of the texture's images.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetElementSize1")]
        public static unsafe partial uint GetElementSize(this KtxTexture2Handle thisParam);

        /// <summary>Returns the size of all the image data of a ktxTexture object in bytes.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetDataSize1")]
        public static unsafe partial ulong GetDataSize(this KtxTexture2Handle thisParam);

        /// <summary>Iterate over the levels or faces in a ktxTexture object.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLevelFaces1")]
        public static unsafe partial KtxErrorCode IterateLevelFaces(
            this KtxTexture2Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetVkFormat1")]
        public static unsafe partial VkFormat GetVkFormat(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_Destroy1")]
        public static unsafe partial void Destroy(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetImageOffset1")]
        public static unsafe partial KtxErrorCode GetImageOffset(
            this KtxTexture2Handle thisParam,
            uint level,
            uint layer,
            uint faceSlice,
            out ulong pOffset
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetDataSizeUncompressed1")]
        public static unsafe partial ulong GetDataSizeUncompressed(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetImageSize1")]
        public static unsafe partial ulong GetImageSize(this KtxTexture2Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_GetLevelSize1")]
        public static unsafe partial ulong GetLevelSize(this KtxTexture2Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLevels1")]
        public static unsafe partial KtxErrorCode IterateLevels(
            this KtxTexture2Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_IterateLoadLevelFaces1")]
        public static unsafe partial KtxErrorCode IterateLoadLevelFaces(
            this KtxTexture2Handle thisParam,
            IterateCallbackDelegate iterCb,
            IntPtr userdata
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_NeedsTranscoding1")]
        public static unsafe partial Bool8 NeedsTranscoding(this KtxTexture2Handle thisParam);

        public static unsafe KtxErrorCode LoadImageData(this KtxTexture2Handle thisParam, Span<byte> pBuffer)
        {
            return LoadImageDataRealInterop(
                thisParam,
                ref *pBuffer.AsPointer(),
                pBuffer.AsPointer() is not null ? (ulong)pBuffer.Length : 0
            );
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_LoadImageData1")]
        private static unsafe partial KtxErrorCode LoadImageDataRealInterop(
            this KtxTexture2Handle thisParam,
            ref byte pBuffer,
            ulong bufSize
        );

        public static unsafe KtxErrorCode SetImageFromMemory(
            this KtxTexture2Handle thisParam,
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
            this KtxTexture2Handle thisParam,
            uint level,
            uint layer,
            uint faceSlice,
            ref readonly byte src,
            ulong srcSize
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_WriteToNamedFile1")]
        public static unsafe partial KtxErrorCode WriteToNamedFile(
            this KtxTexture2Handle thisParam,
            ReadOnlySpan<byte> dstname
        );

        public static unsafe KtxErrorCode WriteToMemory(this KtxTexture2Handle thisParam, out KtxNativeBuffer bytes)
        {
            byte* mem;
            ulong size;
            var returnValue = WriteToMemoryRealInterop(thisParam, out mem, out size);
            bytes = new KtxNativeBuffer(mem, size);
            return returnValue;
        }

        [LibraryImport("Ktx", EntryPoint = "ktxTexture_WriteToMemory1")]
        private static unsafe partial KtxErrorCode WriteToMemoryRealInterop(
            this KtxTexture2Handle thisParam,
            out byte* bytes,
            out ulong size
        );

        /// <summary>Create a new ktxTexture2 as a copy of an existing texture.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CreateCopy1")]
        public static unsafe partial KtxErrorCode CreateCopy(this KtxTexture2Handle orig, out KtxTexture2Handle newTex);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CompressBasis1")]
        public static unsafe partial KtxErrorCode CompressBasis(this KtxTexture2Handle thisParam, uint quality);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CompressBasisEx1")]
        public static unsafe partial KtxErrorCode CompressBasisEx(
            this KtxTexture2Handle thisParam,
            ref readonly KtxBasisParams basisParams
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_DeflateZstd1")]
        public static unsafe partial KtxErrorCode DeflateZstd(this KtxTexture2Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_DeflateZLIB1")]
        public static unsafe partial KtxErrorCode DeflateZlib(this KtxTexture2Handle thisParam, uint level);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetComponentInfo1")]
        public static unsafe partial void GetComponentInfo(
            this KtxTexture2Handle thisParam,
            out uint numComponents,
            out uint componentByteLength
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetNumComponents1")]
        public static unsafe partial uint GetNumComponents(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetTransferFunction_e1")]
        public static unsafe partial KhrDfTransfer GetTransferFunctionE(this KtxTexture2Handle thisParam);

        /// <summary>For backward compatibility.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetOETF_e1")]
        public static unsafe partial KhrDfTransfer GetOetfE(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetOETF1")]
        public static unsafe partial uint GetOetf(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetColorModel_e1")]
        public static unsafe partial KhrDfModel GetColorModelE(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetPremultipliedAlpha1")]
        public static unsafe partial Bool8 GetPremultipliedAlpha(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_GetPrimaries_e1")]
        public static unsafe partial KhrDfPrimaries GetPrimariesE(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_SetTransferFunction1")]
        public static unsafe partial KtxErrorCode SetTransferFunction(
            this KtxTexture2Handle thisParam,
            KhrDfTransfer tf
        );

        /// <summary>For backward compatibility.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_SetOETF1")]
        public static unsafe partial KtxErrorCode SetOetf(this KtxTexture2Handle thisParam, KhrDfTransfer oetf);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_SetPrimaries1")]
        public static unsafe partial KtxErrorCode SetPrimaries(
            this KtxTexture2Handle thisParam,
            KhrDfPrimaries primaries
        );

        /// <summary>For rare testing scenarios. Use ktxTexture2_LoadImageData.</summary>
        public static unsafe KtxErrorCode LoadDeflatedImageData(this KtxTexture2Handle thisParam, Span<byte> pBuffer)
        {
            return LoadDeflatedImageDataRealInterop(
                thisParam,
                ref *pBuffer.AsPointer(),
                pBuffer.AsPointer() is not null ? (ulong)pBuffer.Length : 0
            );
        }

        /// <summary>For rare testing scenarios. Use ktxTexture2_LoadImageData.</summary>
        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_LoadDeflatedImageData1")]
        private static unsafe partial KtxErrorCode LoadDeflatedImageDataRealInterop(
            this KtxTexture2Handle thisParam,
            ref byte pBuffer,
            ulong bufSize
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_TranscodeBasis1")]
        public static unsafe partial KtxErrorCode TranscodeBasis(
            this KtxTexture2Handle thisParam,
            KtxTranscodeFmt fmt,
            KtxTranscodeFlagBits transcodeFlags
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CompressAstcEx1")]
        public static unsafe partial KtxErrorCode CompressAstcEx(
            this KtxTexture2Handle thisParam,
            ref readonly KtxAstcParams basisParams
        );

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_DecodeAstc1")]
        public static unsafe partial KtxErrorCode DecodeAstc(this KtxTexture2Handle thisParam);

        [LibraryImport("Ktx", EntryPoint = "ktxTexture2_CompressAstc1")]
        public static unsafe partial KtxErrorCode CompressAstc(
            this KtxTexture2Handle thisParam,
            KtxPackAstcQualityLevels quality
        );
    }
}
#pragma warning restore 1591
