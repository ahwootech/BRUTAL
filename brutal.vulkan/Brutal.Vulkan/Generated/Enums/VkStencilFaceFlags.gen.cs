namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStencilFaceFlagBits.html">VkStencilFaceFlagBits</see> - Bitmask specifying sets of stencil state for which to update the compare mask
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkStencilFaceFlags</c> values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkStencilFaceFlagBits {
    ///             VK_STENCIL_FACE_FRONT_BIT = 0x00000001,
    ///             VK_STENCIL_FACE_BACK_BIT = 0x00000002,
    ///             VK_STENCIL_FACE_FRONT_AND_BACK = 0x00000003,
    ///             // VK_STENCIL_FRONT_AND_BACK is a legacy alias
    ///             VK_STENCIL_FRONT_AND_BACK = VK_STENCIL_FACE_FRONT_AND_BACK,
    ///         } VkStencilFaceFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkStencilFaceFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FrontBit</c> specifies that only the front set of stencil state is updated.
        /// </summary>
        FrontBit = 0x00000001,

        /// <summary>
        ///     <c>BackBit</c> specifies that only the back set of stencil state is updated.
        /// </summary>
        BackBit = 0x00000002,

        /// <summary>
        ///     <c>FrontAndBack</c> is the combination of <c>VK_STENCIL_FACE_FRONT_BIT</c> and <c>VK_STENCIL_FACE_BACK_BIT</c>, and specifies that both sets of stencil state are updated.
        /// </summary>
        FrontAndBack = 0x00000003,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
