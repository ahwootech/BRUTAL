namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGpaPropertiesAMD.html">VkPhysicalDeviceGpaPropertiesAMD</see> - Structure describing GPU performance API properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGpaPropertiesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkPhysicalDeviceGpaPropertiesAMD {
    ///             VkStructureType                          sType;
    ///             void*                                    pNext;
    ///             VkPhysicalDeviceGpaPropertiesFlagsAMD    flags;
    ///             VkDeviceSize                             maxSqttSeBufferSize;
    ///             uint32_t                                 shaderEngineCount;
    ///             uint32_t                                 perfBlockCount;
    ///             VkGpaPerfBlockPropertiesAMD*             pPerfBlocks;
    ///         } VkPhysicalDeviceGpaPropertiesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceGpaPropertiesAMD()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGpaPropertiesAMD;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceGpaPropertiesFlagsAMD Flags;

        /// <summary>
        ///     <c>MaxSqttSeBufferSize</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MaxSqttSeBufferSize;

        /// <summary>
        ///     <c>ShaderEngineCount</c>
        /// </summary>
        [FieldOffset(32)]
        public int ShaderEngineCount;

        /// <summary>
        ///     <c>PerfBlockCount</c>
        /// </summary>
        [FieldOffset(36)]
        public int PerfBlockCount;

        /// <summary>
        ///     <c>PerfBlocks</c>
        /// </summary>
        [FieldOffset(40)]
        public VkGpaPerfBlockPropertiesAMD* PerfBlocks;
    }
}
