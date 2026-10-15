namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">VkPipelineRasterizationStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline rasterization state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineRasterizationStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineRasterizationStateCreateInfo {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             VkPipelineRasterizationStateCreateFlags    flags;
    ///             VkBool32                                   depthClampEnable;
    ///             VkBool32                                   rasterizerDiscardEnable;
    ///             VkPolygonMode                              polygonMode;
    ///             VkCullModeFlags                            cullMode;
    ///             VkFrontFace                                frontFace;
    ///             VkBool32                                   depthBiasEnable;
    ///             float                                      depthBiasConstantFactor;
    ///             float                                      depthBiasClamp;
    ///             float                                      depthBiasSlopeFactor;
    ///             float                                      lineWidth;
    ///         } VkPipelineRasterizationStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPipelineRasterizationStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRasterizationStateCreateFlags Flags;

        /// <summary>
        ///     <c>DepthClampEnable</c> controls whether to clamp the fragment&apos;s depth values as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-depth">Depth Test^</see>. Enabling depth clamp will also disable clipping primitives to the z planes of the frustum as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vertexpostproc-clipping">Primitive Clipping^</see>.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DepthClampEnable;

        /// <summary>
        ///     <c>RasterizerDiscardEnable</c> controls whether primitives are discarded immediately before the rasterization stage.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 RasterizerDiscardEnable;

        /// <summary>
        ///     <c>PolygonMode</c> is the triangle rendering mode. See <c>VkPolygonMode</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkPolygonMode PolygonMode;

        /// <summary>
        ///     <c>CullMode</c> is the triangle facing direction used for primitive culling. See <c>VkCullModeFlags</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkCullModeFlags CullMode;

        /// <summary>
        ///     <c>FrontFace</c> is a <c>VkFrontFace</c> value specifying the front-facing triangle orientation to be used for culling.
        /// </summary>
        [FieldOffset(36)]
        public VkFrontFace FrontFace;

        /// <summary>
        ///     <c>DepthBiasEnable</c> controls whether to bias fragment depth values.
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 DepthBiasEnable;

        /// <summary>
        ///     <c>DepthBiasConstantFactor</c> is a scalar factor controlling the constant depth value added to each fragment.
        /// </summary>
        [FieldOffset(44)]
        public float DepthBiasConstantFactor;

        /// <summary>
        ///     <c>DepthBiasClamp</c> is the maximum (or minimum) depth bias of a fragment.
        /// </summary>
        [FieldOffset(48)]
        public float DepthBiasClamp;

        /// <summary>
        ///     <c>DepthBiasSlopeFactor</c> is a scalar factor applied to a fragment&apos;s slope in depth bias calculations.
        /// </summary>
        [FieldOffset(52)]
        public float DepthBiasSlopeFactor;

        /// <summary>
        ///     <c>LineWidth</c> is the width of rasterized line segments.
        /// </summary>
        [FieldOffset(56)]
        public float LineWidth;
    }
}
