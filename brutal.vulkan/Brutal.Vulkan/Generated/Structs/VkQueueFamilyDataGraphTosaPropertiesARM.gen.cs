namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyDataGraphTOSAPropertiesARM.html">VkQueueFamilyDataGraphTOSAPropertiesARM</see> - Structure describing the TOSA properties of a processing engine and operation set for a specific queue family of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyDataGraphTOSAPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_instruction_set_tosa
    ///         typedef struct VkQueueFamilyDataGraphTOSAPropertiesARM {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             uint32_t                                profileCount;
    ///             const VkDataGraphTOSANameQualityARM*    pProfiles;
    ///             uint32_t                                extensionCount;
    ///             const VkDataGraphTOSANameQualityARM*    pExtensions;
    ///             VkDataGraphTOSALevelARM                 level;
    ///         } VkQueueFamilyDataGraphTOSAPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkQueueFamilyDataGraphTosaPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyDataGraphTosaPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProfileCount</c> is the length of the <c>pProfiles</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int ProfileCount;

        /// <summary>
        ///     <c>Profiles</c> is a pointer to an array of <c>VkDataGraphTOSANameQualityARM</c> structures describing the TOSA profiles supported.
        /// </summary>
        [FieldOffset(24)]
        public VkDataGraphTosaNameQualityARM* Profiles;

        /// <summary>
        ///     <c>ExtensionCount</c> is the length of the <c>pExtensions</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int ExtensionCount;

        /// <summary>
        ///     <c>Extensions</c> is a pointer to an array of <c>VkDataGraphTOSANameQualityARM</c> structures describing the TOSA extensions supported.
        /// </summary>
        [FieldOffset(40)]
        public VkDataGraphTosaNameQualityARM* Extensions;

        /// <summary>
        ///     <c>Level</c> is a <c>VkDataGraphTOSALevelARM</c> describing the TOSA level supported.
        /// </summary>
        [FieldOffset(48)]
        public VkDataGraphTosaLevelARM Level;
    }
}
