namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceOpticalFlowPropertiesNV.html">VkPhysicalDeviceOpticalFlowPropertiesNV</see> - Structure describing properties supported by VK_NV_optical_flow
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceOpticalFlowPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef struct VkPhysicalDeviceOpticalFlowPropertiesNV {
    ///             VkStructureType                 sType;
    ///             void*                           pNext;
    ///             VkOpticalFlowGridSizeFlagsNV    supportedOutputGridSizes;
    ///             VkOpticalFlowGridSizeFlagsNV    supportedHintGridSizes;
    ///             VkBool32                        hintSupported;
    ///             VkBool32                        costSupported;
    ///             VkBool32                        bidirectionalFlowSupported;
    ///             VkBool32                        globalFlowSupported;
    ///             uint32_t                        minWidth;
    ///             uint32_t                        minHeight;
    ///             uint32_t                        maxWidth;
    ///             uint32_t                        maxHeight;
    ///             uint32_t                        maxNumRegionsOfInterest;
    ///         } VkPhysicalDeviceOpticalFlowPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceOpticalFlowPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedOutputGridSizes</c>
        /// </summary>
        [FieldOffset(16)]
        public VkOpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;

        /// <summary>
        ///     <c>SupportedHintGridSizes</c>
        /// </summary>
        [FieldOffset(20)]
        public VkOpticalFlowGridSizeFlagsNV SupportedHintGridSizes;

        /// <summary>
        ///     <c>HintSupported</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 HintSupported;

        /// <summary>
        ///     <c>CostSupported</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 CostSupported;

        /// <summary>
        ///     <c>BidirectionalFlowSupported</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 BidirectionalFlowSupported;

        /// <summary>
        ///     <c>GlobalFlowSupported</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 GlobalFlowSupported;

        /// <summary>
        ///     <c>MinWidth</c>
        /// </summary>
        [FieldOffset(40)]
        public int MinWidth;

        /// <summary>
        ///     <c>MinHeight</c>
        /// </summary>
        [FieldOffset(44)]
        public int MinHeight;

        /// <summary>
        ///     <c>MaxWidth</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxWidth;

        /// <summary>
        ///     <c>MaxHeight</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxHeight;

        /// <summary>
        ///     <c>MaxNumRegionsOfInterest</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxNumRegionsOfInterest;
    }
}
