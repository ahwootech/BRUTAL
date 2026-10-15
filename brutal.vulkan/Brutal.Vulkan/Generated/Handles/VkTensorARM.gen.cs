namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorARM.html">VkTensorARM</see> - Opaque handle to a tensor object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Tensors are similar to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#images">images^</see>, in that they have
    ///         multi-dimensional access as documented in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#tensors">here</see> chapter, but a
    ///         tensor&apos;s dimensions are not predefined.
    ///         A tensor can have an arbitrary number of dimensions, up to
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits-maxTensorDimensionCount"><c>maxTensorDimensionCount</c>^</see>, with one
    ///         index per dimension used to access the tensor.
    ///     </para>
    ///     <para>
    ///         Tensors <i>can</i> be used by binding them to pipelines via descriptor sets, or by
    ///         directly specifying them as parameters to certain commands.
    ///     </para>
    ///     <para>
    ///         Tensors are represented by <c>VkTensorARM</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap, VK_ARM_tensors
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkTensorARM)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkTensorARM : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.TensorARM;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkTensorARM(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkTensorARM NullHandle = new();
    }
}
