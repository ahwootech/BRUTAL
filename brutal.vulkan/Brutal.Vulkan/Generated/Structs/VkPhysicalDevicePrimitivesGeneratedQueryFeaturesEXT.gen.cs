namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT.html">VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT</see> - Structure describing support for primitives generated query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_primitives_generated_query
    ///         typedef struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           primitivesGeneratedQuery;
    ///             VkBool32           primitivesGeneratedQueryWithRasterizerDiscard;
    ///             VkBool32           primitivesGeneratedQueryWithNonZeroStreams;
    ///         } VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrimitivesGeneratedQuery</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PrimitivesGeneratedQuery;

        /// <summary>
        ///     <c>PrimitivesGeneratedQueryWithRasterizerDiscard</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PrimitivesGeneratedQueryWithRasterizerDiscard;

        /// <summary>
        ///     <c>PrimitivesGeneratedQueryWithNonZeroStreams</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 PrimitivesGeneratedQueryWithNonZeroStreams;
    }
}
