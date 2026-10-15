namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV.html">VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV</see> - Structure describing the device-generated compute features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands_compute
    ///         typedef struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           deviceGeneratedCompute;
    ///             VkBool32           deviceGeneratedComputePipelines;
    ///             VkBool32           deviceGeneratedComputeCaptureReplay;
    ///         } VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceGeneratedCompute</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DeviceGeneratedCompute;

        /// <summary>
        ///     <c>DeviceGeneratedComputePipelines</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DeviceGeneratedComputePipelines;

        /// <summary>
        ///     <c>DeviceGeneratedComputeCaptureReplay</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DeviceGeneratedComputeCaptureReplay;
    }
}
