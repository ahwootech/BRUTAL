namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM.html">VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM</see> - Structure describing shader multiple wait queues properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_shader_multiple_wait_queues
    ///         typedef struct VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxShaderWaitQueues;
    ///         } VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxShaderWaitQueues</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxShaderWaitQueues;
    }
}
