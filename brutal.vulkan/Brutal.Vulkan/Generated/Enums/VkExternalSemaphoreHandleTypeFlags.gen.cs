namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreHandleTypeFlagBits.html">VkExternalSemaphoreHandleTypeFlagBits</see> - Bitmask of valid external semaphore handle types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkPhysicalDeviceExternalSemaphoreInfo::handleType</c>, specifying an
    ///         external semaphore handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalSemaphoreHandleTypeFlagBits {
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT = 0x00000008,
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT = 0x00000010,
    ///             // Provided by VK_FUCHSIA_external_semaphore
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA = 0x00000080,
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT,
    ///         } VkExternalSemaphoreHandleTypeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueFdBit</c> specifies a POSIX file descriptor handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the POSIX system calls <c>dup</c>, <c>dup2</c>, <c>close</c>, and the non-standard system call <c>dup3</c>. Additionally, it <i>must</i> be transportable over a socket using an <c>SCM_RIGHTS</c> control message. It owns a reference to the underlying synchronization primitive represented by its Vulkan semaphore object.
        /// </summary>
        OpaqueFdBit = 0x00000001,

        /// <summary>
        ///     <c>OpaqueWin32Bit</c> specifies an NT handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the functions <c>DuplicateHandle</c>, <c>CloseHandle</c>, <c>CompareObjectHandles</c>, <c>GetHandleInformation</c>, and <c>SetHandleInformation</c>. It owns a reference to the underlying synchronization primitive represented by its Vulkan semaphore object.
        /// </summary>
        OpaqueWin32Bit = 0x00000002,

        /// <summary>
        ///     <c>OpaqueWin32KmtBit</c> specifies a global share handle that has only limited valid usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own a reference to the underlying synchronization primitive represented by its Vulkan semaphore object, and will therefore become invalid when all Vulkan semaphore objects associated with it are destroyed.
        /// </summary>
        OpaqueWin32KmtBit = 0x00000004,

        /// <summary>
        ///     <c>D3D12FenceBit</c> specifies an NT handle returned by <c>ID3D12Device::CreateSharedHandle</c> referring to a Direct3D 12 fence, or <c>ID3D11Device5::CreateFence</c> referring to a Direct3D 11 fence. It owns a reference to the underlying synchronization primitive associated with the Direct3D fence.
        /// </summary>
        D3D12FenceBit = 0x00000008,

        /// <summary>
        ///     <c>SyncFdBit</c> specifies a POSIX file descriptor handle to a Linux Sync File or Android Fence object. It can be used with any native API accepting a valid sync file or fence as input. It owns a reference to the underlying synchronization primitive associated with the file descriptor. Implementations which support importing this handle type <i>must</i> accept any type of sync or fence FD supported by the native system they are running on.  [NOTE]
        /// </summary>
        SyncFdBit = 0x00000010,

        /// <summary>
        ///     <c>ZirconEventBitFUCHSIA</c>
        /// </summary>
        ZirconEventBitFUCHSIA = 0x00000080,

        /// <summary>
        ///     <c>D3D11FenceBit</c> is an alias of <c>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT</c> with the same meaning. It is provided for convenience and code clarity when interacting with D3D11 fences.
        /// </summary>
        D3D11FenceBit = D3D12FenceBit,

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
        ///     <c>D3D12FenceBitKHR</c>
        /// </summary>
        D3D12FenceBitKHR = D3D12FenceBit,

        /// <summary>
        ///     <c>SyncFdBitKHR</c>
        /// </summary>
        SyncFdBitKHR = SyncFdBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
