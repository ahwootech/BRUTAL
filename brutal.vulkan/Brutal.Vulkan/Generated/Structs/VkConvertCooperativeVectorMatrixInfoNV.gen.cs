namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConvertCooperativeVectorMatrixInfoNV.html">VkConvertCooperativeVectorMatrixInfoNV</see> - Structure specifying a request to convert the layout and type of a cooperative vector matrix
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each <c>VkConvertCooperativeVectorMatrixInfoNV</c> structure describes a
    ///         request to convert the layout and type of a cooperative vector matrix.
    ///     </para>
    ///     <para>
    ///         The <c>VkConvertCooperativeVectorMatrixInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_vector
    ///         typedef struct VkConvertCooperativeVectorMatrixInfoNV {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             size_t                               srcSize;
    ///             VkDeviceOrHostAddressConstKHR        srcData;
    ///             size_t*                              pDstSize;
    ///             VkDeviceOrHostAddressKHR             dstData;
    ///             VkComponentTypeKHR                   srcComponentType;
    ///             VkComponentTypeKHR                   dstComponentType;
    ///             uint32_t                             numRows;
    ///             uint32_t                             numColumns;
    ///             VkCooperativeVectorMatrixLayoutNV    srcLayout;
    ///             size_t                               srcStride;
    ///             VkCooperativeVectorMatrixLayoutNV    dstLayout;
    ///             size_t                               dstStride;
    ///         } VkConvertCooperativeVectorMatrixInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkConvertCooperativeVectorMatrixInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ConvertCooperativeVectorMatrixInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcSize</c> is the length in bytes of <c>srcData</c>.
        /// </summary>
        [FieldOffset(16)]
        public nuint SrcSize;

        /// <summary>
        ///     <c>SrcData</c> is either `NULL` or a pointer to the source data in the source layout.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR SrcData;

        /// <summary>
        ///     <c>DstSize</c> is a pointer to an integer related to the number of bytes required or requested to convert.
        /// </summary>
        [FieldOffset(32)]
        public nuint* DstSize;

        /// <summary>
        ///     <c>DstData</c> is either `NULL` or a pointer to the destination data in the destination layout.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceOrHostAddressKHR DstData;

        /// <summary>
        ///     <c>SrcComponentType</c> is the type of a source matrix element.
        /// </summary>
        [FieldOffset(48)]
        public VkComponentTypeKHR SrcComponentType;

        /// <summary>
        ///     <c>DstComponentType</c> is the type of a destination matrix element.
        /// </summary>
        [FieldOffset(52)]
        public VkComponentTypeKHR DstComponentType;

        /// <summary>
        ///     <c>NumRows</c> is the number of rows in the matrix.
        /// </summary>
        [FieldOffset(56)]
        public int NumRows;

        /// <summary>
        ///     <c>NumColumns</c> is the number of columns in the matrix.
        /// </summary>
        [FieldOffset(60)]
        public int NumColumns;

        /// <summary>
        ///     <c>SrcLayout</c> is the layout of the source matrix.
        /// </summary>
        [FieldOffset(64)]
        public VkCooperativeVectorMatrixLayoutNV SrcLayout;

        /// <summary>
        ///     <c>SrcStride</c> is the number of bytes between a consecutive row or column (depending on <c>srcLayout</c>) of the source matrix, if it is row-major or column-major.
        /// </summary>
        [FieldOffset(72)]
        public nuint SrcStride;

        /// <summary>
        ///     <c>DstLayout</c> is the layout the matrix is converted to.
        /// </summary>
        [FieldOffset(80)]
        public VkCooperativeVectorMatrixLayoutNV DstLayout;

        /// <summary>
        ///     <c>DstStride</c> is the number of bytes between a consecutive row or column (depending on <c>dstLayout</c>) of destination matrix, if it is row-major or column-major.
        /// </summary>
        [FieldOffset(88)]
        public nuint DstStride;
    }
}
