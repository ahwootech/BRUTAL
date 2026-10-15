namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingModeLUNARG.html">VkDirectDriverLoadingModeLUNARG</see> - Specify loader behavior of added drivers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDirectDriverLoadingListLUNARG::mode</c>,
    ///         specifying the mode in which drivers are used, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_LUNARG_direct_driver_loading
    ///         typedef enum VkDirectDriverLoadingModeLUNARG {
    ///             VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG = 0,
    ///             VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG = 1,
    ///         } VkDirectDriverLoadingModeLUNARG;
    ///     </code>
    /// </remarks>
    public enum VkDirectDriverLoadingModeLUNARG : int
    {
        /// <summary>
        ///     <c>ExclusiveLUNARG</c> specifies that the provided drivers are used instead of the system-loaded drivers.
        /// </summary>
        ExclusiveLUNARG = 0,

        /// <summary>
        ///     <c>InclusiveLUNARG</c> specifies that the provided drivers are used in addition to the system-loaded drivers.
        /// </summary>
        InclusiveLUNARG = 1,

        /// <summary>
        ///     <c>MaxEnumLUNARG</c>
        /// </summary>
        MaxEnumLUNARG = 0x7FFFFFFF,
    }
}
