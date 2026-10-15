namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCubicClampFeaturesQCOM.html">VkPhysicalDeviceCubicClampFeaturesQCOM</see> - Structure describing cubic clamp features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCubicClampFeaturesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_filter_cubic_clamp
    ///         typedef struct VkPhysicalDeviceCubicClampFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cubicRangeClamp;
    ///         } VkPhysicalDeviceCubicClampFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCubicClampFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCubicClampFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CubicRangeClamp</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CubicRangeClamp;
    }
}
