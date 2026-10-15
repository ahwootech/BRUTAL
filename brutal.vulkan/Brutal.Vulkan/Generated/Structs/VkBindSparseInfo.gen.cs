namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindSparseInfo.html">VkBindSparseInfo</see> - Structure specifying a sparse binding operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindSparseInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBindSparseInfo {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             uint32_t                                    waitSemaphoreCount;
    ///             const VkSemaphore*                          pWaitSemaphores;
    ///             uint32_t                                    bufferBindCount;
    ///             const VkSparseBufferMemoryBindInfo*         pBufferBinds;
    ///             uint32_t                                    imageOpaqueBindCount;
    ///             const VkSparseImageOpaqueMemoryBindInfo*    pImageOpaqueBinds;
    ///             uint32_t                                    imageBindCount;
    ///             const VkSparseImageMemoryBindInfo*          pImageBinds;
    ///             uint32_t                                    signalSemaphoreCount;
    ///             const VkSemaphore*                          pSignalSemaphores;
    ///         } VkBindSparseInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkBindSparseInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindSparseInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreCount</c> is the number of semaphores upon which to wait before executing the sparse binding operations for the batch.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreCount;

        /// <summary>
        ///     <c>WaitSemaphores</c> is a pointer to an array of semaphores upon which to wait on before the sparse binding operations for this batch begin execution. If semaphores to wait on are provided, they define a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-waiting">semaphore wait operation^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphore* WaitSemaphores;

        /// <summary>
        ///     <c>BufferBindCount</c> is the number of sparse buffer bindings to perform in the batch.
        /// </summary>
        [FieldOffset(32)]
        public int BufferBindCount;

        /// <summary>
        ///     <c>BufferBinds</c> is a pointer to an array of <c>VkSparseBufferMemoryBindInfo</c> structures.
        /// </summary>
        [FieldOffset(40)]
        public VkSparseBufferMemoryBindInfo* BufferBinds;

        /// <summary>
        ///     <c>ImageOpaqueBindCount</c> is the number of opaque sparse image bindings to perform.
        /// </summary>
        [FieldOffset(48)]
        public int ImageOpaqueBindCount;

        /// <summary>
        ///     <c>ImageOpaqueBinds</c> is a pointer to an array of <c>VkSparseImageOpaqueMemoryBindInfo</c> structures, indicating opaque sparse image bindings to perform.
        /// </summary>
        [FieldOffset(56)]
        public VkSparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;

        /// <summary>
        ///     <c>ImageBindCount</c> is the number of sparse image bindings to perform.
        /// </summary>
        [FieldOffset(64)]
        public int ImageBindCount;

        /// <summary>
        ///     <c>ImageBinds</c> is a pointer to an array of <c>VkSparseImageMemoryBindInfo</c> structures, indicating sparse image bindings to perform.
        /// </summary>
        [FieldOffset(72)]
        public VkSparseImageMemoryBindInfo* ImageBinds;

        /// <summary>
        ///     <c>SignalSemaphoreCount</c> is the number of semaphores to be signaled once the sparse binding operations specified by the structure have completed execution.
        /// </summary>
        [FieldOffset(80)]
        public int SignalSemaphoreCount;

        /// <summary>
        ///     <c>SignalSemaphores</c> is a pointer to an array of semaphores which will be signaled when the sparse binding operations for this batch have completed execution. If semaphores to be signaled are provided, they define a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-signaling">semaphore signal operation^</see>.
        /// </summary>
        [FieldOffset(88)]
        public VkSemaphore* SignalSemaphores;
    }
}
