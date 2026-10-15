namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAntiLagDataAMD.html">VkAntiLagDataAMD</see> - Structure specifying the parameters for vkAntiLagUpdateAMD
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAntiLagDataAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_anti_lag
    ///         typedef struct VkAntiLagDataAMD {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkAntiLagModeAMD                       mode;
    ///             uint32_t                               maxFPS;
    ///             const VkAntiLagPresentationInfoAMD*    pPresentationInfo;
    ///         } VkAntiLagDataAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAntiLagDataAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AntiLagDataAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkAntiLagModeAMD</c> value specifying the anti-lag status.
        /// </summary>
        [FieldOffset(16)]
        public VkAntiLagModeAMD Mode;

        /// <summary>
        ///     <c>MaxFPS</c> is the framerate limit, in frames per second, used by the application. This limit will be imposed if anti-lag is enabled. If the application tries to render faster, the framerate will be reduced to match this limit. A value of 0 will disable the limit.
        /// </summary>
        [FieldOffset(20)]
        public int MaxFPS;

        /// <summary>
        ///     <c>PresentationInfo</c> is a pointer to a <c>VkAntiLagPresentationInfoAMD</c> structure containing information about the application stage.
        /// </summary>
        [FieldOffset(24)]
        public VkAntiLagPresentationInfoAMD* PresentationInfo;
    }
}
