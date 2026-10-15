namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaPoolCreateFlags : uint
    {
        None = 0,
        IgnoreBufferImageGranularityBit = 0x00000002,
        LinearAlgorithmBit = 0x00000004,
        AlgorithmMask = 0x00000004,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
