namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetPropertiesKHR.html">VkPhysicalDevicePortabilitySubsetPropertiesKHR</see> - Structure describing additional properties supported by a portable implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePortabilitySubsetPropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_portability_subset
    ///         typedef struct VkPhysicalDevicePortabilitySubsetPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           minVertexInputBindingStrideAlignment;
    ///         } VkPhysicalDevicePortabilitySubsetPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePortabilitySubsetPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePortabilitySubsetPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinVertexInputBindingStrideAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public int MinVertexInputBindingStrideAlignment;
    }
}
