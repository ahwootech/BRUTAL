namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// A builder for <see cref="VkPipelineShaderStageCreateInfo"></see>
/// </summary>
public class ShaderStages(Device inDevice, Span<VkPipelineShaderStageCreateInfo> inStages, VkAllocator? allocator)
    : IDisposable
{
    private readonly NativeList<VkPipelineShaderStageCreateInfo> _stages = new(inStages);

    /// <summary>
    /// The number of stages
    /// </summary>
    public int Count => _stages.Count;

    /// <summary>
    /// Destroy shaders (only call this if you know you are responsible for destroying them!)
    /// </summary>
    public void Dispose()
    {
        if (_stages.Count == 0)
            return;

        for (var index = 0; index < _stages.Count; index++)
            inDevice.DestroyShaderModule(_stages[index].Module, allocator);

        _stages.Count = 0;
    }

    /// <summary>
    /// Implicit cast to the <see cref="VkPipelineShaderStageCreateInfo">PipelineShaderStageCreateInfo</see> structure
    /// </summary>
    public static unsafe implicit operator VkPipelineShaderStageCreateInfo*(ShaderStages inValue) =>
        inValue._stages.Ptr;

    /// <summary>
    /// Offset the stages by some number
    /// </summary>
    public static unsafe VkPipelineShaderStageCreateInfo* operator +(ShaderStages inStages, int inValue)
    {
        if (inStages.Count <= inValue)
            throw new ArgumentOutOfRangeException(nameof(inValue));

        return (VkPipelineShaderStageCreateInfo*)inStages + inValue;
    }

    /// <summary>
    /// Create a span from a subset of the shader stages
    /// </summary>
    /// <param name="start">The start element</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Span<VkPipelineShaderStageCreateInfo> Slice(int start)
    {
        return _stages.Slice(start);
    }

    /// <summary>
    /// Create a span from a subset of the shader stages
    /// </summary>
    /// <param name="start">The start element</param>
    /// <param name="length">How many elements to include</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Span<VkPipelineShaderStageCreateInfo> Slice(int start, int length)
    {
        return _stages.Slice(start, length);
    }
}
