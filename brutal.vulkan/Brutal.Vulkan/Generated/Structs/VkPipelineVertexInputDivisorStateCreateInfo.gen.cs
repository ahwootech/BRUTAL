namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputDivisorStateCreateInfo.html">VkPipelineVertexInputDivisorStateCreateInfo</see> - Structure specifying vertex attributes assignment during instanced rendering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-vertexAttributeInstanceRateDivisor"><c>vertexAttributeInstanceRateDivisor</c>^</see> feature is enabled and the
    ///         <c>pNext</c> chain of <c>VkPipelineVertexInputStateCreateInfo</c> includes a
    ///         <c>VkPipelineVertexInputDivisorStateCreateInfo</c> structure, then that
    ///         structure controls how vertex attributes are assigned to an instance when
    ///         instanced rendering is enabled.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineVertexInputDivisorStateCreateInfo</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPipelineVertexInputDivisorStateCreateInfo {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             uint32_t                                         vertexBindingDivisorCount;
    ///             const VkVertexInputBindingDivisorDescription*    pVertexBindingDivisors;
    ///         } VkPipelineVertexInputDivisorStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineVertexInputDivisorStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexBindingDivisorCount</c> is the number of elements in the <c>pVertexBindingDivisors</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int VertexBindingDivisorCount;

        /// <summary>
        ///     <c>VertexBindingDivisors</c> is a pointer to an array of <c>VkVertexInputBindingDivisorDescription</c> structures specifying the divisor value for each binding.
        /// </summary>
        [FieldOffset(24)]
        public VkVertexInputBindingDivisorDescription* VertexBindingDivisors;
    }
}
