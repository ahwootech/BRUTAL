namespace Brutal.VulkanApi;

/// <summary>
///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTransformMatrixKHR.html">VkTransformMatrixKHR</see> - Structure specifying a 3x4 affine transformation matrix
/// </summary>
/// <remarks>
///     <para>
///         :refpage: VkTransformMatrixKHR
///     </para>
///     <para>
///         The <c>VkTransformMatrixKHR</c> structure is defined as:
///     </para>
///     <code>
///         // Provided by VK_KHR_acceleration_structure
///         typedef struct VkTransformMatrixKHR {
///             float    matrix[3][4];
///         } VkTransformMatrixKHR;
///     </code>
/// </remarks>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct VkTransformMatrixKHR
{
    public float4 X;
    public float4 Y;
    public float4 Z;
}
