namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueDataINTEL.html">VkPerformanceValueDataINTEL</see> - Values returned for the parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceValueDataINTEL</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef union VkPerformanceValueDataINTEL {
    ///             uint32_t       value32;
    ///             uint64_t       value64;
    ///             float          valueFloat;
    ///             VkBool32       valueBool;
    ///             const char*    valueString;
    ///         } VkPerformanceValueDataINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkPerformanceValueDataINTEL()
    {
        /// <summary>
        ///     <c>Value32</c> represents 32-bit integer data.
        /// </summary>
        [FieldOffset(0)]
        public int Value32;

        /// <summary>
        ///     <c>Value64</c> represents 64-bit integer data.
        /// </summary>
        [FieldOffset(0)]
        public nint Value64;

        /// <summary>
        ///     <c>ValueFloat</c> represents floating-point data.
        /// </summary>
        [FieldOffset(0)]
        public float ValueFloat;

        /// <summary>
        ///     <c>ValueBool</c> represents basetype:VkBool32 data.
        /// </summary>
        [FieldOffset(0)]
        public Brutal.Bool32 ValueBool;

        /// <summary>
        ///     <c>ValueString</c> represents a pointer to a null-terminated UTF-8 string.
        /// </summary>
        [FieldOffset(0)]
        public byte* ValueString;
    }
}
