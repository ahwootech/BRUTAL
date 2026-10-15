using System.Runtime.CompilerServices;

namespace Brutal.VulkanApi.Vma;

public static class VmaDeviceExtensions
{
    /// <summary>
    /// Creates a VmaAllocator object.
    /// </summary>
    /// <remarks>Fills unset Instance and vkGet*ProcAddr from <paramref name="device"/>.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VmaAllocator CreateVmaAllocator(this Device device, VmaAllocatorCreateInfo pCreateInfo)
    {
        return new VmaAllocator(device, device.CreateVmaAllocatorHandle(pCreateInfo));
    }

    /// <summary>
    /// Creates a raw VmaAllocator handle for custom wrappers. Free with vmaDestroyAllocator.
    /// </summary>
    /// <remarks>Fills unset Instance and vkGet*ProcAddr from <paramref name="device"/>.</remarks>
    public static unsafe VmaAllocatorHandle CreateVmaAllocatorHandle(
        this Device device,
        VmaAllocatorCreateInfo pCreateInfo
    )
    {
        if (pCreateInfo.Instance.IsNull())
            pCreateInfo.Instance = device.PhysicalDevice.Instance.Handle;

        // VMA copies this
        var vulkanFunctions = pCreateInfo.PVulkanFunctions.IsNull() ? default : pCreateInfo.PVulkanFunctions.Value;
        if (vulkanFunctions.VkGetInstanceProcAddr.Invoke == null)
            vulkanFunctions.VkGetInstanceProcAddr = Vulkan.GetInstanceProcAddr;
        if (vulkanFunctions.VkGetDeviceProcAddr.Invoke == null)
            vulkanFunctions.VkGetDeviceProcAddr = device.PInvoke.vkGetDeviceProcAddr;
        pCreateInfo.PVulkanFunctions = &vulkanFunctions;

        var allocatorHandle = new VmaAllocatorHandle();
        var result = Vma.PInvoke.vmaCreateAllocator(&pCreateInfo, &allocatorHandle);
        if (result != VkResult.Success)
            throw new Exception("Failed to create VmaAllocator");

        return allocatorHandle;
    }

    /// <summary>
    /// Destroys a VmaAllocator object.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void DestroyVmaAllocator(this Device device, VmaAllocator allocator)
    {
        Vma.PInvoke.vmaDestroyAllocator(allocator.VkHandle);
    }
}
