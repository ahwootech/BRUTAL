namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHostQueryResetFeatures.html">VkPhysicalDeviceHostQueryResetFeatures</see> - Structure describing whether queries can be reset from the host
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceHostQueryResetFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceHostQueryResetFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hostQueryReset;
    ///         } VkPhysicalDeviceHostQueryResetFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceHostQueryResetFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HostQueryReset</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HostQueryReset;
    }
}
