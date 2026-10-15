namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteInfoNV.html">VkOpticalFlowExecuteInfoNV</see> - Structure specifying parameters of an optical flow vector calculation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpticalFlowExecuteInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef struct VkOpticalFlowExecuteInfoNV {
    ///             VkStructureType                sType;
    ///             void*                          pNext;
    ///             VkOpticalFlowExecuteFlagsNV    flags;
    ///             uint32_t                       regionCount;
    ///             const VkRect2D*                pRegions;
    ///         } VkOpticalFlowExecuteInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkOpticalFlowExecuteInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpticalFlowExecuteInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> are the <c>VkOpticalFlowExecuteFlagsNV</c> used for this command.
        /// </summary>
        [FieldOffset(16)]
        public VkOpticalFlowExecuteFlagsNV Flags;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions of interest specified in <c>pRegions</c>.
        /// </summary>
        [FieldOffset(20)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to <c>regionCount</c> <c>VkRect2D</c> regions of interest.
        /// </summary>
        [FieldOffset(24)]
        public VkRect2D* Regions;
    }
}
