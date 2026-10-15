namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineLibraryFlagBitsEXT.html">VkGraphicsPipelineLibraryFlagBitsEXT</see> - Bitmask specifying the subset of a graphics pipeline to compile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>flags</c> member of
    ///         <c>VkGraphicsPipelineLibraryCreateInfoEXT</c>, specifying the subsets of a
    ///         graphics pipeline to compile are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_graphics_pipeline_library
    ///         typedef enum VkGraphicsPipelineLibraryFlagBitsEXT {
    ///             VK_GRAPHICS_PIPELINE_LIBRARY_VERTEX_INPUT_INTERFACE_BIT_EXT = 0x00000001,
    ///             VK_GRAPHICS_PIPELINE_LIBRARY_PRE_RASTERIZATION_SHADERS_BIT_EXT = 0x00000002,
    ///             VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_SHADER_BIT_EXT = 0x00000004,
    ///             VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_OUTPUT_INTERFACE_BIT_EXT = 0x00000008,
    ///         } VkGraphicsPipelineLibraryFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkGraphicsPipelineLibraryFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>VertexInputInterfaceBitEXT</c>  specifies that a pipeline will include <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-graphics-subsets-vertex-input">vertex input interface state^</see>.
        /// </summary>
        VertexInputInterfaceBitEXT = 0x00000001,

        /// <summary>
        ///     <c>PreRasterizationShadersBitEXT</c>  specifies that a pipeline will include <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-graphics-subsets-pre-rasterization">pre-rasterization shader state^</see>.
        /// </summary>
        PreRasterizationShadersBitEXT = 0x00000002,

        /// <summary>
        ///     <c>FragmentShaderBitEXT</c> specifies that a pipeline will include <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-graphics-subsets-fragment-shader">fragment shader state^</see>.
        /// </summary>
        FragmentShaderBitEXT = 0x00000004,

        /// <summary>
        ///     <c>FragmentOutputInterfaceBitEXT</c>  specifies that a pipeline will include <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-graphics-subsets-fragment-output">fragment output interface state^</see>.
        /// </summary>
        FragmentOutputInterfaceBitEXT = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
