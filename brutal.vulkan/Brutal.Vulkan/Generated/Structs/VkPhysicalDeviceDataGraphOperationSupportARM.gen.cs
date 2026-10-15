namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphOperationSupportARM.html">VkPhysicalDeviceDataGraphOperationSupportARM</see> - Structure describing an operation or set of operations supported by a data graph processing engine
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphOperationSupportARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkPhysicalDeviceDataGraphOperationSupportARM {
    ///             VkPhysicalDeviceDataGraphOperationTypeARM    operationType;
    ///             char                                         name[VK_MAX_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_SET_NAME_SIZE_ARM];
    ///             uint32_t                                     version;
    ///         } VkPhysicalDeviceDataGraphOperationSupportARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public unsafe partial struct VkPhysicalDeviceDataGraphOperationSupportARM()
    {
        /// <summary>
        ///     <c>OperationType</c> is a <c>VkPhysicalDeviceDataGraphOperationTypeARM</c> enum specifying the type of the operation whose support is being described.
        /// </summary>
        [FieldOffset(0)]
        public VkPhysicalDeviceDataGraphOperationTypeARM OperationType;

        ///
        [FieldOffset(4)]
        public fixed byte Name[128];

        /// <summary>
        ///     <c>Version</c> is an integer specifying the version of the operation whose support is being described.
        /// </summary>
        [FieldOffset(132)]
        public int Version;
    }
}
