namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapVersionInfoEXT.html">VkMicromapVersionInfoEXT</see> - Micromap version information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapVersionInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapVersionInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkMicromapVersionInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const uint8_t*     pVersionData;
    ///         } VkMicromapVersionInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMicromapVersionInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MicromapVersionInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VersionData</c> is a pointer to the version header of a micromap as defined in <c>vkCmdCopyMicromapToMemoryEXT</c>
        /// </summary>
        [FieldOffset(16)]
        public byte* VersionData;
    }
}
