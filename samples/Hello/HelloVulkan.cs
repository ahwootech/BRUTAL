/*
 * HelloVulkan
 *
 * Creates a Vulkan instance, lists the physical devices and their queue families, then creates
 * and destroys a logical device with one queue. Nothing is drawn, so no window is needed.
 * See Demo/DemoVulkan.cs for a version that draws a triangle in a window.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Vulkan@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Strings@2026.10.2

// RIAN: This is NOT a best-practices Vulkan sample. There are many shortcuts taken that you should not take in production code.

using Brutal;
using Brutal.Strings;
using Brutal.VulkanApi;

// Vulkan packs versions as major << 22 | minor << 12 | patch.
const int API_VERSION_1_3 = 1 << 22 | 3 << 12;
static string FormatVersion(int version) => $"{(version >> 22) & 0x7F}.{(version >> 12) & 0x3FF}.{version & 0xFFF}";

// MoltenVK is a "portability" driver: macOS only lists it if the instance opts in to portability enumeration.
var extensions = new HashSet<string>();
var flags = VkInstanceCreateFlags.None;
if (Platform.IsMacOS)
{
    extensions.Add(VK.KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME);
    flags |= VkInstanceCreateFlags.EnumeratePortabilityBitKHR;
}

// Everything else hangs off the instance, so it lives at the top level and is disposed after Run returns.
using var instance = Vulkan.CreateInstance(
    new Instance.CreateInfo
    {
        AppInfo = new VkApplicationInfo { ApiVersion = API_VERSION_1_3 },
        Flags = flags,
        EnabledExtensions = extensions,
        EnabledLayers = [], // Set VK_INSTANCE_LAYERS=VK_LAYER_KHRONOS_validation to validate without changing code.
    }
);

Run(instance);

static void Run(Instance instance)
{
    // The instance enumerates its physical devices when it's created.
    Console.WriteLine($"Found {instance.PhysicalDevices.Length} physical device(s)");

    foreach (var physicalDevice in instance.PhysicalDevices)
    {
        var properties = physicalDevice.GetProperties();
        unsafe
        {
            Console.WriteLine($"  {Utf8.GetString(properties.DeviceName)}");
        }
        Console.WriteLine($"    type        {properties.DeviceType}");
        // MoltenVK reports the major.minor the instance asked for, not the newest it supports.
        Console.WriteLine($"    API version {FormatVersion(properties.ApiVersion)}");

        var families = new VkQueueFamilyProperties[physicalDevice.GetQueueFamilyProperties_Count()];
        physicalDevice.GetQueueFamilyProperties_Write(families);
        for (var i = 0; i < families.Length; i++)
            Console.WriteLine($"    queue family {i}: {families[i].QueueCount} x {families[i].QueueFlags}");
    }

    if (instance.PhysicalDevices.Length == 0)
        return;

    // Create a device on the first physical device, with one queue from the first family that can do graphics.
    var device0 = instance.PhysicalDevices[0];
    var queueFamily = device0.GetFirstQueueFamilyWithFlag(VkQueueFlags.GraphicsBit);

    // A portability driver also requires VK_KHR_portability_subset to be enabled on the device.
    var deviceExtensions = new HashSet<string>();
    if (device0.SupportsExtension(VK.KHR_PORTABILITY_SUBSET_EXTENSION_NAME))
        deviceExtensions.Add(VK.KHR_PORTABILITY_SUBSET_EXTENSION_NAME);

    unsafe
    {
        var priority = 1.0f;
        // Disposed at the end of this block, before Run returns and the instance is disposed.
        using var device = device0.CreateDevice(
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

        var queue = device.GetQueue(queueFamily, 0);
        Console.WriteLine($"Created a device with one queue from family {queue.Family}");

        device.WaitIdle();
    }
}
