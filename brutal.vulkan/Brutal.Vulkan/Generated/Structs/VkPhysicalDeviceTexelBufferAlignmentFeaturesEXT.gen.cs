namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT.html">VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT</see> - Structure describing the texel buffer alignment features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_texel_buffer_alignment
    ///         typedef struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           texelBufferAlignment;
    ///         } VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TexelBufferAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TexelBufferAlignment;
    }
}
