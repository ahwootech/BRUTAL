namespace Brutal.VulkanApi;

public class VkResultError : Exception
{
    public VkResult Result { get; }

    public VkResultError(VkResult result, string message)
        : base(message)
    {
        Result = result;
    }
}
