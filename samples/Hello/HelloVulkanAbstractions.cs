/*
 * HelloVulkanAbstractions
 *
 * Sets up Vulkan with the Vulkan.Abstractions helpers, then builds a pipeline's vertex input
 * layout from plain C# structs and prints what it produced.
 * Nothing is drawn, so no window is needed.
 * See Demo/DemoVulkan.cs for a version that draws a triangle in a window.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Vulkan@2026.10.3
#:package Ahwoo.Brutal.Vulkan.Abstractions@2026.10.3
#:package Ahwoo.Brutal.Collections@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.Numerics;
using Brutal.VulkanApi;
using Brutal.VulkanApi.Abstractions;

// VulkanHelpers knows what each OS needs, e.g. portability enumeration for MoltenVK on macOS.
var instanceExtensions = new HashSet<string>();
VulkanHelpers.AddPlatformRequiredExtensions(instanceExtensions);

// Unlike the raw HelloVulkan sample, this turns validation on whenever the layer is installed.
var layers = new HashSet<string>();
if (VulkanHelpers.Validation.IsSupported)
    VulkanHelpers.AddValidationLayers(layers);

Console.WriteLine($"Instance extensions: [{string.Join(", ", instanceExtensions)}]");
Console.WriteLine($"Instance layers:     [{string.Join(", ", layers)}]");

// Everything else hangs off the instance, so it lives at the top level and is disposed after Run returns.
using var instance = Vulkan.CreateInstance(
    new Instance.CreateInfo
    {
        AppInfo = new VkApplicationInfo { ApiVersion = (int)VulkanHelpers.Api.VERSION_1_3 },
        Flags = VulkanHelpers.GetPlatformRequiredInstanceCreateFlags(),
        EnabledExtensions = instanceExtensions,
        EnabledLayers = layers,
    }
);

Run(instance);

static void Run(Instance instance)
{
    var physicalDevice = instance.PhysicalDevices[0];
    var queueFamily = physicalDevice.GetFirstQueueFamilyWithFlag(VkQueueFlags.GraphicsBit);

    // Adds the device extensions that must be enabled whenever they're supported (VK_KHR_portability_subset).
    var deviceExtensions = new HashSet<string>();
    VulkanHelpers.AddMandatoryIfSupportedDeviceExtensions(deviceExtensions, physicalDevice);
    Console.WriteLine($"Device extensions:   [{string.Join(", ", deviceExtensions)}]");

    unsafe
    {
        // DeviceEx is a Device that can also allocate buffers and images itself (IBufferAllocator, IImageAllocator).
        // It's disposed at the end of this block, before Run returns and the instance is disposed.
        var priority = 1.0f;
        using var device = physicalDevice.CreateDevice(
            new DeviceEx.CreateInfo
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
        Console.WriteLine($"Created a {device.GetType().Name} with one queue from family {queueFamily}");

        // VertexInput reads the struct fields to fill in strides, formats, offsets and locations.
        // Binding 0 is per vertex, binding 1 per instance; a float4x4 takes four locations.
        var vertexInput = new VertexInput(2, 7)
            .AddBindingWithAttributes<Vertex>(0, 0, VkVertexInputRate.Vertex)
            .AddBindingWithAttributes<InstanceData>(3, 1, VkVertexInputRate.Instance);

        // Test() checks the layout is valid and returns Ok or the problem it found.
        Console.WriteLine($"Vertex input: {vertexInput.Test()}");
        foreach (var binding in vertexInput.Bindings)
            Console.WriteLine($"  binding {binding.Binding}: stride {binding.Stride}, {binding.InputRate}");
        foreach (var attribute in vertexInput.Attributes)
            Console.WriteLine(
                $"  location {attribute.Location}: binding {attribute.Binding}, offset {attribute.Offset}, {attribute.Format}"
            );

        // It converts straight to the struct that VkGraphicsPipelineCreateInfo.VertexInputState points at.
        VkPipelineVertexInputStateCreateInfo* state = vertexInput;
        Console.WriteLine(
            $"VertexInputState: {state->VertexBindingDescriptionCount} bindings, {state->VertexAttributeDescriptionCount} attributes"
        );
    }
}

struct Vertex(float3 position, float2 texCoord, byte4 color)
{
    public float3 Position = position;
    public float2 TexCoord = texCoord;

    [FixedPointConversion(Behavior.Normalize)] // Four bytes read as 0..1 floats in the shader.
    public byte4 Color = color;
}

struct InstanceData(float4x4 transform)
{
    public float4x4 Transform = transform;
}
