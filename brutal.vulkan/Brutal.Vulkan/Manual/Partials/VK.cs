namespace Brutal.VulkanApi;

public static partial class VK
{
    public const string LAYER_KHRONOS_VALIDATION = "VK_LAYER_KHRONOS_validation";

    // UTF-8 spelling of the same layer name for allocation-free byte comparisons
    public static ReadOnlySpan<byte> LAYER_KHRONOS_VALIDATION_UTF8 => "VK_LAYER_KHRONOS_validation"u8;
}
