namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixPropertiesKHR.html">VkCooperativeMatrixPropertiesKHR</see> - Structure specifying cooperative matrix properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCooperativeMatrixPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_cooperative_matrix
    ///         typedef struct VkCooperativeMatrixPropertiesKHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              MSize;
    ///             uint32_t              NSize;
    ///             uint32_t              KSize;
    ///             VkComponentTypeKHR    AType;
    ///             VkComponentTypeKHR    BType;
    ///             VkComponentTypeKHR    CType;
    ///             VkComponentTypeKHR    ResultType;
    ///             VkBool32              saturatingAccumulation;
    ///             VkScopeKHR            scope;
    ///         } VkCooperativeMatrixPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCooperativeMatrixPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CooperativeMatrixPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MSize</c> is the number of rows in matrices <c>A</c>, <c>C</c>, and <c>Result</c>.
        /// </summary>
        [FieldOffset(16)]
        public int MSize;

        /// <summary>
        ///     <c>NSize</c> is the number of columns in matrices <c>B</c>, <c>C</c>, <c>Result</c>.
        /// </summary>
        [FieldOffset(20)]
        public int NSize;

        /// <summary>
        ///     <c>KSize</c> is the number of columns in matrix <c>A</c> and rows in matrix <c>B</c>.
        /// </summary>
        [FieldOffset(24)]
        public int KSize;

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
    }
}
