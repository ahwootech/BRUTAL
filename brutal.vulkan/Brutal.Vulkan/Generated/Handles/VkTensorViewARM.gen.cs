namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorViewARM.html">VkTensorViewARM</see> - Opaque handle to an tensor view object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Tensor objects are not directly accessed by pipelines for reading or writing
    ///         tensor data.
    ///         Instead, <i>tensor views</i> representing the tensor subresources and containing
    ///         additional metadata are used for that purpose.
    ///         Views <i>must</i> be created on tensors of compatible types.
    ///     </para>
    ///     <para>
    ///         Tensor views are represented by <c>VkTensorViewARM</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkTensorViewARM)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkTensorViewARM : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.TensorViewARM;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkTensorViewARM(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkTensorViewARM NullHandle = new();
    }
}
