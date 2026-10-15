namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInternalAllocationType.html">VkInternalAllocationType</see> - Allocation type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>allocationType</c> parameter to the <c>pfnInternalAllocation</c> and
    ///         <c>pfnInternalFree</c> functions may: be one of the following values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkInternalAllocationType {
    ///             VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = 0,
    ///         } VkInternalAllocationType;
    ///     </code>
    /// </remarks>
    public enum VkInternalAllocationType : int
    {
        /// <summary>
        ///     <c>Executable</c> specifies that the allocation is intended for execution by the host.
        /// </summary>
        Executable = 0,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
