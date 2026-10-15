namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDepthStencilResolveProperties.html">VkPhysicalDeviceDepthStencilResolveProperties</see> - Structure describing depth/stencil resolve properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDepthStencilResolveProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceDepthStencilResolveProperties {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkResolveModeFlags    supportedDepthResolveModes;
    ///             VkResolveModeFlags    supportedStencilResolveModes;
    ///             VkBool32              independentResolveNone;
    ///             VkBool32              independentResolve;
    ///         } VkPhysicalDeviceDepthStencilResolveProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDepthStencilResolveProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedDepthResolveModes</c>
        /// </summary>
        [FieldOffset(16)]
        public VkResolveModeFlags SupportedDepthResolveModes;

        /// <summary>
        ///     <c>SupportedStencilResolveModes</c>
        /// </summary>
        [FieldOffset(20)]
        public VkResolveModeFlags SupportedStencilResolveModes;

        /// <summary>
        ///     <c>IndependentResolveNone</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 IndependentResolveNone;

        /// <summary>
        ///     <c>IndependentResolve</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 IndependentResolve;
    }
}
