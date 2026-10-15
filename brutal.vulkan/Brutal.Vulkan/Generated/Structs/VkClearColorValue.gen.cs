namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClearColorValue.html">VkClearColorValue</see> - Structure specifying a clear color value
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkClearColorValue</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef union VkClearColorValue {
    ///             float       float32[4];
    ///             int32_t     int32[4];
    ///             uint32_t    uint32[4];
    ///         } VkClearColorValue;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkClearColorValue()
    {
        /// <summary>
        ///     <c>Float32</c> are the color clear values when the format of the image or attachment is one of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-numericformat">numeric formats^</see> with a numeric type that is floating-point. Floating-point values are automatically converted to the format of the image, with the clear value being treated as linear if the image is sRGB.
        /// </summary>
        [FieldOffset(0)]
        public float4 Float32;

        /// <summary>
        ///     <c>Int32</c> are the color clear values when the format of the image or attachment has a numeric type that is signed integer (etext:SINT). Signed integer values are converted to the format of the image by casting to the smaller type (with negative 32-bit values mapping to negative values in the smaller type). If the integer clear value is not representable in the target type (e.g. would overflow in conversion to that type), the clear value is undefined:.
        /// </summary>
        [FieldOffset(0)]
        public int4 Int32;

        /// <summary>
        ///     <c>Uint32</c> are the color clear values when the format of the image or attachment has a numeric type that is unsigned integer (etext:UINT). Unsigned integer values are converted to the format of the image by casting to the integer type with fewer bits.
        /// </summary>
        [FieldOffset(0)]
        public uint4 Uint32;
    }
}
