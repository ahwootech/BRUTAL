namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixFlexibleDimensionsPropertiesNV.html">VkCooperativeMatrixFlexibleDimensionsPropertiesNV</see> - Structure specifying cooperative matrix properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCooperativeMatrixFlexibleDimensionsPropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix2
    ///         typedef struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              MGranularity;
    ///             uint32_t              NGranularity;
    ///             uint32_t              KGranularity;
    ///             VkComponentTypeKHR    AType;
    ///             VkComponentTypeKHR    BType;
    ///             VkComponentTypeKHR    CType;
    ///             VkComponentTypeKHR    ResultType;
    ///             VkBool32              saturatingAccumulation;
    ///             VkScopeKHR            scope;
    ///             uint32_t              workgroupInvocations;
    ///         } VkCooperativeMatrixFlexibleDimensionsPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CooperativeMatrixFlexibleDimensionsPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MGranularity</c> is the granularity of the number of rows in matrices <c>A</c>, <c>C</c>, and <c>Result</c>. The rows <i>must</i> be an integer multiple of this value.
        /// </summary>
        [FieldOffset(16)]
        public int MGranularity;

        /// <summary>
        ///     <c>NGranularity</c> is the granularity of columns in matrices <c>B</c>, <c>C</c>, <c>Result</c>. The columns <i>must</i> be an integer multiple of this value.
        /// </summary>
        [FieldOffset(20)]
        public int NGranularity;

        /// <summary>
        ///     <c>KGranularity</c> is the granularity of columns in matrix <c>A</c> and rows in matrix <c>B</c>. The columns/rows <i>must</i> be an integer multiple of this value.
        /// </summary>
        [FieldOffset(24)]
        public int KGranularity;

        /// <summary>
        ///     <c>AType</c> is the component type of matrix <c>A</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkComponentTypeKHR AType;

        /// <summary>
        ///     <c>BType</c> is the component type of matrix <c>B</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkComponentTypeKHR BType;

        /// <summary>
        ///     <c>CType</c> is the component type of matrix <c>C</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkComponentTypeKHR CType;

        /// <summary>
        ///     <c>ResultType</c> is the component type of matrix <c>Result</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkComponentTypeKHR ResultType;

        /// <summary>
        ///     <c>SaturatingAccumulation</c> indicates whether the <c>SaturatingAccumulation</c> operand to <c>OpCooperativeMatrixMulAddKHR</c> <i>must</i> be present or not. If it is <c>VK_TRUE</c>, the <c>SaturatingAccumulation</c> operand <i>must</i> be present. If it is <c>VK_FALSE</c>, the <c>SaturatingAccumulation</c> operand <i>must</i> not be present.
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 SaturatingAccumulation;

        /// <summary>
        ///     <c>Scope</c> is the scope of all the matrix types, of type <c>VkScopeKHR</c>.
        /// </summary>
        [FieldOffset(48)]
        public VkScopeKHR Scope;

        /// <summary>
        ///     <c>WorkgroupInvocations</c> is the number of invocations in the local workgroup when this combination of values is supported.
        /// </summary>
        [FieldOffset(52)]
        public int WorkgroupInvocations;
    }
}
