namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSpecializationInfo.html">VkSpecializationInfo</see> - Structure specifying specialization information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSpecializationInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSpecializationInfo {
    ///             uint32_t                           mapEntryCount;
    ///             const VkSpecializationMapEntry*    pMapEntries;
    ///             size_t                             dataSize;
    ///             const void*                        pData;
    ///         } VkSpecializationInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSpecializationInfo()
    {
        /// <summary>
        ///     <c>MapEntryCount</c> is the number of entries in the <c>pMapEntries</c> array.
        /// </summary>
        [FieldOffset(0)]
        public int MapEntryCount;

        /// <summary>
        ///     <c>MapEntries</c> is a pointer to an array of <c>VkSpecializationMapEntry</c> structures, which map constant IDs to offsets in <c>pData</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkSpecializationMapEntry* MapEntries;

        /// <summary>
        ///     <c>DataSize</c> is the byte size of the <c>pData</c> buffer.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 DataSize;

        /// <summary>
        ///     <c>Data</c> contains the actual constant values to specialize with.
        /// </summary>
        [FieldOffset(24)]
        public void* Data;
    }
}
