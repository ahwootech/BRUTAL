namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderSplitBarrierPropertiesEXT.html">VkPhysicalDeviceShaderSplitBarrierPropertiesEXT</see> - Structure describing split barrier properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderSplitBarrierPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_split_barrier
    ///         typedef struct VkPhysicalDeviceShaderSplitBarrierPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           splitBarrierReservedSharedMemory;
    ///         } VkPhysicalDeviceShaderSplitBarrierPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderSplitBarrierPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderSplitBarrierPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SplitBarrierReservedSharedMemory</c>
        /// </summary>
        [FieldOffset(16)]
        public int SplitBarrierReservedSharedMemory;
    }
}
