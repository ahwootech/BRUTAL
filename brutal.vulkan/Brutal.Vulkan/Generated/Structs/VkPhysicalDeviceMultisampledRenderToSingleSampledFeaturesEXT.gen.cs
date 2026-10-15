namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT.html">VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT</see> - Structure describing whether multisampled rendering to single-sampled attachments is supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///         typedef struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           multisampledRenderToSingleSampled;
    ///         } VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampled</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MultisampledRenderToSingleSampled;
    }
}
