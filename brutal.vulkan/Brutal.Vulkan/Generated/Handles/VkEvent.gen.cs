namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkEvent.html">VkEvent</see> - Opaque handle to an event object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Events are a synchronization primitive that <i>can</i> be used to insert a
    ///         fine-grained dependency between commands submitted to the same queue, or
    ///         between the host and a queue.
    ///         Events <i>must</i> not be used to insert a dependency between commands submitted
    ///         to different queues.
    ///         Events have two states - signaled and unsignaled.
    ///         An application <i>can</i> signal or unsignal an event either on the host or on the
    ///         device.
    ///         A device <i>can</i> be made to wait for an event to become signaled before
    ///         executing further operations.
    ///         No command exists to wait for an event to become signaled on the host, but
    ///         the current state of an event <i>can</i> be queried.
    ///     </para>
    ///     <para>
    ///         Events are represented by <c>VkEvent</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkEvent)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkEvent : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Event;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkEvent(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkEvent NullHandle = new();
    }
}
