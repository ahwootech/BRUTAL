namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyDataGraphOpticalFlowPropertiesARM.html">VkQueueFamilyDataGraphOpticalFlowPropertiesARM</see> - Structure describing optical flow properties of a processing engine and operation set for a specific queue family of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkQueueFamilyDataGraphOpticalFlowPropertiesARM
    ///     </para>
    ///     <para>
    ///         The <c>VkQueueFamilyDataGraphOpticalFlowPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkQueueFamilyDataGraphOpticalFlowPropertiesARM {
    ///             VkStructureType                           sType;
    ///             void*                                     pNext;
    ///             VkDataGraphOpticalFlowGridSizeFlagsARM    supportedOutputGridSizes;
    ///             VkDataGraphOpticalFlowGridSizeFlagsARM    supportedHintGridSizes;
    ///             VkBool32                                  hintSupported;
    ///             VkBool32                                  costSupported;
    ///             uint32_t                                  minWidth;
    ///             uint32_t                                  minHeight;
    ///             uint32_t                                  maxWidth;
    ///             uint32_t                                  maxHeight;
    ///         } VkQueueFamilyDataGraphOpticalFlowPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkQueueFamilyDataGraphOpticalFlowPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyDataGraphOpticalFlowPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedOutputGridSizes</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphOpticalFlowGridSizeFlagsARM SupportedOutputGridSizes;

        /// <summary>
        ///     <c>SupportedHintGridSizes</c>
        /// </summary>
        [FieldOffset(20)]
        public VkDataGraphOpticalFlowGridSizeFlagsARM SupportedHintGridSizes;

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
        ///     <c>MinWidth</c>
        /// </summary>
        [FieldOffset(32)]
        public int MinWidth;

        /// <summary>
        ///     <c>MinHeight</c>
        /// </summary>
        [FieldOffset(36)]
        public int MinHeight;

        /// <summary>
        ///     <c>MaxWidth</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxWidth;

        /// <summary>
        ///     <c>MaxHeight</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxHeight;
    }
}
