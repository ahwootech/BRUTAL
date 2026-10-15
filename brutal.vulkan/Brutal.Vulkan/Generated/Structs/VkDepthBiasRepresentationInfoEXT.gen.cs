namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDepthBiasRepresentationInfoEXT.html">VkDepthBiasRepresentationInfoEXT</see> - Structure specifying depth bias parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDepthBiasRepresentationInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDepthBiasRepresentationInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_bias_control
    ///         typedef struct VkDepthBiasRepresentationInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkDepthBiasRepresentationEXT    depthBiasRepresentation;
    ///             VkBool32                        depthBiasExact;
    ///         } VkDepthBiasRepresentationInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDepthBiasRepresentationInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DepthBiasRepresentationInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthBiasRepresentation</c> is a <c>VkDepthBiasRepresentationEXT</c> value specifying the depth bias representation.
        /// </summary>
        [FieldOffset(16)]
        public VkDepthBiasRepresentationEXT DepthBiasRepresentation;

        /// <summary>
        ///     <c>DepthBiasExact</c> specifies that the implementation is not allowed to scale the depth bias value to ensure a minimum resolvable distance.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DepthBiasExact;
    }
}
