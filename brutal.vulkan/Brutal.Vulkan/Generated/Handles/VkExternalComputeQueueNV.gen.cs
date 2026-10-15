namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalComputeQueueNV.html">VkExternalComputeQueueNV</see> - Opaque handle to an external compute queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         External compute queues are used to join compatible external APIs to a
    ///         <c>VkDevice</c>, allowing workloads submitted through these external APIs to
    ///         be executed simultaneously to workloads submitted through Vulkan.
    ///     </para>
    ///     <para>
    ///         External compute queues are represented by <c>VkExternalComputeQueueNV</c>
    ///         handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_compute_queue
    ///         VK_DEFINE_HANDLE(VkExternalComputeQueueNV)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkExternalComputeQueueNV : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ExternalComputeQueueNV;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkExternalComputeQueueNV(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkExternalComputeQueueNV NullHandle = new();
    }
}
