namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoMaintenance1FeaturesKHR.html">VkPhysicalDeviceVideoMaintenance1FeaturesKHR</see> - Structure describing the video maintenance features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoMaintenance1FeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_maintenance1
    ///         typedef struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           videoMaintenance1;
    ///         } VkPhysicalDeviceVideoMaintenance1FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoMaintenance1FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoMaintenance1</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VideoMaintenance1;
    }
}
