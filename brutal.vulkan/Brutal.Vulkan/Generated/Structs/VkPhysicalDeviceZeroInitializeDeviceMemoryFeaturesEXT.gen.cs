namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT.html">VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT</see> - Structure describing whether the implementation supports cleared allocation functionality
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_zero_initialize_device_memory
    ///         typedef struct VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           zeroInitializeDeviceMemory;
    ///         } VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ZeroInitializeDeviceMemory</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ZeroInitializeDeviceMemory;
    }
}
