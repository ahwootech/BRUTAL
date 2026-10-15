namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorExplicitTilingFormatPropertiesARM.html">VkTensorExplicitTilingFormatPropertiesARM</see> - Structure specifying properties of a format used to describe tensor elements with ARM-specific explicit tiling
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorExplicitTilingFormatPropertiesARM</c> structure describes
    ///         properties of a <c>VkFormat</c> when that format is used to describe tensor
    ///         elements.
    ///         These properties, like those of <c>VkFormatProperties2</c>, are independent
    ///         of any particular tensor.
    ///     </para>
    ///     <para>
    ///         The <c>VkTensorExplicitTilingFormatPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensor_controls
    ///         typedef struct VkTensorExplicitTilingFormatPropertiesARM {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkFormatFeatureFlags2    brick16TilingTensorFeatures;
    ///             VkFormatFeatureFlags2    brick8TilingTensorFeatures;
    ///             VkFormatFeatureFlags2    brick4TilingTensorFeatures;
    ///             VkFormatFeatureFlags2    blockUTilingTensorFeatures;
    ///             VkFormatFeatureFlags2    blockU64kTilingTensorFeatures;
    ///         } VkTensorExplicitTilingFormatPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkTensorExplicitTilingFormatPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorExplicitTilingFormatPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Brick16TilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_BRICK_16_WIDE_ARM</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormatFeatureFlags2 Brick16TilingTensorFeatures;

        /// <summary>
        ///     <c>Brick8TilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_BRICK_8_WIDE_ARM</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkFormatFeatureFlags2 Brick8TilingTensorFeatures;

        /// <summary>
        ///     <c>Brick4TilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_BRICK_4_WIDE_ARM</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkFormatFeatureFlags2 Brick4TilingTensorFeatures;

        /// <summary>
        ///     <c>BlockUTilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_BLOCK_U_INTERLEAVED_ARM</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkFormatFeatureFlags2 BlockUTilingTensorFeatures;

        /// <summary>
        ///     <c>BlockU64kTilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_BLOCK_U_INTERLEAVED_64K_ARM</c>.
        /// </summary>
        [FieldOffset(48)]
        public VkFormatFeatureFlags2 BlockU64kTilingTensorFeatures;
    }
}
