namespace Brutal.VulkanApi;

public readonly record struct VkSampleMask(uint Value)
{
    public static implicit operator VkSampleMask(int value) => new VkSampleMask((uint)value);
}
