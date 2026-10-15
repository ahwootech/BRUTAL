namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorFormatPropertiesARM.html">VkTensorFormatPropertiesARM</see> - Structure specifying properties of a format used to describe tensor elements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorFormatPropertiesARM</c> structure describes properties of a
    ///         <c>VkFormat</c> when that format is used to describe tensor elements.
    ///         These properties, like those of <c>VkFormatProperties2</c>, are independent
    ///         of any particular tensor.
    ///     </para>
    ///     <para>
    ///         The <c>VkTensorFormatPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorFormatPropertiesARM {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkFormatFeatureFlags2    optimalTilingTensorFeatures;
    ///             VkFormatFeatureFlags2    linearTilingTensorFeatures;
    ///         } VkTensorFormatPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkTensorFormatPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorFormatPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OptimalTilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_OPTIMAL_ARM</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormatFeatureFlags2 OptimalTilingTensorFeatures;

        /// <summary>
        ///     <c>LinearTilingTensorFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by tensors created with a <c>tiling</c> parameter of <c>VK_TENSOR_TILING_LINEAR_ARM</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkFormatFeatureFlags2 LinearTilingTensorFeatures;
    }
}
