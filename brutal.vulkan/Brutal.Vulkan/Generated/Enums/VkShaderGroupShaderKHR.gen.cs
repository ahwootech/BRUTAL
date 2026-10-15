namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderGroupShaderKHR.html">VkShaderGroupShaderKHR</see> - Shader group shaders
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>groupShader</c> in
    ///         <c>vkGetRayTracingShaderGroupStackSizeKHR</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef enum VkShaderGroupShaderKHR {
    ///             VK_SHADER_GROUP_SHADER_GENERAL_KHR = 0,
    ///             VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR = 1,
    ///             VK_SHADER_GROUP_SHADER_ANY_HIT_KHR = 2,
    ///             VK_SHADER_GROUP_SHADER_INTERSECTION_KHR = 3,
    ///         } VkShaderGroupShaderKHR;
    ///     </code>
    /// </remarks>
    public enum VkShaderGroupShaderKHR : int
    {
        /// <summary>
        ///     <c>GeneralKHR</c> uses the shader specified in the group with <c>VkRayTracingShaderGroupCreateInfoKHR::generalShader</c>
        /// </summary>
        GeneralKHR = 0,

        /// <summary>
        ///     <c>ClosestHitKHR</c> uses the shader specified in the group with <c>VkRayTracingShaderGroupCreateInfoKHR::closestHitShader</c>
        /// </summary>
        ClosestHitKHR = 1,

        /// <summary>
        ///     <c>AnyHitKHR</c> uses the shader specified in the group with <c>VkRayTracingShaderGroupCreateInfoKHR::anyHitShader</c>
        /// </summary>
        AnyHitKHR = 2,

        /// <summary>
        ///     <c>IntersectionKHR</c> uses the shader specified in the group with <c>VkRayTracingShaderGroupCreateInfoKHR::intersectionShader</c>
        /// </summary>
        IntersectionKHR = 3,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
