/*
 * DemoVulkan
 *
 * Draws a coloured triangle with Vulkan: raw bindings, the Vulkan.Abstractions helpers, and a
 * vertex buffer allocated with VMA. Shaders are compiled at startup with ShaderC.
 *
 * Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Vulkan@2026.10.3
#:package Ahwoo.Brutal.Vulkan.Abstractions@2026.10.3
#:package Ahwoo.Brutal.Vulkan.Vma@2026.10.3
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.ShaderC@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Memory@2026.10.2
#:package Ahwoo.Brutal.Numerics@2026.10.2
#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal;
using Brutal.GlfwApi;
using Brutal.Numerics;
using Brutal.ShaderCApi;
using Brutal.Strings;
using Brutal.VulkanApi;
using Brutal.VulkanApi.Abstractions;
using Brutal.VulkanApi.Vma;

if (!Glfw.Init())
{
    var errorCode = Glfw.GetError(out var errorMessage);
    throw new InvalidOperationException($"Failed to initialize GLFW: {errorCode}, {errorMessage}");
}

// GLFW can't find Brutal's Vulkan loader (libVulkanEx, not libvulkan.1) by itself, so touching Vulkan first loads it.
_ = Vulkan.GetInstanceProcAddr;

try
{
    Run();
}
finally
{
    Glfw.Terminate();
}

static unsafe void Run()
{
    Glfw.WindowHint(GlfwWindowHint.ClientApi, Glfw.Constants.GLFW_NO_API);
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE); // A fixed size means no swapchain rebuilds.

    // Declared first so it's disposed last, after the surface and everything else that draws to it.
    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Demo Vulkan", Size = new int2(640, 480) }
    );

    window.OnKey += (handle, key, _, _, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;
    };

    // VulkanHelpers adds whatever this OS needs (e.g. portability enumeration for MoltenVK).
    var instanceExtensions = new HashSet<string>();
    VulkanHelpers.AddPlatformRequiredExtensions(instanceExtensions);
    var glfwExtensions = Glfw.GetRequiredInstanceExtensions(out var glfwExtensionCount);
    for (var i = 0; i < glfwExtensionCount; i++)
        instanceExtensions.Add(Utf8.GetString(glfwExtensions[i]));

    using var instance = Vulkan.CreateInstance(
        new Instance.CreateInfo
        {
            // For dynamic rendering.
            AppInfo = new VkApplicationInfo { ApiVersion = (int)VulkanHelpers.Api.VERSION_1_3 },
            Flags = VulkanHelpers.GetPlatformRequiredInstanceCreateFlags(),
            EnabledExtensions = instanceExtensions,
            EnabledLayers = [],
        }
    );

    if (Glfw.CreateWindowSurface(instance.VkHandle, window, out var surfaceHandle) != (int)VkResult.Success)
        throw new InvalidOperationException("Failed to create a Vulkan surface for the window");
    var surface = new VkSurfaceKHR((nint)surfaceHandle);

    // One queue draws and presents, so find a device with a queue family that can do both.
    PhysicalDevice? physicalDevice = null;
    var queueFamily = -1;
    foreach (var candidate in instance.PhysicalDevices)
    {
        var families = new VkQueueFamilyProperties[candidate.GetQueueFamilyProperties_Count()];
        candidate.GetQueueFamilyProperties_Write(families);

        for (var i = 0; i < families.Length && physicalDevice is null; i++)
        {
            if ((families[i].QueueFlags & VkQueueFlags.GraphicsBit) != 0 && candidate.GetSurfaceSupportKHR(i, surface))
                (physicalDevice, queueFamily) = (candidate, i);
        }
    }

    if (physicalDevice is null)
        throw new InvalidOperationException(
            "No Vulkan device has a queue family that can draw and present to the window"
        );

    var deviceExtensions = new HashSet<string>();
    VulkanHelpers.AddSwapchainExtensions(deviceExtensions);
    VulkanHelpers.AddMandatoryIfSupportedDeviceExtensions(deviceExtensions, physicalDevice);

    var priority = 1.0f;
    var vulkan13Features = new VkPhysicalDeviceVulkan13Features { DynamicRendering = true };

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
            Next = &vulkan13Features,
        }
    );

    var queue = device.GetQueue(queueFamily, 0);

    // VMA: allocate a host-visible, persistently mapped vertex buffer and write the triangle into it.
    var allocator = device.CreateVmaAllocator(
        new VmaAllocatorCreateInfo
        {
            Instance = instance,
            PhysicalDevice = physicalDevice,
            Device = device,
            VulkanApiVersion = (uint)VulkanHelpers.Api.VERSION_1_3,
        }
    );

    ReadOnlySpan<Vertex> vertices =
    [
        new(new float2(0.0f, -0.5f), new float3(1.0f, 0.0f, 0.0f)),
        new(new float2(0.5f, 0.5f), new float3(0.0f, 1.0f, 0.0f)),
        new(new float2(-0.5f, 0.5f), new float3(0.0f, 0.0f, 1.0f)),
    ];
    var verticesSize = ByteSize.Of(vertices);

    allocator.CreateBuffer(
        new VkBufferCreateInfo { Size = verticesSize, Usage = VkBufferUsageFlags.VertexBufferBit },
        new VmaAllocationCreateInfo
        {
            Usage = VmaMemoryUsage.Auto,
            Flags = VmaAllocationCreateFlags.HostAccessSequentialWriteBit | VmaAllocationCreateFlags.MappedBit,
        },
        out var vertexBuffer,
        out var vertexAllocation,
        out var vertexAllocationInfo
    );

    vertices.CopyTo(new Span<Vertex>((void*)vertexAllocationInfo.PMappedData, vertices.Length));
    allocator.FlushAllocation(vertexAllocation, ByteSize.Zero, verticesSize); // A no-op on host-coherent memory.

    // Swapchain: one image view per swapchain image.
    var capabilities = physicalDevice.GetSurfaceCapabilitiesKHR(surface);

    // CurrentExtent is 0xFFFFFFFF (-1 as an int) when the surface lets the swapchain pick its size.
    var extent = capabilities.CurrentExtent;
    if (extent.Width == -1 && extent.Height == -1)
        extent = new VkExtent2D(
            Math.Clamp(window.FramebufferSize.X, capabilities.MinImageExtent.Width, capabilities.MaxImageExtent.Width),
            Math.Clamp(window.FramebufferSize.Y, capabilities.MinImageExtent.Height, capabilities.MaxImageExtent.Height)
        );

    // Ask for double buffering, within the surface's limits (a MaxImageCount of 0 means no limit).
    var imageCount = Math.Max(capabilities.MinImageCount, 2);
    if (capabilities.MaxImageCount > 0)
        imageCount = Math.Min(imageCount, capabilities.MaxImageCount);

    // Opaque if the surface supports it, otherwise the first mode it does support.
    VkCompositeAlphaFlagsKHR[] alphaModes =
    [
        VkCompositeAlphaFlagsKHR.OpaqueBitKHR,
        VkCompositeAlphaFlagsKHR.PreMultipliedBitKHR,
        VkCompositeAlphaFlagsKHR.PostMultipliedBitKHR,
        VkCompositeAlphaFlagsKHR.InheritBitKHR,
    ];
    var compositeAlpha = alphaModes.First(mode => (capabilities.SupportedCompositeAlpha & mode) != 0);

    Span<VkSurfaceFormatKHR> surfaceFormats =
        stackalloc VkSurfaceFormatKHR[physicalDevice.GetSurfaceFormatsKHR_Count(surface)];
    physicalDevice.GetSurfaceFormatsKHR_Write(surface, surfaceFormats);
    var format = surfaceFormats[0].Format;

    var swapchain = device.CreateSwapchainKHR(
        new VkSwapchainCreateInfoKHR
        {
            Surface = surface,
            MinImageCount = imageCount,
            ImageFormat = format,
            ImageColorSpace = surfaceFormats[0].ColorSpace,
            ImageExtent = extent,
            ImageArrayLayers = 1,
            ImageUsage = VkImageUsageFlags.ColorAttachmentBit,
            ImageSharingMode = VkSharingMode.Exclusive,
            PreTransform = capabilities.CurrentTransform,
            CompositeAlpha = compositeAlpha,
            PresentMode = VkPresentModeKHR.FifoKHR,
            Clipped = true,
        },
        null
    );

    var images = new VkImage[device.GetSwapchainImagesKHR_Count(swapchain)];
    device.GetSwapchainImagesKHR_Write(swapchain, images);

    var colorRange = new VkImageSubresourceRange
    {
        AspectMask = VkImageAspectFlags.ColorBit,
        LevelCount = 1,
        LayerCount = 1,
    };
    var imageViews = new VkImageView[images.Length];
    for (var i = 0; i < images.Length; i++)
        imageViews[i] = device.CreateImageView(
            new VkImageViewCreateInfo
            {
                Image = images[i],
                ViewType = VkImageViewType._2D,
                Format = format,
                SubresourceRange = colorRange,
            },
            null
        );

    // Shaders: positions and colours come from the vertex buffer.
    using var compiler = ShaderC.CreateCompiler();
    using var options = ShaderC.CreateCompilerOptions();

    VkShaderModule CompileShader(ReadOnlySpan<byte> glsl, ShaderKind kind)
    {
        using var spirv = compiler.Compile(glsl, kind, "shader"u8, "main"u8, options);
        return ShaderModuleExtensions.FromSpirv(
            device,
            new ReadOnlySpan<byte>(spirv.GetBytes(), (int)spirv.GetLength()),
            null
        );
    }

    // ShaderStages owns the modules and destroys them on Dispose.
    using var shaderStages = new ShaderStages(
        device,
        [
            Presets.ShaderStage.Vertex(
                CompileShader(
                    """
            #version 450

            layout(location = 0) in vec2 position;
            layout(location = 1) in vec3 inColor;
            layout(location = 0) out vec3 color;

            void main()
            {
                gl_Position = vec4(position, 0.0, 1.0);
                color = inColor;
            }
            """u8,
                    ShaderKind.VertexShader
                )
            ),
            Presets.ShaderStage.Fragment(
                CompileShader(
                    """
            #version 450

            layout(location = 0) in vec3 color;
            layout(location = 0) out vec4 outColor;

            void main()
            {
                outColor = vec4(color, 1.0);
            }
            """u8,
                    ShaderKind.FragmentShader
                )
            ),
        ],
        null
    );

    // Pipeline: Presets cover the common fixed-function state.
    // VertexInput builds the binding and attributes from the Vertex struct's fields.
    var vertexInput = new VertexInput(1, 2).AddBindingWithAttributes<Vertex>(0, 0, VkVertexInputRate.Vertex);
    var viewport = new VkViewport
    {
        Width = extent.Width,
        Height = extent.Height,
        MaxDepth = 1,
    };
    var scissor = new VkRect2D(extent);
    var viewportState = new VkPipelineViewportStateCreateInfo
    {
        ViewportCount = 1,
        Viewports = &viewport,
        ScissorCount = 1,
        Scissors = &scissor,
    };
    var rendering = new VkPipelineRenderingCreateInfo { ColorAttachmentCount = 1, ColorAttachmentFormats = &format };

    var pipelineLayout = device.CreatePipelineLayout([], [], null);
    var pipeline = device.CreateGraphicsPipeline(
        VkPipelineCache.NullHandle,
        new VkGraphicsPipelineCreateInfo
        {
            Next = &rendering,
            StageCount = shaderStages.Count,
            Stages = shaderStages,
            VertexInputState = vertexInput,
            InputAssemblyState = Presets.InputAssembly.TriangleList,
            ViewportState = &viewportState,
            RasterizationState = Presets.Rasterization.Fill.CullNone,
            MultisampleState = Presets.Multisample.None,
            ColorBlendState = Presets.BlendState.BlendNone,
            Layout = pipelineLayout,
        },
        null
    );

    // Commands and synchronisation: one frame in flight.
    var commandPool = device.CreateCommandPool(
        new VkCommandPoolCreateInfo
        {
            QueueFamilyIndex = queueFamily,
            Flags = VkCommandPoolCreateFlags.ResetCommandBufferBit,
        },
        null
    );
    var commandBuffer = device.AllocateCommandBuffer(
        new VkCommandBufferAllocateInfo { CommandPool = commandPool, Level = VkCommandBufferLevel.Primary }
    );

    var imageAvailable = device.CreateSemaphore(new VkSemaphoreCreateInfo(), null);
    var renderFinished = images.Select(_ => device.CreateSemaphore(new VkSemaphoreCreateInfo(), null)).ToArray();
    var frameFence = device.CreateFence(VkFenceCreateFlags.SignaledBit, null);

    void TransitionImage(
        VkImage image,
        VkImageLayout from,
        VkImageLayout to,
        VkPipelineStageFlags srcStage,
        VkPipelineStageFlags dstStage,
        VkAccessFlags srcAccess,
        VkAccessFlags dstAccess
    )
    {
        commandBuffer.PipelineBarrier(
            srcStage,
            dstStage,
            VkDependencyFlags.None,
            [],
            [],
            [
                new VkImageMemoryBarrier
                {
                    SrcAccessMask = srcAccess,
                    DstAccessMask = dstAccess,
                    OldLayout = from,
                    NewLayout = to,
                    SrcQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                    DstQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                    Image = image,
                    SubresourceRange = colorRange,
                },
            ]
        );
    }

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();

        device.WaitForFence(frameFence, -1);
        device.ResetFences([frameFence]);

        // The window can't be resized, so the swapchain is never rebuilt: ErrorOutOfDateKHR throws here and a
        // SuboptimalKHR result is ignored. A resizable window would recreate the swapchain in both cases.
        device.AcquireNextImageKHR(swapchain, -1, imageAvailable, VkFence.NullHandle, out var imageIndex);
        var image = images[imageIndex];

        commandBuffer.Reset();
        commandBuffer.Begin(VkCommandBufferUsageFlags.OneTimeSubmitBit);

        TransitionImage(
            image,
            VkImageLayout.Undefined,
            VkImageLayout.ColorAttachmentOptimal,
            VkPipelineStageFlags.ColorAttachmentOutputBit,
            VkPipelineStageFlags.ColorAttachmentOutputBit,
            VkAccessFlags.None,
            VkAccessFlags.ColorAttachmentWriteBit
        );

        var colorAttachment = new VkRenderingAttachmentInfo
        {
            ImageView = imageViews[imageIndex],
            ImageLayout = VkImageLayout.ColorAttachmentOptimal,
            LoadOp = VkAttachmentLoadOp.Clear,
            StoreOp = VkAttachmentStoreOp.Store,
            ClearValue = new VkClearColorValue { Float32 = new float4(0.1f, 0.1f, 0.1f, 1.0f) },
        };

        commandBuffer.BeginRendering(
            new VkRenderingInfo
            {
                RenderArea = new VkRect2D(extent),
                LayerCount = 1,
                ColorAttachmentCount = 1,
                ColorAttachments = &colorAttachment,
            }
        );
        commandBuffer.BindPipeline(VkPipelineBindPoint.Graphics, pipeline);
        commandBuffer.BindVertexBuffers(0, [vertexBuffer], [new ByteSize64(0)]);
        commandBuffer.Draw(3, 1, 0, 0);
        commandBuffer.EndRendering();

        TransitionImage(
            image,
            VkImageLayout.ColorAttachmentOptimal,
            VkImageLayout.PresentSrcKHR,
            VkPipelineStageFlags.ColorAttachmentOutputBit,
            VkPipelineStageFlags.BottomOfPipeBit,
            VkAccessFlags.ColorAttachmentWriteBit,
            VkAccessFlags.None
        );

        commandBuffer.End();

        var signalSemaphore = renderFinished[imageIndex];
        queue.Submit(
            [imageAvailable],
            [VkPipelineStageFlags.ColorAttachmentOutputBit],
            [commandBuffer],
            [signalSemaphore],
            frameFence
        );

        queue.PresentKHR(
            new VkPresentInfoKHR
            {
                WaitSemaphoreCount = 1,
                WaitSemaphores = &signalSemaphore,
                SwapchainCount = 1,
                Swapchains = &swapchain,
                ImageIndices = &imageIndex,
            }
        );
    }

    // The handles above aren't IDisposable, so they're destroyed here once the GPU is idle, before the
    // using declarations dispose the shader stages, device, instance and window.
    device.WaitIdle();

    allocator.DestroyBuffer(vertexBuffer, vertexAllocation);
    device.DestroyVmaAllocator(allocator);
    device.DestroyFence(frameFence, null);
    device.DestroySemaphore(imageAvailable, null);
    foreach (var semaphore in renderFinished)
        device.DestroySemaphore(semaphore, null);
    device.DestroyCommandPool(commandPool, null);
    device.DestroyPipeline(pipeline, null);
    device.DestroyPipelineLayout(pipelineLayout, null);
    foreach (var imageView in imageViews)
        device.DestroyImageView(imageView, null);
    device.DestroySwapchainKHR(swapchain, null);
    instance.DestroySurfaceKHR(surface, null);
}

struct Vertex(float2 position, float3 color)
{
    public float2 Position = position;
    public float3 Color = color;
}
