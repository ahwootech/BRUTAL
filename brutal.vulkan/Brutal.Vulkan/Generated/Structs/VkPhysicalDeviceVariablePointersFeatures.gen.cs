namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVariablePointersFeatures.html">VkPhysicalDeviceVariablePointersFeatures</see> - Structure describing variable pointers features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVariablePointersFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceVariablePointersFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           variablePointersStorageBuffer;
    ///             VkBool32           variablePointers;
    ///         } VkPhysicalDeviceVariablePointersFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVariablePointersFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VariablePointersStorageBuffer</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VariablePointersStorageBuffer;

        /// <summary>
        ///     <c>VariablePointers</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 VariablePointers;
    }
}
