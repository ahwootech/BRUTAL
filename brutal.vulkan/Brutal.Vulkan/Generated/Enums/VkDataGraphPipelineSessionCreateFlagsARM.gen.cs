namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionCreateFlagBitsARM.html">VkDataGraphPipelineSessionCreateFlagBitsARM</see> - Bitmask specifying additional parameters of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphPipelineSessionCreateInfoARM::flags</c>, specifying
    ///         additional parameters of a data graph pipeline session, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         // Flag bits for VkDataGraphPipelineSessionCreateFlagBitsARM
    ///         typedef VkFlags64 VkDataGraphPipelineSessionCreateFlagBitsARM;
    ///             static const VkDataGraphPipelineSessionCreateFlagBitsARM VK_DATA_GRAPH_PIPELINE_SESSION_CREATE_PROTECTED_BIT_ARM = 0x00000001ULL;
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             static const VkDataGraphPipelineSessionCreateFlagBitsARM VK_DATA_GRAPH_PIPELINE_SESSION_CREATE_OPTICAL_FLOW_CACHE_BIT_ARM = 0x00000002ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkDataGraphPipelineSessionCreateFlagsARM : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedBitARM</c> specifies that the data graph pipeline session is backed by protected memory.
        /// </summary>
        ProtectedBitARM = 0x00000001,

        /// <summary>
        ///     <c>OpticalFlowCacheBitARM</c>
        /// </summary>
        OpticalFlowCacheBitARM = 0x00000002,
    }
}
