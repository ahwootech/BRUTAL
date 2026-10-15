namespace Brutal.VulkanApi.Vma
{
    public enum VmaMemoryUsage : uint
    {
        Unknown = 0x00000000,
        GpuOnly = 0x00000001,
        CpuOnly = 0x00000002,
        CpuToGpu = 0x00000003,
        GpuToCpu = 0x00000004,
        CpuCopy = 0x00000005,
        GpuLazilyAllocated = 0x00000006,
        Auto = 0x00000007,
        AutoPreferDevice = 0x00000008,
        AutoPreferHost = 0x00000009,
        MaxEnum = 0x7FFFFFFF,
    }
}
