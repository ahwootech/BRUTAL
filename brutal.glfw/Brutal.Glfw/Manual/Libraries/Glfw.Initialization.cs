// Initialization, version and error reference
// https://www.glfw.org/docs/latest/group__init.html

// Hand-written members of the Initialization library: the static constructor (native library load,
// DllImportResolver, callback closure wiring), the Initialized state, the error callback wiring,
// Init/Terminate (guarded lifecycle), InitAllocator (delegate rooting), and the version accessors
// (VersionInfo struct packing + property forms). The mechanical SetInitHint and GetError wrappers
// are generated into Generated/Libraries/Glfw.Initialization.gen.cs and merge into this same
// partial class.

using System.Diagnostics;

namespace Brutal.GlfwApi;

/// <summary>The function pointer type for error callbacks.</summary>
public delegate void GlfwErrorCallback(GlfwErrorCode inError, string inDescription);

public static unsafe partial class Glfw
{
    internal static bool Initialized { get; private set; }

    // GLFW holds the function pointers marshalled from these delegates for the lifetime of the
    // process, so the delegates must stay rooted or the pointers dangle. A static strong
    // reference is sufficient for that: the three permanent callbacks live in static readonly
    // fields, and allocator callbacks are appended to AllocatorCallbacks. Entries are never
    // removed from the list: an allocator installed while the library is initialized keeps
    // servicing that init cycle until Terminate, so dropping the previous set on replacement
    // would reintroduce the dangling-pointer bug the list exists to prevent. Installing an
    // allocator is a once-per-process event in practice, so the retained set stays bounded.
    private static readonly GlfwMonitorUnmanagedCallback MonitorUnmanagedCallback;
    private static readonly GlfwJoystickUnmanagedCallback JoystickUnmanagedCallback;
    private static readonly GlfwErrorUnmanagedCallback ErrorUnmanagedCallback;
    private static readonly List<Delegate> AllocatorCallbacks = [];

    static Glfw()
    {
        // Load the GLFW native library
        var glfwNative = NativeLibrary.Load(
            OperatingSystem.IsWindows() ? "glfw3" : "glfw",
            typeof(Glfw).Assembly,
            DllImportSearchPath.AssemblyDirectory
        );

        // Assign the native library to the assembly resolver
        NativeLibrary.SetDllImportResolver(
            typeof(Glfw).Assembly,
            (libraryName, _, _) =>
            {
                // We should only be resolving the GLFW library, any other name is unexpected
                Debug.Assert(libraryName == "glfw", "Unexpected library name requested for resolution.");

                return glfwNative;
            }
        );

        MonitorUnmanagedCallback = (GlfwMonitorUnmanagedCallback)(
            (monitor, eventType) =>
            {
                try
                {
                    MonitorCallback?.Invoke(new GlfwMonitor(monitor), (GlfwMonitorEvent)eventType);
                }
                catch (Exception ex)
                {
                    ExceptionAggregator.Push("An exception occurred in the monitor callback.", ex);
                }
            }
        );

        JoystickUnmanagedCallback = (GlfwJoystickUnmanagedCallback)(
            (joystick, eventType) =>
            {
                try
                {
                    JoystickCallback?.Invoke(joystick, (GlfwJoystickEvent)eventType);
                }
                catch (Exception ex)
                {
                    ExceptionAggregator.Push("An exception occurred in the joystick callback.", ex);
                }
            }
        );

        ErrorUnmanagedCallback = (GlfwErrorUnmanagedCallback)(
            (error, description) =>
            {
                try
                {
                    if (ErrorCallback != null)
                    {
                        var desc = Marshal.PtrToStringUTF8((nint)description) ?? string.Empty;
                        ErrorCallback.Invoke((GlfwErrorCode)error, desc);
                    }
                }
                catch (Exception ex)
                {
                    ExceptionAggregator.Push("An exception occurred in the error callback.", ex);
                }
            }
        );

        PInvoke.SetErrorCallback(ErrorUnmanagedCallback);
    }

    /// <summary>Sets the error callback.</summary>
    /// <remarks>
    ///     This function sets the error callback, which is called with an error code and a human-readable description
    ///     each time a GLFW error occurs.
    ///     <para />
    ///     The error code is set before the callback is called. Calling <see cref="GetError" /> from the error
    ///     callback will return the same value as the error code argument.
    ///     <para />
    ///     The error callback is called on the thread where the error occurred. If you are using GLFW from multiple
    ///     threads, your error callback needs to be written accordingly.
    ///     <para />
    ///     Once set, the error callback remains set even after the library has been terminated.
    ///     <para />
    ///     This function may be called before <see cref="Init" />.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#error_handling">Error handling</seealso>
    public static event GlfwErrorCallback? ErrorCallback;

    /// <summary>Sets the init allocator to the desired value.</summary>
    /// <remarks>
    ///     This function sets the memory allocator that GLFW uses for all internal allocations. The allocator is picked
    ///     up at the beginning of initialization, i.e. by the next call to <see cref="Init" />, and stays in use until
    ///     that init cycle is ended by <see cref="Terminate" />.
    ///     <para />
    ///     GLFW copies the callback pointers before this function returns; the wrapper keeps the managed delegates
    ///     rooted for the remaining lifetime of the process, so the caller does not need to hold references to them.
    ///     <para />
    ///     This function may be called before <see cref="Init" />.
    /// </remarks>
    /// <param name="allocate">The memory allocation callback. Must return a valid pointer or <c>null</c> to signal failure.</param>
    /// <param name="reallocate">The memory reallocation callback.</param>
    /// <param name="deallocate">The memory deallocation callback.</param>
    /// <param name="user">An opaque pointer passed back to every callback invocation.</param>
    /// <exception cref="ArgumentNullException">Any of the three callbacks is <c>null</c>.</exception>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#init_allocator">Custom heap memory allocator</seealso>
    public static void InitAllocator(
        GlfwAllocateUnmanagedCallback allocate,
        GlfwReallocateUnmanagedCallback reallocate,
        GlfwDeallocateUnmanagedCallback deallocate,
        void* user = null
    )
    {
        ArgumentNullException.ThrowIfNull(allocate);
        ArgumentNullException.ThrowIfNull(reallocate);
        ArgumentNullException.ThrowIfNull(deallocate);

        AllocatorCallbacks.Add(allocate);
        AllocatorCallbacks.Add(reallocate);
        AllocatorCallbacks.Add(deallocate);

        var allocator = new GlfwAllocator
        {
            AllocateCallback = Marshal.GetFunctionPointerForDelegate(allocate),
            ReallocateCallback = Marshal.GetFunctionPointerForDelegate(reallocate),
            DeallocateCallback = Marshal.GetFunctionPointerForDelegate(deallocate),
            User = user,
        };

        PInvoke.InitAllocator(&allocator);
    }

    /// <summary>Initializes the GLFW library.</summary>
    /// <remarks>
    ///     This function initializes the GLFW library. Before most GLFW functions can be used, GLFW must be initialized,
    ///     and before an application terminates GLFW should be terminated in order to free any resources allocated during
    ///     or after initialization.
    ///     <para />
    ///     If this function fails, it calls <see cref="Terminate" /> before returning. If it succeeds, you should call
    ///     <see cref="Terminate" /> before the application exits.
    ///     <para />
    ///     Additional calls to this function after successful initialization but before termination will return
    ///     <c>true</c> immediately.
    /// </remarks>
    /// <returns><c>true</c> if successful, or <c>false</c> if an error occurred.</returns>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#intro_init">Initialization and termination</seealso>
    public static bool Init()
    {
        if (Initialized)
            return true;

        Initialized = PInvoke.Init() == Constants.GLFW_TRUE;
        if (Initialized)
        {
            PInvoke.SetMonitorCallback(MonitorUnmanagedCallback);
            PInvoke.SetJoystickCallback(JoystickUnmanagedCallback);
        }

        return Initialized;
    }

    /// <summary>Terminates the GLFW library.</summary>
    /// <remarks>
    ///     This function destroys all remaining windows and cursors, restores any modified gamma ramps and frees any
    ///     other allocated resources. Once this function is called, you must again call <see cref="Init" /> successfully
    ///     before you will be able to use most GLFW functions.
    ///     <para />
    ///     If GLFW has been successfully initialized, this function should be called before the application exits.
    ///     If initialization fails, there is no need to call this function, as it is called by <see cref="Init" /> before
    ///     it returns failure
    ///     <para />
    ///     This function has no effect if GLFW is not initialized.
    /// </remarks>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#intro_init">Initialization and termination</seealso>
    public static void Terminate()
    {
        if (Initialized)
        {
            PInvoke.Terminate();
            Initialized = false;
        }
    }

    public struct VersionInfo
    {
        public int Major;
        public int Minor;
        public int Revision;
    }

    /// <summary>Retrieves the version of the GLFW library.</summary>
    /// <remarks>
    ///     This function retrieves the major, minor and revision numbers of the GLFW library. It is intended for when you
    ///     are using GLFW as a shared library and want to ensure that you are using the minimum required version.
    ///     <para />
    ///     This function may be called before <see cref="Init" />
    /// </remarks>
    /// <returns>Major, Minor, Revision.</returns>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#intro_version">Version management</seealso>
    /// <threadSafety>This function may be called from any thread.</threadSafety>
    public static VersionInfo Version
    {
        get
        {
            PInvoke.GetVersion(out var major, out var minor, out var rev);
            return new VersionInfo
            {
                Major = major,
                Minor = minor,
                Revision = rev,
            };
        }
    }

    /// <summary>Returns a string describing the compile-time configuration.</summary>
    /// <threadSafety>This function may be called from any thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/intro_guide.html#intro_version">Version management</seealso>
    // glfwGetVersionString always returns a valid static string, so the null-preserving marshaller's
    // nullable return can be safely forgiven here.
    public static string VersionString => PInvoke.GetVersionString()!;
}
