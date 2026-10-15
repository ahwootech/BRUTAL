namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCuLaunchInfoNVX.html">VkCuLaunchInfoNVX</see> - Stub description of VkCuLaunchInfoNVX
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_binary_import
    ///         typedef struct VkCuLaunchInfoNVX {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkCuFunctionNVX        function;
    ///             uint32_t               gridDimX;
    ///             uint32_t               gridDimY;
    ///             uint32_t               gridDimZ;
    ///             uint32_t               blockDimX;
    ///             uint32_t               blockDimY;
    ///             uint32_t               blockDimZ;
    ///             uint32_t               sharedMemBytes;
    ///             size_t                 paramCount;
    ///             const void* const *    pParams;
    ///             size_t                 extraCount;
    ///             const void* const *    pExtras;
    ///         } VkCuLaunchInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkCuLaunchInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CuLaunchInfoNVX;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Function</c>
        /// </summary>
        [FieldOffset(16)]
        public VkCuFunctionNVX Function;

        /// <summary>
        ///     <c>GridDimX</c>
        /// </summary>
        [FieldOffset(24)]
        public int GridDimX;

        /// <summary>
        ///     <c>GridDimY</c>
        /// </summary>
        [FieldOffset(28)]
        public int GridDimY;

        /// <summary>
        ///     <c>GridDimZ</c>
        /// </summary>
        [FieldOffset(32)]
        public int GridDimZ;

        /// <summary>
        ///     <c>BlockDimX</c>
        /// </summary>
        [FieldOffset(36)]
        public int BlockDimX;

        /// <summary>
        ///     <c>BlockDimY</c>
        /// </summary>
        [FieldOffset(40)]
        public int BlockDimY;

        /// <summary>
        ///     <c>BlockDimZ</c>
        /// </summary>
        [FieldOffset(44)]
        public int BlockDimZ;

        /// <summary>
        ///     <c>SharedMemBytes</c>
        /// </summary>
        [FieldOffset(48)]
        public int SharedMemBytes;

        /// <summary>
        ///     <c>ParamCount</c>
        /// </summary>
        [FieldOffset(56)]
        public nuint ParamCount;

        /// <summary>
        ///     <c>Params</c>
        /// </summary>
        [FieldOffset(64)]
        public void** Params;

        /// <summary>
        ///     <c>ExtraCount</c>
        /// </summary>
        [FieldOffset(72)]
        public nuint ExtraCount;

        /// <summary>
        ///     <c>Extras</c>
        /// </summary>
        [FieldOffset(80)]
        public void** Extras;
    }
}
