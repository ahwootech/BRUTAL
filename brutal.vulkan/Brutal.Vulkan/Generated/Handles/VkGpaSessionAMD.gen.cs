namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaSessionAMD.html">VkGpaSessionAMD</see> - Opaque handle to a GPU Performance API object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         GPU Performance API (GPA) session objects hold the results of sampled
    ///         performance counters and are represented by <c>VkGpaSessionAMD</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkGpaSessionAMD)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkGpaSessionAMD : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.GpaSessionAMD;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkGpaSessionAMD(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkGpaSessionAMD NullHandle = new();
    }
}
