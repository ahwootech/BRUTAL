namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryTensorsARM.html">VkFrameBoundaryTensorsARM</see> - Add tensor frame boundary information to queue submissions
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFrameBoundaryTensorsARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_frame_boundary with VK_ARM_tensors
    ///         typedef struct VkFrameBoundaryTensorsARM {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             uint32_t              tensorCount;
    ///             const VkTensorARM*    pTensors;
    ///         } VkFrameBoundaryTensorsARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFrameBoundaryTensorsARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FrameBoundaryTensorsARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorCount</c> is the number of tensors that store frame results.
        /// </summary>
        [FieldOffset(16)]
        public int TensorCount;

        /// <summary>
        ///     <c>Tensors</c> is a pointer to an array of <c>VkTensorARM</c> objects with tensorCount entries.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorARM* Tensors;
    }
}
