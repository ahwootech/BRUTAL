namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR.html">VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR</see> - Structure describing additional video encode feedback features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_feedback2
    ///         typedef struct VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           videoEncodeFeedback2;
    ///         } VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoEncodeFeedback2FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoEncodeFeedback2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VideoEncodeFeedback2;
    }
}
