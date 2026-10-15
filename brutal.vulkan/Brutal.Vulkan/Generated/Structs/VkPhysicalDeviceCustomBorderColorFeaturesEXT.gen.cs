namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCustomBorderColorFeaturesEXT.html">VkPhysicalDeviceCustomBorderColorFeaturesEXT</see> - Structure describing whether custom border colors can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCustomBorderColorFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_custom_border_color
    ///         typedef struct VkPhysicalDeviceCustomBorderColorFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           customBorderColors;
    ///             VkBool32           customBorderColorWithoutFormat;
    ///         } VkPhysicalDeviceCustomBorderColorFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCustomBorderColorFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCustomBorderColorFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CustomBorderColors</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CustomBorderColors;

        /// <summary>
        ///     <c>CustomBorderColorWithoutFormat</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CustomBorderColorWithoutFormat;
    }
}
