namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice16BitStorageFeatures.html">VkPhysicalDevice16BitStorageFeatures</see> - Structure describing features supported by VK_KHR_16bit_storage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevice16BitStorageFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDevice16BitStorageFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           storageBuffer16BitAccess;
    ///             VkBool32           uniformAndStorageBuffer16BitAccess;
    ///             VkBool32           storagePushConstant16;
    ///             VkBool32           storageInputOutput16;
    ///         } VkPhysicalDevice16BitStorageFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevice16BitStorageFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StorageBuffer16BitAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 StorageBuffer16BitAccess;

        /// <summary>
        ///     <c>UniformAndStorageBuffer16BitAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 UniformAndStorageBuffer16BitAccess;

        /// <summary>
        ///     <c>StoragePushConstant16</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 StoragePushConstant16;

        /// <summary>
        ///     <c>StorageInputOutput16</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 StorageInputOutput16;
    }
}
