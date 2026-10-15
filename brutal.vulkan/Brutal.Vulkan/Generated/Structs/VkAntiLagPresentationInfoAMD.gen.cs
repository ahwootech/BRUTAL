namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAntiLagPresentationInfoAMD.html">VkAntiLagPresentationInfoAMD</see> - Structure specifying information about stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAntiLagPresentationInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_anti_lag
    ///         typedef struct VkAntiLagPresentationInfoAMD {
    ///             VkStructureType      sType;
    ///             void*                pNext;
    ///             VkAntiLagStageAMD    stage;
    ///             uint64_t             frameIndex;
    ///         } VkAntiLagPresentationInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAntiLagPresentationInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AntiLagPresentationInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Stage</c> is a <c>VkAntiLagStageAMD</c> value specifying the current application stage.
        /// </summary>
        [FieldOffset(16)]
        public VkAntiLagStageAMD Stage;

        /// <summary>
        ///     <c>FrameIndex</c> is set just before the application processes input data (<c>VK_ANTI_LAG_STAGE_INPUT_AMD</c>). The same <c>frameIndex</c> value <i>should</i> be set before the frame with current input data will be presented by <c>vkQueuePresentKHR</c> (<c>VK_ANTI_LAG_STAGE_PRESENT_AMD</c>). This <i>should</i> be done for each frame.
        /// </summary>
        [FieldOffset(24)]
        public nint FrameIndex;
    }
}
