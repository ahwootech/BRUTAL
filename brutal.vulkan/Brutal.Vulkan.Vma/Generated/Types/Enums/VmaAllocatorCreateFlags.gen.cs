namespace Brutal.VulkanApi.Vma
{
    [Flags]
    public enum VmaAllocatorCreateFlags : uint
    {
        None = 0,
        ExternallySynchronizedBit = 0x00000001,
        KhrDedicatedAllocationBit = 0x00000002,
        KhrBindMemory2Bit = 0x00000004,
        ExtMemoryBudgetBit = 0x00000008,
        AmdDeviceCoherentMemoryBit = 0x00000010,
        BufferDeviceAddressBit = 0x00000020,
        ExtMemoryPriorityBit = 0x00000040,
        KhrMaintenance4Bit = 0x00000080,
        KhrMaintenance5Bit = 0x00000100,
        KhrExternalMemoryWin32Bit = 0x00000200,
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
