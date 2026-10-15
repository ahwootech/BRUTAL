namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR.html">VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR</see> - Structure describing the workgroup storage explicit layout features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_workgroup_memory_explicit_layout
    ///         typedef struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           workgroupMemoryExplicitLayout;
    ///             VkBool32           workgroupMemoryExplicitLayoutScalarBlockLayout;
    ///             VkBool32           workgroupMemoryExplicitLayout8BitAccess;
    ///             VkBool32           workgroupMemoryExplicitLayout16BitAccess;
    ///         } VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WorkgroupMemoryExplicitLayout</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 WorkgroupMemoryExplicitLayout;

        /// <summary>
        ///     <c>WorkgroupMemoryExplicitLayoutScalarBlockLayout</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 WorkgroupMemoryExplicitLayoutScalarBlockLayout;

        /// <summary>
        ///     <c>WorkgroupMemoryExplicitLayout8BitAccess</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 WorkgroupMemoryExplicitLayout8BitAccess;

        /// <summary>
        ///     <c>WorkgroupMemoryExplicitLayout16BitAccess</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 WorkgroupMemoryExplicitLayout16BitAccess;
    }
}
