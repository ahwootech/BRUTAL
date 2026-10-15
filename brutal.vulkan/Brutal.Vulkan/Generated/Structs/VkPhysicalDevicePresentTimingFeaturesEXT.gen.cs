namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePresentTimingFeaturesEXT.html">VkPhysicalDevicePresentTimingFeaturesEXT</see> - Structure indicating support for present timing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePresentTimingFeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPhysicalDevicePresentTimingFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentTiming;
    ///             VkBool32           presentAtAbsoluteTime;
    ///             VkBool32           presentAtRelativeTime;
    ///         } VkPhysicalDevicePresentTimingFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevicePresentTimingFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePresentTimingFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentTiming</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentTiming;

        /// <summary>
        ///     <c>PresentAtAbsoluteTime</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PresentAtAbsoluteTime;

        /// <summary>
        ///     <c>PresentAtRelativeTime</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 PresentAtRelativeTime;
    }
}
