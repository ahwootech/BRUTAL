namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGlobalPriorityQueryFeatures.html">VkPhysicalDeviceGlobalPriorityQueryFeatures</see> - Structure describing whether global priority query can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGlobalPriorityQueryFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceGlobalPriorityQueryFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           globalPriorityQuery;
    ///         } VkPhysicalDeviceGlobalPriorityQueryFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceGlobalPriorityQueryFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGlobalPriorityQueryFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GlobalPriorityQuery</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 GlobalPriorityQuery;
    }
}
