/*
 * HelloVulkanVma
 *
 * Creates a VMA allocator, allocates a buffer the CPU can write to through a persistent mapping,
 * writes a few numbers into it and prints them back. Nothing is drawn, so no window is needed.
 * See Demo/DemoVulkan.cs for VMA feeding a vertex buffer to draw a triangle in a window.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Vulkan@2026.10.3
#:package Ahwoo.Brutal.Vulkan.Vma@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4

using Brutal;
using Brutal.VulkanApi;
using Brutal.VulkanApi.Vma;

const int API_VERSION_1_3 = 1 << 22 | 3 << 12;

// A plain Vulkan instance and device; see Hello/HelloVulkan.cs for what the macOS portability bits are for.
HashSet<string> instanceExtensions = Platform.IsMacOS ? [VK.KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME] : [];
var instanceFlags = Platform.IsMacOS ? VkInstanceCreateFlags.EnumeratePortabilityBitKHR : VkInstanceCreateFlags.None;

// Everything else hangs off the instance, so it lives at the top level and is disposed after Run returns.
using var instance = Vulkan.CreateInstance(
    new Instance.CreateInfo
    {
        AppInfo = new VkApplicationInfo { ApiVersion = API_VERSION_1_3 },
        Flags = instanceFlags,
        EnabledExtensions = instanceExtensions,
        EnabledLayers = [],
    }
);

Run(instance);

static unsafe void Run(Instance instance)
{
    var physicalDevice = instance.PhysicalDevices[0];
    var queueFamily = physicalDevice.GetFirstQueueFamilyWithFlag(VkQueueFlags.TransferBit);

    var deviceExtensions = new HashSet<string>();
    if (physicalDevice.SupportsExtension(VK.KHR_PORTABILITY_SUBSET_EXTENSION_NAME))
        deviceExtensions.Add(VK.KHR_PORTABILITY_SUBSET_EXTENSION_NAME);

    var priority = 1.0f;
    // Disposed when Run returns, after the allocator is destroyed and before the instance.
    using var device = physicalDevice.CreateDevice(
        new Device.CreateInfo
        {
            Extensions = deviceExtensions,
            QueueCreateInfos =
            [
                new VkDeviceQueueCreateInfo
                {
                    QueueFamilyIndex = queueFamily,
                    QueueCount = 1,
                    QueuePriorities = &priority,
                },
            ],
        }
    );

    // VMA must be told the API version the instance was created with.
    var allocator = device.CreateVmaAllocator(
        new VmaAllocatorCreateInfo
        {
            Instance = instance,
            PhysicalDevice = physicalDevice,
            Device = device,
            VulkanApiVersion = API_VERSION_1_3,
        }
    );

    // Auto picks the memory type, HostAccessSequentialWrite asks for one the CPU can write to,
    // and Mapped keeps it mapped for the buffer's whole lifetime.
    const int COUNT = 4;
    allocator.CreateBuffer(
        new VkBufferCreateInfo { Size = ByteSize.Of<int>() * COUNT, Usage = VkBufferUsageFlags.TransferSrcBit },
        new VmaAllocationCreateInfo
        {
            Usage = VmaMemoryUsage.Auto,
            Flags = VmaAllocationCreateFlags.HostAccessSequentialWriteBit | VmaAllocationCreateFlags.MappedBit,
        },
        out var buffer,
        out var allocation,
        out var allocationInfo
    );

    // PMappedData points straight at the buffer's memory, so there's no map or unmap call.
    var mapped = new Span<int>((void*)allocationInfo.PMappedData, COUNT);
    for (var i = 0; i < COUNT; i++)
        mapped[i] = (i + 1) * 10;
    Console.WriteLine($"Buffer holds: {string.Join(", ", mapped.ToArray())}");

    // The allocator isn't IDisposable, so the buffer and then the allocator are destroyed by hand.
    allocator.DestroyBuffer(buffer, allocation);
    device.DestroyVmaAllocator(allocator);
}
