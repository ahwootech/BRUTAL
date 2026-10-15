namespace Brutal.VulkanApi;

/// <summary>
/// Class that wraps a Vulkan Queue handle.
/// </summary>
public class Queue : VulkanHandleWrapper<VkQueue, VkDevice.FunctionTable>
{
    /// <summary>
    /// The family index of this queue.
    /// </summary>
    public int Family { get; }

    /// <summary>
    /// The index of this queue within the family.
    /// </summary>
    public int Index { get; }

    public Device Device { get; init; }

    internal Queue(Device device, int family, int index)
    {
        Handle = device.GetQueueInternal(family, index);
        Family = family;
        Index = index;
        Device = device;
    }

    public VkQueue Handle { get; init; }
    public ref VkDevice.FunctionTable PInvoke => ref Device.PInvoke;

    private VulkanHandleWrapper<VkQueue, VkDevice.FunctionTable> AsWrapper() => this;

    public void WaitIdle()
    {
        lock (_lock)
        {
            AsWrapper().WaitIdleInternal();
        }
    }

    public void BindSparse(ReadOnlySpan<VkBindSparseInfo> inBindInfo, VkFence inFence)
    {
        lock (_lock)
        {
            AsWrapper().BindSparseInternal(inBindInfo, inFence);
        }
    }

    public void BeginDebugUtilsLabelEXT(VkDebugUtilsLabelEXT inLabelInfo)
    {
        lock (_lock)
        {
            AsWrapper().BeginDebugUtilsLabelEXTInternal(inLabelInfo);
        }
    }

    public void EndDebugUtilsLabelEXT()
    {
        lock (_lock)
        {
            AsWrapper().EndDebugUtilsLabelEXTInternal();
        }
    }

    public void InsertDebugUtilsLabelEXT(VkDebugUtilsLabelEXT inLabelInfo)
    {
        lock (_lock)
        {
            AsWrapper().InsertDebugUtilsLabelEXTInternal(inLabelInfo);
        }
    }

    public void Submit(Span<VkSubmitInfo> inSubmits, VkFence inFence)
    {
        lock (_lock)
        {
            AsWrapper().SubmitInternal(inSubmits, inFence);
        }
    }

    public void Submit2(Span<VkSubmitInfo2> inSubmits, VkFence inFence)
    {
        lock (_lock)
        {
            AsWrapper().Submit2Internal(inSubmits, inFence);
        }
    }

    public VkResult PresentKHR(VkPresentInfoKHR inPresentInfo)
    {
        lock (_lock)
        {
            return AsWrapper().PresentKHRInternal(inPresentInfo);
        }
    }

    // Lock to ensure that only one thread is submitting at a time.
    private readonly Lock _lock = new();

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkQueue(Queue queue) => queue.Handle;
}
