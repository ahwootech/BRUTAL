namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAdvancedStateCreateInfoEXT.html">VkPipelineColorBlendAdvancedStateCreateInfoEXT</see> - Structure specifying parameters that affect advanced blend operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPipelineColorBlendStateCreateInfo</c>
    ///         includes a <c>VkPipelineColorBlendAdvancedStateCreateInfoEXT</c> structure,
    ///         then that structure includes parameters that affect advanced blend
    ///         operations.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineColorBlendAdvancedStateCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_blend_operation_advanced
    ///         typedef struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkBool32             srcPremultiplied;
    ///             VkBool32             dstPremultiplied;
    ///             VkBlendOverlapEXT    blendOverlap;
    ///         } VkPipelineColorBlendAdvancedStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcPremultiplied</c> specifies whether the source color of the blend operation is treated as premultiplied.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SrcPremultiplied;

        /// <summary>
        ///     <c>DstPremultiplied</c> specifies whether the destination color of the blend operation is treated as premultiplied.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DstPremultiplied;

        /// <summary>
        ///     <c>BlendOverlap</c> is a <c>VkBlendOverlapEXT</c> value specifying how the source and destination sample&apos;s coverage is correlated.
        /// </summary>
        [FieldOffset(24)]
        public VkBlendOverlapEXT BlendOverlap;
    }
}
