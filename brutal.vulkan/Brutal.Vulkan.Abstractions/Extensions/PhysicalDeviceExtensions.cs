namespace Brutal.VulkanApi.Abstractions;

public static class PhysicalDeviceExtensions
{
    public static DeviceEx CreateDevice(this PhysicalDevice physicalDevice, DeviceEx.CreateInfo createInfo)
    {
        return new DeviceEx(physicalDevice, createInfo);
    }
}
