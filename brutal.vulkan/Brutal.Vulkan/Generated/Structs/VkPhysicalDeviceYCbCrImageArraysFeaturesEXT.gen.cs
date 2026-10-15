namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceYcbcrImageArraysFeaturesEXT.html">VkPhysicalDeviceYcbcrImageArraysFeaturesEXT</see> - Structure describing extended {YCbCr} image creation features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceYcbcrImageArraysFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_ycbcr_image_arrays
    ///         typedef struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           ycbcrImageArrays;
    ///         } VkPhysicalDeviceYcbcrImageArraysFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceYCbCrImageArraysFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceYCbCrImageArraysFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>YcbcrImageArrays</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 YcbcrImageArrays;
    }
}
