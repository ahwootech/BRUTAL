namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoMaintenance2FeaturesKHR.html">VkPhysicalDeviceVideoMaintenance2FeaturesKHR</see> - Structure describing the video maintenance features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoMaintenance2FeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_maintenance2
    ///         typedef struct VkPhysicalDeviceVideoMaintenance2FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           videoMaintenance2;
    ///         } VkPhysicalDeviceVideoMaintenance2FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoMaintenance2FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoMaintenance2FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoMaintenance2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VideoMaintenance2;
    }
}
