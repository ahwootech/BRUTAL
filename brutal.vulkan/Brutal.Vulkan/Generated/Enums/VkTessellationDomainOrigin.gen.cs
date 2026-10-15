namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTessellationDomainOrigin.html">VkTessellationDomainOrigin</see> - Enum describing tessellation domain origin
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The possible tessellation domain origins are specified by the
    ///         <c>VkTessellationDomainOrigin</c> enumeration:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkTessellationDomainOrigin {
    ///             VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = 0,
    ///             VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = 1,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT,
    ///         } VkTessellationDomainOrigin;
    ///     </code>
    /// </remarks>
    public enum VkTessellationDomainOrigin : int
    {
        /// <summary>
        ///     <c>UpperLeft</c> specifies that the origin of the domain space is in the upper left corner, as shown in figure <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#img-tessellation-topology-ul">here</see>.
        /// </summary>
        UpperLeft = 0,

        /// <summary>
        ///     <c>LowerLeft</c> specifies that the origin of the domain space is in the lower left corner, as shown in figure <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#img-tessellation-topology-ll">here</see>.  This enum affects how the <c>VertexOrderCw</c> and <c>VertexOrderCcw</c> tessellation execution modes are interpreted, since the winding is defined relative to the orientation of the domain.
        /// </summary>
        LowerLeft = 1,

        /// <summary>
        ///     <c>UpperLeftKHR</c>
        /// </summary>
        UpperLeftKHR = UpperLeft,

        /// <summary>
        ///     <c>LowerLeftKHR</c>
        /// </summary>
        LowerLeftKHR = LowerLeft,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
