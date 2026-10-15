namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryAcquireUnmodifiedEXT.html">VkExternalMemoryAcquireUnmodifiedEXT</see> - Structure specifying that external memory has remained unmodified since releasing ownership
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         An <i>acquire operation</i> may: have a performance penalty when acquiring
    ///         ownership of a subresource range from one of the special queue families
    ///         reserved for external memory ownership transfers described above.
    ///         The application <i>can</i> reduce the performance penalty in some cases by adding
    ///         a <c>VkExternalMemoryAcquireUnmodifiedEXT</c> structure to the <c>pNext</c>
    ///         chain of the <i>acquire operation</i>&apos;s memory barrier structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkExternalMemoryAcquireUnmodifiedEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_acquire_unmodified
    ///         typedef struct VkExternalMemoryAcquireUnmodifiedEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           acquireUnmodifiedMemory;
    ///         } VkExternalMemoryAcquireUnmodifiedEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalMemoryAcquireUnmodifiedEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalMemoryAcquireUnmodifiedEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AcquireUnmodifiedMemory</c> specifies, if <c>VK_TRUE</c>, that no range of <c>VkDeviceMemory</c> bound to the resource of the memory barrier&apos;s subresource range was modified at any time since the resource&apos;s most recent release of ownership to the queue family specified by the memory barrier&apos;s <c>srcQueueFamilyIndex</c>. If <c>VK_FALSE</c>, it specifies nothing.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AcquireUnmodifiedMemory;
    }
}
