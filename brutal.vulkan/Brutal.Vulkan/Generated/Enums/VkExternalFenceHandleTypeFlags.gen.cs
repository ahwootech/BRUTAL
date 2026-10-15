namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalFenceHandleTypeFlagBits.html">VkExternalFenceHandleTypeFlagBits</see> - Bitmask of valid external fence handle types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///     </para>
    ///     <para>
    ///         * <c>VkPhysicalDeviceExternalFenceInfo::handleType</c>
    ///         * <c>VkExternalFenceProperties::exportFromImportedHandleTypes</c>
    ///         * <c>VkExternalFenceProperties::compatibleHandleTypes</c>
    ///     </para>
    ///     <para>
    ///         indicate external fence handle types, and are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalFenceHandleTypeFlagBits {
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT = 0x00000008,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT,
    ///         } VkExternalFenceHandleTypeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalFenceHandleTypeFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueFdBit</c> specifies a POSIX file descriptor handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the POSIX system calls <c>dup</c>, <c>dup2</c>, <c>close</c>, and the non-standard system call <c>dup3</c>. Additionally, it <i>must</i> be transportable over a socket using an <c>SCM_RIGHTS</c> control message. It owns a reference to the underlying synchronization primitive represented by its Vulkan fence object.
        /// </summary>
        OpaqueFdBit = 0x00000001,

        /// <summary>
        ///     <c>OpaqueWin32Bit</c> specifies an NT handle that has only limited valid usage outside of Vulkan and other compatible APIs. It <i>must</i> be compatible with the functions <c>DuplicateHandle</c>, <c>CloseHandle</c>, <c>CompareObjectHandles</c>, <c>GetHandleInformation</c>, and <c>SetHandleInformation</c>. It owns a reference to the underlying synchronization primitive represented by its Vulkan fence object.
        /// </summary>
        OpaqueWin32Bit = 0x00000002,

        /// <summary>
        ///     <c>OpaqueWin32KmtBit</c> specifies a global share handle that has only limited valid usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own a reference to the underlying synchronization primitive represented by its Vulkan fence object, and will therefore become invalid when all Vulkan fence objects associated with it are destroyed.
        /// </summary>
        OpaqueWin32KmtBit = 0x00000004,

        /// <summary>
        ///     <c>SyncFdBit</c> specifies a POSIX file descriptor handle to a Linux Sync File or Android Fence. It can be used with any native API accepting a valid sync file or fence as input. It owns a reference to the underlying synchronization primitive associated with the file descriptor. Implementations which support importing this handle type <i>must</i> accept any type of sync or fence FD supported by the native system they are running on.  &lt;&lt;&lt;  Some external fence handle types can only be shared within the same underlying physical device and/or the same driver version, as defined in the following table:  [[external-fence-handle-types-compatibility]] .External Fence Handle Types Compatibility |
        /// </summary>
        SyncFdBit = 0x00000008,

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
        ///     <c>SyncFdBitKHR</c>
        /// </summary>
        SyncFdBitKHR = SyncFdBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
