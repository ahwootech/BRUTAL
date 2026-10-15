namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowImageFormatPropertiesARM.html">VkDataGraphOpticalFlowImageFormatPropertiesARM</see> - Structure describing properties of an optical flow image format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphOpticalFlowImageFormatPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphOpticalFlowImageFormatPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkFormat           format;
    ///         } VkDataGraphOpticalFlowImageFormatPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphOpticalFlowImageFormatPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphOpticalFlowImageFormatPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c>
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;
    }
}
