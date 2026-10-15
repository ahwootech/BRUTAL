namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorTilingARM.html">VkTensorTilingARM</see> - Specifies the tiling arrangement of data in an tensor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkTensorCreateInfoARM::tiling</c>, specifying the
    ///         tiling arrangement of elements in the tensor, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef enum VkTensorTilingARM {
    ///             VK_TENSOR_TILING_OPTIMAL_ARM = 0,
    ///             VK_TENSOR_TILING_LINEAR_ARM = 1,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_TENSOR_TILING_BRICK_16_WIDE_ARM = 1000565000,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_TENSOR_TILING_BRICK_8_WIDE_ARM = 1000565001,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_TENSOR_TILING_BRICK_4_WIDE_ARM = 1000565002,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_TENSOR_TILING_BLOCK_U_INTERLEAVED_ARM = 1000565003,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_TENSOR_TILING_BLOCK_U_INTERLEAVED_64K_ARM = 1000565004,
    ///         } VkTensorTilingARM;
    ///     </code>
    /// </remarks>
    public enum VkTensorTilingARM : int
    {
        /// <summary>
        ///     <c>OptimalARM</c> specifies optimal tiling (elements are laid out in an implementation-dependent arrangement, for more efficient memory access).
        /// </summary>
        OptimalARM = 0,

        /// <summary>
        ///     <c>LinearARM</c> specifies linear tiling (elements are laid out linearly and the offset between each element is determined by the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-tensor-description-strides">strides^</see> of the tensor).
        /// </summary>
        LinearARM = 1,

        /// <summary>
        ///     <c>Brick16WideARM</c>
        /// </summary>
        Brick16WideARM = 1000565000,

        /// <summary>
        ///     <c>Brick8WideARM</c>
        /// </summary>
        Brick8WideARM = 1000565001,

        /// <summary>
        ///     <c>Brick4WideARM</c>
        /// </summary>
        Brick4WideARM = 1000565002,

        /// <summary>
        ///     <c>BlockUInterleavedARM</c>
        /// </summary>
        BlockUInterleavedARM = 1000565003,

        /// <summary>
        ///     <c>BlockUInterleaved64KARM</c>
        /// </summary>
        BlockUInterleaved64KARM = 1000565004,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
