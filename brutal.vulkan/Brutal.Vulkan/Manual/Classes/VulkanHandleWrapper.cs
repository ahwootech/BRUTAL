namespace Brutal.VulkanApi;

public interface VulkanHandleWrapper<THandleType, TFunctionTable> : IVulkanHandle
    where THandleType : unmanaged, IVulkanHandle
    where TFunctionTable : unmanaged
{
    internal THandleType Handle { get; init; }
    public ref TFunctionTable PInvoke { get; }
}
