namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT.html">VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT</see> - Structure describing features to configure primitive restart index
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_primitive_restart_index
    ///         typedef struct VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           primitiveRestartIndex;
    ///         } VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePrimitiveRestartIndexFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrimitiveRestartIndex</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PrimitiveRestartIndex;
    }
}
