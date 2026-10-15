namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphore.html">VkSemaphore</see> - Opaque handle to a semaphore object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Semaphores are a synchronization primitive that <i>can</i> be used to insert a
    ///         dependency
    ///         between queue operations.
    ///         Semaphores have two states - signaled and unsignaled.
    ///         A semaphore <i>can</i> be signaled after execution of a queue operation is
    ///         completed, and a queue operation <i>can</i> wait for a semaphore to become
    ///         signaled before it begins execution.
    ///     </para>
    ///     <para>
    ///         Semaphores are represented by <c>VkSemaphore</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkSemaphore)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkSemaphore : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Semaphore;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkSemaphore(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkSemaphore NullHandle = new();
    }
}
