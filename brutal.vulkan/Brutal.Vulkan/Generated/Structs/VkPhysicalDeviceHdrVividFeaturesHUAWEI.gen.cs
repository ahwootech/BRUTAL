namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHdrVividFeaturesHUAWEI.html">VkPhysicalDeviceHdrVividFeaturesHUAWEI</see> - Structure describing whether HDR Vivid metadata is supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceHdrVividFeaturesHUAWEI</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_hdr_vivid
    ///         typedef struct VkPhysicalDeviceHdrVividFeaturesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hdrVivid;
    ///         } VkPhysicalDeviceHdrVividFeaturesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceHdrVividFeaturesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceHdrVividFeaturesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HdrVivid</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HdrVivid;
    }
}
