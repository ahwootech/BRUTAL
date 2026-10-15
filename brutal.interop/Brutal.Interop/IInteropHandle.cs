namespace Brutal.Interop;

/// <summary>
///     Describes an object that can be marshalled between managed and unmanaged code via a typed handle.
/// </summary>
public interface IInteropHandle<THandle, out TSelf> : INullable
    where THandle : unmanaged
    where TSelf : struct, IInteropHandle<THandle, TSelf>
{
    THandle Pointer { get; init; }
}
