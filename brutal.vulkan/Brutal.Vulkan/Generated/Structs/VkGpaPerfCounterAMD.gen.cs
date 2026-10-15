namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaPerfCounterAMD.html">VkGpaPerfCounterAMD</see> - Structure specifying parameters of a GPA sample
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGpaPerfCounterAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaPerfCounterAMD {
    ///             VkGpaPerfBlockAMD    blockType;
    ///             uint32_t             blockInstance;
    ///             uint32_t             eventID;
    ///         } VkGpaPerfCounterAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkGpaPerfCounterAMD()
    {
        /// <summary>
        ///     <c>BlockType</c> is a <c>VkGpaPerfBlockAMD</c> value specifying the GPU block type to sample.
        /// </summary>
        [FieldOffset(0)]
        public VkGpaPerfBlockAMD BlockType;

        /// <summary>
        ///     <c>BlockInstance</c> is a value specifying which instance of the GPU block to sample.
        /// </summary>
        [FieldOffset(4)]
        public int BlockInstance;

        /// <summary>
        ///     <c>EventID</c> is a value specifying the hardware-specific identifier of the performance counter to sample.
        /// </summary>
        [FieldOffset(8)]
        public int EventID;
    }
}
