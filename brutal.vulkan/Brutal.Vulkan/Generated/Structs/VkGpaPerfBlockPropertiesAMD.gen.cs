namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaPerfBlockPropertiesAMD.html">VkGpaPerfBlockPropertiesAMD</see> - Structure describing GPU performance API block properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGpaPerfBlockPropertiesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaPerfBlockPropertiesAMD {
    ///             VkGpaPerfBlockAMD                   blockType;
    ///             VkGpaPerfBlockPropertiesFlagsAMD    flags;
    ///             uint32_t                            instanceCount;
    ///             uint32_t                            maxEventID;
    ///             uint32_t                            maxGlobalOnlyCounters;
    ///             uint32_t                            maxGlobalSharedCounters;
    ///             uint32_t                            maxStreamingCounters;
    ///         } VkGpaPerfBlockPropertiesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct VkGpaPerfBlockPropertiesAMD()
    {
        /// <summary>
        ///     <c>BlockType</c>
        /// </summary>
        [FieldOffset(0)]
        public VkGpaPerfBlockAMD BlockType;

        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(4)]
        public VkGpaPerfBlockPropertiesFlagsAMD Flags;

        /// <summary>
        ///     <c>InstanceCount</c>
        /// </summary>
        [FieldOffset(8)]
        public int InstanceCount;

        /// <summary>
        ///     <c>MaxEventID</c>
        /// </summary>
        [FieldOffset(12)]
        public int MaxEventID;

        /// <summary>
        ///     <c>MaxGlobalOnlyCounters</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxGlobalOnlyCounters;

        /// <summary>
        ///     <c>MaxGlobalSharedCounters</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxGlobalSharedCounters;

        /// <summary>
        ///     <c>MaxStreamingCounters</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxStreamingCounters;
    }
}
