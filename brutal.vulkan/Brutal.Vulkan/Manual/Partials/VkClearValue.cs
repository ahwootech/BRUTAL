namespace Brutal.VulkanApi;

public partial struct VkClearValue
{
    public static implicit operator VkClearValue(VkClearColorValue color) => new VkClearValue { Color = color };

    public static implicit operator VkClearValue(VkClearDepthStencilValue depthStencil) =>
        new VkClearValue { DepthStencil = depthStencil };
}
