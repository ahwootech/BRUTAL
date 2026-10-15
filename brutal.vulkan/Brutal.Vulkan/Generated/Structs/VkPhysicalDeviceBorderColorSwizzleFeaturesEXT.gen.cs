namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBorderColorSwizzleFeaturesEXT.html">VkPhysicalDeviceBorderColorSwizzleFeaturesEXT</see> - Structure describing whether samplers with custom border colors require the component swizzle specified in order to have defined behavior
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceBorderColorSwizzleFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_border_color_swizzle
    ///         typedef struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           borderColorSwizzle;
    ///             VkBool32           borderColorSwizzleFromImage;
    ///         } VkPhysicalDeviceBorderColorSwizzleFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceBorderColorSwizzleFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BorderColorSwizzle</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 BorderColorSwizzle;

        /// <summary>
        ///     <c>BorderColorSwizzleFromImage</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 BorderColorSwizzleFromImage;
    }
}
