namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT.html">VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT</see> - Structure describing whether the implementation supports pageable device-local memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_pageable_device_local_memory
    ///         typedef struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pageableDeviceLocalMemory;
    ///         } VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PageableDeviceLocalMemory</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PageableDeviceLocalMemory;
    }
}
