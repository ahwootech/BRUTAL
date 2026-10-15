namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaDefragmentationFlags : uint
    {
        None = 0,
        FlagAlgorithmFastBit = 0x00000001,
        FlagAlgorithmBalancedBit = 0x00000002,
        FlagAlgorithmFullBit = 0x00000004,
        FlagAlgorithmExtensiveBit = 0x00000008,
        FlagAlgorithmMask = 0x0000000F,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
