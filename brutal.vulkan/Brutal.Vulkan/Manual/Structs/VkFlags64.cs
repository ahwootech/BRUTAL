namespace Brutal.VulkanApi;

public readonly record struct VkFlags64(ulong Value)
{
    public static implicit operator VkFlags64(int value) => new VkFlags64((ulong)value);
}
