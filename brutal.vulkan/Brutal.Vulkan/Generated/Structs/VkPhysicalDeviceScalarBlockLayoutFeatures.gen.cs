namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceScalarBlockLayoutFeatures.html">VkPhysicalDeviceScalarBlockLayoutFeatures</see> - Structure indicating support for scalar block layouts
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceScalarBlockLayoutFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceScalarBlockLayoutFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           scalarBlockLayout;
    ///         } VkPhysicalDeviceScalarBlockLayoutFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ScalarBlockLayout</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ScalarBlockLayout;
    }
}
