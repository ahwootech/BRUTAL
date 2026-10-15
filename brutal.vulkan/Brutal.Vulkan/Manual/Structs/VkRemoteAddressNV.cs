namespace Brutal.VulkanApi;

public readonly record struct VkRemoteAddressNV(nint Value)
{
    public static implicit operator VkRemoteAddressNV(int value) => new VkRemoteAddressNV((nint)value);
}
