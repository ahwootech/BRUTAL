namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyCommandTransformInfoQCOM.html">VkCopyCommandTransformInfoQCOM</see> - Structure describing transform parameters of rotated copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCopyCommandTransformInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_rotated_copy_commands
    ///         typedef struct VkCopyCommandTransformInfoQCOM {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkSurfaceTransformFlagBitsKHR    transform;
    ///         } VkCopyCommandTransformInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCopyCommandTransformInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyCommandTransformInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Transform</c> is a <c>VkSurfaceTransformFlagsKHR</c> value describing the transform to be applied.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceTransformFlagsKHR Transform;
    }
}
