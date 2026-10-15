namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHostImageCopyFeatures.html">VkPhysicalDeviceHostImageCopyFeatures</see> - Structure indicating support for copies to or from images from host memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceHostImageCopyFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceHostImageCopyFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hostImageCopy;
    ///         } VkPhysicalDeviceHostImageCopyFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceHostImageCopyFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceHostImageCopyFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HostImageCopy</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HostImageCopy;
    }
}
