namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBitsNV.html">VkExternalMemoryHandleTypeFlagBitsNV</see> - Bitmask specifying external memory handle types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkImportMemoryWin32HandleInfoNV::handleType</c>,
    ///         specifying the type of an external memory handle, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_capabilities
    ///         typedef enum VkExternalMemoryHandleTypeFlagBitsNV {
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = 0x00000001,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = 0x00000002,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = 0x00000004,
    ///             VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = 0x00000008,
    ///         } VkExternalMemoryHandleTypeFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueWin32BitNV</c> specifies a handle to memory returned by <c>vkGetMemoryWin32HandleNV</c>, or one duplicated from such a handle using `DuplicateHandle()`.
        /// </summary>
        OpaqueWin32BitNV = 0x00000001,

        /// <summary>
        ///     <c>OpaqueWin32KmtBitNV</c> specifies a handle to memory returned by <c>vkGetMemoryWin32HandleNV</c>.
        /// </summary>
        OpaqueWin32KmtBitNV = 0x00000002,

        /// <summary>
        ///     <c>D3D11ImageBitNV</c> specifies a valid NT handle to memory returned by `IDXGIResource1::CreateSharedHandle`, or a handle duplicated from such a handle using `DuplicateHandle()`.
        /// </summary>
        D3D11ImageBitNV = 0x00000004,

        /// <summary>
        ///     <c>D3D11ImageKmtBitNV</c> specifies a handle to memory returned by `IDXGIResource::GetSharedHandle()`.
        /// </summary>
        D3D11ImageKmtBitNV = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
