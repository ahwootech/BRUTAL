namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportFenceFdInfoKHR.html">VkImportFenceFdInfoKHR</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImportFenceFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_fence_fd
    ///         typedef struct VkImportFenceFdInfoKHR {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkFence                              fence;
    ///             VkFenceImportFlags                   flags;
    ///             VkExternalFenceHandleTypeFlagBits    handleType;
    ///             int                                  fd;
    ///         } VkImportFenceFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkImportFenceFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportFenceFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Fence</c> is the fence into which the payload will be imported.
        /// </summary>
        [FieldOffset(16)]
        public VkFence Fence;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkFenceImportFlags</c> specifying additional parameters for the fence payload import operation.
        /// </summary>
        [FieldOffset(24)]
        public VkFenceImportFlags Flags;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalFenceHandleTypeFlags</c> value specifying the type of <c>fd</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExternalFenceHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>Fd</c> is the external handle to import.
        /// </summary>
        [FieldOffset(32)]
        public int Fd;
    }
}
