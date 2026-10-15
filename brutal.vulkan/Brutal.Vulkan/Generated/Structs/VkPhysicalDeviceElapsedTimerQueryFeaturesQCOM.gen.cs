namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM.html">VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM</see> - Structure describing elapsed timer query features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_elapsed_timer_query
    ///         typedef struct VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           elapsedTimerQuery;
    ///         } VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceElapsedTimerQueryFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceElapsedTimerQueryFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ElapsedTimerQuery</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ElapsedTimerQuery;
    }
}
