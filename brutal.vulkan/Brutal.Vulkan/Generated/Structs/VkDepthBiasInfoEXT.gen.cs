namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDepthBiasInfoEXT.html">VkDepthBiasInfoEXT</see> - Structure specifying depth bias parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDepthBiasInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDepthBiasInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_bias_control
    ///         typedef struct VkDepthBiasInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             float              depthBiasConstantFactor;
    ///             float              depthBiasClamp;
    ///             float              depthBiasSlopeFactor;
    ///         } VkDepthBiasInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDepthBiasInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DepthBiasInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthBiasConstantFactor</c> is a scalar factor controlling the constant depth value added to each fragment.
        /// </summary>
        [FieldOffset(16)]
        public float DepthBiasConstantFactor;

        /// <summary>
        ///     <c>DepthBiasClamp</c> is the maximum (or minimum) depth bias of a fragment.
        /// </summary>
        [FieldOffset(20)]
        public float DepthBiasClamp;

        /// <summary>
        ///     <c>DepthBiasSlopeFactor</c> is a scalar factor applied to a fragment&apos;s slope in depth bias calculations.
        /// </summary>
        [FieldOffset(24)]
        public float DepthBiasSlopeFactor;
    }
}
