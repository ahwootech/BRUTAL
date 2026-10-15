namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkProtectedSubmitInfo.html">VkProtectedSubmitInfo</see> - Structure indicating whether the submission is protected
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSubmitInfo</c> includes a
    ///         <c>VkProtectedSubmitInfo</c> structure, then the structure indicates whether
    ///         the batch is protected.
    ///         The <c>VkProtectedSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkProtectedSubmitInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           protectedSubmit;
    ///         } VkProtectedSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkProtectedSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ProtectedSubmitInfo;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProtectedSubmit</c> specifies whether the batch is protected. If <c>protectedSubmit</c> is <c>VK_TRUE</c>, the batch is protected. If <c>protectedSubmit</c> is <c>VK_FALSE</c>, the batch is unprotected. If the <c>VkSubmitInfo::pNext</c> chain does not include this structure, the batch is unprotected.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ProtectedSubmit;
    }
}
