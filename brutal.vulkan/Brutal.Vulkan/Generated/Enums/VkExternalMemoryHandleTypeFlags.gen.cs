namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBits.html">VkExternalMemoryHandleTypeFlagBits</see> - Bit specifying external memory handle types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPhysicalDeviceExternalImageFormatInfo::handleType</c>, specifying
    ///         an external memory handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalMemoryHandleTypeFlagBits {
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT = 0x00000008,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT = 0x00000010,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT = 0x00000020,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT = 0x00000040,
    ///             // Provided by VK_EXT_external_memory_dma_buf
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT = 0x00000200,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID = 0x00000400,
    ///             // Provided by VK_EXT_external_memory_host
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT = 0x00000080,
    ///             // Provided by VK_EXT_external_memory_host
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT = 0x00000100,
    ///             // Provided by VK_FUCHSIA_external_memory
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA = 0x00000800,
    ///             // Provided by VK_NV_external_memory_rdma
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV = 0x00001000,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OH_NATIVE_BUFFER_BIT_OHOS = 0x00008000,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCREEN_BUFFER_BIT_QNX = 0x00004000,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLBUFFER_BIT_EXT = 0x00010000,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLTEXTURE_BIT_EXT = 0x00020000,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLHEAP_BIT_EXT = 0x00040000,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT,
    ///         } VkExternalMemoryHandleTypeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueFdBit</c> specifies a POSIX file descriptor handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the POSIX system calls <c>dup</c>, <c>dup2</c>, <c>close</c>, and the non-standard system call <c>dup3</c>. Additionally, it <i>must</i> be transportable over a socket using an <c>SCM_RIGHTS</c> control message. It owns a reference to the underlying memory resource represented by its Vulkan memory object.
        /// </summary>
        OpaqueFdBit = 0x00000001,

        /// <summary>
        ///     <c>OpaqueWin32Bit</c> specifies an NT handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the functions <c>DuplicateHandle</c>, <c>CloseHandle</c>, <c>CompareObjectHandles</c>, <c>GetHandleInformation</c>, and <c>SetHandleInformation</c>. It owns a reference to the underlying memory resource represented by its Vulkan memory object.
        /// </summary>
        OpaqueWin32Bit = 0x00000002,

        /// <summary>
        ///     <c>OpaqueWin32KmtBit</c> specifies a global share handle that has only limited valid usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own a reference to the underlying memory resource represented by its Vulkan memory object, and will therefore become invalid when all Vulkan memory objects associated with it are destroyed.
        /// </summary>
        OpaqueWin32KmtBit = 0x00000004,

        /// <summary>
        ///     <c>D3D11TextureBit</c> specifies an NT handle returned by <c>IDXGIResource1::CreateSharedHandle</c> referring to a Direct3D 10 or 11 texture resource. It owns a reference to the memory used by the Direct3D resource.
        /// </summary>
        D3D11TextureBit = 0x00000008,

        /// <summary>
        ///     <c>D3D11TextureKmtBit</c> specifies a global share handle returned by <c>IDXGIResource::GetSharedHandle</c> referring to a Direct3D 10 or 11 texture resource. It does not own a reference to the underlying Direct3D resource, and will therefore become invalid when all Vulkan memory objects and Direct3D resources associated with it are destroyed.
        /// </summary>
        D3D11TextureKmtBit = 0x00000010,

        /// <summary>
        ///     <c>D3D12HeapBit</c> specifies an NT handle returned by <c>ID3D12Device::CreateSharedHandle</c> referring to a Direct3D 12 heap resource. It owns a reference to the resources used by the Direct3D heap.
        /// </summary>
        D3D12HeapBit = 0x00000020,

        /// <summary>
        ///     <c>D3D12ResourceBit</c> specifies an NT handle returned by <c>ID3D12Device::CreateSharedHandle</c> referring to a Direct3D 12 committed resource. It owns a reference to the memory used by the Direct3D resource.  &lt;&lt;&lt;  Some external memory handle types can only be shared within the same underlying physical device and/or the same driver version, as defined in the following table:  [[external-memory-handle-types-compatibility]] .External Memory Handle Types Compatibility |
        /// </summary>
        D3D12ResourceBit = 0x00000040,

        /// <summary>
        ///     <c>DmaBufBitEXT</c>
        /// </summary>
        DmaBufBitEXT = 0x00000200,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferBitANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferBitANDROID = 0x00000400,

        /// <summary>
        ///     <c>HostAllocationBitEXT</c>
        /// </summary>
        HostAllocationBitEXT = 0x00000080,

        /// <summary>
        ///     <c>HostMappedForeignMemoryBitEXT</c>
        /// </summary>
        HostMappedForeignMemoryBitEXT = 0x00000100,

        /// <summary>
        ///     <c>ZirconVmoBitFUCHSIA</c>
        /// </summary>
        ZirconVmoBitFUCHSIA = 0x00000800,

        /// <summary>
        ///     <c>RdmaAddressBitNV</c>
        /// </summary>
        RdmaAddressBitNV = 0x00001000,

        /// <summary>
        ///     <c>OhNativeBufferBitOHOS</c>
        /// </summary>
        OhNativeBufferBitOHOS = 0x00008000,

        /// <summary>
        ///     <c>ScreenBufferBitQNX</c>
        /// </summary>
        ScreenBufferBitQNX = 0x00004000,

        /// <summary>
        ///     <c>MtlbufferBitEXT</c>
        /// </summary>
        MtlbufferBitEXT = 0x00010000,

        /// <summary>
        ///     <c>MtltextureBitEXT</c>
        /// </summary>
        MtltextureBitEXT = 0x00020000,

        /// <summary>
        ///     <c>MtlheapBitEXT</c>
        /// </summary>
        MtlheapBitEXT = 0x00040000,

        /// <summary>
        ///     <c>OpaqueFdBitKHR</c>
        /// </summary>
        OpaqueFdBitKHR = OpaqueFdBit,

        /// <summary>
        ///     <c>OpaqueWin32BitKHR</c>
        /// </summary>
        OpaqueWin32BitKHR = OpaqueWin32Bit,

        /// <summary>
        ///     <c>OpaqueWin32KmtBitKHR</c>
        /// </summary>
        OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,

        /// <summary>
        ///     <c>D3D11TextureBitKHR</c>
        /// </summary>
        D3D11TextureBitKHR = D3D11TextureBit,

        /// <summary>
        ///     <c>D3D11TextureKmtBitKHR</c>
        /// </summary>
        D3D11TextureKmtBitKHR = D3D11TextureKmtBit,

        /// <summary>
        ///     <c>D3D12HeapBitKHR</c>
        /// </summary>
        D3D12HeapBitKHR = D3D12HeapBit,

        /// <summary>
        ///     <c>D3D12ResourceBitKHR</c>
        /// </summary>
        D3D12ResourceBitKHR = D3D12ResourceBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
