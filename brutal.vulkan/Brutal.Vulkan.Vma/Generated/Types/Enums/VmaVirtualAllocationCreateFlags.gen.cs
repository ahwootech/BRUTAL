namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaVirtualAllocationCreateFlags : uint
    {
        None = 0,
        UpperAddressBit = 0x00000040,
        StrategyMinMemoryBit = 0x00010000,
        StrategyMinTimeBit = 0x00020000,
        StrategyMinOffsetBit = 0x00040000,
        StrategyMask = 0x00070000,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
