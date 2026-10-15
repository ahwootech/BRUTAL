namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComponentSwizzle.html">VkComponentSwizzle</see> - Specify how a component is swizzled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the members of <c>VkComponentMapping</c>, specifying the
    ///         component values placed in each component of the output vector, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkComponentSwizzle {
    ///             VK_COMPONENT_SWIZZLE_IDENTITY = 0,
    ///             VK_COMPONENT_SWIZZLE_ZERO = 1,
    ///             VK_COMPONENT_SWIZZLE_ONE = 2,
    ///             VK_COMPONENT_SWIZZLE_R = 3,
    ///             VK_COMPONENT_SWIZZLE_G = 4,
    ///             VK_COMPONENT_SWIZZLE_B = 5,
    ///             VK_COMPONENT_SWIZZLE_A = 6,
    ///         } VkComponentSwizzle;
    ///     </code>
    /// </remarks>
    public enum VkComponentSwizzle : int
    {
        /// <summary>
        ///     <c>Identity</c> specifies that the component is set to the identity swizzle.
        /// </summary>
        Identity = 0,

        /// <summary>
        ///     <c>Zero</c> specifies that the component is set to zero.
        /// </summary>
        Zero = 1,

        /// <summary>
        ///     <c>One</c> specifies that the component is set to either 1 or 1.0, depending on whether the type of the image view format is integer or floating-point respectively, as determined by the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-definition">Format Definition^</see> section for each <c>VkFormat</c>.
        /// </summary>
        One = 2,

        /// <summary>
        ///     <c>R</c> specifies that the component is set to the value of the R component of the image.
        /// </summary>
        R = 3,

        /// <summary>
        ///     <c>G</c> specifies that the component is set to the value of the G component of the image.
        /// </summary>
        G = 4,

        /// <summary>
        ///     <c>B</c> specifies that the component is set to the value of the B component of the image.
        /// </summary>
        B = 5,

        /// <summary>
        ///     <c>A</c> specifies that the component is set to the value of the A component of the image.  [[resources-image-views-identity-mappings]] Setting the identity swizzle on a component is equivalent to setting the identity mapping on that component. That is:  [[resources-component-mappings-equivalent-to-swizzle_identity-table]] .Component Mappings Equivalent To <c>VK_COMPONENT_SWIZZLE_IDENTITY</c> [options=&quot;header&quot;] |
        /// </summary>
        A = 6,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
