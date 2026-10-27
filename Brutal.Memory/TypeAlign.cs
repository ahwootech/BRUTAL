using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.Memory;

/// <summary>
/// Provides the natural memory alignment requirement for an unmanaged type <typeparamref name="T"/>.
/// Serves as the C# equivalent of C++ <c>alignof(T)</c>.
/// </summary>
/// <typeparam name="T">The unmanaged type whose alignment is to be queried.</typeparam>
public static unsafe class TypeAlign<T> where T : unmanaged
{
	/// <summary>
	/// Probe struct to measure padding added by the runtime between fields.
	/// Explicitly sequential to prevent field reordering optimizations.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	private struct Probe
	{
		public byte Byte;
		public T Value;
	}

	/// <summary>
	/// The natural alignment of type <typeparamref name="T"/> in bytes.
	/// Guaranteed to be a power of two (1, 2, 4, 8, or 16).
	/// </summary>
	public static readonly int Value = ComputeAlignment();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ComputeAlignment()
	{
		Probe probe = default;
		return (int)((byte*)&probe.Value - (byte*)&probe);
	}
}