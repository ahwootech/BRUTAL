namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderModuleCreateInfo.html">VkShaderModuleCreateInfo</see> - Structure specifying parameters of a newly created shader module
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkShaderModuleCreateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkShaderModuleCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkShaderModuleCreateInfo {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             VkShaderModuleCreateFlags    flags;
    ///             size_t                       codeSize;
    ///             const uint32_t*              pCode;
    ///         } VkShaderModuleCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkShaderModuleCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderModuleCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderModuleCreateFlags Flags;

        /// <summary>
        ///     <c>CodeSize</c> is the size, in bytes, of the code pointed to by <c>pCode</c>.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 CodeSize;

        /// <summary>
        ///     <c>Code</c> is a pointer to code that is used to create the shader module. The type and format of the code is determined from the content of the memory addressed by <c>pCode</c>.
        /// </summary>
        [FieldOffset(32)]
        public int* Code;
    }
}
