namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCooperativeVectorPropertiesNV.html">VkCooperativeVectorPropertiesNV</see> - Structure specifying cooperative vector properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each <c>VkCooperativeVectorPropertiesNV</c> structure describes a single
    ///         supported combination of types for a matrix-vector multiply (or
    ///         multiply-add) operation (<c>OpCooperativeVectorMatrixMulNV</c> or
    ///         <c>OpCooperativeVectorMatrixMulAddNV</c>).
    ///     </para>
    ///     <para>
    ///         The <c>VkCooperativeVectorPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_vector
    ///         typedef struct VkCooperativeVectorPropertiesNV {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkComponentTypeKHR    inputType;
    ///             VkComponentTypeKHR    inputInterpretation;
    ///             VkComponentTypeKHR    matrixInterpretation;
    ///             VkComponentTypeKHR    biasInterpretation;
    ///             VkComponentTypeKHR    resultType;
    ///             VkBool32              transpose;
    ///         } VkCooperativeVectorPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCooperativeVectorPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CooperativeVectorPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>InputType</c> is the component type of vector <c>Input</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkComponentTypeKHR InputType;

        /// <summary>
        ///     <c>InputInterpretation</c> is the value of <c>InputInterpretation</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkComponentTypeKHR InputInterpretation;

        /// <summary>
        ///     <c>MatrixInterpretation</c> is the value of <c>MatrixInterpretation</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkComponentTypeKHR MatrixInterpretation;

        /// <summary>
        ///     <c>BiasInterpretation</c> is the value of <c>BiasInterpretation</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkComponentTypeKHR BiasInterpretation;

        /// <summary>
        ///     <c>ResultType</c> is the component type of <c>Result</c> <c>Type</c>, of type <c>VkComponentTypeKHR</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkComponentTypeKHR ResultType;

        /// <summary>
        ///     <c>Transpose</c> is a boolean indicating whether opaque layout matrices with this combination of input and output types supports transposition.
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 Transpose;
    }
}
