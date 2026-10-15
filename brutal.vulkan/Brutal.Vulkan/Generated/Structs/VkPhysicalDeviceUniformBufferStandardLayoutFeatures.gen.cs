namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceUniformBufferStandardLayoutFeatures.html">VkPhysicalDeviceUniformBufferStandardLayoutFeatures</see> - Structure indicating support for std430-like packing in uniform buffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceUniformBufferStandardLayoutFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           uniformBufferStandardLayout;
    ///         } VkPhysicalDeviceUniformBufferStandardLayoutFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UniformBufferStandardLayout</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UniformBufferStandardLayout;
    }
}
