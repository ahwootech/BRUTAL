namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingListLUNARG.html">VkDirectDriverLoadingListLUNARG</see> - Structure specifying additional drivers to load
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDirectDriverLoadingListLUNARG</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_LUNARG_direct_driver_loading
    ///         typedef struct VkDirectDriverLoadingListLUNARG {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkDirectDriverLoadingModeLUNARG           mode;
    ///             uint32_t                                  driverCount;
    ///             const VkDirectDriverLoadingInfoLUNARG*    pDrivers;
    ///         } VkDirectDriverLoadingListLUNARG;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDirectDriverLoadingListLUNARG()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DirectDriverLoadingListLUNARG;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Mode</c> controls the mode in which to load the provided drivers.
        /// </summary>
        [FieldOffset(16)]
        public VkDirectDriverLoadingModeLUNARG Mode;

        /// <summary>
        ///     <c>DriverCount</c> is the number of driver manifest paths.
        /// </summary>
        [FieldOffset(20)]
        public int DriverCount;

        /// <summary>
        ///     <c>Drivers</c> is a pointer to an array of <c>driverCount</c> <c>VkDirectDriverLoadingInfoLUNARG</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkDirectDriverLoadingInfoLUNARG* Drivers;
    }
}
