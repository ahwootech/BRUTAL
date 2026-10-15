namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGpaFeaturesAMD.html">VkPhysicalDeviceGpaFeaturesAMD</see> - Structure describing support for GPU performance API
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGpaFeaturesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkPhysicalDeviceGpaFeaturesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           perfCounters;
    ///             VkBool32           streamingPerfCounters;
    ///             VkBool32           sqThreadTracing;
    ///             VkBool32           clockModes;
    ///         } VkPhysicalDeviceGpaFeaturesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceGpaFeaturesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGpaFeaturesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerfCounters</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerfCounters;

        /// <summary>
        ///     <c>StreamingPerfCounters</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 StreamingPerfCounters;

        /// <summary>
        ///     <c>SqThreadTracing</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 SqThreadTracing;

        /// <summary>
        ///     <c>ClockModes</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ClockModes;
    }
}
