namespace Brutal.VulkanApi;

public readonly record struct VkDeviceAddress(ulong Value)
{
    public static implicit operator VkDeviceAddress(int value) => new VkDeviceAddress((ulong)value);
}
