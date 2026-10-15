namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html">VkVideoEncodeRateControlInfoKHR</see> - Structure to set encode stream rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeRateControlInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeRateControlInfoKHR {
    ///             VkStructureType                                sType;
    ///             const void*                                    pNext;
    ///             VkVideoEncodeRateControlFlagsKHR               flags;
    ///             VkVideoEncodeRateControlModeFlagBitsKHR        rateControlMode;
    ///             uint32_t                                       layerCount;
    ///             const VkVideoEncodeRateControlLayerInfoKHR*    pLayers;
    ///             uint32_t                                       virtualBufferSizeInMs;
    ///             uint32_t                                       initialVirtualBufferSizeInMs;
    ///         } VkVideoEncodeRateControlInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoEncodeRateControlInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeRateControlInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeRateControlFlagsKHR Flags;

        /// <summary>
        ///     <c>RateControlMode</c> is a <c>VkVideoEncodeRateControlModeFlagsKHR</c> value specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeRateControlModeFlagsKHR RateControlMode;

        /// <summary>
        ///     <c>LayerCount</c> specifies the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-layers">rate control layers^</see> to use.
        /// </summary>
        [FieldOffset(24)]
        public int LayerCount;

        /// <summary>
        ///     <c>Layers</c> is a pointer to an array of <c>layerCount</c> <c>VkVideoEncodeRateControlLayerInfoKHR</c> structures, each specifying the rate control configuration of the corresponding rate control layer.
        /// </summary>
        [FieldOffset(32)]
        public VkVideoEncodeRateControlLayerInfoKHR* Layers;

        /// <summary>
        ///     <c>VirtualBufferSizeInMs</c> is the size in milliseconds of the virtual buffer used by the implementation&apos;s rate control algorithm for the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-leaky-bucket-model">leaky bucket model^</see>, with respect to the average bitrate of the stream calculated by summing the values of the <c>averageBitrate</c> members of the elements of the <c>pLayers</c> array.
        /// </summary>
        [FieldOffset(40)]
        public int VirtualBufferSizeInMs;

        /// <summary>
        ///     <c>InitialVirtualBufferSizeInMs</c> is the initial occupancy in milliseconds of the virtual buffer used by the implementation&apos;s rate control algorithm for the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-leaky-bucket-model">leaky bucket model^</see>.
        /// </summary>
        [FieldOffset(44)]
        public int InitialVirtualBufferSizeInMs;
    }
}
