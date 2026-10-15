namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Provides extension methods for submitting command buffers and handling synchronization for Vulkan queues.
/// </summary>
public static class QueueExtensions
{
    /// <summary>
    /// Submits command buffers to a Vulkan queue with specified wait and signal semaphores, and a fence for synchronization.
    /// </summary>
    /// <param name="queue">The Vulkan queue to submit command buffers to.</param>
    /// <param name="waitSemaphores">A span of semaphores to wait on before executing the command buffers.</param>
    /// <param name="waitDstStageMask">A span of pipeline stage flags indicating the stages to wait for.</param>
    /// <param name="commandBuffers">A span of command buffers to execute.</param>
    /// <param name="signalSemaphores">A span of semaphores to signal after executing the command buffers.</param>
    /// <param name="fence">A fence that is signaled when the queue finishes executing the submitted command buffers.</param>
    public static void Submit(
        this Queue queue,
        Span<VkSemaphore> waitSemaphores,
        Span<VkPipelineStageFlags> waitDstStageMask,
        Span<CommandBuffer> commandBuffers,
        Span<VkSemaphore> signalSemaphores,
        VkFence fence
    )
    {
        unsafe
        {
            var commandBuffersPtr = stackalloc VkCommandBuffer[commandBuffers.Length];
            for (var i = 0; i < commandBuffers.Length; i++)
                commandBuffersPtr[i] = commandBuffers[i].Handle;

            fixed (VkSemaphore* waitSemaphoresPtr = waitSemaphores)
            fixed (VkPipelineStageFlags* waitDstStageMaskPtr = waitDstStageMask)
            fixed (VkSemaphore* signalSemaphoresPtr = signalSemaphores)
            {
                var submitInfo = new VkSubmitInfo
                {
                    WaitSemaphoreCount = waitSemaphores.Length,
                    WaitSemaphores = waitSemaphoresPtr,
                    WaitDstStageMask = waitDstStageMaskPtr,
                    CommandBufferCount = commandBuffers.Length,
                    CommandBuffers = commandBuffersPtr,
                    SignalSemaphoreCount = signalSemaphores.Length,
                    SignalSemaphores = signalSemaphoresPtr,
                };

                queue.Submit([submitInfo], fence);
            }
        }
    }
}
