namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCooperativeMatrixPropertiesNV.html">VkCooperativeMatrixPropertiesNV</see> - Structure specifying cooperative matrix properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCooperativeMatrixPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix
    ///         typedef struct VkCooperativeMatrixPropertiesNV {
    ///             VkStructureType      sType;
    ///             void*                pNext;
    ///             uint32_t             MSize;
    ///             uint32_t             NSize;
    ///             uint32_t             KSize;
    ///             VkComponentTypeNV    AType;
    ///             VkComponentTypeNV    BType;
    ///             VkComponentTypeNV    CType;
    ///             VkComponentTypeNV    DType;
    ///             VkScopeNV            scope;
    ///         } VkCooperativeMatrixPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCooperativeMatrixPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CooperativeMatrixPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MSize</c> is the number of rows in matrices A, C, and D.
        /// </summary>
        [FieldOffset(16)]
        public int MSize;

        /// <summary>
        ///     <c>NSize</c> is the number of columns in matrices B, C, D.
        /// </summary>
        [FieldOffset(20)]
        public int NSize;

        /// <summary>
        ///     <c>KSize</c> is the number of columns in matrix A and rows in matrix B.
        /// </summary>
        [FieldOffset(24)]
        public int KSize;

        /// <summary>
        ///     <c>AType</c> is the component type of matrix A, of type <c>VkComponentTypeNV</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkComponentTypeNV AType;

        /// <summary>
        ///     <c>BType</c> is the component type of matrix B, of type <c>VkComponentTypeNV</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkComponentTypeNV BType;

        /// <summary>
        ///     <c>CType</c> is the component type of matrix C, of type <c>VkComponentTypeNV</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkComponentTypeNV CType;

        /// <summary>
        ///     <c>DType</c> is the component type of matrix D, of type <c>VkComponentTypeNV</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkComponentTypeNV DType;

        /// <summary>
        ///     <c>Scope</c> is the scope of all the matrix types, of type <c>VkScopeNV</c>.
        /// </summary>
        [FieldOffset(44)]
        public VkScopeNV Scope;
    }
}
