namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGpaProperties2AMD.html">VkPhysicalDeviceGpaProperties2AMD</see> - Structure describing additional GPU performance API properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGpaProperties2AMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkPhysicalDeviceGpaProperties2AMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           revisionId;
    ///         } VkPhysicalDeviceGpaProperties2AMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceGpaProperties2AMD()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGpaProperties2AMD;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RevisionId</c>
        /// </summary>
        [FieldOffset(16)]
        public int RevisionId;
    }
}
