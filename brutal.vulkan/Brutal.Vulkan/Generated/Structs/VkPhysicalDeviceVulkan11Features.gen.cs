namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Features.html">VkPhysicalDeviceVulkan11Features</see> - Structure describing the Vulkan 1.1 features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan11Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceVulkan11Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           storageBuffer16BitAccess;
    ///             VkBool32           uniformAndStorageBuffer16BitAccess;
    ///             VkBool32           storagePushConstant16;
    ///             VkBool32           storageInputOutput16;
    ///             VkBool32           multiview;
    ///             VkBool32           multiviewGeometryShader;
    ///             VkBool32           multiviewTessellationShader;
    ///             VkBool32           variablePointersStorageBuffer;
    ///             VkBool32           variablePointers;
    ///             VkBool32           protectedMemory;
    ///             VkBool32           samplerYcbcrConversion;
    ///             VkBool32           shaderDrawParameters;
    ///         } VkPhysicalDeviceVulkan11Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceVulkan11Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan11Features;

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

        /// <summary>
        ///     <c>Multiview</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 Multiview;

        /// <summary>
        ///     <c>MultiviewGeometryShader</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 MultiviewGeometryShader;

        /// <summary>
        ///     <c>MultiviewTessellationShader</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 MultiviewTessellationShader;

        /// <summary>
        ///     <c>VariablePointersStorageBuffer</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 VariablePointersStorageBuffer;

        /// <summary>
        ///     <c>VariablePointers</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 VariablePointers;

        /// <summary>
        ///     <c>ProtectedMemory</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ProtectedMemory;

        /// <summary>
        ///     <c>SamplerYcbcrConversion</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 SamplerYcbcrConversion;

        /// <summary>
        ///     <c>ShaderDrawParameters</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ShaderDrawParameters;
    }
}
