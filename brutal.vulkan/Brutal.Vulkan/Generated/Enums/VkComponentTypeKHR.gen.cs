namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComponentTypeKHR.html">VkComponentTypeKHR</see> - Specify SPIR-V cooperative matrix component type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values for <c>VkComponentTypeKHR</c> include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_cooperative_matrix, VK_NV_cooperative_vector
    ///         typedef enum VkComponentTypeKHR {
    ///             VK_COMPONENT_TYPE_FLOAT16_KHR = 0,
    ///             VK_COMPONENT_TYPE_FLOAT32_KHR = 1,
    ///             VK_COMPONENT_TYPE_FLOAT64_KHR = 2,
    ///             VK_COMPONENT_TYPE_SINT8_KHR = 3,
    ///             VK_COMPONENT_TYPE_SINT16_KHR = 4,
    ///             VK_COMPONENT_TYPE_SINT32_KHR = 5,
    ///             VK_COMPONENT_TYPE_SINT64_KHR = 6,
    ///             VK_COMPONENT_TYPE_UINT8_KHR = 7,
    ///             VK_COMPONENT_TYPE_UINT16_KHR = 8,
    ///             VK_COMPONENT_TYPE_UINT32_KHR = 9,
    ///             VK_COMPONENT_TYPE_UINT64_KHR = 10,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_KHR_shader_bfloat16
    ///             VK_COMPONENT_TYPE_BFLOAT16_KHR = 1000141000,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_COMPONENT_TYPE_SINT8_PACKED_NV = 1000491000,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_COMPONENT_TYPE_UINT8_PACKED_NV = 1000491001,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_float8
    ///             VK_COMPONENT_TYPE_FLOAT8_E4M3_EXT = 1000491002,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_float8
    ///             VK_COMPONENT_TYPE_FLOAT8_E5M2_EXT = 1000491003,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_ocp_microscaling_types
    ///             VK_COMPONENT_TYPE_FLOAT6_E2M3_EXT = 1000672000,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_ocp_microscaling_types
    ///             VK_COMPONENT_TYPE_FLOAT6_E3M2_EXT = 1000672001,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_ocp_microscaling_types
    ///             VK_COMPONENT_TYPE_FLOAT4_E2M1_EXT = 1000672002,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_ocp_microscaling_types
    ///             VK_COMPONENT_TYPE_FLOAT8_UNSIGNED_E8M0_EXT = 1000672003,
    ///             // Provided by VK_KHR_cooperative_matrix with VK_EXT_shader_ocp_microscaling_types
    ///             VK_COMPONENT_TYPE_MXINT8_EXT = 1000672004,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_FLOAT16_NV = VK_COMPONENT_TYPE_FLOAT16_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_FLOAT32_NV = VK_COMPONENT_TYPE_FLOAT32_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_FLOAT64_NV = VK_COMPONENT_TYPE_FLOAT64_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_SINT8_NV = VK_COMPONENT_TYPE_SINT8_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_SINT16_NV = VK_COMPONENT_TYPE_SINT16_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_SINT32_NV = VK_COMPONENT_TYPE_SINT32_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_SINT64_NV = VK_COMPONENT_TYPE_SINT64_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_UINT8_NV = VK_COMPONENT_TYPE_UINT8_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_UINT16_NV = VK_COMPONENT_TYPE_UINT16_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_UINT32_NV = VK_COMPONENT_TYPE_UINT32_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_COMPONENT_TYPE_UINT64_NV = VK_COMPONENT_TYPE_UINT64_KHR,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_COMPONENT_TYPE_FLOAT_E4M3_NV = VK_COMPONENT_TYPE_FLOAT8_E4M3_EXT,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_COMPONENT_TYPE_FLOAT_E5M2_NV = VK_COMPONENT_TYPE_FLOAT8_E5M2_EXT,
    ///         } VkComponentTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkComponentTypeKHR : int
    {
        /// <summary>
        ///     <c>Float16KHR</c> corresponds to SPIR-V <c>OpTypeFloat</c> 16.
        /// </summary>
        Float16KHR = 0,

        /// <summary>
        ///     <c>Float32KHR</c> corresponds to SPIR-V <c>OpTypeFloat</c> 32.
        /// </summary>
        Float32KHR = 1,

        /// <summary>
        ///     <c>Float64KHR</c> corresponds to SPIR-V <c>OpTypeFloat</c> 64.
        /// </summary>
        Float64KHR = 2,

        /// <summary>
        ///     <c>SInt8KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 8 0/1.
        /// </summary>
        SInt8KHR = 3,

        /// <summary>
        ///     <c>SInt16KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 16 0/1.
        /// </summary>
        SInt16KHR = 4,

        /// <summary>
        ///     <c>SInt32KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 32 0/1.
        /// </summary>
        SInt32KHR = 5,

        /// <summary>
        ///     <c>SInt64KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 64 0/1.
        /// </summary>
        SInt64KHR = 6,

        /// <summary>
        ///     <c>UInt8KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 8 0/1.
        /// </summary>
        UInt8KHR = 7,

        /// <summary>
        ///     <c>UInt16KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 16 0/1.
        /// </summary>
        UInt16KHR = 8,

        /// <summary>
        ///     <c>UInt32KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 32 0/1.
        /// </summary>
        UInt32KHR = 9,

        /// <summary>
        ///     <c>UInt64KHR</c> corresponds to SPIR-V <c>OpTypeInt</c> 64 0/1.
        /// </summary>
        UInt64KHR = 10,

        /// <summary>
        ///     <c>Bfloat16KHR</c>
        /// </summary>
        Bfloat16KHR = 1000141000,

        /// <summary>
        ///     <c>SInt8PackedNV</c> corresponds to four 8-bit signed integers packed in a 32-bit unsigned integer.
        /// </summary>
        SInt8PackedNV = 1000491000,

        /// <summary>
        ///     <c>UInt8PackedNV</c> corresponds to four 8-bit unsigned integers packed in a 32-bit unsigned integer.
        /// </summary>
        UInt8PackedNV = 1000491001,

        /// <summary>
        ///     <c>Float8E4M3EXT</c>
        /// </summary>
        Float8E4M3EXT = 1000491002,

        /// <summary>
        ///     <c>Float8E5M2EXT</c>
        /// </summary>
        Float8E5M2EXT = 1000491003,

        /// <summary>
        ///     <c>Float6E2M3EXT</c>
        /// </summary>
        Float6E2M3EXT = 1000672000,

        /// <summary>
        ///     <c>Float6E3M2EXT</c>
        /// </summary>
        Float6E3M2EXT = 1000672001,

        /// <summary>
        ///     <c>Float4E2M1EXT</c>
        /// </summary>
        Float4E2M1EXT = 1000672002,

        /// <summary>
        ///     <c>Float8UnsignedE8M0EXT</c>
        /// </summary>
        Float8UnsignedE8M0EXT = 1000672003,

        /// <summary>
        ///     <c>Mxint8EXT</c>
        /// </summary>
        Mxint8EXT = 1000672004,

        /// <summary>
        ///     <c>Float16NV</c>
        /// </summary>
        Float16NV = Float16KHR,

        /// <summary>
        ///     <c>Float32NV</c>
        /// </summary>
        Float32NV = Float32KHR,

        /// <summary>
        ///     <c>Float64NV</c>
        /// </summary>
        Float64NV = Float64KHR,

        /// <summary>
        ///     <c>SInt8NV</c>
        /// </summary>
        SInt8NV = SInt8KHR,

        /// <summary>
        ///     <c>SInt16NV</c>
        /// </summary>
        SInt16NV = SInt16KHR,

        /// <summary>
        ///     <c>SInt32NV</c>
        /// </summary>
        SInt32NV = SInt32KHR,

        /// <summary>
        ///     <c>SInt64NV</c>
        /// </summary>
        SInt64NV = SInt64KHR,

        /// <summary>
        ///     <c>UInt8NV</c>
        /// </summary>
        UInt8NV = UInt8KHR,

        /// <summary>
        ///     <c>UInt16NV</c>
        /// </summary>
        UInt16NV = UInt16KHR,

        /// <summary>
        ///     <c>UInt32NV</c>
        /// </summary>
        UInt32NV = UInt32KHR,

        /// <summary>
        ///     <c>UInt64NV</c>
        /// </summary>
        UInt64NV = UInt64KHR,

        /// <summary>
        ///     <c>FloatE4M3NV</c>
        /// </summary>
        FloatE4M3NV = Float8E4M3EXT,

        /// <summary>
        ///     <c>FloatE5M2NV</c>
        /// </summary>
        FloatE5M2NV = Float8E5M2EXT,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
