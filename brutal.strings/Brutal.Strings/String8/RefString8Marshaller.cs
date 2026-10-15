using System.Runtime.InteropServices.Marshalling;
using Brutal.Attributes;

namespace Brutal.Strings;

[CustomMarshaller(
    managedType: typeof(RefString8),
    marshalMode: MarshalMode.ManagedToUnmanagedIn,
    marshallerType: typeof(RefString8Marshaller)
)]
[CustomMarshaller(
    managedType: typeof(RefString8),
    marshalMode: MarshalMode.UnmanagedToManagedIn,
    marshallerType: typeof(RefString8Marshaller)
)]
public static class RefString8Marshaller
{
    public static unsafe Char8* ConvertToUnmanaged(RefString8 managed)
    {
        return (Char8*)Unsafe.AsPointer(ref managed.GetPinnableReference());
    }

    // pointer is [Fixed] because it originates from native interop / owned by the unmanaged side
    public static unsafe RefString8 ConvertToManaged([Fixed] Char8* unmanaged)
    {
        return new RefString8(unmanaged);
    }

    public static ref Char8 GetPinnableReference(RefString8 managed)
    {
        return ref managed.GetPinnableReference();
    }
}
