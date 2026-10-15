namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationLineStateCreateInfo.html">VkPipelineRasterizationLineStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline line rasterization state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Line segment rasterization options are controlled by the
    ///         <c>VkPipelineRasterizationLineStateCreateInfo</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRasterizationLineStateCreateInfo</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPipelineRasterizationLineStateCreateInfo {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkLineRasterizationMode    lineRasterizationMode;
    ///             VkBool32                   stippledLineEnable;
    ///             uint32_t                   lineStippleFactor;
    ///             uint16_t                   lineStipplePattern;
    ///         } VkPipelineRasterizationLineStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationLineStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LineRasterizationMode</c> is a <c>VkLineRasterizationMode</c> value selecting the style of line rasterization.
        /// </summary>
        [FieldOffset(16)]
        public VkLineRasterizationMode LineRasterizationMode;

        /// <summary>
        ///     <c>StippledLineEnable</c> enables <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-lines-stipple">stippled line rasterization^</see>.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 StippledLineEnable;

        /// <summary>
        ///     <c>LineStippleFactor</c> is the repeat factor used in stippled line rasterization.
        /// </summary>
        [FieldOffset(24)]
        public int LineStippleFactor;

        /// <summary>
        ///     <c>LineStipplePattern</c> is the bit pattern used in stippled line rasterization.
        /// </summary>
        [FieldOffset(28)]
        public ushort LineStipplePattern;
    }
}
