namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationFlagsEXT.html">VkValidationFlagsEXT</see> - Specify validation checks to disable for a Vulkan instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When creating a Vulkan instance for which you wish to disable validation
    ///         checks, add a <c>VkValidationFlagsEXT</c> structure to the <c>pNext</c> chain
    ///         of the <c>VkInstanceCreateInfo</c> structure, specifying the checks to be
    ///         disabled.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_flags
    ///         typedef struct VkValidationFlagsEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             uint32_t                       disabledValidationCheckCount;
    ///             const VkValidationCheckEXT*    pDisabledValidationChecks;
    ///         } VkValidationFlagsEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkValidationFlagsEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ValidationFlagsEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisabledValidationCheckCount</c> is the number of checks to disable.
        /// </summary>
        [FieldOffset(16)]
        public int DisabledValidationCheckCount;

        /// <summary>
        ///     <c>DisabledValidationChecks</c> is a pointer to an array of <c>VkValidationCheckEXT</c> values specifying the validation checks to be disabled.
        /// </summary>
        [FieldOffset(24)]
        public VkValidationCheckEXT* DisabledValidationChecks;
    }
}
