using System.Runtime.InteropServices.Marshalling;

// Hand-written members of the Cursor library: the GlfwCursor handle type, its custom marshaller,
// and the custom-image CreateCursor factory (which bundles a CreateInfo struct and fixed-pins the
// image - not mechanically derivable). The standard-shape CreateCursor overload is generated into
// Generated/Libraries/Glfw.Cursor.gen.cs and merges into this same partial class.

namespace Brutal.GlfwApi;

public static unsafe partial class Glfw
{
    /// <summary>Creates a custom cursor.</summary>
    /// <remarks>
    ///     Creates a new custom cursor image that can be set for a window with <see cref="GlfwWindow.SetCursor">GlfwWindow.SetCursor</see>
    ///     . The cursor can be destroyed with <see cref="GlfwCursor.Dispose">GlfwCursor.Dispose</see>. Any remaining cursors are destroyed by
    ///     <see cref="Terminate" />.
    ///     <para />
    ///     The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight bits per channel with the red channel
    ///     first. They are arranged canonically as packed sequential rows, starting from the top-left corner.
    ///     <para />
    ///     The cursor hotspot is specified in pixels, relative to the upper-left corner of the cursor image. Like all other
    ///     coordinate systems in GLFW, the X-axis points to the right and the Y-axis points down.
    /// </remarks>
    /// <returns>The handle of the new cursor, or <c>null</c> if an error occurred.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso cref="GlfwCursor.Dispose">GlfwCursor.Dispose</seealso>
    /// <seealso cref="CreateCursor(GlfwStandardCursor)" />
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_object">Cursor objects</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.InvalidValue" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public static GlfwCursor CreateCursor(in GlfwCursor.CreateInfo info)
    {
        fixed (GlfwImage* imagePtr = &info.Image)
        {
            return PInvoke.CreateCursor(imagePtr, info.Hot.X, info.Hot.Y);
        }
    }
}

/// <summary>
///     Wrapper around a <see cref="GlfwCursorHandle" />*
/// </summary>
[NativeMarshalling(typeof(GlfwCursorMarshaller))]
public unsafe struct GlfwCursor : IDisposable, INullable
{
    /// <summary>
    /// Information required to create a custom cursor.
    /// </summary>
    public struct CreateInfo
    {
        /// <summary>
        ///     The image to use for the cursor.
        /// </summary>
        public GlfwImage Image;

        /// <summary>
        ///     The position of the cursor hotspot, relative to the upper-left corner of the image.
        /// </summary>
        public int2 Hot;
    }

    internal GlfwCursor(GlfwCursorHandle* inPointer)
    {
        Pointer = inPointer;
    }

    internal GlfwCursorHandle* Pointer { get; private set; }

    /// <summary>
    ///     Gets the native Glfw handle for this cursor
    /// </summary>
    public nint NativeHandle => (nint)Pointer;

    /// <summary>Destroys a cursor.</summary>
    /// <remarks>
    ///     This function destroys a cursor previously created with <see cref="Glfw.CreateCursor(in Brutal.GlfwApi.GlfwCursor.CreateInfo)" /> or
    ///     <see cref="Glfw.CreateCursor(GlfwStandardCursor)" />. Any remaining cursors are destroyed by <see cref="Glfw.Terminate" />.
    ///     <para />
    ///     If the specified cursor is current for any window, that window will be reverted to the default cursor. This does
    ///     not affect the cursor mode.
    /// </remarks>
    /// <reentrancy>This function must not be called from a callback.</reentrancy>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso cref="Glfw.CreateCursor(in Brutal.GlfwApi.GlfwCursor.CreateInfo)" />
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_object">Cursor objects</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public void Dispose()
    {
        if (Pointer != null)
        {
            Glfw.PInvoke.DestroyCursor(this);
            Pointer = null;
        }
    }

    /// <summary>Returns whether this cursor handle is null (uninitialised or already destroyed).</summary>
    /// <returns><c>true</c> if the underlying native handle is null; otherwise <c>false</c>.</returns>
    public bool IsNull()
    {
        return Pointer == null;
    }
}

[CustomMarshaller(
    managedType: typeof(GlfwCursor),
    marshalMode: MarshalMode.Default,
    marshallerType: typeof(GlfwCursorMarshaller)
)]
internal static unsafe class GlfwCursorMarshaller
{
    internal static GlfwCursorHandle* ConvertToUnmanaged(GlfwCursor managed) => managed.Pointer;

    internal static GlfwCursor ConvertToManaged(GlfwCursorHandle* unmanaged) => new(unmanaged);
}
