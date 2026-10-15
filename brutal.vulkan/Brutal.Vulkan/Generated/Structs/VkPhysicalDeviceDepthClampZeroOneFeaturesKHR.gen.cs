namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDepthClampZeroOneFeaturesKHR.html">VkPhysicalDeviceDepthClampZeroOneFeaturesKHR</see> - Structure describing feature to control zero to one depth clamping
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDepthClampZeroOneFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_depth_clamp_zero_one
    ///         typedef struct VkPhysicalDeviceDepthClampZeroOneFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           depthClampZeroOne;
    ///         } VkPhysicalDeviceDepthClampZeroOneFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDepthClampZeroOneFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDepthClampZeroOneFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthClampZeroOne</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DepthClampZeroOne;
    }
}
