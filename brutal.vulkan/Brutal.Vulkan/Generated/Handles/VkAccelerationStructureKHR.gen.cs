namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureKHR.html">VkAccelerationStructureKHR</see> - Opaque handle to an acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureKHR
    ///     </para>
    ///     <para>
    ///         Acceleration structures for the `<c>VK_KHR_acceleration_structure</c>
    ///         extension`
    ///         are represented by <c>VkAccelerationStructureKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkAccelerationStructureKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkAccelerationStructureKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.AccelerationStructureKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkAccelerationStructureKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkAccelerationStructureKHR NullHandle = new();
    }
}
