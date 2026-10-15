namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInitializePerformanceApiInfoINTEL.html">VkInitializePerformanceApiInfoINTEL</see> - Structure specifying parameters of initialize of the device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkInitializePerformanceApiInfoINTEL</c> structure is defined as :
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkInitializePerformanceApiInfoINTEL {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             void*              pUserData;
    ///         } VkInitializePerformanceApiInfoINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkInitializePerformanceApiInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.InitializePerformanceApiInfoINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UserData</c> is NULL or a pointer for application data.
        /// </summary>
        [FieldOffset(16)]
        public void* UserData;
    }
}
