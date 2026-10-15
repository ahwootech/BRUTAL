namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImagelessFramebufferFeatures.html">VkPhysicalDeviceImagelessFramebufferFeatures</see> - Structure indicating support for imageless framebuffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImagelessFramebufferFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceImagelessFramebufferFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           imagelessFramebuffer;
    ///         } VkPhysicalDeviceImagelessFramebufferFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImagelessFramebufferFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImagelessFramebuffer</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ImagelessFramebuffer;
    }
}
