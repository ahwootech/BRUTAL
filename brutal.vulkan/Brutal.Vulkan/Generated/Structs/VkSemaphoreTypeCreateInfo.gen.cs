namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreTypeCreateInfo.html">VkSemaphoreTypeCreateInfo</see> - Structure specifying the type of a newly created semaphore
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSemaphoreTypeCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSemaphoreTypeCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSemaphoreType    semaphoreType;
    ///             uint64_t           initialValue;
    ///         } VkSemaphoreTypeCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSemaphoreTypeCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreTypeCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SemaphoreType</c> is a <c>VkSemaphoreType</c> value specifying the type of the semaphore.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphoreType SemaphoreType;

        /// <summary>
        ///     <c>InitialValue</c> is the initial payload value if <c>semaphoreType</c> is <c>VK_SEMAPHORE_TYPE_TIMELINE</c>.
        /// </summary>
        [FieldOffset(24)]
        public nint InitialValue;
    }
}
