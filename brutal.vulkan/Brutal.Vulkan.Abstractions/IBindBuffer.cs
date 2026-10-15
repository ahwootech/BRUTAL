namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// An interface describing a buffer that can be bound to a command buffer.
/// </summary>
public interface IBindBuffer
{
    /// <summary>
    /// The Vulkan buffer handle.
    /// </summary>
    public VkBuffer VkBuffer { get; }

    /// <summary>
    /// The offset within the parent buffer where this buffer starts for binding.
    /// </summary>
    public ByteSize BindOffset { get; }
}

public static class BindBufferExtensions
{
    /// <summary>
    /// Binds a vertex buffer to the command buffer at the specified binding index using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</see>.
    /// </summary>
    /// <param name="inCommandBuffer">The command buffer to record the binding command.</param>
    /// <param name="inBinding">The vertex input binding index to update.</param>
    /// <param name="inBuffer">The vertex buffer to bind.</param>
    /// <param name="inAdditionalOffset">Optional additional offset to add to the buffer's bind offset.</param>
    public static void BindVertexBuffer<T>(
        this CommandBuffer inCommandBuffer,
        int inBinding,
        T inBuffer,
        ByteSize inAdditionalOffset = default
    )
        where T : IBindBuffer
    {
        inCommandBuffer.BindVertexBuffer(inBinding, inBuffer.VkBuffer, inBuffer.BindOffset + inAdditionalOffset);
    }

    ///<summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</see> - Bind vertex buffers to a command buffer</summary>
    ///<param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    ///<param name="inFirstBinding">is the index of the first vertex input binding whose state is updated by the command.</param>
    ///<param name="inBuffers">is a pointer to an array of buffer handles.</param>
    public static unsafe void BindVertexBuffers<T>(
        this CommandBuffer inCommandBuffer,
        int inFirstBinding,
        Span<T> inBuffers
    )
        where T : IBindBuffer
    {
        Span<VkBuffer> buffers = stackalloc VkBuffer[inBuffers.Length];
        Span<ByteSize64> offsets = stackalloc ByteSize64[inBuffers.Length];

        for (var i = 0; i < inBuffers.Length; i++)
        {
            buffers[i] = inBuffers[i].VkBuffer;
            offsets[i] = inBuffers[i].BindOffset;
        }

        inCommandBuffer.BindVertexBuffers(inFirstBinding, buffers, offsets);
    }

    ///<summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</see> - Bind vertex buffers to a command buffer</summary>
    ///<param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    ///<param name="inFirstBinding">is the index of the first vertex input binding whose state is updated by the command.</param>
    ///<param name="inBuffers">is a pointer to an array of buffer handles.</param>
    ///<param name="inAdditionalOffsets">is a pointer to an array of buffer offsets, beyond the buffer's bind offset.</param>
    public static unsafe void BindVertexBuffers<T>(
        this CommandBuffer inCommandBuffer,
        int inFirstBinding,
        Span<T> inBuffers,
        Span<ByteSize> inAdditionalOffsets
    )
        where T : IBindBuffer
    {
        if (inBuffers.Length != inAdditionalOffsets.Length)
            throw new ArgumentException("inBuffers and inAdditionalOffsets must be the same length");

        Span<VkBuffer> buffers = stackalloc VkBuffer[inBuffers.Length];
        Span<ByteSize64> offsets = stackalloc ByteSize64[inBuffers.Length];

        for (var i = 0; i < inBuffers.Length; i++)
        {
            buffers[i] = inBuffers[i].VkBuffer;
            offsets[i] = inBuffers[i].BindOffset + inAdditionalOffsets[i];
        }

        inCommandBuffer.BindVertexBuffers(inFirstBinding, buffers, offsets);
    }

    ///<summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">vkCmdBindIndexBuffer</see> - Bind an index buffer to a command buffer</summary>
    ///<param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    ///<param name="inBuffer">is the buffer being bound.</param>
    ///<param name="inIndexType">is a <c>VkIndexType</c> value specifying the size of the indices.</param>
    public static void BindIndexBuffer<T>(this CommandBuffer inCommandBuffer, T inBuffer, VkIndexType inIndexType)
        where T : IBindBuffer
    {
        inCommandBuffer.BindIndexBuffer(inBuffer.VkBuffer, inBuffer.BindOffset, inIndexType);
    }

    /// <summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">vkCmdBindIndexBuffer</see> - Bind an index buffer to a command buffer</summary>
    /// <param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    /// <param name="inBuffer">is the buffer being bound.</param>
    /// <param name="inAdditionalOffset">is an additional offset to add to the buffer's bind offset.</param>
    /// <param name="inIndexType">is a <c>VkIndexType</c> value specifying the size of the indices.</param>
    public static void BindIndexBuffer<T>(
        this CommandBuffer inCommandBuffer,
        T inBuffer,
        ByteSize inAdditionalOffset,
        VkIndexType inIndexType
    )
        where T : IBindBuffer
    {
        inCommandBuffer.BindIndexBuffer(inBuffer.VkBuffer, inBuffer.BindOffset + inAdditionalOffset, inIndexType);
    }

    ///<summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html">vkCmdDrawIndirect</see> - Draw primitives with indirect parameters</summary>
    ///<param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    ///<param name="inBuffer">is the buffer containing draw parameters.</param>
    ///<param name="inDrawCount">is the number of draws to execute, and <i>can</i> be zero.</param>
    ///<param name="inStride">is the byte stride between successive sets of draw parameters.</param>
    public static void DrawIndirect<T>(
        this CommandBuffer inCommandBuffer,
        T inBuffer,
        ElementCount inDrawCount,
        ByteSize inStride
    )
        where T : IBindBuffer
    {
        inCommandBuffer.DrawIndirect(inBuffer.VkBuffer, inBuffer.BindOffset, inDrawCount, inStride);
    }

    /// <summary><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html">vkCmdDrawIndirect</see> - Draw primitives with indirect parameters</summary>
    /// <param name="inCommandBuffer">is the command buffer into which the command is recorded.</param>
    /// <param name="inBuffer">is the buffer containing draw parameters.</param>
    /// <param name="inAdditionalOffset">is an additional offset to add to the buffer's bind offset.</param>
    /// <param name="inDrawCount">is the number of draws to execute, and <i>can</i> be zero.</param>
    /// <param name="inStride">is the byte stride between successive sets of draw parameters.</param>
    public static void DrawIndirect<T>(
        this CommandBuffer inCommandBuffer,
        T inBuffer,
        ByteSize inAdditionalOffset,
        ElementCount inDrawCount,
        ByteSize inStride
    )
        where T : IBindBuffer
    {
        inCommandBuffer.DrawIndirect(
            inBuffer.VkBuffer,
            inBuffer.BindOffset + inAdditionalOffset,
            inDrawCount,
            inStride
        );
    }
}
