namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaSessionCreateInfoAMD.html">VkGpaSessionCreateInfoAMD</see> - Structure specifying parameters of a newly created GPA session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGpaSessionCreateInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaSessionCreateInfoAMD {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkGpaSessionAMD    secondaryCopySource;
    ///         } VkGpaSessionCreateInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkGpaSessionCreateInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GpaSessionCreateInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SecondaryCopySource</c> is a <c>VkGpaSessionAMD</c> handle whose results <i>can</i> be copied into this session.
        /// </summary>
        [FieldOffset(16)]
        public VkGpaSessionAMD SecondaryCopySource;
    }
}
