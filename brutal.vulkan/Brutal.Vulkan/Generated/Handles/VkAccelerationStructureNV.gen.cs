namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureNV.html">VkAccelerationStructureNV</see> - Opaque handle to an acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureNV
    ///     </para>
    ///     <para>
    ///         Acceleration structures for the `<c>VK_NV_ray_tracing</c> extension` are
    ///         represented by the similar <c>VkAccelerationStructureNV</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkAccelerationStructureNV)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkAccelerationStructureNV : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.AccelerationStructureNV;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkAccelerationStructureNV(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkAccelerationStructureNV NullHandle = new();
    }
}
