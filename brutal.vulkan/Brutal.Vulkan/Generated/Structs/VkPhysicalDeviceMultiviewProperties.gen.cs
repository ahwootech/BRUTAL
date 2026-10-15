namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewProperties.html">VkPhysicalDeviceMultiviewProperties</see> - Structure describing multiview limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultiviewProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceMultiviewProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxMultiviewViewCount;
    ///             uint32_t           maxMultiviewInstanceIndex;
    ///         } VkPhysicalDeviceMultiviewProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultiviewProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMultiviewProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxMultiviewViewCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxMultiviewViewCount;

        /// <summary>
        ///     <c>MaxMultiviewInstanceIndex</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxMultiviewInstanceIndex;
    }
}
