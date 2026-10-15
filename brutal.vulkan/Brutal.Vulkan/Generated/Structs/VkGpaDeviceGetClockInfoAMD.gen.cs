namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaDeviceGetClockInfoAMD.html">VkGpaDeviceGetClockInfoAMD</see> - Structure containing returned clock ratios or clock mode to set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGpaDeviceGetClockInfoAMD
    ///     </para>
    ///     <para>
    ///         The <c>VkGpaDeviceGetClockInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaDeviceGetClockInfoAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             float              memoryClockRatioToPeak;
    ///             float              engineClockRatioToPeak;
    ///             uint32_t           memoryClockFrequency;
    ///             uint32_t           engineClockFrequency;
    ///         } VkGpaDeviceGetClockInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkGpaDeviceGetClockInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GpaDeviceGetClockInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryClockRatioToPeak</c> is the returned ratio of the current memory clock to the maximum memory clock.
        /// </summary>
        [FieldOffset(16)]
        public float MemoryClockRatioToPeak;

        /// <summary>
        ///     <c>EngineClockRatioToPeak</c> is the returned ratio of the current engine clock to the maximum engine clock.
        /// </summary>
        [FieldOffset(20)]
        public float EngineClockRatioToPeak;

        /// <summary>
        ///     <c>MemoryClockFrequency</c> is the current memory clock frequency in MHz.
        /// </summary>
        [FieldOffset(24)]
        public int MemoryClockFrequency;

        /// <summary>
        ///     <c>EngineClockFrequency</c> is the current engine clock frequency in MHz.
        /// </summary>
        [FieldOffset(28)]
        public int EngineClockFrequency;
    }
}
