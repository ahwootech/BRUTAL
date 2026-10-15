namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreatePrivateDataInfoNV.html">VkOpticalFlowSessionCreatePrivateDataInfoNV</see> - Structure for NV internal use only
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpticalFlowSessionCreatePrivateDataInfoNV</c> structure is for NV
    ///         internal use only and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef struct VkOpticalFlowSessionCreatePrivateDataInfoNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           id;
    ///             uint32_t           size;
    ///             const void*        pPrivateData;
    ///         } VkOpticalFlowSessionCreatePrivateDataInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkOpticalFlowSessionCreatePrivateDataInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpticalFlowSessionCreatePrivateDataInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Id</c> is an identifier for data which is passed at a memory location specified in <c>VkOpticalFlowSessionCreatePrivateDataInfoNV::pPrivateData</c>.
        /// </summary>
        [FieldOffset(16)]
        public int Id;

        /// <summary>
        ///     <c>Size</c> is the size of data in bytes which is passed at a memory location specified in <c>VkOpticalFlowSessionCreatePrivateDataInfoNV::pPrivateData</c>.
        /// </summary>
        [FieldOffset(20)]
        public int Size;

        /// <summary>
        ///     <c>PrivateData</c> is a pointer to NV internal data.
        /// </summary>
        [FieldOffset(24)]
        public void* PrivateData;
    }
}
