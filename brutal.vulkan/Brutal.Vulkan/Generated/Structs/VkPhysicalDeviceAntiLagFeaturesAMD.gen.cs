namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAntiLagFeaturesAMD.html">VkPhysicalDeviceAntiLagFeaturesAMD</see> - Structure describing whether VK_AMD_anti_lag can be supported by an implementation.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceAntiLagFeaturesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_anti_lag
    ///         typedef struct VkPhysicalDeviceAntiLagFeaturesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           antiLag;
    ///         } VkPhysicalDeviceAntiLagFeaturesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceAntiLagFeaturesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceAntiLagFeaturesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AntiLag</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AntiLag;
    }
}
