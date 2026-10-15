namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice8BitStorageFeatures.html">VkPhysicalDevice8BitStorageFeatures</see> - Structure describing features supported by VK_KHR_8bit_storage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevice8BitStorageFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDevice8BitStorageFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           storageBuffer8BitAccess;
    ///             VkBool32           uniformAndStorageBuffer8BitAccess;
    ///             VkBool32           storagePushConstant8;
    ///         } VkPhysicalDevice8BitStorageFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevice8BitStorageFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevice8BitStorageFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StorageBuffer8BitAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 StorageBuffer8BitAccess;

        /// <summary>
        ///     <c>UniformAndStorageBuffer8BitAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 UniformAndStorageBuffer8BitAccess;

        /// <summary>
        ///     <c>StoragePushConstant8</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 StoragePushConstant8;
    }
}
