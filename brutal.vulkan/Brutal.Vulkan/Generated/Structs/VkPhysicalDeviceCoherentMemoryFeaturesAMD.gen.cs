namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCoherentMemoryFeaturesAMD.html">VkPhysicalDeviceCoherentMemoryFeaturesAMD</see> - Structure describing whether device coherent memory can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCoherentMemoryFeaturesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_device_coherent_memory
    ///         typedef struct VkPhysicalDeviceCoherentMemoryFeaturesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           deviceCoherentMemory;
    ///         } VkPhysicalDeviceCoherentMemoryFeaturesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceCoherentMemory</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DeviceCoherentMemory;
    }
}
