namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Provides extension methods for recording Vulkan command buffer commands.
/// </summary>
public static class CommandBufferExtensions
{
    /// <summary>
    /// Resets the command buffer to its initial state using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html">vkResetCommandBuffer</see>.
    /// The command buffer must not be in a pending state and will be reset to the initial state.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to reset.</param>
    public static void Reset(this CommandBuffer inCommandBuffer)
    {
        inCommandBuffer.Reset(VkCommandBufferResetFlags.None);
    }

    /// <summary>
    /// Begins recording commands on the command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html">vkBeginCommandBuffer</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to begin recording.</param>
    public static void Begin(this CommandBuffer inCommandBuffer)
    {
        inCommandBuffer.Begin(new VkCommandBufferBeginInfo { Flags = VkCommandBufferUsageFlags.None });
    }

    /// <summary>
    /// Begins a Vulkan debug label region on the command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginDebugUtilsLabelEXT.html">vkCmdBeginDebugUtilsLabelEXT</see>.
    /// This allows grouping commands within a labeled region for better debugging and profiling.
    /// </summary>
    /// <param name="inCommandBuffer">The Vulkan command buffer on which to begin the debug label.</param>
    /// <param name="label">A read-only span of bytes representing the label name. The label should be null-terminated.</param>
    /// <param name="color">A <see cref="float4"/> structure representing the RGBA color of the label.</param>
    public static unsafe void BeginDebugLabel(
        this CommandBuffer inCommandBuffer,
        in ReadOnlySpan<byte> label,
        in float4 color
    )
    {
        var vkLabel = new VkDebugUtilsLabelEXT { LabelName = label.AsPointer() };
        vkLabel.Color[0] = color.R;
        vkLabel.Color[1] = color.G;
        vkLabel.Color[2] = color.B;
        vkLabel.Color[3] = color.A;
        inCommandBuffer.BeginDebugUtilsLabelEXT(vkLabel);
    }

    /// <summary>
    /// Ends the current Vulkan debug label region on the command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndDebugUtilsLabelEXT.html">vkCmdEndDebugUtilsLabelEXT</see>.
    /// This marks the end of a previously started debug label region, allowing Vulkan debugging tools to identify command groups.
    /// </summary>
    /// <param name="inCommandBuffer">The Vulkan command buffer on which to end the debug label.</param>
    public static void EndDebugLabel(this CommandBuffer inCommandBuffer)
    {
        inCommandBuffer.EndDebugUtilsLabelEXT();
    }

    /// <summary>
    /// Begins recording commands on the command buffer with specified usage flags using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html">vkBeginCommandBuffer</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to begin recording.</param>
    /// <param name="usage">The usage flags determining how the command buffer will be used.</param>
    public static void Begin(this CommandBuffer inCommandBuffer, VkCommandBufferUsageFlags usage)
    {
        inCommandBuffer.Begin(new VkCommandBufferBeginInfo { Flags = usage });
    }

    /// <summary>
    /// Begins recording commands on the command buffer with specified usage flags and inheritance information
    /// for secondary command buffers, using <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html">vkBeginCommandBuffer</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to begin recording.</param>
    /// <param name="usage">The usage flags for the command buffer.</param>
    /// <param name="inheritanceInfo">
    /// For secondary command buffers, a pointer to a <c>VkCommandBufferInheritanceInfo</c> structure providing additional state;
    /// ignored for primary command buffers.
    /// </param>
    public static void Begin(
        this CommandBuffer inCommandBuffer,
        VkCommandBufferUsageFlags usage,
        VkCommandBufferInheritanceInfo inheritanceInfo
    )
    {
        unsafe
        {
            inCommandBuffer.Begin(new VkCommandBufferBeginInfo { Flags = usage, InheritanceInfo = &inheritanceInfo });
        }
    }

    /// <summary>
    /// Records a command to copy data between buffers using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer.html">vkCmdCopyBuffer</see>.
    /// Copies the specified region from the source buffer to the destination buffer.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer that will record the copy command.</param>
    /// <param name="inSrcBuffer">The source buffer.</param>
    /// <param name="inDstBuffer">The destination buffer.</param>
    /// <param name="inRegion">A <c>VkBufferCopy</c> structure defining the region to copy.</param>
    public static void CopyBuffer(
        this CommandBuffer inCommandBuffer,
        VkBuffer inSrcBuffer,
        VkBuffer inDstBuffer,
        VkBufferCopy inRegion
    )
    {
        inCommandBuffer.CopyBuffer(inSrcBuffer, inDstBuffer, [inRegion]);
    }

    /// <summary>
    /// Records a command to copy a specified number of bytes from the source buffer to the destination buffer.
    /// This is a convenience overload that assumes zero offsets.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer that will record the copy command.</param>
    /// <param name="inSrcBuffer">The source buffer.</param>
    /// <param name="inDstBuffer">The destination buffer.</param>
    /// <param name="inSize">The number of bytes to copy from the start of the buffers.</param>
    public static void CopyBuffer(
        this CommandBuffer inCommandBuffer,
        VkBuffer inSrcBuffer,
        VkBuffer inDstBuffer,
        ByteSize inSize
    )
    {
        CopyBuffer(
            inCommandBuffer,
            inSrcBuffer,
            inDstBuffer,
            new VkBufferCopy
            {
                Size = inSize,
                DstOffset = ByteSize.Zero,
                SrcOffset = ByteSize.Zero,
            }
        );
    }

    /// <summary>
    /// Binds a vertex buffer to the command buffer at the specified binding index using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to record the binding command.</param>
    /// <param name="inBinding">The vertex input binding index to update.</param>
    /// <param name="inBuffer">The vertex buffer to bind.</param>
    /// <param name="inOffset">The offset (in bytes) within the buffer to start binding from. Defaults to 0.</param>
    public static void BindVertexBuffer(
        this CommandBuffer inCommandBuffer,
        int inBinding,
        VkBuffer inBuffer,
        ByteSize inOffset = default
    )
    {
        inCommandBuffer.BindVertexBuffers(inBinding, [inBuffer], [inOffset]);
    }

    /// <summary>
    /// Records a command to update a push constant value of type <typeparamref name="T"/> in the command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html">vkCmdPushConstants</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to record the push constant update.</param>
    /// <param name="inLayout">The pipeline layout that defines the push constant ranges.</param>
    /// <param name="inStageFlags">A bitmask of <c>VkShaderStageFlags</c> indicating which shader stages will access the push constant.</param>
    /// <param name="inOffset">The byte offset within the push constant range at which to start updating.</param>
    /// <param name="inData">The push constant value to update.</param>
    public static void PushConstants<T>(
        this CommandBuffer inCommandBuffer,
        VkPipelineLayout inLayout,
        VkShaderStageFlags inStageFlags,
        ByteSize inOffset,
        T inData
    )
        where T : unmanaged
    {
        inCommandBuffer.PushConstants(inLayout, inStageFlags, inOffset, [inData]);
    }

    /// <summary>
    /// Records a command to update a sequence of push constants of type <typeparamref name="T"/> in the command buffer using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html">vkCmdPushConstants</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to record the push constant update.</param>
    /// <param name="inLayout">The pipeline layout that defines the push constant ranges.</param>
    /// <param name="inStageFlags">A bitmask of <c>VkShaderStageFlags</c> indicating which shader stages will access the push constants.</param>
    /// <param name="inOffset">The byte offset within the push constant range at which to start updating.</param>
    /// <param name="inData">A span containing the push constant values to update.</param>
    public static void PushConstants<T>(
        this CommandBuffer inCommandBuffer,
        VkPipelineLayout inLayout,
        VkShaderStageFlags inStageFlags,
        ByteSize inOffset,
        ReadOnlySpan<T> inData
    )
        where T : unmanaged
    {
        unsafe
        {
            fixed (T* ptr = inData)
            {
                inCommandBuffer.PInvoke.vkCmdPushConstants.Invoke(
                    inCommandBuffer.Handle,
                    inLayout,
                    inStageFlags,
                    (int)inOffset,
                    (int)ByteSize.Of<T>(inData.Length),
                    ptr
                );
            }
        }
    }
}
