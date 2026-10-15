namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingInfoLUNARG.html">VkDirectDriverLoadingInfoLUNARG</see> - Structure specifying the information required to load an additional driver
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDirectDriverLoadingInfoLUNARG</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_LUNARG_direct_driver_loading
    ///         typedef struct VkDirectDriverLoadingInfoLUNARG {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkDirectDriverLoadingFlagsLUNARG    flags;
    ///             PFN_vkGetInstanceProcAddrLUNARG     pfnGetInstanceProcAddr;
    ///         } VkDirectDriverLoadingInfoLUNARG;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDirectDriverLoadingInfoLUNARG()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DirectDriverLoadingInfoLUNARG;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDirectDriverLoadingFlagsLUNARG Flags;

        /// <summary>
        ///     <c>PfnGetInstanceProcAddr</c> is a <c>PFN_vkGetInstanceProcAddrLUNARG</c> pointer to the driver <c>vkGetInstanceProcAddr</c> function.
        /// </summary>
        [FieldOffset(24)]
        public PfnVkGetInstanceProcAddrLUNARG PfnGetInstanceProcAddr;
    }
}
