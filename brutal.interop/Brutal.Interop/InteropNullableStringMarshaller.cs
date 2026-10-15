using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Brutal.Interop;

/// <summary>
/// Marshaller for UTF-8 strings whose out direction preserves a NULL native
/// pointer as <see langword="null"/>. The null-preserving sibling of
/// <see cref="InteropStringMarshaller"/>, for native APIs that use a NULL
/// return as a failure or absence sentinel.
/// </summary>
[CustomMarshaller(
    typeof(string),
    MarshalMode.ManagedToUnmanagedIn,
    typeof(InteropStringMarshaller.ManagedToUnmanagedIn)
)] // string parameter, shared with the non-nullable sibling
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(ManagedToUnmanagedOut))] // return string?
public static unsafe class InteropNullableStringMarshaller
{
    public static class ManagedToUnmanagedOut
    {
        public static string? ConvertToManaged(byte* unmanaged)
        {
            if (unmanaged == null)
                return null;

            return Marshal.PtrToStringUTF8((IntPtr)unmanaged);
        }
    }
}
