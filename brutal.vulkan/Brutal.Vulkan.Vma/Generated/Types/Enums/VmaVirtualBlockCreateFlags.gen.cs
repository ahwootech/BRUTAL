namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaVirtualBlockCreateFlags : uint
    {
        None = 0,
        LinearAlgorithmBit = 0x00000001,
        AlgorithmMask = 0x00000001,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
