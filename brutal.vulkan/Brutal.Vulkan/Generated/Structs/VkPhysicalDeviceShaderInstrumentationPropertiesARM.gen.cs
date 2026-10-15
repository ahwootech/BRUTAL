namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderInstrumentationPropertiesARM.html">VkPhysicalDeviceShaderInstrumentationPropertiesARM</see> - Structure describing shader instrumentation properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderInstrumentationPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_instrumentation
    ///         typedef struct VkPhysicalDeviceShaderInstrumentationPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           numMetrics;
    ///             VkBool32           perBasicBlockGranularity;
    ///         } VkPhysicalDeviceShaderInstrumentationPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderInstrumentationPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderInstrumentationPropertiesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NumMetrics</c>
        /// </summary>
        [FieldOffset(16)]
        public int NumMetrics;

        /// <summary>
        ///     <c>PerBasicBlockGranularity</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PerBasicBlockGranularity;
    }
}
