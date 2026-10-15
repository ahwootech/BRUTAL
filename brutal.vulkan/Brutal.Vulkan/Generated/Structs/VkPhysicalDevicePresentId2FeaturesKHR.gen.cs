namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePresentId2FeaturesKHR.html">VkPhysicalDevicePresentId2FeaturesKHR</see> - Structure indicating support for present id 2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePresentId2FeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_present_id2
    ///         typedef struct VkPhysicalDevicePresentId2FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentId2;
    ///         } VkPhysicalDevicePresentId2FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePresentId2FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePresentId2FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentId2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentId2;
    }
}
