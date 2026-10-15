namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCooperativeVectorMatrixLayoutNV.html">VkCooperativeVectorMatrixLayoutNV</see> - Specify cooperative vector matrix layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values for <c>VkCooperativeVectorMatrixLayoutNV</c> include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_vector
    ///         typedef enum VkCooperativeVectorMatrixLayoutNV {
    ///             VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV = 0,
    ///             VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV = 1,
    ///             VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV = 2,
    ///             VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV = 3,
    ///         } VkCooperativeVectorMatrixLayoutNV;
    ///     </code>
    /// </remarks>
    public enum VkCooperativeVectorMatrixLayoutNV : int
    {
        /// <summary>
        ///     <c>RowMajorNV</c> corresponds to SPIR-V <c>RowMajorNV</c> layout.
        /// </summary>
        RowMajorNV = 0,

        /// <summary>
        ///     <c>ColumnMajorNV</c> corresponds to SPIR-V <c>ColumnMajorNV</c> layout.
        /// </summary>
        ColumnMajorNV = 1,

        /// <summary>
        ///     <c>InferencingOptimalNV</c>  corresponds to SPIR-V <c>InferencingOptimalNV</c> layout.
        /// </summary>
        InferencingOptimalNV = 2,

        /// <summary>
        ///     <c>TrainingOptimalNV</c>  corresponds to SPIR-V <c>TrainingOptimalNV</c> layout.  All enum values match the corresponding SPIR-V value.  Row-major layout has elements of each row stored consecutively in memory, with a controllable stride from the start of one row to the start of the next row. Column-major layout has elements of each column stored consecutively in memory, with a controllable stride from the start of one column to the start of the next column. Inferencing-optimal and Training-optimal layouts are implementation-dependent, and the application <i>can</i> convert a matrix to those layouts using <c>vkConvertCooperativeVectorMatrixNV</c> or <c>vkCmdConvertCooperativeVectorMatrixNV</c>. Training-optimal layout with <c>VK_COMPONENT_TYPE_FLOAT16_KHR</c> or <c>VK_COMPONENT_TYPE_FLOAT32_KHR</c> type has the additional guarantee that the application <i>can</i> reinterpret the data as an array of elements and perform element-wise operations on the data, and finite values in any padding elements do not affect the result of a matrix-vector multiply (inf/NaN values may: still cause NaN values in the result).
        /// </summary>
        TrainingOptimalNV = 3,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
