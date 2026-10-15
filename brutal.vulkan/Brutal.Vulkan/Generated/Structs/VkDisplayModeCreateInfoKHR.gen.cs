namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModeCreateInfoKHR.html">VkDisplayModeCreateInfoKHR</see> - Structure specifying parameters of a newly created display mode object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayModeCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayModeCreateInfoKHR {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkDisplayModeCreateFlagsKHR    flags;
    ///             VkDisplayModeParametersKHR     parameters;
    ///         } VkDisplayModeCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDisplayModeCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayModeCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use, and <i>must</i> be zero.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayModeCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Parameters</c> is a <c>VkDisplayModeParametersKHR</c> structure describing the display parameters to use in creating the new mode. If the parameters are not compatible with the specified display, the implementation <i>must</i> return <c>VK_ERROR_INITIALIZATION_FAILED</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkDisplayModeParametersKHR Parameters;
    }
}
