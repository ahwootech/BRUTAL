namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceToolProperties.html">VkPhysicalDeviceToolProperties</see> - Structure providing information about an active tool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceToolProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceToolProperties {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             char                  name[VK_MAX_EXTENSION_NAME_SIZE];
    ///             char                  version[VK_MAX_EXTENSION_NAME_SIZE];
    ///             VkToolPurposeFlags    purposes;
    ///             char                  description[VK_MAX_DESCRIPTION_SIZE];
    ///             char                  layer[VK_MAX_EXTENSION_NAME_SIZE];
    ///         } VkPhysicalDeviceToolProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 1048)]
    public unsafe partial struct VkPhysicalDeviceToolProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceToolProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte Name[256];

        ///
        [FieldOffset(272)]
        public fixed byte Version[256];

        /// <summary>
        ///     <c>Purposes</c> is a bitmask of <c>VkToolPurposeFlags</c> which is populated with purposes supported by the tool.
        /// </summary>
        [FieldOffset(528)]
        public VkToolPurposeFlags Purposes;

        ///
        [FieldOffset(532)]
        public fixed byte Description[256];

        ///
        [FieldOffset(788)]
        public fixed byte Layer[256];
    }
}
