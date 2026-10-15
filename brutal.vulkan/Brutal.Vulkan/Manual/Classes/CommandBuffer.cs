namespace Brutal.VulkanApi;

/// <summary>
/// Class that wraps a Command Buffer handle.
/// </summary>
public struct CommandBuffer : VulkanHandleWrapper<VkCommandBuffer, VkDevice.FunctionTable>
{
    private readonly Ptr<VkDevice.FunctionTable> _pInvoke;

    public CommandBuffer(Device device, VkCommandBuffer handle)
    {
        _pInvoke = device._pInvoke;
        Handle = handle;
    }

    public VkCommandBuffer Handle { get; init; }
    public ref VkDevice.FunctionTable PInvoke => ref _pInvoke.Value;

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkCommandBuffer(CommandBuffer commandBuffer) => commandBuffer.Handle;
}
