namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2PropertiesNV.html">VkPhysicalDeviceCooperativeMatrix2PropertiesNV</see> - Structure describing cooperative matrix properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrix2PropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix2
    ///         typedef struct VkPhysicalDeviceCooperativeMatrix2PropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           cooperativeMatrixWorkgroupScopeMaxWorkgroupSize;
    ///             uint32_t           cooperativeMatrixFlexibleDimensionsMaxDimension;
    ///             uint32_t           cooperativeMatrixWorkgroupScopeReservedSharedMemory;
    ///         } VkPhysicalDeviceCooperativeMatrix2PropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2PropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrix2PropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrixWorkgroupScopeMaxWorkgroupSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int CooperativeMatrixWorkgroupScopeMaxWorkgroupSize;

        /// <summary>
        ///     <c>CooperativeMatrixFlexibleDimensionsMaxDimension</c>
        /// </summary>
        [FieldOffset(20)]
        public int CooperativeMatrixFlexibleDimensionsMaxDimension;

        /// <summary>
        ///     <c>CooperativeMatrixWorkgroupScopeReservedSharedMemory</c>
        /// </summary>
        [FieldOffset(24)]
        public int CooperativeMatrixWorkgroupScopeReservedSharedMemory;
    }
}
