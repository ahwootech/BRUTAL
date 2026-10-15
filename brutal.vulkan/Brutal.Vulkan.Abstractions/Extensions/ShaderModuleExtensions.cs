namespace Brutal.VulkanApi.Abstractions;

public static class ShaderModuleExtensions
{
    public static unsafe VkShaderModule FromSpirv(Device device, ReadOnlySpan<byte> bytes, VkAllocator? allocator)
    {
        return device.CreateShaderModule(
            new VkShaderModuleCreateInfo { Code = bytes.Cast<byte, int>().AsPointer(), CodeSize = ByteSize.Of(bytes) },
            allocator
        );
    }
}
