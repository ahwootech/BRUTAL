using Brutal.VulkanApi;
using Brutal.VulkanApi.Abstractions;

namespace Brutal.ImGuiApi.Backends;

public partial class VulkanBackend
{
    private static class Helpers
    {
        public static unsafe VkSurfaceFormatKHR SelectSurfaceFormat(
            PhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            ReadOnlySpan<VkFormat> requestFormats,
            VkColorSpaceKHR requestColorSpace
        )
        {
            Assert(!requestFormats.IsEmpty);

            // Per Spec Format and View Format are expected to be the same unless VK_IMAGE_CREATE_MUTABLE_BIT was set at image creation
            // Assuming that the default behavior is without setting this bit, there is no need for separate Swapchain image and image view format
            // Additionally several new color spaces were introduced with Vulkan Spec v1.0.40,
            // hence we must make sure that a format with the mostly available color space, VK_COLOR_SPACE_SRGB_NONLINEAR_KHR, is found and used.
            var surfaceFormatCount = physicalDevice.GetSurfaceFormatsKHR_Count(surface);
            Span<VkSurfaceFormatKHR> formats = stackalloc VkSurfaceFormatKHR[surfaceFormatCount];
            physicalDevice.GetSurfaceFormatsKHR_Write(surface, formats);

            // First check if only one format, VK_FORMAT_UNDEFINED, is available, which would imply that any format is available
            if (formats.Length is 1)
            {
                if (formats[0].Format is VkFormat.Undefined)
                    return new VkSurfaceFormatKHR { Format = requestFormats[0], ColorSpace = requestColorSpace };

                // No point in searching another format
                return formats[0];
            }

            // Request several formats, the first found will be used
            foreach (var t in requestFormats)
            foreach (var format in formats)
                if (format.Format == t && format.ColorSpace == requestColorSpace)
                    return format;

            // If none of the requested image formats could be found, use the first available
            return formats[0];
        }

        public static unsafe VkPresentModeKHR SelectPresentMode(
            PhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            ReadOnlySpan<VkPresentModeKHR> requestModes
        )
        {
            Assert(!requestModes.IsEmpty);

            // Request a certain mode and confirm that it is available. If not use VK_PRESENT_MODE_FIFO_KHR which is mandatory
            var numModes = physicalDevice.GetSurfacePresentModesKHR_Count(surface);
            Span<VkPresentModeKHR> modes = stackalloc VkPresentModeKHR[numModes];
            physicalDevice.GetSurfacePresentModesKHR_Write(surface, modes);

            foreach (var requestMode in requestModes)
            foreach (var mode in modes)
                if (requestMode == mode)
                    return requestMode;

            return VkPresentModeKHR.FifoKHR; // Always available
        }

        // TODO: Can we pass command pool?
        public static unsafe void CreateOrResizeWindow(
            PhysicalDevice physicalDevice,
            Device device,
            WindowImpl* window,
            Queue queue,
            int queueFamily,
            int width,
            int height,
            int minImageCount
        )
        {
            CreateWindowSwapChain(physicalDevice, device, window, width, height, minImageCount);
            CreateWindowCommandBuffers(physicalDevice, device, window, queueFamily);

            // FIXME: to submit the command buffer, we need a queue. In the examples folder, the ImGui_ImplVulkanH_CreateOrResizeWindow function is called
            // before the ImGui_ImplVulkan_Init function, so we don't have access to the queue yet. Here we have the queue_family that we can use to grab
            // a queue from the device and submit the command buffer. It would be better to have access to the queue as suggested in the FIXME below.
            var commandPool = device.CreateCommandPool(
                new VkCommandPoolCreateInfo
                {
                    QueueFamilyIndex = queueFamily,
                    Flags = VkCommandPoolCreateFlags.ResetCommandBufferBit,
                },
                null
            );

            var fence = device.CreateFence(new VkFenceCreateInfo { Flags = 0 }, null);

            var commandBuffer = device.AllocateCommandBuffer(
                new VkCommandBufferAllocateInfo { CommandPool = commandPool, Level = VkCommandBufferLevel.Primary }
            );

            commandBuffer.Begin(new VkCommandBufferBeginInfo { Flags = VkCommandBufferUsageFlags.OneTimeSubmitBit });

            // Transition the images to the correct layout for rendering
            for (var i = 0; i < window->ImageCount; i++)
            {
                var barrier = new VkImageMemoryBarrier
                {
                    Image = window->Frames[i].Backbuffer,
                    OldLayout = VkImageLayout.Undefined,
                    NewLayout = VkImageLayout.PresentSrcKHR,
                    SrcQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                    DstQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                    SubresourceRange = new VkImageSubresourceRange
                    {
                        AspectMask = VkImageAspectFlags.ColorBit,
                        LevelCount = 1,
                        LayerCount = 1,
                    },
                };
                commandBuffer.PipelineBarrier(
                    VkPipelineStageFlags.BottomOfPipeBit,
                    VkPipelineStageFlags.ColorAttachmentOutputBit,
                    VkDependencyFlags.None,
                    [],
                    [],
                    [barrier]
                );
            }

            commandBuffer.End();

            queue.Submit([], [], [commandBuffer], [], fence);
            device.WaitForFences([fence], true, -1);

            // Destroy command buffer and fence and command pool
            device.DestroyCommandPool(commandPool, null);
            device.DestroyFence(fence, null);
        }

        public static unsafe void DestroyWindow(Instance instance, Device device, WindowImpl* window)
        {
            // TODO: ???
            device.WaitIdle(); // FIXME: We could wait on the Queue if we had the queue in wd-> (otherwise VulkanH functions can't use globals)
            //vkQueueWaitIdle(bd->Queue);

            for (var i = 0; i < window->ImageCount; i++)
                DestroyFrame(device, &window->Frames.DataRaw[i]);
            for (var i = 0; i < window->SemaphoreCount; i++)
                DestroyFrameSemaphores(device, &window->FrameSemaphores.DataRaw[i]);
            window->Frames.Clear();
            window->FrameSemaphores.Clear();
            device.DestroyRenderPass(window->RenderPass, null);
            device.DestroySwapchainKHR(window->Swapchain, null);
            instance.DestroySurfaceKHR(window->Surface, null);

            *window = default;
        }

        // Also destroy old swap chain and in-flight frames data, if any.
        private static unsafe void CreateWindowSwapChain(
            PhysicalDevice physicalDevice,
            Device device,
            WindowImpl* window,
            int width,
            int height,
            int minImageCount
        )
        {
            var oldSwapchain = window->Swapchain;
            window->Swapchain = default;
            // TODO: NOOOOOOO
            device.WaitIdle();

            // We don't use ImGui_ImplVulkanH_DestroyWindow() because we want to preserve the old swapchain to create the new one.
            // Destroy old Framebuffer
            for (var i = 0; i < window->ImageCount; i++)
                DestroyFrame(device, &window->Frames.DataRaw[i]);
            for (var i = 0; i < window->SemaphoreCount; i++)
                DestroyFrameSemaphores(device, &window->FrameSemaphores.DataRaw[i]);
            window->Frames.Clear();
            window->FrameSemaphores.Clear();
            window->ImageCount = 0;
            if (window->RenderPass.IsNotNull())
                device.DestroyRenderPass(window->RenderPass, null);

            // If min image count was not specified, request different count of images dependent on selected present mode
            if (minImageCount is 0)
                minImageCount = GetMinImageCountFromPresentMode(window->PresentMode);

            // Create Swapchain
            {
                var cap = physicalDevice.GetSurfaceCapabilitiesKHR(window->Surface);

                var info = new VkSwapchainCreateInfoKHR
                {
                    Surface = window->Surface,
                    MinImageCount = minImageCount,
                    ImageFormat = window->SurfaceFormat.Format,
                    ImageColorSpace = window->SurfaceFormat.ColorSpace,
                    ImageArrayLayers = 1,
                    ImageUsage = VkImageUsageFlags.ColorAttachmentBit,
                    ImageSharingMode = VkSharingMode.Exclusive, // Assume that graphics family == present family
                    PreTransform = cap.SupportedTransforms.HasFlag(VkSurfaceTransformFlagsKHR.IdentityBitKHR)
                        ? VkSurfaceTransformFlagsKHR.IdentityBitKHR
                        : cap.CurrentTransform,
                    CompositeAlpha = VkCompositeAlphaFlagsKHR.OpaqueBitKHR,
                    PresentMode = window->PresentMode,
                    Clipped = true,
                    OldSwapchain = oldSwapchain,
                };
                if (info.MinImageCount < cap.MinImageCount)
                    info.MinImageCount = cap.MinImageCount;
                else if (cap.MaxImageCount != 0 && info.MinImageCount > cap.MaxImageCount)
                    info.MinImageCount = cap.MaxImageCount;
                if (cap.CurrentExtent.Width == -1)
                {
                    window->Width = width;
                    window->Height = height;
                    info.ImageExtent.Width = width;
                    info.ImageExtent.Height = height;
                }
                else
                {
                    window->Width = cap.CurrentExtent.Width;
                    window->Height = cap.CurrentExtent.Height;
                    info.ImageExtent.Width = cap.CurrentExtent.Width;
                    info.ImageExtent.Height = cap.CurrentExtent.Height;
                }
                window->Swapchain = device.CreateSwapchainKHR(info, null);
                window->ImageCount = device.GetSwapchainImagesKHR_Count(window->Swapchain);
                Span<VkImage> backBuffers = stackalloc VkImage[window->ImageCount];
                Assert(window->ImageCount >= minImageCount);
                device.GetSwapchainImagesKHR_Write(window->Swapchain, backBuffers);

                window->SemaphoreCount = window->ImageCount + 1;
                window->Frames.Count = window->ImageCount;
                window->FrameSemaphores.Count = window->SemaphoreCount;
                // TODO: Do we need to zero out this memory?
                // memset(window->Frames.Data, 0, window->Frames.size_in_bytes());
                // memset(window->FrameSemaphores.Data, 0, window->FrameSemaphores.size_in_bytes());
                for (var i = 0; i < window->ImageCount; i++)
                    window->Frames.Data[i].Backbuffer = backBuffers[i];
            }
            if (oldSwapchain.IsNotNull())
                device.DestroySwapchainKHR(oldSwapchain, null);

            // Create the Render Pass
            {
                var attachment = new VkAttachmentDescription
                {
                    Format = window->SurfaceFormat.Format,
                    Samples = VkSampleCountFlags._1Bit,
                    LoadOp = window->ClearEnable ? VkAttachmentLoadOp.Clear : VkAttachmentLoadOp.DontCare,
                    StoreOp = VkAttachmentStoreOp.Store,
                    StencilLoadOp = VkAttachmentLoadOp.DontCare,
                    StencilStoreOp = VkAttachmentStoreOp.DontCare,
                    InitialLayout = VkImageLayout.Undefined,
                    FinalLayout = VkImageLayout.PresentSrcKHR,
                };
                var colorAttachment = new VkAttachmentReference
                {
                    Attachment = 0,
                    Layout = VkImageLayout.ColorAttachmentOptimal,
                };
                var subPass = new VkSubpassDescription
                {
                    PipelineBindPoint = VkPipelineBindPoint.Graphics,
                    ColorAttachmentCount = 1,
                    ColorAttachments = &colorAttachment,
                };
                var dependency = new VkSubpassDependency
                {
                    SrcSubpass = VK.SUBPASS_EXTERNAL,
                    DstSubpass = 0,
                    SrcStageMask = VkPipelineStageFlags.ColorAttachmentOutputBit,
                    DstStageMask = VkPipelineStageFlags.ColorAttachmentOutputBit,
                    SrcAccessMask = 0,
                    DstAccessMask = VkAccessFlags.ColorAttachmentWriteBit,
                };

                window->RenderPass = device.CreateRenderPass(
                    new VkRenderPassCreateInfo
                    {
                        AttachmentCount = 1,
                        Attachments = &attachment,
                        SubpassCount = 1,
                        Subpasses = &subPass,
                        DependencyCount = 1,
                        Dependencies = &dependency,
                    },
                    null
                );

                // We do not create a pipeline by default as this is also used by examples' main.cpp,
                // but secondary viewport in multi-viewport mode may want to create one with:
                //ImGui_ImplVulkan_CreatePipeline(device, allocator, VK_NULL_HANDLE, window->RenderPass, VK_SAMPLE_COUNT_1_BIT, &window->Pipeline, v->Subpass);
            }

            // Create The Image Views
            {
                var info = new VkImageViewCreateInfo
                {
                    ViewType = VkImageViewType._2D,
                    Format = window->SurfaceFormat.Format,
                    Components = new VkComponentMapping
                    {
                        R = VkComponentSwizzle.R,
                        G = VkComponentSwizzle.G,
                        B = VkComponentSwizzle.B,
                        A = VkComponentSwizzle.A,
                    },
                    SubresourceRange = new VkImageSubresourceRange
                    {
                        AspectMask = VkImageAspectFlags.ColorBit,
                        LevelCount = 1,
                        LayerCount = 1,
                    },
                };
                for (var i = 0; i < window->ImageCount; i++)
                {
                    var frame = &window->Frames.DataRaw[i];
                    info.Image = frame->Backbuffer;
                    frame->BackbufferView = device.CreateImageView(info, null);
                }
            }

            // Create Framebuffer
            {
                VkImageView attachment;
                var info = new VkFramebufferCreateInfo
                {
                    RenderPass = window->RenderPass,
                    AttachmentCount = 1,
                    Attachments = &attachment,
                    Width = window->Width,
                    Height = window->Height,
                    Layers = 1,
                };
                for (var i = 0; i < window->ImageCount; i++)
                {
                    var frame = &window->Frames.DataRaw[i];
                    attachment = frame->BackbufferView;
                    frame->Framebuffer = device.CreateFramebuffer(info, null);
                }
            }
        }

        private static int GetMinImageCountFromPresentMode(VkPresentModeKHR presentMode)
        {
            return presentMode switch
            {
                VkPresentModeKHR.MailboxKHR => 3,
                VkPresentModeKHR.FifoKHR => 2,
                VkPresentModeKHR.FifoRelaxedKHR => 2,
                VkPresentModeKHR.ImmediateKHR => 1,
                _ => 1,
            };
        }

        private static unsafe void CreateWindowCommandBuffers(
            PhysicalDevice physicalDevice,
            Device device,
            WindowImpl* window,
            int queueFamily
        )
        {
            Assert(physicalDevice.IsNotNull() && device.IsNotNull());

            // Create Command Buffers
            for (var i = 0; i < window->ImageCount; i++)
            {
                var frame = &window->Frames.DataRaw[i];

                // TODO: Seriously, each frame has its own command pool?
                frame->CommandPool = device.CreateCommandPool(
                    new VkCommandPoolCreateInfo { QueueFamilyIndex = queueFamily },
                    null
                );

                frame->CommandBuffer = device.AllocateCommandBuffer(
                    new VkCommandBufferAllocateInfo
                    {
                        CommandPool = frame->CommandPool,
                        Level = VkCommandBufferLevel.Primary,
                    }
                );

                frame->Fence = device.CreateFence(
                    new VkFenceCreateInfo { Flags = VkFenceCreateFlags.SignaledBit },
                    null
                );
            }

            for (var i = 0; i < window->SemaphoreCount; i++)
            {
                var semaphores = &window->FrameSemaphores.DataRaw[i];
                {
                    var createInfo = new VkSemaphoreCreateInfo();
                    semaphores->ImageAcquiredSemaphore = device.CreateSemaphore(createInfo, null);
                    semaphores->RenderCompleteSemaphore = device.CreateSemaphore(createInfo, null);
                }
            }
        }

        private static unsafe void DestroyFrame(Device device, Frame* frame)
        {
            device.DestroyFence(frame->Fence, null);
            device.DestroyCommandPool(frame->CommandPool, null);
            frame->Fence = default;
            frame->CommandBuffer = default;
            frame->CommandPool = default;

            device.DestroyImageView(frame->BackbufferView, null);
            device.DestroyFramebuffer(frame->Framebuffer, null);
        }

        private static unsafe void DestroyFrameSemaphores(Device device, FrameSemaphores* semaphores)
        {
            device.DestroySemaphore(semaphores->ImageAcquiredSemaphore, null);
            device.DestroySemaphore(semaphores->RenderCompleteSemaphore, null);
            semaphores->ImageAcquiredSemaphore = semaphores->RenderCompleteSemaphore = default;
        }
    }
}
