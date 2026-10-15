namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorHeapPropertiesEXT.html">VkPhysicalDeviceDescriptorHeapPropertiesEXT</see> - Structure describing supported image alignments for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorHeapPropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkPhysicalDeviceDescriptorHeapPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       samplerHeapAlignment;
    ///             VkDeviceSize       resourceHeapAlignment;
    ///             VkDeviceSize       maxSamplerHeapSize;
    ///             VkDeviceSize       maxResourceHeapSize;
    ///             VkDeviceSize       minSamplerHeapReservedRange;
    ///             VkDeviceSize       minSamplerHeapReservedRangeWithEmbedded;
    ///             VkDeviceSize       minResourceHeapReservedRange;
    ///             VkDeviceSize       samplerDescriptorSize;
    ///             VkDeviceSize       imageDescriptorSize;
    ///             VkDeviceSize       bufferDescriptorSize;
    ///             VkDeviceSize       samplerDescriptorAlignment;
    ///             VkDeviceSize       imageDescriptorAlignment;
    ///             VkDeviceSize       bufferDescriptorAlignment;
    ///             VkDeviceSize       maxPushDataSize;
    ///             size_t             imageCaptureReplayOpaqueDataSize;
    ///             uint32_t           maxDescriptorHeapEmbeddedSamplers;
    ///             uint32_t           samplerYcbcrConversionCount;
    ///             VkBool32           sparseDescriptorHeaps;
    ///             VkBool32           protectedDescriptorHeaps;
    ///         } VkPhysicalDeviceDescriptorHeapPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public unsafe partial struct VkPhysicalDeviceDescriptorHeapPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorHeapPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SamplerHeapAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 SamplerHeapAlignment;

        /// <summary>
        ///     <c>ResourceHeapAlignment</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 ResourceHeapAlignment;

        /// <summary>
        ///     <c>MaxSamplerHeapSize</c>
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MaxSamplerHeapSize;

        /// <summary>
        ///     <c>MaxResourceHeapSize</c>
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 MaxResourceHeapSize;

        /// <summary>
        ///     <c>MinSamplerHeapReservedRange</c>
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 MinSamplerHeapReservedRange;

        /// <summary>
        ///     <c>MinSamplerHeapReservedRangeWithEmbedded</c>
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 MinSamplerHeapReservedRangeWithEmbedded;

        /// <summary>
        ///     <c>MinResourceHeapReservedRange</c>
        /// </summary>
        [FieldOffset(64)]
        public ByteSize64 MinResourceHeapReservedRange;

        /// <summary>
        ///     <c>SamplerDescriptorSize</c>
        /// </summary>
        [FieldOffset(72)]
        public ByteSize64 SamplerDescriptorSize;

        /// <summary>
        ///     <c>ImageDescriptorSize</c>
        /// </summary>
        [FieldOffset(80)]
        public ByteSize64 ImageDescriptorSize;

        /// <summary>
        ///     <c>BufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(88)]
        public ByteSize64 BufferDescriptorSize;

        /// <summary>
        ///     <c>SamplerDescriptorAlignment</c>
        /// </summary>
        [FieldOffset(96)]
        public ByteSize64 SamplerDescriptorAlignment;

        /// <summary>
        ///     <c>ImageDescriptorAlignment</c>
        /// </summary>
        [FieldOffset(104)]
        public ByteSize64 ImageDescriptorAlignment;

        /// <summary>
        ///     <c>BufferDescriptorAlignment</c>
        /// </summary>
        [FieldOffset(112)]
        public ByteSize64 BufferDescriptorAlignment;

        /// <summary>
        ///     <c>MaxPushDataSize</c>
        /// </summary>
        [FieldOffset(120)]
        public ByteSize64 MaxPushDataSize;

        /// <summary>
        ///     <c>ImageCaptureReplayOpaqueDataSize</c>
        /// </summary>
        [FieldOffset(128)]
        public nuint ImageCaptureReplayOpaqueDataSize;

        /// <summary>
        ///     <c>MaxDescriptorHeapEmbeddedSamplers</c>
        /// </summary>
        [FieldOffset(136)]
        public int MaxDescriptorHeapEmbeddedSamplers;

        /// <summary>
        ///     <c>SamplerYcbcrConversionCount</c>
        /// </summary>
        [FieldOffset(140)]
        public int SamplerYcbcrConversionCount;

        /// <summary>
        ///     <c>SparseDescriptorHeaps</c>
        /// </summary>
        [FieldOffset(144)]
        public Brutal.Bool32 SparseDescriptorHeaps;

        /// <summary>
        ///     <c>ProtectedDescriptorHeaps</c>
        /// </summary>
        [FieldOffset(148)]
        public Brutal.Bool32 ProtectedDescriptorHeaps;
    }
}
