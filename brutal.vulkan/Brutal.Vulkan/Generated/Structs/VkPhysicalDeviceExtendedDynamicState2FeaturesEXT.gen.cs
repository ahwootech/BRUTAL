namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState2FeaturesEXT.html">VkPhysicalDeviceExtendedDynamicState2FeaturesEXT</see> - Structure describing what extended dynamic state can be used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedDynamicState2FeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_extended_dynamic_state2
    ///         typedef struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           extendedDynamicState2;
    ///             VkBool32           extendedDynamicState2LogicOp;
    ///             VkBool32           extendedDynamicState2PatchControlPoints;
    ///         } VkPhysicalDeviceExtendedDynamicState2FeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedDynamicState2FeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExtendedDynamicState2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExtendedDynamicState2;

        /// <summary>
        ///     <c>ExtendedDynamicState2LogicOp</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ExtendedDynamicState2LogicOp;

        /// <summary>
        ///     <c>ExtendedDynamicState2PatchControlPoints</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ExtendedDynamicState2PatchControlPoints;
    }
}
