namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInvocationMaskFeaturesHUAWEI.html">VkPhysicalDeviceInvocationMaskFeaturesHUAWEI</see> - Structure describing invocation mask features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceInvocationMaskFeaturesHUAWEI</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_invocation_mask
    ///         typedef struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           invocationMask;
    ///         } VkPhysicalDeviceInvocationMaskFeaturesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceInvocationMaskFeaturesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>InvocationMask</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 InvocationMask;
    }
}
