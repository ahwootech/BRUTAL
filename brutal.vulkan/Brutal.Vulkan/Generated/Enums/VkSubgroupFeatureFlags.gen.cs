namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubgroupFeatureFlagBits.html">VkSubgroupFeatureFlagBits</see> - Bitmask describing what group operations are supported with subgroup scope
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPhysicalDeviceSubgroupProperties::supportedOperations</c>
    ///         to specify supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-group-operations">group operations^</see> with
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-scope-subgroup">subgroup scope^</see> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkSubgroupFeatureFlagBits {
    ///             VK_SUBGROUP_FEATURE_BASIC_BIT = 0x00000001,
    ///             VK_SUBGROUP_FEATURE_VOTE_BIT = 0x00000002,
    ///             VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 0x00000004,
    ///             VK_SUBGROUP_FEATURE_BALLOT_BIT = 0x00000008,
    ///             VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 0x00000010,
    ///             VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 0x00000020,
    ///             VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 0x00000040,
    ///             VK_SUBGROUP_FEATURE_QUAD_BIT = 0x00000080,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_SUBGROUP_FEATURE_ROTATE_BIT = 0x00000200,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT = 0x00000400,
    ///             // Provided by VK_EXT_shader_subgroup_partitioned
    ///             VK_SUBGROUP_FEATURE_PARTITIONED_BIT_EXT = 0x00000100,
    ///             // Provided by VK_NV_shader_subgroup_partitioned
    ///             VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = VK_SUBGROUP_FEATURE_PARTITIONED_BIT_EXT,
    ///             // Provided by VK_KHR_shader_subgroup_rotate
    ///             VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_BIT,
    ///             // Provided by VK_KHR_shader_subgroup_rotate
    ///             VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT,
    ///         } VkSubgroupFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSubgroupFeatureFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>BasicBit</c>
        /// </summary>
        BasicBit = 0x00000001,

        /// <summary>
        ///     <c>VoteBit</c>
        /// </summary>
        VoteBit = 0x00000002,

        /// <summary>
        ///     <c>ArithmeticBit</c>
        /// </summary>
        ArithmeticBit = 0x00000004,

        /// <summary>
        ///     <c>BallotBit</c>
        /// </summary>
        BallotBit = 0x00000008,

        /// <summary>
        ///     <c>ShuffleBit</c>
        /// </summary>
        ShuffleBit = 0x00000010,

        /// <summary>
        ///     <c>ShuffleRelativeBit</c>
        /// </summary>
        ShuffleRelativeBit = 0x00000020,

        /// <summary>
        ///     <c>ClusteredBit</c>
        /// </summary>
        ClusteredBit = 0x00000040,

        /// <summary>
        ///     <c>QuadBit</c>
        /// </summary>
        QuadBit = 0x00000080,

        /// <summary>
        ///     <c>RotateBit</c>
        /// </summary>
        RotateBit = 0x00000200,

        /// <summary>
        ///     <c>RotateClusteredBit</c>
        /// </summary>
        RotateClusteredBit = 0x00000400,

        /// <summary>
        ///     <c>PartitionedBitEXT</c>
        /// </summary>
        PartitionedBitEXT = 0x00000100,

        /// <summary>
        ///     <c>PartitionedBitNV</c>
        /// </summary>
        PartitionedBitNV = PartitionedBitEXT,

        /// <summary>
        ///     <c>RotateBitKHR</c>
        /// </summary>
        RotateBitKHR = RotateBit,

        /// <summary>
        ///     <c>RotateClusteredBitKHR</c>
        /// </summary>
        RotateClusteredBitKHR = RotateClusteredBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
