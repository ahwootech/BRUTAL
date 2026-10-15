namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaAllocationCreateFlags : uint
    {
        None = 0,
        DedicatedMemoryBit = 0x00000001,
        NeverAllocateBit = 0x00000002,
        MappedBit = 0x00000004,
        UserDataCopyStringBit = 0x00000020,
        UpperAddressBit = 0x00000040,
        DontBindBit = 0x00000080,
        WithinBudgetBit = 0x00000100,
        CanAliasBit = 0x00000200,
        HostAccessSequentialWriteBit = 0x00000400,
        HostAccessRandomBit = 0x00000800,
        HostAccessAllowTransferInsteadBit = 0x00001000,
        StrategyMinMemoryBit = 0x00010000,
        StrategyMinTimeBit = 0x00020000,
        StrategyMinOffsetBit = 0x00040000,
        StrategyBestFitBit = 0x00010000,
        StrategyFirstFitBit = 0x00020000,
        StrategyMask = 0x00070000,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
