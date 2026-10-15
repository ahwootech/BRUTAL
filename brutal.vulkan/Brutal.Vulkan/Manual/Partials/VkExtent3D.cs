namespace Brutal.VulkanApi;

public partial struct VkExtent3D
{
    public VkExtent3D(int width, int height, int depth)
        : this()
    {
        Width = width;
        Height = height;
        Depth = depth;
    }
}
