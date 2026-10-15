namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedFlagsFeaturesKHR.html">VkPhysicalDeviceExtendedFlagsFeaturesKHR</see> - Structure describing whether the implementation supports extended flags functionality
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedFlagsFeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         typedef struct VkPhysicalDeviceExtendedFlagsFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           extendedFlags;
    ///         } VkPhysicalDeviceExtendedFlagsFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExtendedFlagsFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedFlagsFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExtendedFlags</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExtendedFlags;
    }
}
