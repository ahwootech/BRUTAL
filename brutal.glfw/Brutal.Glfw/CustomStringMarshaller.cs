using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Brutal.GlfwApi;

/// <summary>
/// Marshaller for UTF-8 strings.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))] // string parameter
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(ManagedToUnmanagedOut))] // return string
//[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedRef, typeof(ManagedToUnmanagedRef))]
//[CustomMarshaller(typeof(string), MarshalMode.UnmanagedToManagedIn, typeof(UnmanagedToManagedIn))]
//[CustomMarshaller(typeof(string), MarshalMode.UnmanagedToManagedRef, typeof(UnmanagedToManagedRef))]
//[CustomMarshaller(typeof(string), MarshalMode.UnmanagedToManagedOut, typeof(UnmanagedToManagedOut))]
//[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
public static unsafe class CustomStringMarshaller
{
    /// <summary>
    /// Custom marshaller to marshal a managed string as a UTF-8 unmanaged string.
    /// </summary>
    public ref struct ManagedToUnmanagedIn
    {
        /// <summary>
        /// Gets the requested buffer size for optimized marshalling.
        /// </summary>
        public static int BufferSize => 0x100;

        private byte* _unmanagedValue;
        private bool _allocated;

        /// <summary>
        /// Initializes the marshaller with a managed string and requested buffer.
        /// </summary>
        /// <param name="managed">The managed string with which to initialize the marshaller.</param>
        /// <param name="buffer">The request buffer whose size is at least <see cref="BufferSize"/>.</param>
        public void FromManaged(string? managed, Span<byte> buffer)
        {
            _allocated = false;

            if (managed is null)
            {
                _unmanagedValue = null;
                return;
            }

            const int MaxUtf8BytesPerChar = 3;

            // >= for null terminator
            // Use the cast to long to avoid the checked operation
            if ((long)MaxUtf8BytesPerChar * managed.Length >= buffer.Length)
            {
                // Calculate accurate byte count when the provided stack-allocated buffer is not sufficient
                int exactByteCount = checked(Encoding.UTF8.GetByteCount(managed) + 1); // + 1 for null terminator
                if (exactByteCount > buffer.Length)
                {
                    buffer = new Span<byte>((byte*)NativeMemory.Alloc((nuint)exactByteCount), exactByteCount);
                    _allocated = true;
                }
            }

            // Unsafe.AsPointer is safe since buffer must be pinned
            _unmanagedValue = (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(buffer));

            int byteCount = Encoding.UTF8.GetBytes(managed, buffer);
            buffer[byteCount] = 0; // null-terminate
        }

        /// <summary>
        /// Converts the current managed string to an unmanaged string.
        /// </summary>
        /// <returns>An unmanaged string.</returns>
        public byte* ToUnmanaged() => _unmanagedValue;

        /// <summary>
        /// Frees any allocated unmanaged memory.
        /// </summary>
        public void Free()
        {
            if (_allocated)
                NativeMemory.Free(_unmanagedValue);
        }
    }

    public static class ManagedToUnmanagedOut
    {
        /// <summary>
        /// Converts an unmanaged UTF-8 string to a managed string, preserving a NULL pointer as
        /// <see langword="null"/>.
        /// </summary>
        /// <remarks>
        /// Several GLFW functions return NULL to signal failure - e.g. <c>glfwGetClipboardString</c>
        /// returns NULL on <c>FormatUnavailable</c>. Collapsing NULL to an empty string would make a
        /// failed call indistinguishable from a legitimately empty result, so the NULL signal is
        /// preserved and the return type is nullable.
        /// </remarks>
        /// <param name="unmanaged">The unmanaged UTF-8 string, or NULL.</param>
        /// <returns>The managed string, or <see langword="null"/> if <paramref name="unmanaged"/> is NULL.</returns>
        public static string? ConvertToManaged(byte* unmanaged)
        {
            if (unmanaged == null)
                return null;

            return Marshal.PtrToStringUTF8((IntPtr)unmanaged);
        }
    }

    /*
    public ref struct ManagedToUnmanagedRef
    {
        public void FromManaged(string managed) { }

        public void FromUnmanaged(byte* unmanaged)
        {
        }

        public string ToManaged()
        {
            return "";
        }

        public byte* ToUnmanaged()
        {
            return null;
        }

        public void Free() { }
    }


    public ref struct UnmanagedToManagedOut
    {
        public void FromManaged(string managed) { }

        public byte* ToUnmanaged()
        {
            return null;
        }

        public void Free() { }
    }

    public ref struct UnmanagedToManagedRef
    {
        public void FromManaged(string managed) { }

        public void FromUnmanaged(byte* unmanaged)
        {
        }

        public string ToManaged()
        {
            return "";
        }

        public byte* ToUnmanaged()
        {
            return null;
        }

        public void Free() { }
    }

    public ref struct UnmanagedToManagedIn
    {
        private byte* _unmanagedValue;

        public void FromUnmanaged(byte* unmanaged)
        {
            _unmanagedValue = unmanaged;
        }

        public string ToManaged()
        {
            return "";
        }

        public void Free() { }
    }
    */
}
