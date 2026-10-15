using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace Brutal.Interop;

[CustomMarshaller(
    typeof(CustomMarshallerAttribute.GenericPlaceholder),
    MarshalMode.Default,
    typeof(InteropHandleMarshaller<,>)
)]
public static class InteropHandleMarshaller<T, THandle>
    where THandle : unmanaged
    where T : struct, IInteropHandle<THandle, T>
{
    public static THandle ConvertToUnmanaged(T managed) => managed.Pointer;

    public static T ConvertToManaged(THandle unmanaged) => Unsafe.As<THandle, T>(ref unmanaged);
}
