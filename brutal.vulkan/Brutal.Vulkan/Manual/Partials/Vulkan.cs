namespace Brutal.VulkanApi;

public static partial class Vulkan
{
    public static LogCategory Log = LogCategory.Make("Vulkan");

    /// <summary>
    /// Assembles the input parameters into a VkInstanceCreateInfo struct and uses it to create an instance
    /// </summary>
    public static Instance CreateInstance(Instance.CreateInfo createInfo)
    {
        return new Instance(createInfo);
    }
}
