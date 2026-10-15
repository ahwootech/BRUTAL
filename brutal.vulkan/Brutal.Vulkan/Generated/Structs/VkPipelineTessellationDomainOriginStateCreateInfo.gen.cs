namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineTessellationDomainOriginStateCreateInfo.html">VkPipelineTessellationDomainOriginStateCreateInfo</see> - Structure specifying the orientation of the tessellation domain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineTessellationDomainOriginStateCreateInfo</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPipelineTessellationDomainOriginStateCreateInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkTessellationDomainOrigin    domainOrigin;
    ///         } VkPipelineTessellationDomainOriginStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DomainOrigin</c> is a <c>VkTessellationDomainOrigin</c> value controlling the origin of the tessellation domain space.
        /// </summary>
        [FieldOffset(16)]
        public VkTessellationDomainOrigin DomainOrigin;
    }
}
