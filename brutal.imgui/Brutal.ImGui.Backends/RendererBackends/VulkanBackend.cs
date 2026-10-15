using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Memory;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Pointers.Extensions;
using Brutal.VulkanApi;
using Brutal.VulkanApi.Abstractions;
using CommunityToolkit.HighPerformance;

namespace Brutal.ImGuiApi.Backends;

/**
 * Brutal port based on the default imgui_impl_vulkan C++ code
 * Key variations:
 * - Ignored dynamic rendering path for simplicity
 * - Always create a local DescriptorPool
 * - Not attempting to support multi-context. Use instance members instead of all static where possible.
 */

public partial class VulkanBackend : IRendererBackend
{
    public struct CreateInfo
    {
        public required DeviceEx Device;
        public required Queue GraphicsQueue;
        public required VkRenderPass RenderPass;
        public int SubPass;
        public required int MinImageCount;
        public required int ImageCount;
        public required VkSampleCountFlags SampleCount;
        public required int DescriptorPoolSize;
        public ByteSize MinAllocationSize; // Minimum allocation size. Set to 1024*1024 to satisfy zealous best practices validation layer and waste a little memory.
    }

    private static readonly Ptr<byte> Name = "Brutal.ImGuiApi.VulkanBackend"u8;

    // Backend uses a small number of descriptors per font atlas + as many as additional calls done to ImGui_ImplVulkan_AddTexture().
    private const int MINIMUM_IMAGE_SAMPLER_POOL_SIZE = 8; // Minimum per atlas

    public unsafe VulkanBackend(in CreateInfo info)
    {
        Device = info.Device;
        GraphicsQueue = info.GraphicsQueue;
        RenderPass = info.RenderPass;
        SubPass = info.SubPass;
        ImageCount = info.ImageCount;
        MinImageCount = info.MinImageCount;
        SampleCount = info.SampleCount;
        DescriptorPoolSize = info.DescriptorPoolSize;
        MinAllocationSize = info.MinAllocationSize;

        var io = ImGui.GetIO();
        Assert(io.BackendRendererUserData is 0, "ImGui backend renderer already set");

        io.BackendRendererUserData = (nint)GCHandle.Alloc(this);
        io.BackendRendererName = Name;
        io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset; // We can honor the ImDrawCmd::VtxOffset field, allowing for large meshes.
        io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures; // We can honor ImGuiPlatformIO::Textures[] requests during render.
        io.BackendFlags |= ImGuiBackendFlags.RendererHasViewports; // We can create multi-viewports on the Renderer side (optional)

        Assert(info.Device.IsNotNull());
        Assert(info.GraphicsQueue.IsNotNull());
        Assert(info.DescriptorPoolSize > 0);
        Assert(info.MinImageCount >= 2);
        Assert(info.ImageCount >= info.MinImageCount);

        // TODO: Verify this is actually required
        var properties = info.Device.PhysicalDevice.GetProperties();
        _nonCoherentAtomSize = properties.Limits.NonCoherentAtomSize;

        // Create device objects
        _texSampler = CreateSampler();
        CreateDescriptorPool(out _descriptorSetLayout, out _descriptorPool);
        _pipelineLayout = CreatePipelineLayout();
        CreateShaderModules(out _shaderModuleVert, out _shaderModuleFrag);
        _pipeline = CreatePipeline();
        CreateCommandBuffer(out _texCommandPool, out _texCommandBuffer);

        // Our render function expect RendererUserData to be storing the window render buffer we need (for the main viewport we won't use ->Window)
        var mainViewport = ImGui.GetMainViewport();

        mainViewport.RendererUserData = (nint)Mem.AllocZeroed<ViewportData>();

        InitMultiViewportSupport();
    }

    public void NewFrame() { }

    public void RenderDrawData(ImDrawDataPtr drawData, CommandBuffer commandBuffer)
    {
        RenderDrawData(drawData, commandBuffer, _pipeline);
    }

    private unsafe void RenderDrawData(ImDrawDataPtr drawData, CommandBuffer commandBuffer, VkPipeline pipeline)
    {
        // Avoid rendering when minimized, scale coordinates for retina displays (screen coordinates != framebuffer coordinates)
        var width = (int)(drawData.DisplaySize.X * drawData.FramebufferScale.X);
        var height = (int)(drawData.DisplaySize.Y * drawData.FramebufferScale.Y);
        if (width <= 0 || height <= 0)
            return;

        // Catch up with texture updates. Most of the times, the list will have 1 element with an OK status, aka nothing to do.
        // (This almost always points to ImGui::GetPlatformIO().Textures[] but is part of ImDrawData to allow overriding or disabling texture updates).
        if (drawData.Textures.IsNotNull())
        {
            foreach (var tex in drawData.Textures.Value)
                if (tex.Status != ImTextureStatus.OK)
                    UpdateTexture(tex);
        }

        // Allocate array to store enough vertex/index buffers. Each unique viewport gets its own storage.
        var viewportRendererData = (ViewportData*)drawData.OwnerViewport.RendererUserData;
        Assert(viewportRendererData is not null);
        var windowRenderBuffers = &viewportRendererData->RenderBuffers;
        if (windowRenderBuffers->FrameRenderBuffers.Count is 0)
        {
            windowRenderBuffers->Index = 0;
            windowRenderBuffers->Count = (uint)ImageCount;
            windowRenderBuffers->FrameRenderBuffers.Count = ImageCount;
        }
        Assert(windowRenderBuffers->Count == ImageCount);
        windowRenderBuffers->Index = (windowRenderBuffers->Index + 1) % windowRenderBuffers->Count;
        var renderBuffers = &windowRenderBuffers->FrameRenderBuffers.DataRaw[(int)windowRenderBuffers->Index];

        if (drawData.TotalVtxCount > 0)
        {
            // Create or resize the vertex/index buffers
            var vertexSize = ByteSize.Of<ImDrawVert>(drawData.TotalVtxCount).AlignTo(_bufferMemoryAlignment);
            var indexSize = ByteSize.Of<ushort>(drawData.TotalIdxCount).AlignTo(_bufferMemoryAlignment);
            if (renderBuffers->VertexBuffer.IsNull() || renderBuffers->VertexBufferSize.Bytes < vertexSize.Bytes)
                CreateOrResizeBuffer(
                    ref renderBuffers->VertexBuffer,
                    ref renderBuffers->VertexBufferMemory,
                    out renderBuffers->VertexBufferSize,
                    vertexSize,
                    VkBufferUsageFlags.VertexBufferBit
                );
            if (renderBuffers->IndexBuffer.IsNull() || renderBuffers->IndexBufferSize.Bytes < indexSize.Bytes)
                CreateOrResizeBuffer(
                    ref renderBuffers->IndexBuffer,
                    ref renderBuffers->IndexBufferMemory,
                    out renderBuffers->IndexBufferSize,
                    indexSize,
                    VkBufferUsageFlags.IndexBufferBit
                );

            // Upload vertex/index data into a single contiguous GPU buffer
            var vtxDst = Device.MapMemory<ImDrawVert>(renderBuffers->VertexBufferMemory);

            var idxDst = Device.MapMemory<ushort>(renderBuffers->IndexBufferMemory);

            foreach (var drawList in drawData.CmdLists)
            {
                Mem.Copy(drawList.VtxBuffer.Data, vtxDst, drawList.VtxBuffer.Count);
                Mem.Copy(drawList.IdxBuffer.Data, idxDst, drawList.IdxBuffer.Count);
                vtxDst = vtxDst.Offset(drawList.VtxBuffer.Count);
                idxDst = idxDst.Offset(drawList.IdxBuffer.Count);
            }

            Span<VkMappedMemoryRange> range =
            [
                new() { Memory = renderBuffers->VertexBufferMemory, Size = VK.WHOLE_SIZE },
                new() { Memory = renderBuffers->IndexBufferMemory, Size = VK.WHOLE_SIZE },
            ];

            Device.FlushMappedMemoryRanges(range);
            Device.UnmapMemory(renderBuffers->VertexBufferMemory);
            Device.UnmapMemory(renderBuffers->IndexBufferMemory);
        }

        // Setup desired Vulkan state
        SetupRenderState(drawData, pipeline, commandBuffer, renderBuffers, new float2(width, height));

        // Setup render state structure (for callbacks and custom texture bindings)
        var platformIo = ImGui.GetPlatformIO();
        var renderState = new RenderState
        {
            CommandBuffer = commandBuffer,
            Pipeline = pipeline,
            PipelineLayout = _pipelineLayout,
        };
        platformIo.Renderer_RenderState = (nint)(&renderState); // TODO: Why like this?

        // Will project scissor/clipping rectangles into framebuffer space
        var clipOffset = drawData.DisplayPos; // (0,0) unless using multi-viewports
        var clipScale = drawData.FramebufferScale; // (1,1) unless using retina display which are often (2,2)

        // Render command lists
        // (Because we merged all buffers into a single one, we maintain our own offset into them)
        VkDescriptorSet last_desc_set = default;
        var vtxOffset = 0;
        var idxOffset = 0;
        foreach (var drawList in drawData.CmdLists)
        {
            for (var i = 0; i < drawList.CmdBuffer.Count; i++)
            {
                var pcmd = drawList.CmdBuffer[i];
                if (pcmd.UserCallback is not 0)
                {
                    // TODO: Implement
                    // // User callback, registered via ImDrawList::AddCallback()
                    // // (ImDrawCallback_ResetRenderState is a special callback value used by the user to request the renderer to reset render state.)
                    // if (pcmd.UserCallback == ImDrawCallback_ResetRenderState)
                    //     SetupRenderState(
                    //         drawData,
                    //         pipeline,
                    //         commandBuffer,
                    //         renderBuffer,
                    //         new float2(width, height)
                    //     );
                    // else
                    //     pcmd.UserCallback(draw_list, pcmd);
                    // last_desc_set = default;
                }
                else
                {
                    // Project scissor/clipping rectangles into framebuffer space
                    var clipMin = new float2(
                        (pcmd.ClipRect.X - clipOffset.X) * clipScale.X,
                        (pcmd.ClipRect.Y - clipOffset.Y) * clipScale.Y
                    );
                    var clipMax = new float2(
                        (pcmd.ClipRect.Z - clipOffset.X) * clipScale.X,
                        (pcmd.ClipRect.W - clipOffset.Y) * clipScale.Y
                    );

                    // Clamp to viewport as vkCmdSetScissor() won't accept values that are off bounds
                    clipMin = float2.Max(clipMin, float2.Zero);
                    clipMax = float2.Min(clipMax, new float2(width, height));

                    if (clipMax.X <= clipMin.X || clipMax.Y <= clipMin.Y)
                        continue;

                    // Apply scissor/clipping rectangle
                    Span<VkRect2D> scissor =
                    [
                        new()
                        {
                            Offset = new VkOffset2D { X = (int)clipMin.X, Y = (int)clipMin.Y },
                            Extent = new VkExtent2D
                            {
                                Width = (int)(clipMax.X - clipMin.X),
                                Height = (int)(clipMax.Y - clipMin.Y),
                            },
                        },
                    ];
                    commandBuffer.SetScissor(firstScissor: 0, scissor);

                    // Bind DescriptorSet with font or user texture
                    Span<VkDescriptorSet> descSet = [new(pcmd.GetTexID())];
                    if (descSet[0].VkHandle != last_desc_set.VkHandle)
                        commandBuffer.BindDescriptorSets(VkPipelineBindPoint.Graphics, _pipelineLayout, 0, descSet, []);
                    last_desc_set = descSet[0];

                    // Draw
                    commandBuffer.DrawIndexed(
                        (int)pcmd.ElemCount,
                        instanceCount: 1,
                        firstIndex: (int)pcmd.IdxOffset + idxOffset,
                        vertexOffset: (int)pcmd.VtxOffset + vtxOffset,
                        firstInstance: 0
                    );
                }
            }
            idxOffset += drawList.IdxBuffer.Count;
            vtxOffset += drawList.VtxBuffer.Count;
        }

        platformIo.Renderer_RenderState = 0;

        // Note: C++ backend attempted to 'reset' scissor at this point, but I don't believe this tidyup is necessary
        // - if someone is using dynamic state they should set it each draw call themselves
    }

    private unsafe void SetupRenderState(
        ImDrawDataPtr drawData,
        VkPipeline pipeline,
        CommandBuffer commandBuffer,
        FrameRenderBuffers* renderBuffers,
        float2 framebufferSize
    )
    {
        // Bind pipeline:
        {
            commandBuffer.BindPipeline(VkPipelineBindPoint.Graphics, pipeline);
        }

        // Bind Vertex And Index Buffer:
        if (drawData.TotalVtxCount > 0)
        {
            commandBuffer.BindVertexBuffer(0, renderBuffers->VertexBuffer);
            commandBuffer.BindIndexBuffer(renderBuffers->IndexBuffer, offset: ByteSize.Zero, VkIndexType.UInt16);
        }

        // Setup viewport:
        {
            commandBuffer.SetViewport(
                firstViewport: 0,
                [
                    new VkViewport
                    {
                        Width = framebufferSize.X,
                        Height = framebufferSize.Y,
                        MinDepth = 0.0f,
                        MaxDepth = 1.0f,
                    },
                ]
            );
        }

        // Setup scale and translation:
        // Our visible imgui space lies from draw_data->DisplayPps (top left) to draw_data->DisplayPos+data_data->DisplaySize (bottom right). DisplayPos is (0,0) for single viewport apps.
        {
            Span<float> scale = [2.0f / drawData.DisplaySize.X, 2.0f / drawData.DisplaySize.Y];
            Span<float> translate =
            [
                -1.0f - drawData.DisplayPos.X * scale[0],
                -1.0f - drawData.DisplayPos.Y * scale[1],
            ];

            commandBuffer.PushConstants(
                _pipelineLayout,
                VkShaderStageFlags.VertexBit,
                offset: 0,
                scale.Cast<float, byte>()
            );
            commandBuffer.PushConstants(
                _pipelineLayout,
                VkShaderStageFlags.VertexBit,
                offset: sizeof(float) * 2,
                translate.Cast<float, byte>()
            );
        }
    }

    private void CreateOrResizeBuffer(
        ref VkBuffer buffer,
        ref VkDeviceMemory bufferMemory,
        out ByteSize bufferSize,
        ByteSize newSize,
        VkBufferUsageFlags usage
    )
    {
        if (buffer.IsNotNull())
            Device.DestroyBuffer(buffer, null);
        if (bufferMemory.IsNotNull())
            Device.FreeMemory(bufferMemory, null);

        var bytes = ByteSize.Max(MinAllocationSize, newSize);
        var bufferSizeAligned = bytes.AlignTo(_bufferMemoryAlignment);

        buffer = Device.CreateBuffer(
            new VkBufferCreateInfo
            {
                Size = bufferSizeAligned,
                Usage = usage,
                SharingMode = VkSharingMode.Exclusive,
            },
            null
        );

        var req = Device.GetBufferMemoryRequirements(buffer);
        _bufferMemoryAlignment = ByteSize.Max(_bufferMemoryAlignment, req.Alignment);

        bufferMemory = Device.AllocateMemory(
            new VkMemoryAllocateInfo
            {
                AllocationSize = req.Size,
                MemoryTypeIndex = MemoryType(VkMemoryPropertyFlags.HostVisibleBit, req.MemoryTypeBits),
            },
            null
        );

        Device.BindBufferMemory(buffer, bufferMemory, memoryOffset: ByteSize.Zero);

        bufferSize = bufferSizeAligned;
    }

    private int MemoryType(VkMemoryPropertyFlags properties, int typeBits)
    {
        var prop = PhysicalDevice.GetMemoryProperties();
        for (var i = 0; i < prop.MemoryTypeCount; i++)
            if ((prop.MemoryTypes[i].PropertyFlags & properties) == properties && (typeBits & (1 << i)) is not 0)
                return i;

        // No usable memory type, matching the assert/throw behaviour of the C++ reference backend.
        throw new InvalidOperationException(
            $"No suitable Vulkan memory type found for properties {properties} and type bits 0x{typeBits:X}."
        );
    }

    private unsafe void UpdateTexture(ImTextureDataPtr tex)
    {
        if (tex.Status is ImTextureStatus.OK)
            return;

        if (tex.Status is ImTextureStatus.WantCreate)
        {
            // Create and upload new texture to graphics system
            Assert(tex.TexID == ImTextureID.Invalid && tex.BackendUserData is 0);
            Assert(tex.Format is ImTextureFormat.RGBA32);
            var backendTex = Mem.Alloc<Texture>();

            // Create the Image:
            {
                backendTex.Value.Image = Device.CreateImage(
                    new VkImageCreateInfo
                    {
                        ImageType = VkImageType._2D,
                        Format = VkFormat.R8G8B8A8UNorm,
                        Extent = new VkExtent3D
                        {
                            Width = tex.Width,
                            Height = tex.Height,
                            Depth = 1,
                        },
                        MipLevels = 1,
                        ArrayLayers = 1,
                        Samples = VkSampleCountFlags._1Bit,
                        Tiling = VkImageTiling.Optimal,
                        Usage = VkImageUsageFlags.SampledBit | VkImageUsageFlags.TransferDstBit,
                        SharingMode = VkSharingMode.Exclusive,
                        InitialLayout = VkImageLayout.Undefined,
                    },
                    null
                );

                var req = Device.GetImageMemoryRequirements(backendTex.Value.Image);

                backendTex.Value.Memory = Device.AllocateMemory(
                    new VkMemoryAllocateInfo
                    {
                        AllocationSize = ByteSize.Max(MinAllocationSize, req.Size),
                        MemoryTypeIndex = MemoryType(VkMemoryPropertyFlags.DeviceLocalBit, req.MemoryTypeBits),
                    },
                    null
                );
                Device.BindImageMemory(backendTex.Value.Image, backendTex.Value.Memory, memoryOffset: ByteSize.Zero);
            }

            // Create the Image View:
            {
                backendTex.Value.ImageView = Device.CreateImageView(
                    new VkImageViewCreateInfo
                    {
                        Image = backendTex.Value.Image,
                        ViewType = VkImageViewType._2D,
                        Format = VkFormat.R8G8B8A8UNorm,
                        SubresourceRange = new VkImageSubresourceRange
                        {
                            AspectMask = VkImageAspectFlags.ColorBit,
                            LevelCount = 1,
                            LayerCount = 1,
                        },
                    },
                    null
                );
            }

            // Create the Descriptor Set
            backendTex.Value.DescriptorSet = AddTextureImpl(
                _texSampler,
                backendTex.Value.ImageView,
                VkImageLayout.ShaderReadOnlyOptimal
            );

            // Store identifiers
            tex.SetTexID(new ImTextureID(backendTex.Value.DescriptorSet.VkHandle));
            tex.BackendUserData = (nint)backendTex;
        }

        if (tex.Status is ImTextureStatus.WantCreate or ImTextureStatus.WantUpdates)
        {
            var backendTex = (Texture*)tex.BackendUserData;

            // Update full texture or selected blocks. We only ever write to textures regions which have never been used before!
            // This backend choose to use tex.UpdateRect but you can use tex.Updates[] to upload individual regions.
            // We could use the smaller rect on _WantCreate but using the full rect allows us to clear the texture.
            var uploadX = tex.Status is ImTextureStatus.WantCreate ? 0 : tex.UpdateRect.x;
            var uploadY = tex.Status is ImTextureStatus.WantCreate ? 0 : tex.UpdateRect.y;
            var uploadW = tex.Status is ImTextureStatus.WantCreate ? tex.Width : tex.UpdateRect.w;
            var uploadH = tex.Status is ImTextureStatus.WantCreate ? tex.Height : tex.UpdateRect.h;

            // Create the Upload Buffer:
            VkDeviceMemory uploadBufferMemory;

            VkBuffer uploadBuffer;
            var uploadPitch = ByteSize.Of(uploadW * tex.BytesPerPixel);
            var uploadSize = ByteSize.Of((ulong)(uploadH * uploadPitch)).AlignTo(_nonCoherentAtomSize);
            {
                uploadBuffer = Device.CreateBuffer(
                    new VkBufferCreateInfo
                    {
                        Size = uploadSize,
                        Usage = VkBufferUsageFlags.TransferSrcBit,
                        SharingMode = VkSharingMode.Exclusive,
                    },
                    null
                );

                var req = Device.GetBufferMemoryRequirements(uploadBuffer);

                _bufferMemoryAlignment = ByteSize.Max(_bufferMemoryAlignment, req.Alignment);

                uploadBufferMemory = Device.AllocateMemory(
                    new VkMemoryAllocateInfo
                    {
                        AllocationSize = ByteSize.Max(MinAllocationSize, req.Size),
                        MemoryTypeIndex = MemoryType(VkMemoryPropertyFlags.HostVisibleBit, req.MemoryTypeBits),
                    },
                    null
                );

                Device.BindBufferMemory(uploadBuffer, uploadBufferMemory, memoryOffset: ByteSize.Zero);
            }

            // Upload to Buffer:
            {
                var map = Device.MapMemory(
                    new MapInfo(uploadBufferMemory) { Region = new MapRegion { Size = uploadSize } }
                );

                for (var y = 0; y < uploadH; y++)
                    Mem.Copy((byte*)tex.GetPixelsAt(uploadX, uploadY + y), map.Offset(uploadPitch * y), uploadPitch);

                Device.FlushMappedMemoryRanges(
                    [new VkMappedMemoryRange { Memory = uploadBufferMemory, Size = uploadSize }]
                );

                Device.UnmapMemory(uploadBufferMemory);
            }

            // Start command buffer
            {
                Device.ResetCommandPool(_texCommandPool, VkCommandPoolResetFlags.None);

                _texCommandBuffer.Begin(
                    new VkCommandBufferBeginInfo { Flags = VkCommandBufferUsageFlags.OneTimeSubmitBit }
                );
            }

            // Copy to Image:
            {
                _texCommandBuffer.PipelineBarrier(
                    VkPipelineStageFlags.FragmentShaderBit | VkPipelineStageFlags.HostBit,
                    VkPipelineStageFlags.TransferBit,
                    dependencyFlags: VkDependencyFlags.None,
                    [],
                    [
                        new VkBufferMemoryBarrier
                        {
                            SrcAccessMask = VkAccessFlags.HostWriteBit,
                            DstAccessMask = VkAccessFlags.TransferReadBit,
                            SrcQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            DstQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            Buffer = uploadBuffer,
                            Offset = ByteSize.Zero,
                            Size = uploadSize,
                        },
                    ],
                    [
                        new VkImageMemoryBarrier
                        {
                            DstAccessMask = VkAccessFlags.TransferWriteBit,
                            OldLayout =
                                tex.Status is ImTextureStatus.WantCreate
                                    ? VkImageLayout.Undefined
                                    : VkImageLayout.ShaderReadOnlyOptimal,
                            NewLayout = VkImageLayout.TransferDstOptimal,
                            SrcQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            DstQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            Image = backendTex->Image,
                            SubresourceRange = new VkImageSubresourceRange
                            {
                                AspectMask = VkImageAspectFlags.ColorBit,
                                LevelCount = 1,
                                LayerCount = 1,
                            },
                        },
                    ]
                );

                _texCommandBuffer.CopyBufferToImage(
                    uploadBuffer,
                    backendTex->Image,
                    VkImageLayout.TransferDstOptimal,
                    [
                        new VkBufferImageCopy
                        {
                            ImageSubresource = new VkImageSubresourceLayers
                            {
                                AspectMask = VkImageAspectFlags.ColorBit,
                                LayerCount = 1,
                            },
                            ImageExtent = new VkExtent3D
                            {
                                Width = uploadW,
                                Height = uploadH,
                                Depth = 1,
                            },
                            ImageOffset = new VkOffset3D
                            {
                                X = uploadX,
                                Y = uploadY,
                                Z = 0,
                            },
                        },
                    ]
                );

                _texCommandBuffer.PipelineBarrier(
                    VkPipelineStageFlags.TransferBit,
                    VkPipelineStageFlags.FragmentShaderBit,
                    VkDependencyFlags.None,
                    [],
                    [],
                    [
                        new VkImageMemoryBarrier
                        {
                            SrcAccessMask = VkAccessFlags.TransferWriteBit,
                            DstAccessMask = VkAccessFlags.ShaderReadBit,
                            OldLayout = VkImageLayout.TransferDstOptimal,
                            NewLayout = VkImageLayout.ShaderReadOnlyOptimal,
                            SrcQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            DstQueueFamilyIndex = VK.QUEUE_FAMILY_IGNORED,
                            Image = backendTex->Image,
                            SubresourceRange = new VkImageSubresourceRange
                            {
                                AspectMask = VkImageAspectFlags.ColorBit,
                                LevelCount = 1,
                                LayerCount = 1,
                            },
                        },
                    ]
                );
            }

            // End command buffer
            var fence = Device.CreateFence(VkFenceCreateFlags.None, null);
            _texCommandBuffer.End();
            GraphicsQueue.Submit([], [], [_texCommandBuffer], [], fence);
            Device.WaitForFence(fence, -1);

            Device.DestroyFence(fence, null);
            Device.DestroyBuffer(uploadBuffer, null);
            Device.FreeMemory(uploadBufferMemory, null);

            tex.SetStatus(ImTextureStatus.OK);
        }

        if (tex.Status is ImTextureStatus.WantDestroy && tex.UnusedFrames >= ImageCount)
            DestroyTexture(tex);
    }

    private unsafe void DestroyTexture(ImTextureDataPtr tex)
    {
        var backendTex = (Texture*)tex.BackendUserData;
        if (backendTex is null)
            return;

        Assert(backendTex->DescriptorSet.VkHandle == tex.TexID.Value);
        RemoveTextureImpl(backendTex->DescriptorSet);
        Device.DestroyImageView(backendTex->ImageView, null);
        Device.DestroyImage(backendTex->Image, null);
        Device.FreeMemory(backendTex->Memory, null);
        Mem.Free(backendTex);

        // Clear identifiers and mark as destroyed (in order to allow e.g. calling InvalidateDeviceObjects while running)
        tex.SetTexID(ImTextureID.Invalid);
        tex.SetStatus(ImTextureStatus.Destroyed);
        tex.BackendUserData = 0;
    }

    public ImTextureRef AddTexture(VkSampler sampler, VkImageView imageView, VkImageLayout imageLayout)
    {
        var descriptorSet = AddTextureImpl(sampler, imageView, imageLayout);
        return new ImTextureRef { _TexID = (ImTextureID)descriptorSet.VkHandle };
    }

    public void RemoveTexture(ImTextureRef texture)
    {
        RemoveTextureImpl(new VkDescriptorSet(texture._TexID));
    }

    // Register a texture by creating a descriptor
    // FIXME: This is experimental in the sense that we are unsure how to best design/tackle this problem, please post to https://github.com/ocornut/imgui/pull/914 if you have suggestions.
    private unsafe VkDescriptorSet AddTextureImpl(VkSampler sampler, VkImageView imageView, VkImageLayout imageLayout)
    {
        // Create Descriptor Set:
        var descriptorSet = Device.AllocateDescriptorSet(_descriptorPool, _descriptorSetLayout);

        // Update the Descriptor Set:
        {
            var imageInfo = new VkDescriptorImageInfo
            {
                Sampler = sampler,
                ImageView = imageView,
                ImageLayout = imageLayout,
            };
            Device.UpdateDescriptorSets(
                [
                    new VkWriteDescriptorSet
                    {
                        DstSet = descriptorSet,
                        DescriptorCount = 1,
                        DescriptorType = VkDescriptorType.CombinedImageSampler,
                        ImageInfo = &imageInfo,
                    },
                ],
                []
            );
        }
        return descriptorSet;
    }

    private void RemoveTextureImpl(VkDescriptorSet descriptorSet)
    {
        Device.FreeDescriptorSets(_descriptorPool, [descriptorSet]);
    }

    private unsafe void DestroyFrameRenderBuffers(FrameRenderBuffers* buffers)
    {
        if (buffers->VertexBuffer.IsNotNull())
        {
            Device.DestroyBuffer(buffers->VertexBuffer, null);
            buffers->VertexBuffer = default;
        }
        if (buffers->VertexBufferMemory.IsNotNull())
        {
            Device.FreeMemory(buffers->VertexBufferMemory, null);
            buffers->VertexBufferMemory = default;
        }
        if (buffers->IndexBuffer.IsNotNull())
        {
            Device.DestroyBuffer(buffers->IndexBuffer, null);
            buffers->IndexBuffer = default;
        }
        if (buffers->IndexBufferMemory.IsNotNull())
        {
            Device.FreeMemory(buffers->IndexBufferMemory, null);
            buffers->IndexBufferMemory = default;
        }
        buffers->VertexBufferSize = ByteSize.Zero;
        buffers->IndexBufferSize = ByteSize.Zero;
    }

    private unsafe void DestroyWindowRenderBuffers(WindowRenderBuffers* buffers)
    {
        for (var n = 0; n < buffers->Count; n++)
            DestroyFrameRenderBuffers(&buffers->FrameRenderBuffers.DataRaw[n]);
        buffers->FrameRenderBuffers.Clear();
        buffers->Index = 0;
        buffers->Count = 0;
    }

    private unsafe void DestroyDeviceObjects()
    {
        // Destroy all viewports render buffers
        var platformIo = ImGui.GetPlatformIO();
        foreach (var viewport in platformIo.Viewports)
        {
            var viewportData = (ViewportData*)viewport.RendererUserData;
            if (viewportData is not null)
                DestroyWindowRenderBuffers(&viewportData->RenderBuffers);
        }

        // Destroy all textures
        foreach (var tex in platformIo.Textures)
            if (tex.RefCount == 1)
                DestroyTexture(tex);

        Device.FreeCommandBuffers(_texCommandPool, [_texCommandBuffer]);
        Device.DestroyCommandPool(_texCommandPool, null);
        Device.DestroySampler(_texSampler, null);
        Device.DestroyShaderModule(_shaderModuleVert, null);
        Device.DestroyShaderModule(_shaderModuleFrag, null);
        Device.DestroyDescriptorSetLayout(_descriptorSetLayout, null);
        Device.DestroyPipelineLayout(_pipelineLayout, null);
        Device.DestroyPipeline(_pipeline, null);
        Device.DestroyPipeline(_pipelineForViewports, null);
        Device.DestroyDescriptorPool(_descriptorPool, null);
    }

    public unsafe void Dispose()
    {
        var io = ImGui.GetIO();

        // First destroy objects in all viewports
        DestroyDeviceObjects();

        // Manually delete main viewport render data in-case we haven't initialized for viewports
        var mainViewport = ImGui.GetMainViewport();
        var viewportData = mainViewport.RendererUserData;
        if (viewportData is not 0)
            Mem.Free(new Ptr((void*)viewportData)); // TODO: fix this??
        mainViewport.RendererUserData = 0;

        // Clean up windows
        ShutdownMultiViewportSupport();

        io.BackendRendererName = null;
        io.BackendRendererUserData = 0;
        io.BackendFlags &= ~(
            ImGuiBackendFlags.RendererHasVtxOffset
            | ImGuiBackendFlags.RendererHasTextures
            | ImGuiBackendFlags.RendererHasViewports
        );
    }

    // TODO: Replace with something generic
    private static void Assert(bool condition, string message = "")
    {
        if (!condition)
            throw new Exception(message);
    }

    private VkSampler CreateSampler()
    {
        return Device.CreateSampler(
            new VkSamplerCreateInfo
            {
                MagFilter = VkFilter.Linear,
                MinFilter = VkFilter.Linear,
                MipmapMode = VkSamplerMipmapMode.Linear,
                AddressModeU = VkSamplerAddressMode.ClampToEdge,
                AddressModeV = VkSamplerAddressMode.ClampToEdge,
                AddressModeW = VkSamplerAddressMode.ClampToEdge,
                MinLod = -1000,
                MaxLod = 1000,
                MaxAnisotropy = 1.0f,
            },
            null
        );
    }

    private void CreateDescriptorPool(
        out DescriptorSetLayoutEx descriptorSetLayout,
        out DescriptorPoolEx descriptorPool
    )
    {
        // Bilinear sampling is required by default. Set 'io.Fonts->Flags |= ImFontAtlasFlags_NoBakedLines' or 'style.AntiAliasedLinesUseTex = false' to allow point/nearest sampling.
        var descriptorSetLayoutBinding = new VkDescriptorSetLayoutBinding
        {
            DescriptorType = VkDescriptorType.CombinedImageSampler,
            DescriptorCount = 1,
            StageFlags = VkShaderStageFlags.FragmentBit,
        };

        descriptorSetLayout = Device.CreateDescriptorSetLayout(
            new DescriptorSetLayoutEx.CreateInfo { Bindings = [descriptorSetLayoutBinding] },
            null
        );

        Assert(
            DescriptorPoolSize >= MINIMUM_IMAGE_SAMPLER_POOL_SIZE,
            $"VulkanBackend pool size needs to be at least {MINIMUM_IMAGE_SAMPLER_POOL_SIZE}."
        );

        var descriptorPoolSize = new VkDescriptorPoolSize
        {
            Type = VkDescriptorType.CombinedImageSampler,
            DescriptorCount = DescriptorPoolSize,
        };

        descriptorPool = Device.CreateDescriptorPool(
            new DescriptorPoolEx.CreateInfo
            {
                Flags = VkDescriptorPoolCreateFlags.FreeDescriptorSetBit,
                MaxSets = DescriptorPoolSize,
                PoolSizes = [descriptorPoolSize],
            },
            null
        );
    }

    private VkPipelineLayout CreatePipelineLayout()
    {
        // Constants: we are using 'vec2 offset' and 'vec2 scale' instead of a full 3d projection matrix
        var pushConstants = new VkPushConstantRange
        {
            StageFlags = VkShaderStageFlags.VertexBit,
            Offset = ByteSize.Zero,
            Size = ByteSize.Of<float>(4),
        };

        return Device.CreatePipelineLayout([_descriptorSetLayout], [pushConstants], null);
    }

    private void CreateCommandBuffer(out VkCommandPool texCommandPool, out CommandBuffer texCommandBuffer)
    {
        // Create command pool/buffer for texture upload
        texCommandPool = Device.CreateCommandPool(
            new VkCommandPoolCreateInfo { QueueFamilyIndex = GraphicsQueue.Family },
            null
        );

        texCommandBuffer = Device.AllocateCommandBuffer(
            new VkCommandBufferAllocateInfo { CommandPool = texCommandPool, Level = VkCommandBufferLevel.Primary }
        );
    }

    private VkPipeline CreatePipeline()
    {
        return CreatePipeline(RenderPass, SubPass, SampleCount);
    }

    private unsafe VkPipeline CreatePipeline(VkRenderPass renderPass, int subPass, VkSampleCountFlags sampleCount)
    {
        var shaderName = "main"u8;

        Span<VkPipelineShaderStageCreateInfo> stages =
        [
            new()
            {
                Stage = VkShaderStageFlags.VertexBit,
                Module = _shaderModuleVert,
                Name = shaderName.AsPointer(),
            },
            new()
            {
                Stage = VkShaderStageFlags.FragmentBit,
                Module = _shaderModuleFrag,
                Name = shaderName.AsPointer(),
            },
        ];

        var bindingDesc = new VkVertexInputBindingDescription
        {
            Stride = ByteSize.Of<ImDrawVert>(),
            InputRate = VkVertexInputRate.Vertex,
        };

        Span<VkVertexInputAttributeDescription> attributeDesc =
        [
            new()
            {
                Location = 0,
                Binding = bindingDesc.Binding,
                Format = VkFormat.R32G32SFloat,
                Offset = ByteSize.OffsetOf<ImDrawVert>(nameof(ImDrawVert.pos)),
            },
            new()
            {
                Location = 1,
                Binding = bindingDesc.Binding,
                Format = VkFormat.R32G32SFloat,
                Offset = ByteSize.OffsetOf<ImDrawVert>(nameof(ImDrawVert.uv)),
            },
            new()
            {
                Location = 2,
                Binding = bindingDesc.Binding,
                Format = VkFormat.R8G8B8A8UNorm,
                Offset = ByteSize.OffsetOf<ImDrawVert>(nameof(ImDrawVert.col)),
            },
        ];

        var vertexInfo = new VkPipelineVertexInputStateCreateInfo
        {
            VertexBindingDescriptionCount = 1,
            VertexBindingDescriptions = &bindingDesc,
            VertexAttributeDescriptionCount = 3,
            VertexAttributeDescriptions = attributeDesc.AsPointer(),
        };

        var inputAssemblyStateCreateInfo = new VkPipelineInputAssemblyStateCreateInfo
        {
            Topology = VkPrimitiveTopology.TriangleList,
        };

        var viewportInfo = new VkPipelineViewportStateCreateInfo { ViewportCount = 1, ScissorCount = 1 };

        var rasterInfo = new VkPipelineRasterizationStateCreateInfo
        {
            PolygonMode = VkPolygonMode.Fill,
            CullMode = VkCullModeFlags.None,
            FrontFace = VkFrontFace.CounterClockwise,
            LineWidth = 1.0f,
        };

        var multisampleInfo = new VkPipelineMultisampleStateCreateInfo { RasterizationSamples = sampleCount };

        var colorAttachment = new VkPipelineColorBlendAttachmentState
        {
            BlendEnable = true,
            SrcColorBlendFactor = VkBlendFactor.SrcAlpha,
            DstColorBlendFactor = VkBlendFactor.OneMinusSrcAlpha,
            ColorBlendOp = VkBlendOp.Add,
            SrcAlphaBlendFactor = VkBlendFactor.One,
            DstAlphaBlendFactor = VkBlendFactor.OneMinusSrcAlpha,
            AlphaBlendOp = VkBlendOp.Add,
            ColorWriteMask =
                VkColorComponentFlags.RBit
                | VkColorComponentFlags.GBit
                | VkColorComponentFlags.BBit
                | VkColorComponentFlags.ABit,
        };

        var depthInfo = new VkPipelineDepthStencilStateCreateInfo();

        var blendInfo = new VkPipelineColorBlendStateCreateInfo { AttachmentCount = 1, Attachments = &colorAttachment };

        Span<VkDynamicState> dynamicStates = [VkDynamicState.Viewport, VkDynamicState.Scissor];

        var dynamicState = new VkPipelineDynamicStateCreateInfo
        {
            DynamicStateCount = dynamicStates.Length,
            DynamicStates = dynamicStates.AsPointer(),
        };

        VkPipeline pipeline;
        Device.CreateGraphicsPipelines(
            default,
            [
                new VkGraphicsPipelineCreateInfo
                {
                    Flags = VkPipelineCreateFlags.None,
                    StageCount = 2,
                    Stages = stages.AsPointer(),
                    VertexInputState = &vertexInfo,
                    InputAssemblyState = &inputAssemblyStateCreateInfo,
                    ViewportState = &viewportInfo,
                    RasterizationState = &rasterInfo,
                    MultisampleState = &multisampleInfo,
                    DepthStencilState = &depthInfo,
                    ColorBlendState = &blendInfo,
                    DynamicState = &dynamicState,
                    Layout = _pipelineLayout,
                    RenderPass = renderPass,
                    Subpass = subPass,
                },
            ],
            default,
            new ReadOnlySpan<VkPipeline>(&pipeline, 1)
        );
        return pipeline;
    }

    private unsafe void CreateShaderModules(out VkShaderModule vert, out VkShaderModule frag)
    {
        // Create the shader modules
        fixed (uint* vertSourcePtr = ShaderSource.Vert)
            vert = Device.CreateShaderModule(
                new VkShaderModuleCreateInfo { CodeSize = ByteSize.Of(ShaderSource.Vert), Code = (int*)vertSourcePtr },
                null
            );

        fixed (uint* fragSourcePtr = ShaderSource.Frag)
            frag = Device.CreateShaderModule(
                new VkShaderModuleCreateInfo { CodeSize = ByteSize.Of(ShaderSource.Frag), Code = (int*)fragSourcePtr },
                null
            );
    }

    #region MultiViewport
    private unsafe void InitMultiViewportSupport()
    {
        var platformIo = ImGui.GetPlatformIO();
        if (ImGui.GetIO().BackendFlags.HasFlag(ImGuiBackendFlags.PlatformHasViewports))
            Assert(
                platformIo.Platform_CreateVkSurface is not 0,
                "Platform needs to setup the CreateVkSurface handler."
            );
        platformIo.Renderer_CreateWindow = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&CreateWindow;
        platformIo.Renderer_DestroyWindow = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&DestroyWindow;
        platformIo.Renderer_SetWindowSize = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2, void>)&SetWindowSize;
        platformIo.Renderer_RenderWindow = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void*, void>)&RenderWindow;
        platformIo.Renderer_SwapBuffers = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void*, void>)&SwapBuffers;
    }

    private void ShutdownMultiViewportSupport()
    {
        ImGui.DestroyPlatformWindows();
    }

    private static VulkanBackend GetBackend()
    {
        var handle = GCHandle.FromIntPtr(ImGui.GetIO().BackendRendererUserData);
        // TODO: Buffer exceptions rather than throw, since this will be from native calls
        if (handle.Target is not VulkanBackend backend)
            throw new Exception("ImGui backend is not a VulkanBackend.");
        return backend;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void CreateWindow(ImGuiViewportPtr viewport)
    {
        var backend = GetBackend();
        var viewportData = Mem.AllocZeroed<ViewportData>();
        viewport.RendererUserData = (nint)viewportData;
        ref var window = ref viewportData.Value.Window;

        // Create surface
        var platformIo = ImGui.GetPlatformIO();
        var createSurfaceFunc = (delegate* unmanaged[Cdecl]<
            ImGuiViewportPtr,
            VkInstance,
            nint,
            VkSurfaceKHR*,
            VkResult>)
            platformIo.Platform_CreateVkSurface;

        fixed (VkSurfaceKHR* surfacePtr = &window.Surface)
            createSurfaceFunc(viewport, backend.Instance, 0, surfacePtr);

        // Check for WSI support
        var res = backend.PhysicalDevice.GetSurfaceSupportKHR(backend.GraphicsQueue.Family, window.Surface);
        if (!res)
            throw new Exception("VulkanBackend: No WSI support.");

        // Select Surface Format
        ReadOnlySpan<VkFormat> requestSurfaceImageFormats =
        [
            VkFormat.B8G8R8A8UNorm,
            VkFormat.R8G8B8A8UNorm,
            VkFormat.B8G8R8UNorm,
            VkFormat.R8G8B8UNorm,
        ];

        window.SurfaceFormat = Helpers.SelectSurfaceFormat(
            backend.PhysicalDevice,
            window.Surface,
            requestSurfaceImageFormats,
            VkColorSpaceKHR.SRGBNonlinearKHR
        );

        // Select Present Mode
        // FIXME-VULKAN: Even thought mailbox seems to get us maximum framerate with a single window, it halves framerate with a second window etc. (w/ Nvidia and SDK 1.82.1)
        // TODO: Do we want these present mode options?
        ReadOnlySpan<VkPresentModeKHR> presentModes =
        [
            VkPresentModeKHR.MailboxKHR,
            VkPresentModeKHR.ImmediateKHR,
            VkPresentModeKHR.FifoKHR,
        ];
        window.PresentMode = Helpers.SelectPresentMode(backend.PhysicalDevice, window.Surface, presentModes);

        // Create SwapChain, RenderPass, Framebuffer, etc.
        window.ClearEnable = !viewport.Flags.HasFlag(ImGuiViewportFlags.NoRendererClear);

        fixed (WindowImpl* windowPtr = &window)
            Helpers.CreateOrResizeWindow(
                backend.PhysicalDevice,
                backend.Device,
                windowPtr,
                backend.GraphicsQueue,
                backend.GraphicsQueue.Family,
                (int)viewport.Size.X,
                (int)viewport.Size.Y,
                backend.MinImageCount
            );
        viewportData.Value.WindowOwned = true;

        // Create pipeline (shared by all secondary viewports)
        if (backend._pipelineForViewports.IsNull())
            backend._pipelineForViewports = backend.CreatePipeline(
                window.RenderPass,
                subPass: 0,
                VkSampleCountFlags._1Bit
            );
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void DestroyWindow(ImGuiViewportPtr viewport)
    {
        // If backend is null we assumed that it has already been shut down

        // The main viewport (owned by the application) will always have RendererUserData == 0 since we didn't create the data for it.
        var viewportData = (ViewportData*)viewport.RendererUserData;
        if (viewportData is not null)
        {
            var backend = GetBackend();

            if (viewportData->WindowOwned)
                Helpers.DestroyWindow(backend.Instance, backend.Device, &viewportData->Window);
            backend.DestroyWindowRenderBuffers(&viewportData->RenderBuffers);
            Mem.Free(viewportData);
        }
        viewport.RendererUserData = 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowSize(ImGuiViewportPtr viewport, float2 size)
    {
        var viewportData = (ViewportData*)viewport.RendererUserData;
        if (viewportData == null) // This is nullptr for the main viewport (which is left to the user/app to handle)
            return;
        viewportData->Window.ClearEnable = !viewport.Flags.HasFlag(ImGuiViewportFlags.NoRendererClear);
        var backend = GetBackend();
        Helpers.CreateOrResizeWindow(
            backend.PhysicalDevice,
            backend.Device,
            &viewportData->Window,
            backend.GraphicsQueue,
            backend.GraphicsQueue.Family,
            (int)size.X,
            (int)size.Y,
            backend.MinImageCount
        );
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void RenderWindow(ImGuiViewportPtr viewport, void* _)
    {
        var backend = GetBackend();
        var viewportData = (ViewportData*)viewport.RendererUserData;
        var windowData = &viewportData->Window;

        if (viewportData->SwapChainNeedRebuild || viewportData->SwapChainSuboptimal)
        {
            Helpers.CreateOrResizeWindow(
                backend.PhysicalDevice,
                backend.Device,
                windowData,
                backend.GraphicsQueue,
                backend.GraphicsQueue.Family,
                (int)viewport.Size.X,
                (int)viewport.Size.Y,
                backend.MinImageCount
            );
            viewportData->SwapChainNeedRebuild = viewportData->SwapChainSuboptimal = false;
        }

        var frameSemaphoresData = &windowData->FrameSemaphores.DataRaw[windowData->SemaphoreIndex];
        var result = backend.Device.AcquireNextImageKHR(
            windowData->Swapchain,
            -1,
            frameSemaphoresData->ImageAcquiredSemaphore,
            default,
            out windowData->FrameIndex
        );

        if (result == VkResult.ErrorOutOfDateKHR)
        {
            viewportData->SwapChainNeedRebuild = true; // Since we are not going to swap this frame anyway, it's ok that recreation happens on next frame.
            return;
        }

        if (result == VkResult.SuboptimalKHR)
        {
            viewportData->SwapChainSuboptimal = true;
        }
        else if (result != VkResult.Success)
        {
            throw new Exception("VulkanBackend: Failed to acquire next image.");
        }

        var frameData = &windowData->Frames.DataRaw[windowData->FrameIndex];

        // TODO: Seems a little dubious...
        for (; ; )
        {
            result = backend.Device.WaitForFences([frameData->Fence], true, timeout: 100);
            if (result is VkResult.Success)
                break;
            if (result is VkResult.Timeout)
                continue;
            throw new Exception("VulkanBackend: Failed to wait for fence.");
        }
        backend.Device.ResetCommandPool(frameData->CommandPool, VkCommandPoolResetFlags.None);

        var cb = frameData->CommandBuffer;

        cb.Begin(new VkCommandBufferBeginInfo { Flags = VkCommandBufferUsageFlags.OneTimeSubmitBit });
        windowData->ClearValue = new VkClearColorValue { Float32 = new float4(0.0f, 0.0f, 0.0f, 1.0f) };
        cb.BeginRenderPass(
            new VkRenderPassBeginInfo
            {
                RenderPass = windowData->RenderPass,
                Framebuffer = frameData->Framebuffer,
                RenderArea = new VkRect2D
                {
                    Extent = new VkExtent2D { Width = windowData->Width, Height = windowData->Height },
                },
                ClearValueCount = viewport.Flags.HasFlag(ImGuiViewportFlags.NoRendererClear) ? 0 : 1,
                ClearValues = viewport.Flags.HasFlag(ImGuiViewportFlags.NoRendererClear)
                    ? null
                    : &windowData->ClearValue,
            },
            VkSubpassContents.Inline
        );

        backend.RenderDrawData(viewport.DrawData, cb, backend._pipelineForViewports);

        cb.EndRenderPass();

        var waitStage = VkPipelineStageFlags.ColorAttachmentOutputBit;

        cb.End();

        var vkcb = cb.Handle;

        backend.Device.ResetFences([frameData->Fence]);
        backend.GraphicsQueue.Submit(
            [
                new VkSubmitInfo
                {
                    WaitSemaphoreCount = 1,
                    WaitSemaphores = &frameSemaphoresData->ImageAcquiredSemaphore,
                    WaitDstStageMask = &waitStage,
                    CommandBufferCount = 1,
                    CommandBuffers = &vkcb,
                    SignalSemaphoreCount = 1,
                    SignalSemaphores = &frameSemaphoresData->RenderCompleteSemaphore,
                },
            ],
            frameData->Fence
        );
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SwapBuffers(ImGuiViewportPtr viewport, void* _)
    {
        var backend = GetBackend();
        var viewportData = (ViewportData*)viewport.RendererUserData;
        var windowData = &viewportData->Window;

        if (viewportData->SwapChainNeedRebuild) // Frame data became invalid in the middle of rendering
            return;

        var presentIndex = windowData->FrameIndex;

        var frameSemaphoresData = &windowData->FrameSemaphores.DataRaw[windowData->SemaphoreIndex];
        var result = backend.GraphicsQueue.PresentKHR(
            new VkPresentInfoKHR
            {
                WaitSemaphoreCount = 1,
                WaitSemaphores = &frameSemaphoresData->RenderCompleteSemaphore,
                SwapchainCount = 1,
                Swapchains = &windowData->Swapchain,
                ImageIndices = &presentIndex,
            }
        );
        if (result is VkResult.ErrorOutOfDateKHR)
        {
            viewportData->SwapChainNeedRebuild = true;
            return;
        }

        if (result is VkResult.SuboptimalKHR)
        {
            viewportData->SwapChainSuboptimal = true;
        }
        else if (result != VkResult.Success)
        {
            throw new Exception("VulkanBackend: Failed to present.");
        }

        windowData->SemaphoreIndex = (windowData->SemaphoreIndex + 1) % windowData->SemaphoreCount; // Now we can use the next set of semaphores
    }

    #endregion

    private DeviceEx Device { get; }
    private PhysicalDevice PhysicalDevice => Device.PhysicalDevice;
    private Instance Instance => PhysicalDevice.Instance;
    private Queue GraphicsQueue { get; }
    private VkRenderPass RenderPass { get; }
    private int SubPass { get; }
    private int MinImageCount { get; }
    private int ImageCount { get; }
    private VkSampleCountFlags SampleCount { get; }
    private int DescriptorPoolSize { get; }
    private ByteSize MinAllocationSize { get; } // Minimum allocation size. Set to 1024*1024 to satisfy zealous best practices validation layer and waste a little memory.

    private ByteSize _bufferMemoryAlignment = ByteSize.Of(256);
    private readonly ByteSize _nonCoherentAtomSize;
    private DescriptorSetLayoutEx _descriptorSetLayout;
    private readonly VkPipelineLayout _pipelineLayout;
    private readonly VkPipeline _pipeline; // pipeline for main render pass (created by app)
    private VkPipeline _pipelineForViewports; // pipeline for secondary viewports (created by backend)
    private readonly VkShaderModule _shaderModuleVert;
    private readonly VkShaderModule _shaderModuleFrag;
    private readonly DescriptorPoolEx _descriptorPool;

    // Texture management
    private readonly VkSampler _texSampler;
    private readonly VkCommandPool _texCommandPool;
    private CommandBuffer _texCommandBuffer;

    // For multi-viewport support:
    // Helper structure we store in the void* RendererUserData field of each ImGuiViewport to easily retrieve our backend data.
    [StructLayout(LayoutKind.Sequential)]
    private struct ViewportData
    {
        public WindowImpl Window; // Used by secondary viewports only
        public WindowRenderBuffers RenderBuffers; // Used by all viewports
        public bool WindowOwned;
        public bool SwapChainNeedRebuild; // Flag when viewport swapchain resized in the middle of processing a frame
        public bool SwapChainSuboptimal; // Flag when VK_SUBOPTIMAL_KHR was returned.
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct Texture
    {
        public VkDeviceMemory Memory;
        public VkImage Image;
        public VkImageView ImageView;
        public VkDescriptorSet DescriptorSet;
    }

    // Reusable buffers used for rendering 1 current in-flight frame, for ImGui_ImplVulkan_RenderDrawData()
    [StructLayout(LayoutKind.Sequential)]
    private struct FrameRenderBuffers
    {
        public VkDeviceMemory VertexBufferMemory;
        public VkDeviceMemory IndexBufferMemory;
        public ByteSize VertexBufferSize;
        public ByteSize IndexBufferSize;
        public VkBuffer VertexBuffer;
        public VkBuffer IndexBuffer;
    }

    // Each viewport will hold 1 ImGui_ImplVulkanH_WindowRenderBuffers
    [StructLayout(LayoutKind.Sequential)]
    private struct WindowRenderBuffers
    {
        public uint Index;
        public uint Count;

        // TODO: Does this need to be initialized in any particular way?
        public ImVector<FrameRenderBuffers> FrameRenderBuffers;
    }

    // [BETA] Selected render state data shared with callbacks.
    // This is temporarily stored in GetPlatformIO().Renderer_RenderState during the ImGui_ImplVulkan_RenderDrawData() call.
    // (Please open an issue if you feel you need access to more data)
    [StructLayout(LayoutKind.Sequential)]
    private struct RenderState
    {
        public CommandBuffer CommandBuffer;
        public VkPipeline Pipeline;
        public VkPipelineLayout PipelineLayout;
    }

    // Helper structure to hold the data needed by one rendering frame
    // (Used by example's main.cpp. Used by multi-viewport features. Probably NOT used by your own engine/app.)
    [StructLayout(LayoutKind.Sequential)]
    private struct Frame
    {
        public VkCommandPool CommandPool;
        public CommandBuffer CommandBuffer;
        public VkFence Fence;
        public VkImage Backbuffer;
        public VkImageView BackbufferView;
        public VkFramebuffer Framebuffer;
    };

    [StructLayout(LayoutKind.Sequential)]
    private struct FrameSemaphores
    {
        public VkSemaphore ImageAcquiredSemaphore;
        public VkSemaphore RenderCompleteSemaphore;
    };

    // Helper structure to hold the data needed by one rendering context into one OS window
    // (Used by example's main.cpp. Used by multi-viewport features. Probably NOT used by your own engine/app.)
    [StructLayout(LayoutKind.Sequential)]
    private struct WindowImpl()
    {
        public int Width;
        public int Height;
        public VkSwapchainKHR Swapchain;
        public VkSurfaceKHR Surface;
        public VkSurfaceFormatKHR SurfaceFormat;
        public required VkPresentModeKHR PresentMode;
        public VkRenderPass RenderPass;

        // public bool UseDynamicRendering;
        public bool ClearEnable = true;
        public VkClearValue ClearValue;
        public int FrameIndex; // Current frame being rendered to (0 <= FrameIndex < FrameInFlightCount)
        public int ImageCount; // Number of simultaneous in-flight frames (returned by vkGetSwapchainImagesKHR, usually derived from min_image_count)
        public int SemaphoreCount; // Number of simultaneous in-flight frames + 1, to be able to use it in vkAcquireNextImageKHR
        public int SemaphoreIndex; // Current set of swapchain wait semaphores we're using (needs to be distinct from per frame data)
        public ImVector<Frame> Frames;
        public ImVector<FrameSemaphores> FrameSemaphores;
    };

    private static class ShaderSource
    {
        /*
        #version 450 core
        layout(location = 0) in vec2 aPos;
        layout(location = 1) in vec2 aUV;
        layout(location = 2) in vec4 aColor;
        layout(push_constant) uniform uPushConstant { vec2 uScale; vec2 uTranslate; } pc;

        out gl_PerVertex { vec4 gl_Position; };
        layout(location = 0) out struct { vec4 Color; vec2 UV; } Out;

        void main()
        {
            Out.Color = aColor;
            Out.UV = aUV;
            gl_Position = vec4(aPos * pc.uScale + pc.uTranslate, 0, 1);
        }
        */

        // csharpier-ignore
        public static readonly uint[] Vert =
        [
            0x07230203,0x00010000,0x00080001,0x0000002e,0x00000000,0x00020011,0x00000001,0x0006000b,
            0x00000001,0x4c534c47,0x6474732e,0x3035342e,0x00000000,0x0003000e,0x00000000,0x00000001,
            0x000a000f,0x00000000,0x00000004,0x6e69616d,0x00000000,0x0000000b,0x0000000f,0x00000015,
            0x0000001b,0x0000001c,0x00030003,0x00000002,0x000001c2,0x00040005,0x00000004,0x6e69616d,
            0x00000000,0x00030005,0x00000009,0x00000000,0x00050006,0x00000009,0x00000000,0x6f6c6f43,
            0x00000072,0x00040006,0x00000009,0x00000001,0x00005655,0x00030005,0x0000000b,0x0074754f,
            0x00040005,0x0000000f,0x6c6f4361,0x0000726f,0x00030005,0x00000015,0x00565561,0x00060005,
            0x00000019,0x505f6c67,0x65567265,0x78657472,0x00000000,0x00060006,0x00000019,0x00000000,
            0x505f6c67,0x7469736f,0x006e6f69,0x00030005,0x0000001b,0x00000000,0x00040005,0x0000001c,
            0x736f5061,0x00000000,0x00060005,0x0000001e,0x73755075,0x6e6f4368,0x6e617473,0x00000074,
            0x00050006,0x0000001e,0x00000000,0x61635375,0x0000656c,0x00060006,0x0000001e,0x00000001,
            0x61725475,0x616c736e,0x00006574,0x00030005,0x00000020,0x00006370,0x00040047,0x0000000b,
            0x0000001e,0x00000000,0x00040047,0x0000000f,0x0000001e,0x00000002,0x00040047,0x00000015,
            0x0000001e,0x00000001,0x00050048,0x00000019,0x00000000,0x0000000b,0x00000000,0x00030047,
            0x00000019,0x00000002,0x00040047,0x0000001c,0x0000001e,0x00000000,0x00050048,0x0000001e,
            0x00000000,0x00000023,0x00000000,0x00050048,0x0000001e,0x00000001,0x00000023,0x00000008,
            0x00030047,0x0000001e,0x00000002,0x00020013,0x00000002,0x00030021,0x00000003,0x00000002,
            0x00030016,0x00000006,0x00000020,0x00040017,0x00000007,0x00000006,0x00000004,0x00040017,
            0x00000008,0x00000006,0x00000002,0x0004001e,0x00000009,0x00000007,0x00000008,0x00040020,
            0x0000000a,0x00000003,0x00000009,0x0004003b,0x0000000a,0x0000000b,0x00000003,0x00040015,
            0x0000000c,0x00000020,0x00000001,0x0004002b,0x0000000c,0x0000000d,0x00000000,0x00040020,
            0x0000000e,0x00000001,0x00000007,0x0004003b,0x0000000e,0x0000000f,0x00000001,0x00040020,
            0x00000011,0x00000003,0x00000007,0x0004002b,0x0000000c,0x00000013,0x00000001,0x00040020,
            0x00000014,0x00000001,0x00000008,0x0004003b,0x00000014,0x00000015,0x00000001,0x00040020,
            0x00000017,0x00000003,0x00000008,0x0003001e,0x00000019,0x00000007,0x00040020,0x0000001a,
            0x00000003,0x00000019,0x0004003b,0x0000001a,0x0000001b,0x00000003,0x0004003b,0x00000014,
            0x0000001c,0x00000001,0x0004001e,0x0000001e,0x00000008,0x00000008,0x00040020,0x0000001f,
            0x00000009,0x0000001e,0x0004003b,0x0000001f,0x00000020,0x00000009,0x00040020,0x00000021,
            0x00000009,0x00000008,0x0004002b,0x00000006,0x00000028,0x00000000,0x0004002b,0x00000006,
            0x00000029,0x3f800000,0x00050036,0x00000002,0x00000004,0x00000000,0x00000003,0x000200f8,
            0x00000005,0x0004003d,0x00000007,0x00000010,0x0000000f,0x00050041,0x00000011,0x00000012,
            0x0000000b,0x0000000d,0x0003003e,0x00000012,0x00000010,0x0004003d,0x00000008,0x00000016,
            0x00000015,0x00050041,0x00000017,0x00000018,0x0000000b,0x00000013,0x0003003e,0x00000018,
            0x00000016,0x0004003d,0x00000008,0x0000001d,0x0000001c,0x00050041,0x00000021,0x00000022,
            0x00000020,0x0000000d,0x0004003d,0x00000008,0x00000023,0x00000022,0x00050085,0x00000008,
            0x00000024,0x0000001d,0x00000023,0x00050041,0x00000021,0x00000025,0x00000020,0x00000013,
            0x0004003d,0x00000008,0x00000026,0x00000025,0x00050081,0x00000008,0x00000027,0x00000024,
            0x00000026,0x00050051,0x00000006,0x0000002a,0x00000027,0x00000000,0x00050051,0x00000006,
            0x0000002b,0x00000027,0x00000001,0x00070050,0x00000007,0x0000002c,0x0000002a,0x0000002b,
            0x00000028,0x00000029,0x00050041,0x00000011,0x0000002d,0x0000001b,0x0000000d,0x0003003e,
            0x0000002d,0x0000002c,0x000100fd,0x00010038
        ];

        /*
        #version 450 core
        layout(location = 0) out vec4 fColor;
        layout(set=0, binding=0) uniform sampler2D sTexture;
        layout(location = 0) in struct { vec4 Color; vec2 UV; } In;
        void main()
        {
            fColor = In.Color * texture(sTexture, In.UV.st);
        }
        */

        // csharpier-ignore
        public static readonly uint[] Frag =
        [
            0x07230203,0x00010000,0x00080001,0x0000001e,0x00000000,0x00020011,0x00000001,0x0006000b,
            0x00000001,0x4c534c47,0x6474732e,0x3035342e,0x00000000,0x0003000e,0x00000000,0x00000001,
            0x0007000f,0x00000004,0x00000004,0x6e69616d,0x00000000,0x00000009,0x0000000d,0x00030010,
            0x00000004,0x00000007,0x00030003,0x00000002,0x000001c2,0x00040005,0x00000004,0x6e69616d,
            0x00000000,0x00040005,0x00000009,0x6c6f4366,0x0000726f,0x00030005,0x0000000b,0x00000000,
            0x00050006,0x0000000b,0x00000000,0x6f6c6f43,0x00000072,0x00040006,0x0000000b,0x00000001,
            0x00005655,0x00030005,0x0000000d,0x00006e49,0x00050005,0x00000016,0x78655473,0x65727574,
            0x00000000,0x00040047,0x00000009,0x0000001e,0x00000000,0x00040047,0x0000000d,0x0000001e,
            0x00000000,0x00040047,0x00000016,0x00000022,0x00000000,0x00040047,0x00000016,0x00000021,
            0x00000000,0x00020013,0x00000002,0x00030021,0x00000003,0x00000002,0x00030016,0x00000006,
            0x00000020,0x00040017,0x00000007,0x00000006,0x00000004,0x00040020,0x00000008,0x00000003,
            0x00000007,0x0004003b,0x00000008,0x00000009,0x00000003,0x00040017,0x0000000a,0x00000006,
            0x00000002,0x0004001e,0x0000000b,0x00000007,0x0000000a,0x00040020,0x0000000c,0x00000001,
            0x0000000b,0x0004003b,0x0000000c,0x0000000d,0x00000001,0x00040015,0x0000000e,0x00000020,
            0x00000001,0x0004002b,0x0000000e,0x0000000f,0x00000000,0x00040020,0x00000010,0x00000001,
            0x00000007,0x00090019,0x00000013,0x00000006,0x00000001,0x00000000,0x00000000,0x00000000,
            0x00000001,0x00000000,0x0003001b,0x00000014,0x00000013,0x00040020,0x00000015,0x00000000,
            0x00000014,0x0004003b,0x00000015,0x00000016,0x00000000,0x0004002b,0x0000000e,0x00000018,
            0x00000001,0x00040020,0x00000019,0x00000001,0x0000000a,0x00050036,0x00000002,0x00000004,
            0x00000000,0x00000003,0x000200f8,0x00000005,0x00050041,0x00000010,0x00000011,0x0000000d,
            0x0000000f,0x0004003d,0x00000007,0x00000012,0x00000011,0x0004003d,0x00000014,0x00000017,
            0x00000016,0x00050041,0x00000019,0x0000001a,0x0000000d,0x00000018,0x0004003d,0x0000000a,
            0x0000001b,0x0000001a,0x00050057,0x00000007,0x0000001c,0x00000017,0x0000001b,0x00050085,
            0x00000007,0x0000001d,0x00000012,0x0000001c,0x0003003e,0x00000009,0x0000001d,0x000100fd,
            0x00010038
        ];
    }
}
