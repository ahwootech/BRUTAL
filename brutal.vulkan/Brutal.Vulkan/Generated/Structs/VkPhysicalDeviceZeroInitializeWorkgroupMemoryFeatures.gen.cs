namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures.html">VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures</see> - Structure describing support for zero initialization of workgroup memory by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderZeroInitializeWorkgroupMemory;
    ///         } VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderZeroInitializeWorkgroupMemory</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderZeroInitializeWorkgroupMemory;
    }
}
