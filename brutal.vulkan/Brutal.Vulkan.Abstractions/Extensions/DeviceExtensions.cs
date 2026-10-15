namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Functions to extend the Device class
/// </summary>
public static class DeviceExtensions
{
    /// <summary>
    /// Creates a default render pass configured for common rendering scenarios. This method sets up attachments for color,
    /// depth, and, if multisampling is enabled, resolve operations, and configures the corresponding subpass dependencies.
    /// </summary>
    /// <param name="inDevice">The logical device used for creating the render pass.</param>
    /// <param name="sampleColor">If true, a color attachment is created and sampled; otherwise, no color attachment is configured.</param>
    /// <param name="sampleDepth">If true, a depth attachment is created and sampled; otherwise, no depth attachment is configured.</param>
    /// <param name="sampleCount">Specifies the number of samples per pixel. A value other than <c>VkSampleCountFlags._1</c> indicates that multisampling is enabled.</param>
    /// <param name="colorFormat">The format to be used for the color attachment image.</param>
    /// <param name="depthFormat">The format to be used for the depth attachment image.</param>
    /// <param name="resolvedFormat">The format to be used for the resolve attachment image when multisampling is enabled.</param>
    /// <returns>A <c>VkRenderPass</c> object representing the configured render pass.</returns>
    public static unsafe VkRenderPass CreateDefaultRenderPass(
        this Device inDevice,
        bool sampleColor,
        bool sampleDepth,
        VkSampleCountFlags sampleCount,
        VkFormat colorFormat,
        VkFormat depthFormat,
        VkFormat resolvedFormat,
        VkAllocator? allocator
    )
    {
        var multisamplingEnabled = sampleCount != VkSampleCountFlags._1Bit;

        VkAttachmentDescription? colorAttachment = null;
        VkAttachmentDescription? depthAttachment = null;
        VkAttachmentDescription? resolveAttachment = null;

        // Describe the color attachment
        if (sampleColor)
        {
            var storeOp = VkAttachmentStoreOp.DontCare;
            var finalLayout = VkImageLayout.ShaderReadOnlyOptimal;
            if (multisamplingEnabled)
            {
                storeOp = VkAttachmentStoreOp.DontCare;
                finalLayout = VkImageLayout.ColorAttachmentOptimal;
            }

            colorAttachment = new VkAttachmentDescription
            {
                Format = colorFormat,
                Samples = sampleCount,
                LoadOp = VkAttachmentLoadOp.Clear,
                StoreOp = storeOp,
                StencilLoadOp = VkAttachmentLoadOp.DontCare,
                StencilStoreOp = VkAttachmentStoreOp.DontCare,
                InitialLayout = VkImageLayout.Undefined,
                FinalLayout = finalLayout,
            };
        }

        // Describe the depth attachment
        if (sampleDepth)
        {
            depthAttachment = new VkAttachmentDescription
            {
                Format = depthFormat,
                Samples = sampleCount,
                LoadOp = VkAttachmentLoadOp.Clear,
                StoreOp = VkAttachmentStoreOp.Store,
                StencilLoadOp = VkAttachmentLoadOp.DontCare,
                StencilStoreOp = VkAttachmentStoreOp.DontCare,
                InitialLayout = VkImageLayout.Undefined,
                FinalLayout = VkImageLayout.DepthStencilReadOnlyOptimal,
            };
        }

        // Describe the Multisample-to-singlesample color resolve attachments
        if (multisamplingEnabled)
        {
            // Resolve color attachment
            if (sampleColor)
            {
                resolveAttachment = new VkAttachmentDescription
                {
                    Format = resolvedFormat,
                    Samples = VkSampleCountFlags._1Bit,
                    LoadOp = VkAttachmentLoadOp.DontCare,
                    StoreOp = VkAttachmentStoreOp.Store,
                    StencilLoadOp = VkAttachmentLoadOp.DontCare,
                    StencilStoreOp = VkAttachmentStoreOp.DontCare,
                    InitialLayout = VkImageLayout.Undefined,
                    FinalLayout = VkImageLayout.ShaderReadOnlyOptimal,
                };
            }

            // Resolve depth attachment
            if (sampleDepth)
            {
                // (Not yet implemented)
            }
        }

        // Describe the attachment references
        var references =
            stackalloc VkAttachmentReference[3] {
                new VkAttachmentReference { Attachment = 0, Layout = VkImageLayout.ColorAttachmentOptimal },
                new VkAttachmentReference { Attachment = 1, Layout = VkImageLayout.DepthStencilAttachmentOptimal },
                new VkAttachmentReference { Attachment = 2, Layout = VkImageLayout.ColorAttachmentOptimal },
            };

        // Create a subpass
        var subpass = new VkSubpassDescription { PipelineBindPoint = VkPipelineBindPoint.Graphics };
        if (sampleColor)
        {
            subpass.ColorAttachmentCount = 1;
            subpass.ColorAttachments = &references[0];
        }
        if (sampleDepth)
        {
            subpass.DepthStencilAttachment = &references[1];
        }
        if (multisamplingEnabled)
        {
            subpass.ResolveAttachments = &references[2];
        }

        // Create subpass dependencies determined by whether multisampling is enabled or not
        VkSubpassDependency renderSubpass;
        VkSubpassDependency? resolveSubpass = null;
        if (multisamplingEnabled)
        {
            renderSubpass = new VkSubpassDependency
            {
                SrcSubpass = VK.SUBPASS_EXTERNAL,
                DstSubpass = 0,
                SrcStageMask = VkPipelineStageFlags.ColorAttachmentOutputBit,
                DstStageMask = VkPipelineStageFlags.ColorAttachmentOutputBit,
                SrcAccessMask = VkAccessFlags.None,
                DstAccessMask = VkAccessFlags.ColorAttachmentWriteBit | VkAccessFlags.ColorAttachmentReadBit,
                DependencyFlags = VkDependencyFlags.None,
            };
            resolveSubpass = new VkSubpassDependency
            {
                SrcSubpass = VK.SUBPASS_EXTERNAL,
                DstSubpass = 0,
                SrcStageMask = VkPipelineStageFlags.EarlyFragmentTestsBit | VkPipelineStageFlags.LateFragmentTestsBit,
                DstStageMask = VkPipelineStageFlags.EarlyFragmentTestsBit | VkPipelineStageFlags.LateFragmentTestsBit,
                SrcAccessMask = VkAccessFlags.DepthStencilAttachmentWriteBit,
                DstAccessMask =
                    VkAccessFlags.DepthStencilAttachmentWriteBit | VkAccessFlags.DepthStencilAttachmentReadBit,
                DependencyFlags = VkDependencyFlags.None,
            };
        }
        else
        {
            renderSubpass = new VkSubpassDependency
            {
                SrcSubpass = VK.SUBPASS_EXTERNAL,
                DstSubpass = 0,
                SrcStageMask =
                    VkPipelineStageFlags.ColorAttachmentOutputBit | VkPipelineStageFlags.LateFragmentTestsBit,
                DstStageMask =
                    VkPipelineStageFlags.ColorAttachmentOutputBit | VkPipelineStageFlags.EarlyFragmentTestsBit,
                SrcAccessMask = VkAccessFlags.DepthStencilAttachmentWriteBit,
                DstAccessMask = VkAccessFlags.ColorAttachmentWriteBit | VkAccessFlags.DepthStencilAttachmentWriteBit,
                DependencyFlags = VkDependencyFlags.None,
            };
        }

        // Build arrays of structures we'll be passing to the render pass creation
        var attachments = stackalloc VkAttachmentDescription[3];
        var dependencies = stackalloc VkSubpassDependency[2];

        Span<VkSubpassDescription> subpasses = [subpass];

        var attachmentCount = 0;
        var dependencyCount = 0;

        attachments[attachmentCount++] = colorAttachment!.Value;
        attachments[attachmentCount++] = depthAttachment!.Value;

        if (multisamplingEnabled)
        {
            attachments[attachmentCount++] = resolveAttachment!.Value;
            dependencies[dependencyCount++] = renderSubpass;
            dependencies[dependencyCount++] = resolveSubpass!.Value;
        }
        else
        {
            dependencies[dependencyCount++] = renderSubpass;
        }

        return inDevice.CreateRenderPass(
            new VkRenderPassCreateInfo
            {
                Flags = 0,
                AttachmentCount = attachmentCount,
                Attachments = attachments,
                SubpassCount = subpasses.Length,
                Subpasses = subpasses.AsPointer(),
                DependencyCount = dependencyCount,
                Dependencies = dependencies,
            },
            allocator
        );
    }

    /// <summary>
    /// Creates a new pipeline layout object using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineLayout.html">vkCreatePipelineLayout</see>.
    /// </summary>
    /// <param name="inDevice">The logical device used to create the pipeline layout.</param>
    /// <param name="setLayouts">
    /// A span of <see cref="VkDescriptorSetLayout"/> handles that define the descriptor set layouts to be used in the pipeline layout.
    /// </param>
    /// <param name="pushConstantRanges">
    /// A span of <see cref="VkPushConstantRange"/> structures specifying the push constant ranges for the pipeline layout.
    /// </param>
    /// <returns>A <c>VkPipelineLayout</c> object representing the created pipeline layout.</returns>
    public static VkPipelineLayout CreatePipelineLayout(
        this Device inDevice,
        ReadOnlySpan<VkDescriptorSetLayout> setLayouts,
        ReadOnlySpan<VkPushConstantRange> pushConstantRanges,
        VkAllocator? allocator
    )
    {
        unsafe
        {
            fixed (VkDescriptorSetLayout* p1 = setLayouts)
            fixed (VkPushConstantRange* p2 = pushConstantRanges)
                return inDevice.CreatePipelineLayout(
                    new VkPipelineLayoutCreateInfo
                    {
                        SetLayouts = p1,
                        PushConstantRanges = p2,
                        SetLayoutCount = setLayouts.Length,
                        PushConstantRangeCount = pushConstantRanges.Length,
                    },
                    allocator
                );
        }
    }

    /// <summary>
    /// Creates a graphics pipeline using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateGraphicsPipelines.html">vkCreateGraphicsPipelines</see>.
    /// </summary>
    /// <param name="inDevice">The logical device used for creating the graphics pipeline.</param>
    /// <param name="inPipelineCache">
    /// A pipeline cache handle. Use <c>VK_NULL_HANDLE</c> if pipeline caching is disabled; otherwise, provide the handle of a valid
    /// pipeline cache object to enable caching during pipeline creation.
    /// </param>
    /// <param name="inCreateInfo">
    /// A <see cref="VkGraphicsPipelineCreateInfo"/> structure containing the parameters required to create the graphics pipeline.
    /// </param>
    /// <returns>A <c>VkPipeline</c> object representing the created graphics pipeline.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe VkPipeline CreateGraphicsPipeline(
        this Device inDevice,
        VkPipelineCache inPipelineCache,
        VkGraphicsPipelineCreateInfo inCreateInfo,
        VkAllocator? allocator
    )
    {
        VkPipeline pipeline = new();
        inDevice.CreateGraphicsPipelines(
            inPipelineCache,
            [inCreateInfo],
            null,
            new ReadOnlySpan<VkPipeline>(&pipeline, 1)
        );

        return pipeline;
    }

    /// <summary>
    /// Allocates a single command buffer from the specified command pool using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html">vkAllocateCommandBuffers</see>.
    /// </summary>
    /// <param name="device">The logical device that owns the command pool.</param>
    /// <param name="createInfo">A <see cref="VkCommandBufferAllocateInfo"/> structure specifying the command pool and allocation parameters.</param>
    /// <returns>A <c>CommandBuffer</c> object representing the allocated command buffer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe CommandBuffer AllocateCommandBuffer(this Device device, VkCommandBufferAllocateInfo createInfo)
    {
        Span<VkCommandBuffer> commandBufferHandles = stackalloc VkCommandBuffer[1];
        createInfo.CommandBufferCount = 1;
        device.AllocateCommandBuffersInternal(createInfo, commandBufferHandles);
        return new CommandBuffer(device, commandBufferHandles[0]);
    }

    /// <summary>
    /// Allocates multiple command buffers from the specified command pool using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html">vkAllocateCommandBuffers</see>.
    /// </summary>
    /// <param name="device">The logical device that owns the command pool.</param>
    /// <param name="createInfo">A <see cref="VkCommandBufferAllocateInfo"/> structure specifying the command pool and allocation parameters.</param>
    /// <param name="commandBuffers">A span of <see cref="CommandBuffer"/> to store the allocated command buffers.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void AllocateCommandBuffers(
        this Device device,
        VkCommandBufferAllocateInfo createInfo,
        Span<CommandBuffer> commandBuffers
    )
    {
        if (commandBuffers.Length == 0)
            throw new ArgumentException("The command buffer span must not be empty.", nameof(commandBuffers));

        Span<VkCommandBuffer> commandBufferHandles = stackalloc VkCommandBuffer[commandBuffers.Length];
        createInfo.CommandBufferCount = commandBuffers.Length;
        device.AllocateCommandBuffersInternal(createInfo, commandBufferHandles);
        for (var i = 0; i < commandBuffers.Length; i++)
            commandBuffers[i] = new CommandBuffer(device, commandBufferHandles[i]);
    }

    /// <summary>
    /// Allocates device memory for a buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html">vkAllocateMemory</see>.
    /// It queries the memory requirements of the specified buffer and selects an appropriate memory type that matches the required properties.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the memory.</param>
    /// <param name="inPhysicalDevice">The physical device used to determine a compatible memory type.</param>
    /// <param name="inBuffer">The buffer for which memory is to be allocated.</param>
    /// <param name="inRequiredProperties">The required memory property flags that the allocated memory must satisfy.</param>
    /// <returns>A <c>VkDeviceMemory</c> object representing the allocated memory for the buffer.</returns>
    public static VkDeviceMemory AllocateMemory(
        this Device inDevice,
        PhysicalDevice inPhysicalDevice,
        VkBuffer inBuffer,
        VkMemoryPropertyFlags inRequiredProperties,
        VkAllocator? allocator
    )
    {
        // Check the memory requirements for the vertex buffer
        var bufferMemoryRequirements = inDevice.GetBufferMemoryRequirements(inBuffer);
        var bufferMemoryTypeIndex = inPhysicalDevice.FindMemoryType(
            bufferMemoryRequirements.MemoryTypeBits,
            inRequiredProperties
        );

        // Allocate memory for the vertex buffer
        var memory = inDevice.AllocateMemory(
            new VkMemoryAllocateInfo
            {
                AllocationSize = bufferMemoryRequirements.Size,
                MemoryTypeIndex = bufferMemoryTypeIndex,
            },
            allocator
        );

        return memory;
    }

    /// <summary>
    /// Allocates device memory for an image using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html">vkAllocateMemory</see>.
    /// It queries the memory requirements of the specified image and selects an appropriate memory type that meets the required properties.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the memory.</param>
    /// <param name="inPhysicalDevice">The physical device used to determine a compatible memory type.</param>
    /// <param name="inImage">The image for which memory is to be allocated.</param>
    /// <param name="inRequiredProperties">The required memory property flags that the allocated memory must satisfy.</param>
    /// <returns>A <c>VkDeviceMemory</c> object representing the allocated memory for the image.</returns>
    public static VkDeviceMemory AllocateMemory(
        this Device inDevice,
        PhysicalDevice inPhysicalDevice,
        VkImage inImage,
        VkMemoryPropertyFlags inRequiredProperties,
        VkAllocator? allocator
    )
    {
        // Check the memory requirements for the vertex buffer
        var bufferMemoryRequirements = inDevice.GetImageMemoryRequirements(inImage);
        var bufferMemoryTypeIndex = inPhysicalDevice.FindMemoryType(
            bufferMemoryRequirements.MemoryTypeBits,
            inRequiredProperties
        );

        // Allocate memory for the vertex buffer
        var memory = inDevice.AllocateMemory(
            new VkMemoryAllocateInfo
            {
                AllocationSize = bufferMemoryRequirements.Size,
                MemoryTypeIndex = bufferMemoryTypeIndex,
            },
            allocator
        );

        return memory;
    }

    /// <summary>
    /// Maps device memory to a pointer of type T using vkMapMemory.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the memory.</param>
    /// <param name="mapInfo">A <see cref="MapInfo"/> structure specifying the memory range to map.</param>
    /// <returns>A pointer to the mapped memory cast to type T.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ptr<T> MapMemory<T>(this Device inDevice, in MapInfo mapInfo)
        where T : unmanaged
    {
        return inDevice.MapMemory(mapInfo).Cast<T>();
    }

    /// <summary>
    /// Maps device memory to a pointer of type T using vkMapMemory.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the memory.</param>
    /// <param name="mapInfo">A <see cref="MapInfo"/> structure specifying the memory range to map.</param>
    /// <returns>A pointer to the mapped memory cast to type T.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Ptr MapMemory(this Device inDevice, in MapInfo mapInfo)
    {
        if (mapInfo.Region.Size < 1 && mapInfo.Region.Size != VK.WHOLE_SIZE)
            throw new ArgumentOutOfRangeException(
                nameof(mapInfo.Region.Size),
                "The size of the memory region must be greater than zero, or VK.WHOLE_SIZE."
            );

        var ptr = inDevice.MapMemory(mapInfo.Memory, mapInfo.Region.Offset, mapInfo.Region.Size, mapInfo.Flags);

        return ptr;
    }

    /// <summary>
    /// Writes data from a span to device memory. This method maps the specified memory, copies the data from the source span,
    /// and then unmaps the memory.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source span.</typeparam>
    /// <param name="inDevice">The logical device that owns the destination memory.</param>
    /// <param name="inSrc">The source span containing the data to write.</param>
    /// <param name="inDstMemory">The <c>VkDeviceMemory</c> object that will receive the data.</param>
    /// <param name="inOffset">The zero-based byte offset from the beginning of the memory object at which to start writing.</param>
    /// <param name="inFlags">Reserved for future use; typically set to <c>VkMemoryMapFlags.None</c>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void WriteMemory<T>(
        this Device inDevice,
        Span<T> inSrc,
        VkDeviceMemory inDstMemory,
        ByteSize inOffset = default,
        VkMemoryMapFlags inFlags = VkMemoryMapFlags.None
    )
        where T : unmanaged
    {
        Ptr ptr = inDevice.MapMemory(inDstMemory, inOffset, ByteSize.Of(inSrc), inFlags);
        Mem.Copy(inSrc, ptr.AsSpan<T>(inSrc.Length));
        inDevice.UnmapMemory(inDstMemory);
    }

    /// <summary>
    /// Writes data from an array to device memory. This method maps the specified memory, copies the data from the source array,
    /// and then unmaps the memory.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source array.</typeparam>
    /// <param name="inDevice">The logical device that owns the destination memory.</param>
    /// <param name="inSrc">The source array containing the data to write.</param>
    /// <param name="inDstMemory">The <c>VkDeviceMemory</c> object that will receive the data.</param>
    /// <param name="inOffset">The zero-based byte offset from the beginning of the memory object at which to start writing.</param>
    /// <param name="inFlags">Reserved for future use; typically set to <c>VkMemoryMapFlags.None</c>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void WriteMemory<T>(
        this Device inDevice,
        ReadOnlySpan<T> inSrc,
        VkDeviceMemory inDstMemory,
        ByteSize inOffset = default,
        VkMemoryMapFlags inFlags = VkMemoryMapFlags.None
    )
        where T : unmanaged
    {
        Ptr ptr = inDevice.MapMemory(inDstMemory, inOffset, ByteSize.Of(inSrc), inFlags);
        Mem.Copy(inSrc, ptr.AsSpan<T>(inSrc.Length));
        inDevice.UnmapMemory(inDstMemory);
    }

    /// <summary>
    /// Binds a descriptor set to a command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets.html">vkCmdBindDescriptorSets</see>.
    /// An optional dynamic offset can be provided.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to which the descriptor set will be bound.</param>
    /// <param name="inPipelineBindPoint">
    /// The pipeline bind point indicating the type of pipeline that will use the descriptor set. Binding at a specific bind point
    /// does not disturb descriptor sets bound at other bind points.
    /// </param>
    /// <param name="inLayout">The pipeline layout that defines the descriptor set bindings.</param>
    /// <param name="inSet">The index of the descriptor set to bind.</param>
    /// <param name="inDescriptorSet">The descriptor set to be bound to the command buffer.</param>
    /// <param name="inDynamicOffsets">
    /// Span of dynamic offsets to be used with the descriptor set. If no dynamic offsets are needed, pass an empty span.
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void BindDescriptorSet(
        this CommandBuffer inCommandBuffer,
        VkPipelineBindPoint inPipelineBindPoint,
        VkPipelineLayout inLayout,
        int inSet,
        VkDescriptorSet inDescriptorSet,
        Span<ByteSize32> inDynamicOffsets
    )
    {
        inCommandBuffer.BindDescriptorSets(inPipelineBindPoint, inLayout, inSet, [inDescriptorSet], inDynamicOffsets);
    }

    /// <summary>
    /// Creates a new fence object using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateFence.html">vkCreateFence</see>.
    /// </summary>
    /// <param name="inDevice">The logical device that creates the fence.</param>
    /// <param name="inCreateFlags">
    /// Flags that control the creation and initial state of the fence. See <see cref="VkFenceCreateFlags"/> for details.
    /// </param>
    /// <returns>A <c>VkFence</c> object representing the created fence.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkFence CreateFence(this Device inDevice, VkFenceCreateFlags inCreateFlags, VkAllocator? allocator)
    {
        return inDevice.CreateFence(new VkFenceCreateInfo { Flags = inCreateFlags }, allocator);
    }

    /// <summary>
    /// Waits for a fence to become signaled using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForFences.html">vkWaitForFences</see>.
    /// The timeout value is adjusted to the closest allowed value by the implementation.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the fence.</param>
    /// <param name="inFence">The fence to wait on.</param>
    /// <param name="inTimeout">
    /// The timeout period in nanoseconds. The actual timeout may be longer than requested due to implementation-dependent timeout accuracy.
    /// </param>
    /// <returns>A <c>VkResult</c> indicating the outcome of the wait operation.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkResult WaitForFence(this Device inDevice, VkFence inFence, nint inTimeout)
    {
        return inDevice.WaitForFences([inFence], true, inTimeout);
    }

    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeCommandBuffers.html">vkFreeCommandBuffers</see> - Free command buffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To free command buffers, call:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         void vkFreeCommandBuffers(
    ///         VkDevice                                    device,
    ///         VkCommandPool                               commandPool,
    ///         uint32_t                                    commandBufferCount,
    ///         const VkCommandBuffer*                      pCommandBuffers);
    ///     </code>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void FreeCommandBuffers(
        this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
        VkCommandPool commandPool,
        ReadOnlySpan<CommandBuffer> pCommandBuffers
    )
    {
        Span<VkCommandBuffer> vkCommandBuffers = stackalloc VkCommandBuffer[pCommandBuffers.Length];
        for (var index = 0; index < pCommandBuffers.Length; index++)
            vkCommandBuffers[index] = pCommandBuffers[index].Handle;
        handle.FreeCommandBuffersInternal(commandPool, vkCommandBuffers);
    }

    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html">vkCmdExecuteCommands</see> - Execute a secondary command buffer from a primary command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Secondary command buffers <i>must</i> not be directly submitted to a queue.
    ///         To record a secondary command buffer to execute as part of a primary command
    ///         buffer, call:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         void vkCmdExecuteCommands(
    ///         VkCommandBuffer                             commandBuffer,
    ///         uint32_t                                    commandBufferCount,
    ///         const VkCommandBuffer*                      pCommandBuffers);
    ///     </code>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ExecuteCommands(
        this VulkanHandleWrapper<VkCommandBuffer, VkDevice.FunctionTable> handle,
        ReadOnlySpan<CommandBuffer> pCommandBuffers
    )
    {
        Span<VkCommandBuffer> vkCommandBuffers = stackalloc VkCommandBuffer[pCommandBuffers.Length];
        for (var index = 0; index < pCommandBuffers.Length; index++)
            vkCommandBuffers[index] = pCommandBuffers[index].Handle;
        handle.CmdExecuteCommandsInternal(vkCommandBuffers);
    }
}
