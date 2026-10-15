namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFenceGetFdInfoKHR.html">VkFenceGetFdInfoKHR</see> - Structure describing a POSIX FD fence export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFenceGetFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_fence_fd
    ///         typedef struct VkFenceGetFdInfoKHR {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkFence                              fence;
    ///             VkExternalFenceHandleTypeFlagBits    handleType;
    ///         } VkFenceGetFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFenceGetFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FenceGetFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Fence</c> is the fence from which state will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkFence Fence;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalFenceHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalFenceHandleTypeFlags HandleType;
    }
}
