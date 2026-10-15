namespace Brutal.VulkanApi.Abstractions;

/// <summary>
///     Object that holds data for loading and submitting staging data to the GPU
/// </summary>
public class StagingPool : IDisposable
{
    private readonly Device _device;
    private readonly IBufferAllocator _allocator;
    private readonly Queue _queue;
    private readonly VkCommandBufferLevel _level;
    private readonly VkCommandPool _commandPool;
    private readonly List<VkFence> _fences;
    private readonly Stack<VkFence> _freeFences = new();
    private readonly List<CommandBuffer> _commandBuffers;
    private readonly List<BufferEx> _stagingBuffers = [];
    private readonly Dictionary<ByteSize, Stack<BufferEx>> _freeStagingBuffers = new();
    private int _commandBufferIndex;
    private int _submitted;

    // Staging buffer count as of the last Submit; only these belong to submitted work and are safe to recycle
    private int _submittedStagingBuffers;

    internal StagingPool(
        IBufferAllocator inAllocator,
        Queue inQueue,
        int inInitialCommandBufferCount,
        VkCommandBufferLevel inLevel = VkCommandBufferLevel.Primary
    )
    {
        _queue = inQueue;
        _level = inLevel;
        _device = inAllocator.GetDevice();
        _allocator = inAllocator;
        _commandPool = _device.CreateCommandPool(
            new VkCommandPoolCreateInfo { QueueFamilyIndex = inQueue.Family, Flags = VkCommandPoolCreateFlags.None },
            null
        );

        _fences = new(1);
        _commandBuffers = new(inInitialCommandBufferCount);

        if (inInitialCommandBufferCount > 0)
        {
            Span<CommandBuffer> commandBuffers = stackalloc CommandBuffer[inInitialCommandBufferCount];

            _device.AllocateCommandBuffers(
                new VkCommandBufferAllocateInfo { CommandPool = _commandPool, Level = inLevel },
                commandBuffers
            );

            _commandBuffers.AddRange(commandBuffers);
        }
        else
        {
            _commandBuffers = [];
        }
    }

    /// <summary>
    /// Allocate another command buffer from this pool
    /// </summary>
    /// <returns></returns>
    public CommandBuffer NextCommandBuffer()
    {
        if (_commandBufferIndex > _commandBuffers.Count)
            throw new Exception("CommandBuffer index got ahead of Vk allocations");

        if (_commandBufferIndex == _commandBuffers.Count)
        {
            _commandBuffers.Add(
                _device.AllocateCommandBuffer(
                    new VkCommandBufferAllocateInfo { CommandPool = _commandPool, Level = _level }
                )
            );
        }

        return _commandBuffers[_commandBufferIndex++];
    }

    /// <summary>
    /// Add a staging buffer reference to this staging data, ensuring it is cached until we submit command buffers which use the buffer and then explicitly call Dispose()
    /// </summary>
    public BufferEx AddStagingBuffer(ByteSize value)
    {
        // Reuse a size-matched recycled buffer in O(1) instead of scanning a flat list
        if (_freeStagingBuffers.TryGetValue(value, out var bucket) && bucket.Count > 0)
        {
            var recycled = bucket.Pop();
            _stagingBuffers.Add(recycled);
            return recycled;
        }

        var buffer = _allocator.CreateBuffer(
            new BufferEx.CreateInfo
            {
                Name = "StagingBuffer",
                BufferSize = value,
                BufferUsage = VkBufferUsageFlags.TransferSrcBit,
                AllocRequiredProperties = VkMemoryPropertyFlags.HostCoherentBit | VkMemoryPropertyFlags.HostVisibleBit,
            }
        );

        _stagingBuffers.Add(buffer);

        return buffer;
    }

    /// <summary>
    /// Add a staging buffer reference to this staging data, ensuring it is cached until we submit command buffers which use the buffer and then explicitly call Dispose()
    /// </summary>
    public BufferEx AddStagingBuffer<T>(ElementCount inCount)
        where T : unmanaged
    {
        return AddStagingBuffer(ByteSize.Of<T>(inCount));
    }

    /// <summary>
    /// Add a staging buffer reference to this staging data, ensuring it is cached until we submit command buffers which use the buffer and then explicitly call Dispose()
    /// </summary>
    public BufferEx AddStagingBuffer<T>(Span<T> inData)
        where T : unmanaged
    {
        var buffer = AddStagingBuffer<T>(inData.Length);

        using var mapped = buffer.Map();
        inData.CopyTo(mapped.AsSpan<T>());

        return buffer;
    }

    /// <summary>
    /// Submit pending command buffers
    /// </summary>
    public StagingPool Submit()
    {
        return Submit([], [], []);
    }

    /// <summary>
    /// Submit pending command buffers
    /// </summary>
    public StagingPool Submit(
        Span<VkSemaphore> waitSemaphores,
        Span<VkPipelineStageFlags> waitDstStageMask,
        Span<VkSemaphore> signalSemaphores
    )
    {
        var count = _commandBufferIndex - _submitted;
        if (count != 0)
        {
            // Reuse a recycled (already reset) fence before creating a new one
            var fence =
                _freeFences.Count > 0
                    ? _freeFences.Pop()
                    : _device.CreateFence(new VkFenceCreateInfo { Flags = VkFenceCreateFlags.None }, null);
            _fences.Add(fence);

            var commandBuffers = _commandBuffers.AsSpan().Slice(_submitted, count);
            _queue.Submit(waitSemaphores, waitDstStageMask, commandBuffers, signalSemaphores, fence);
            _submitted += count;

            // Everything staged so far is referenced by this submission; mark it as recyclable.
            _submittedStagingBuffers = _stagingBuffers.Count;
        }

        return this;
    }

    /// <summary>
    /// Wait for fences to complete for a given timeout
    /// </summary>
    /// <param name="waitTimeout">is the timeout period in nanoseconds</param>
    /// <returns>true if all fences are signalled</returns>
    public bool WaitFor(nint waitTimeout)
    {
        if (_fences.Count == 0)
            return true;

        if (_device.WaitForFences(_fences.AsSpan(), true, waitTimeout) == VkResult.Success)
        {
            // Fences and submitted staging buffers are signalled now, so reclaim them even mid-stream
            ReclaimSignalled();

            // The command pool resets as a whole, so only rewind once nothing is still recorded
            if (_submitted == _commandBufferIndex)
                RewindCommandBuffers();

            return true;
        }

        return false;
    }

    /// <summary>
    /// Return signalled fences and the staging buffers behind submitted work to their free pools.
    /// Safe to call while later command buffers are still recorded but unsubmitted.
    /// </summary>
    private void ReclaimSignalled()
    {
        // Reset the signalled fences and return them to the free pool
        if (_fences.Count > 0)
        {
            _device.ResetFences(_fences.AsSpan());
            foreach (var fence in _fences)
                _freeFences.Push(fence);
            _fences.Clear();
        }

        // Only recycle buffers from submitted work; anything added since the last Submit stays for the caller
        for (var i = 0; i < _submittedStagingBuffers; i++)
            PushFreeStagingBuffer(_stagingBuffers[i]);
        _stagingBuffers.RemoveRange(0, _submittedStagingBuffers);
        _submittedStagingBuffers = 0;
    }

    /// <summary>
    /// Reset the command pool and rewind for the next batch, once all recorded work has been submitted.
    /// </summary>
    private void RewindCommandBuffers()
    {
        // Reset the command buffers back to the initial state for reuse instead of freeing them
        if (_commandBufferIndex > 0)
            _device.ResetCommandPool(_commandPool, VkCommandPoolResetFlags.None);

        _commandBufferIndex = 0;
        _submitted = 0;
    }

    // Return a staging buffer to its size bucket for later reuse
    private void PushFreeStagingBuffer(BufferEx buffer)
    {
        if (!_freeStagingBuffers.TryGetValue(buffer.BufferSize, out var bucket))
        {
            bucket = new Stack<BufferEx>();
            _freeStagingBuffers[buffer.BufferSize] = bucket;
        }
        bucket.Push(buffer);
    }

    /// <summary>
    /// Wait for fences to complete
    /// </summary>
    /// <returns>true if all fences are signalled</returns>
    public void Wait()
    {
        if (!WaitFor(-1))
            throw new Exception("WaitForFences failed unexpectedly.");
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Submit();
        Wait();

        _device.DestroyCommandPool(_commandPool, null);

        foreach (var vkBuffer in _stagingBuffers)
            vkBuffer.Dispose();

        foreach (var bucket in _freeStagingBuffers.Values)
        foreach (var vkBuffer in bucket)
            vkBuffer.Dispose();

        foreach (var vkFence in _fences)
            _device.DestroyFence(vkFence, null);

        foreach (var vkFence in _freeFences)
            _device.DestroyFence(vkFence, null);
    }
}

/// <summary>
/// Extensions for StagingPool
/// </summary>
public static class StagingPoolExtensions
{
    /// <summary>
    /// Create a new staging data object with the provided name, command pool, and initial command buffer count.
    /// Will allocate initialCommandBufferCount command buffers from the provided command pool.
    /// </summary>
    public static StagingPool CreateStagingPool(
        this IBufferAllocator inAllocator,
        Queue inQueue,
        int inInitialCommandBufferCount,
        VkCommandBufferLevel inLevel = VkCommandBufferLevel.Primary
    )
    {
        return new StagingPool(inAllocator, inQueue, inInitialCommandBufferCount, inLevel);
    }
}
