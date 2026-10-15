namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAmigoProfilingSubmitInfoSEC.html">VkAmigoProfilingSubmitInfoSEC</see> - Stub description of VkAmigoProfilingSubmitInfoSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_amigo_profiling
    ///         typedef struct VkAmigoProfilingSubmitInfoSEC {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           firstDrawTimestamp;
    ///             uint64_t           swapBufferTimestamp;
    ///         } VkAmigoProfilingSubmitInfoSEC;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAmigoProfilingSubmitInfoSEC()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AmigoProfilingSubmitInfoSEC;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FirstDrawTimestamp</c>
        /// </summary>
        [FieldOffset(16)]
        public nint FirstDrawTimestamp;

        /// <summary>
        ///     <c>SwapBufferTimestamp</c>
        /// </summary>
        [FieldOffset(24)]
        public nint SwapBufferTimestamp;
    }
}
