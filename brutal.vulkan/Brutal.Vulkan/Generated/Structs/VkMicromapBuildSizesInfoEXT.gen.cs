namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildSizesInfoEXT.html">VkMicromapBuildSizesInfoEXT</see> - Structure specifying build sizes for a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapBuildSizesInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapBuildSizesInfoEXT</c> structure describes the required build
    ///         sizes for a micromap and scratch buffers and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkMicromapBuildSizesInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceSize       micromapSize;
    ///             VkDeviceSize       buildScratchSize;
    ///             VkBool32           discardable;
    ///         } VkMicromapBuildSizesInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkMicromapBuildSizesInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MicromapBuildSizesInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MicromapSize</c> is the size in bytes required in a <c>VkMicromapEXT</c> for a build or update operation.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 MicromapSize;

        /// <summary>
        ///     <c>BuildScratchSize</c> is the size in bytes required in a scratch buffer for a build operation.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 BuildScratchSize;

        /// <summary>
        ///     <c>Discardable</c> indicates whether or not the micromap object may be destroyed after an acceleration structure build or update. A false value means that acceleration structures built with this micromap may: contain references to the data contained therein, and the application <i>must</i> not destroy the micromap until ray traversal has concluded. A true value means that the information in the micromap will be copied by value into the acceleration structure, and the micromap <i>can</i> be destroyed after the acceleration structure build concludes.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 Discardable;
    }
}
