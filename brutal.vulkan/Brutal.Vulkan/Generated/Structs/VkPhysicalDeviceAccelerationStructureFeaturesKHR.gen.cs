namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructureFeaturesKHR.html">VkPhysicalDeviceAccelerationStructureFeaturesKHR</see> - Structure describing the acceleration structure features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceAccelerationStructureFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkPhysicalDeviceAccelerationStructureFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           accelerationStructure;
    ///             VkBool32           accelerationStructureCaptureReplay;
    ///             VkBool32           accelerationStructureIndirectBuild;
    ///             // accelerationStructureHostCommands is legacy, but no reason was given in the API XML
    ///             VkBool32           accelerationStructureHostCommands;
    ///             VkBool32           descriptorBindingAccelerationStructureUpdateAfterBind;
    ///         } VkPhysicalDeviceAccelerationStructureFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructure</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AccelerationStructure;

        /// <summary>
        ///     <c>AccelerationStructureCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 AccelerationStructureCaptureReplay;

        /// <summary>
        ///     <c>AccelerationStructureIndirectBuild</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 AccelerationStructureIndirectBuild;

        /// <summary>
        ///     <c>AccelerationStructureHostCommands</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 AccelerationStructureHostCommands;

        /// <summary>
        ///     <c>DescriptorBindingAccelerationStructureUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 DescriptorBindingAccelerationStructureUpdateAfterBind;
    }
}
