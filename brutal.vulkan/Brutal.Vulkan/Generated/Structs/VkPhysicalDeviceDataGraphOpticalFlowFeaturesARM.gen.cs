namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM.html">VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM</see> - Structure describing the data graph optical flow features supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dataGraphOpticalFlow;
    ///         } VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDataGraphOpticalFlowFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDataGraphOpticalFlowFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataGraphOpticalFlow</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DataGraphOpticalFlow;
    }
}
