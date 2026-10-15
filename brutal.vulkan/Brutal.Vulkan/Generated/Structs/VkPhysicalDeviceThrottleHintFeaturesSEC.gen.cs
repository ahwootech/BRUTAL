namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceThrottleHintFeaturesSEC.html">VkPhysicalDeviceThrottleHintFeaturesSEC</see> - Stub description of VkPhysicalDeviceThrottleHintFeaturesSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[features-throttleHint]]
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_throttle_hint
    ///         typedef struct VkPhysicalDeviceThrottleHintFeaturesSEC {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           throttleHint;
    ///         } VkPhysicalDeviceThrottleHintFeaturesSEC;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceThrottleHintFeaturesSEC()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceThrottleHintFeaturesSEC;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ThrottleHint</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ThrottleHint;
    }
}
