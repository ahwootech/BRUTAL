namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceIndexTypeUint8Features.html">VkPhysicalDeviceIndexTypeUint8Features</see> - Structure describing whether uint8 index type can be used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceIndexTypeUint8Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceIndexTypeUint8Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           indexTypeUint8;
    ///         } VkPhysicalDeviceIndexTypeUint8Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceIndexTypeUInt8Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceIndexTypeUInt8Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IndexTypeUint8</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 IndexTypeUint8;
    }
}
