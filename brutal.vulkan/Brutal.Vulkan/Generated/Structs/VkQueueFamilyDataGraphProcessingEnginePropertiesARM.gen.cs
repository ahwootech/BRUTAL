namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyDataGraphProcessingEnginePropertiesARM.html">VkQueueFamilyDataGraphProcessingEnginePropertiesARM</see> - Structure describing the properties of a data graph processing engine type for a given queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyDataGraphProcessingEnginePropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkQueueFamilyDataGraphProcessingEnginePropertiesARM {
    ///             VkStructureType                       sType;
    ///             void*                                 pNext;
    ///             VkExternalSemaphoreHandleTypeFlags    foreignSemaphoreHandleTypes;
    ///             VkExternalMemoryHandleTypeFlags       foreignMemoryHandleTypes;
    ///         } VkQueueFamilyDataGraphProcessingEnginePropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyDataGraphProcessingEnginePropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyDataGraphProcessingEnginePropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ForeignSemaphoreHandleTypes</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> that describes the external semaphore handle types supported by a foreign data graph processing engine.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalSemaphoreHandleTypeFlags ForeignSemaphoreHandleTypes;

        /// <summary>
        ///     <c>ForeignMemoryHandleTypes</c> is a <c>VkExternalMemoryHandleTypeFlags</c> that describes the external memory handle types supported by a foreign data graph processing engine.
        /// </summary>
        [FieldOffset(20)]
        public VkExternalMemoryHandleTypeFlags ForeignMemoryHandleTypes;
    }
}
