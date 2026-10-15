namespace Brutal.VulkanApi;

public partial struct VkRect2D
{
    public VkRect2D(VkExtent2D extent)
        : this()
    {
        Offset = new VkOffset2D(0, 0);
        Extent = extent;
    }

    public VkRect2D(int width, int height)
        : this()
    {
        Offset = new VkOffset2D(0, 0);
        Extent = new VkExtent2D(width, height);
    }
}
