namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryFlagBitsKHR.html">VkGeometryFlagBitsKHR</see> - Bitmask specifying additional parameters for a geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryFlagBitsKHR
    ///     </para>
    ///     <para>
    ///         Bits specifying additional parameters for geometries in acceleration
    ///         structure builds, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkGeometryFlagBitsKHR {
    ///             VK_GEOMETRY_OPAQUE_BIT_KHR = 0x00000001,
    ///             VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 0x00000002,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_OPAQUE_BIT_NV = VK_GEOMETRY_OPAQUE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV = VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR,
    ///         } VkGeometryFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkGeometryFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueBitKHR</c> specifies that this geometry does not invoke the any-hit shaders even if present in a hit group.
        /// </summary>
        OpaqueBitKHR = 0x00000001,

        /// <summary>
        ///     <c>NoDuplicateAnyHitInvocationBitKHR</c> specifies that the implementation <i>must</i> only call the any-hit shader a single time for each primitive in this geometry. If this bit is absent an implementation may: invoke the any-hit shader more than once for this geometry.
        /// </summary>
        NoDuplicateAnyHitInvocationBitKHR = 0x00000002,

        /// <summary>
        ///     <c>OpaqueBitNV</c>
        /// </summary>
        OpaqueBitNV = OpaqueBitKHR,

        /// <summary>
        ///     <c>NoDuplicateAnyHitInvocationBitNV</c>
        /// </summary>
        NoDuplicateAnyHitInvocationBitNV = NoDuplicateAnyHitInvocationBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
