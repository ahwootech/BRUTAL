using CommunityToolkit.HighPerformance.Helpers;

namespace Brutal.VulkanApi;

// Helper wrappers for bitfield wrapper properties to get/set specific bit ranges within a backing field
internal static class BitFields
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasFlag(int target, int bit)
    {
        return BitHelper.HasFlag((uint)target, bit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetFlag(ref int target, int bit, bool value)
    {
        BitHelper.SetFlag(ref Unsafe.As<int, uint>(ref target), bit, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ExtractRange(int target, byte start, byte length)
    {
        return (int)BitHelper.ExtractRange((uint)target, start, length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetRange(ref int target, byte start, byte length, int flags)
    {
        BitHelper.SetRange(ref Unsafe.As<int, uint>(ref target), start, length, (uint)flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static VkGeometryInstanceFlagsKHR ExtractRange(VkGeometryInstanceFlagsKHR target, byte start, byte length)
    {
        return (VkGeometryInstanceFlagsKHR)BitHelper.ExtractRange((uint)target, start, length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetRange(
        ref VkGeometryInstanceFlagsKHR target,
        byte start,
        byte length,
        VkGeometryInstanceFlagsKHR flags
    )
    {
        BitHelper.SetRange(ref Unsafe.As<VkGeometryInstanceFlagsKHR, uint>(ref target), start, length, (uint)flags);
    }
}
