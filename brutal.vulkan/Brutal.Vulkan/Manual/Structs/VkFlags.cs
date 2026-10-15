namespace Brutal.VulkanApi;

public readonly record struct VkFlags(uint Value)
{
    public static implicit operator VkFlags(int value) => new VkFlags((uint)value);
}
