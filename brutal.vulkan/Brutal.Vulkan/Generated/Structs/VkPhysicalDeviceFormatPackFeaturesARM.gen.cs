namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFormatPackFeaturesARM.html">VkPhysicalDeviceFormatPackFeaturesARM</see> - Structure describing whether the additional formats feature is supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFormatPackFeaturesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_format_pack
    ///         typedef struct VkPhysicalDeviceFormatPackFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           formatPack;
    ///         } VkPhysicalDeviceFormatPackFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFormatPackFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFormatPackFeaturesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FormatPack</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FormatPack;
    }
}
