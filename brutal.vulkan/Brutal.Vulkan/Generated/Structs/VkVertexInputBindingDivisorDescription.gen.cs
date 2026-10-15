namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDivisorDescription.html">VkVertexInputBindingDivisorDescription</see> - Structure specifying a divisor used in instanced rendering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The individual divisor values per binding are specified using the
    ///         <c>VkVertexInputBindingDivisorDescription</c> structure which is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkVertexInputBindingDivisorDescription {
    ///             uint32_t    binding;
    ///             uint32_t    divisor;
    ///         } VkVertexInputBindingDivisorDescription;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkVertexInputBindingDivisorDescription()
    {
        /// <summary>
        ///     <c>Binding</c> is the binding number for which the divisor is specified.
        /// </summary>
        [FieldOffset(0)]
        public int Binding;

        /// <summary>
        ///     <c>Divisor</c> is the number of successive instances that will use the same value of the vertex attribute when instanced rendering is enabled. For example, if the divisor is N, the same vertex attribute will be applied to N successive instances before moving on to the next vertex attribute. The maximum value of <c>divisor</c> is implementation-dependent and can be queried using <c>VkPhysicalDeviceVertexAttributeDivisorProperties::maxVertexAttribDivisor</c>. A value of `0` <i>can</i> be used for the divisor if the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-vertexAttributeInstanceRateZeroDivisor"><c>vertexAttributeInstanceRateZeroDivisor</c>^</see> feature is enabled. In this case, the same vertex attribute will be applied to all instances.
        /// </summary>
        [FieldOffset(4)]
        public int Divisor;
    }
}
