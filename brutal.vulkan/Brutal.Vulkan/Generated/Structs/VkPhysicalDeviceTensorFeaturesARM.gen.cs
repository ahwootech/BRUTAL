namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTensorFeaturesARM.html">VkPhysicalDeviceTensorFeaturesARM</see> - Structure describing tensor features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTensorFeaturesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceTensorFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           tensorNonPacked;
    ///             VkBool32           shaderTensorAccess;
    ///             VkBool32           shaderStorageTensorArrayDynamicIndexing;
    ///             VkBool32           shaderStorageTensorArrayNonUniformIndexing;
    ///             VkBool32           descriptorBindingStorageTensorUpdateAfterBind;
    ///             VkBool32           tensors;
    ///         } VkPhysicalDeviceTensorFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceTensorFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTensorFeaturesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorNonPacked</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TensorNonPacked;

        /// <summary>
        ///     <c>ShaderTensorAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderTensorAccess;

        /// <summary>
        ///     <c>ShaderStorageTensorArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderStorageTensorArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderStorageTensorArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderStorageTensorArrayNonUniformIndexing;

        /// <summary>
        ///     <c>DescriptorBindingStorageTensorUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 DescriptorBindingStorageTensorUpdateAfterBind;

        /// <summary>
        ///     <c>Tensors</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 Tensors;
    }
}
