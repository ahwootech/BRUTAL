namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265GopRemainingFrameInfoKHR.html">VkVideoEncodeH265GopRemainingFrameInfoKHR</see> - Structure specifying H.265 encode rate control GOP remaining frame counts
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265GopRemainingFrameInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265GopRemainingFrameInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           useGopRemainingFrames;
    ///             uint32_t           gopRemainingI;
    ///             uint32_t           gopRemainingP;
    ///             uint32_t           gopRemainingB;
    ///         } VkVideoEncodeH265GopRemainingFrameInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeH265GopRemainingFrameInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265GopRemainingFrameInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseGopRemainingFrames</c> indicates whether the implementation&apos;s rate control algorithm <i>should</i> use the values specified in <c>gopRemainingI</c>, <c>gopRemainingP</c>, and <c>gopRemainingB</c>. If <c>useGopRemainingFrames</c> is <c>VK_FALSE</c>, then the values of <c>gopRemainingI</c>, <c>gopRemainingP</c>, and <c>gopRemainingB</c> are ignored.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseGopRemainingFrames;

        /// <summary>
        ///     <c>GopRemainingI</c> specifies the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-i-pic">I frames^</see> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-gop">GOP^</see> prior to executing the video encode operation.
        /// </summary>
        [FieldOffset(20)]
        public int GopRemainingI;

        /// <summary>
        ///     <c>GopRemainingP</c> specifies the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-p-pic">P frames^</see> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-gop">GOP^</see> prior to executing the video encode operation.
        /// </summary>
        [FieldOffset(24)]
        public int GopRemainingP;

        /// <summary>
        ///     <c>GopRemainingB</c> specifies the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B frames^</see> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-gop">GOP^</see> prior to executing the video encode operation.
        /// </summary>
        [FieldOffset(28)]
        public int GopRemainingB;
    }
}
