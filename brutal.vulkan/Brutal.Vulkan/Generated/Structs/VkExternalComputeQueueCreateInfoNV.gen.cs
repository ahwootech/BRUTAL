namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalComputeQueueCreateInfoNV.html">VkExternalComputeQueueCreateInfoNV</see> - Structure specifying configuration parameters for external compute queue creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalComputeQueueCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_compute_queue
    ///         typedef struct VkExternalComputeQueueCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkQueue            preferredQueue;
    ///         } VkExternalComputeQueueCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalComputeQueueCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalComputeQueueCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PreferredQueue</c> is a <c>VkQueue</c> supporting graphics commands.
        /// </summary>
        [FieldOffset(16)]
        public VkQueue PreferredQueue;
    }
}
