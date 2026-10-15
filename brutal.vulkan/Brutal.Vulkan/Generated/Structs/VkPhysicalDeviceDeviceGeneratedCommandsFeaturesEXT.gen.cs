namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT.html">VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT</see> - Structure describing the device-generated compute features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           deviceGeneratedCommands;
    ///             VkBool32           dynamicGeneratedPipelineLayout;
    ///         } VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceGeneratedCommands</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DeviceGeneratedCommands;

        /// <summary>
        ///     <c>DynamicGeneratedPipelineLayout</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DynamicGeneratedPipelineLayout;
    }
}
