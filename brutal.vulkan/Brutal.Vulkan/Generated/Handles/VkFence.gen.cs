namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFence.html">VkFence</see> - Opaque handle to a fence object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Fences are a synchronization primitive that <i>can</i> be used to insert a
    ///         dependency from a queue to the host.
    ///         Fences have two states - signaled and unsignaled.
    ///         A fence <i>can</i> be signaled as part of the execution of a
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#devsandqueues-submission">queue submission^</see> command.
    ///         Fences <i>can</i> be unsignaled on the host with <c>vkResetFences</c>.
    ///         Fences <i>can</i> be waited on by the host with the <c>vkWaitForFences</c> command,
    ///         and the current state <i>can</i> be queried with <c>vkGetFenceStatus</c>.
    ///     </para>
    ///     <para>
    ///         Fences are represented by <c>VkFence</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkFence)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkFence : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Fence;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkFence(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkFence NullHandle = new();
    }
}
