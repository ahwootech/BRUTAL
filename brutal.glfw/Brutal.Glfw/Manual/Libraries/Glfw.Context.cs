// Context reference
// https://www.glfw.org/docs/latest/group__context.html

// Hand-written members of the Context library. GetCurrentContext and GetProcAddress are in the
// generator's ManualMethods set (no P/Invoke is generated for them - see Manual/Glfw.PInvoke.cs),
// so they cannot be generated and live here. The rest of the Context library is generated into
// Generated/Libraries/Glfw.Context.gen.cs and merges into this same partial class.

namespace Brutal.GlfwApi;

public static unsafe partial class Glfw
{
    /// <summary>Returns the window whose context is current on the calling thread.</summary>
    /// <remarks>
    ///     This function returns the window whose OpenGL or OpenGL ES context is current on the calling thread.
    /// </remarks>
    /// <returns>The window whose context is current, or <c>null</c> if no window's context is current.</returns>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <threadSafety>This function may be called from any thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/context_guide.html#context_current">Current context</seealso>
    public static nint GetCurrentContext()
    {
        return (nint)PInvoke.GetCurrentContext();
    }

    /// <summary>Returns the address of the specified function for the current context.</summary>
    /// <remarks>
    ///     This function returns the address of the specified OpenGL or OpenGL ES core or extension function, if it is
    ///     supported by the current context.
    ///     <para />
    ///     A context must be current on the calling thread. Calling this function without a current context will cause a
    ///     <see cref="GlfwErrorCode.NoCurrentContext" /> error.
    ///     <para />
    ///     This function does not apply to Vulkan. If you are rendering with Vulkan, see
    ///     <see cref="GetInstanceProcAddress">GetInstanceProcAddress</see>,
    ///     <see cref="InstanceLibrary.GetProcAddr">InstanceLibrary.GetProcAddr</see> and
    ///     <see cref="DeviceLibrary.GetProcAddr">DeviceLibrary.GetProcAddr</see> instead.
    ///     <para />
    ///     The address of a given function is not guaranteed to be the same between contexts.
    ///     <para />
    ///     This function may return a non-null address despite the associated version or extension not being available.
    ///     Always check the context version or extension string first.
    /// </remarks>
    /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.NoCurrentContext" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <pointerLifetime>The returned function pointer is valid until the context is destroyed or the library is terminated.</pointerLifetime>
    /// <threadSafety>This function may be called from any thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/context_guide.html#context_glext">OpenGL and OpenGL ES extensions</seealso>
    public static nint GetProcAddress(ReadOnlySpan<byte> procName)
    {
        fixed (byte* pProcName = procName)
            return PInvoke.GetProcAddress(pProcName);
    }
}
