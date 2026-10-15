namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaSampleBeginInfoAMD.html">VkGpaSampleBeginInfoAMD</see> - Structure specifying parameters of a GPA sample
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGpaSampleBeginInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaSampleBeginInfoAMD {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkGpaSampleTypeAMD            sampleType;
    ///             VkBool32                      sampleInternalOperations;
    ///             VkBool32                      cacheFlushOnCounterCollection;
    ///             VkBool32                      sqShaderMaskEnable;
    ///             VkGpaSqShaderStageFlagsAMD    sqShaderMask;
    ///             uint32_t                      perfCounterCount;
    ///             const VkGpaPerfCounterAMD*    pPerfCounters;
    ///             uint32_t                      streamingPerfTraceSampleInterval;
    ///             VkDeviceSize                  perfCounterDeviceMemoryLimit;
    ///             VkBool32                      sqThreadTraceEnable;
    ///             VkBool32                      sqThreadTraceSuppressInstructionTokens;
    ///             VkDeviceSize                  sqThreadTraceDeviceMemoryLimit;
    ///             VkPipelineStageFlags          timingPreSample;
    ///             VkPipelineStageFlags          timingPostSample;
    ///         } VkGpaSampleBeginInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkGpaSampleBeginInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GpaSampleBeginInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleType</c> is a <c>VkGpaSampleTypeAMD</c> value specifying the type of sample.
        /// </summary>
        [FieldOffset(16)]
        public VkGpaSampleTypeAMD SampleType;

        /// <summary>
        ///     <c>SampleInternalOperations</c> is a boolean indicating whether internal driver operations are included in the results.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SampleInternalOperations;

        /// <summary>
        ///     <c>CacheFlushOnCounterCollection</c> is a boolean indicating whether the driver should insert cache flush and invalidate events before and after every sample.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 CacheFlushOnCounterCollection;

        /// <summary>
        ///     <c>SqShaderMaskEnable</c> is a boolean indicating whether <c>sqShaderMask</c> specifies the shader stages to sample. If <c>VK_FALSE</c>, all shader stages are sampled.
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 SqShaderMaskEnable;

        /// <summary>
        ///     <c>SqShaderMask</c> is a bitmask of <c>VkGpaSqShaderStageFlagsAMD</c> values specifying which shader stages to sample. Shader stage bits that are not relevant to the specific device are ignored.
        /// </summary>
        [FieldOffset(32)]
        public VkGpaSqShaderStageFlagsAMD SqShaderMask;

        /// <summary>
        ///     <c>PerfCounterCount</c> is the number of counters in the <c>pPerfCounters</c> array
        /// </summary>
        [FieldOffset(36)]
        public int PerfCounterCount;

        /// <summary>
        ///     <c>PerfCounters</c> is a pointer to an array of <c>VkGpaPerfCounterAMD</c> structures specifying the counters to be sampled. If <c>sampleType</c> is <c>VK_GPA_SAMPLE_TYPE_CUMULATIVE_AMD</c> <c>pPerfCounters</c> specifies the counters that are sampled at the beginning and at end of the sample period. If <c>sampleType</c> is <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c> then the SPM data will be added to the samples RGP data blob.
        /// </summary>
        [FieldOffset(40)]
        public VkGpaPerfCounterAMD* PerfCounters;

        /// <summary>
        ///     <c>StreamingPerfTraceSampleInterval</c> is a value specifying the period for SPM samples in cycles, and is ignored if <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c>.
        /// </summary>
        [FieldOffset(48)]
        public int StreamingPerfTraceSampleInterval;

        /// <summary>
        ///     <c>PerfCounterDeviceMemoryLimit</c> is a value specifying the maximum amount of GPU memory that this sample can allocate for SPM data. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 PerfCounterDeviceMemoryLimit;

        /// <summary>
        ///     <c>SqThreadTraceEnable</c> is a boolean specifying whether SQTT data should be included. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 SqThreadTraceEnable;

        /// <summary>
        ///     <c>SqThreadTraceSuppressInstructionTokens</c> is a boolean specifying whether instruction-level SQTT tokens should be captured. If <c>VK_FALSE</c>, the amount of sample data is significantly reduced. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 SqThreadTraceSuppressInstructionTokens;

        /// <summary>
        ///     <c>SqThreadTraceDeviceMemoryLimit</c> is a value specifying the maximum amount of GPU memory in bytes that this sample can allocate for the SQTT buffer. If `0`, the maximum size to prevent dropping tokens towards the end of the sample is allocated. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TRACE_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(72)]
        public ByteSize64 SqThreadTraceDeviceMemoryLimit;

        /// <summary>
        ///     <c>TimingPreSample</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages specifying where the begin timestamp should take place. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TIMING_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(80)]
        public VkPipelineStageFlags TimingPreSample;

        /// <summary>
        ///     <c>TimingPostSample</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages specifying where the end timestamp should take place. If <c>sampleType</c> is not <c>VK_GPA_SAMPLE_TYPE_TIMING_AMD</c> this value is ignored.
        /// </summary>
        [FieldOffset(84)]
        public VkPipelineStageFlags TimingPostSample;
    }
}
