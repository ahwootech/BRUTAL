namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    public static unsafe partial class Init
    {
        /// <summary>
        /// Initializes the SDL subsystems selected by <paramref name="flags"/>.
        /// </summary>
        /// <remarks>
        /// This is the throwing, ergonomic entry point that replaces the raw <c>SDL_Init</c> binding
        /// (which stays available only as <see cref="Sdl.PInvoke.Init"/> because the name
        /// <c>Init</c> collides with this enclosing class). The first call into the P/Invoke layer
        /// installs the <see cref="NativeLibrary.SetDllImportResolver"/> that locates the SDL3 shared
        /// library, so no separate registration step is required. Call <see cref="Quit"/> before the
        /// application exits.
        /// </remarks>
        /// <param name="flags">The subsystems to initialize.</param>
        /// <exception cref="SdlException">SDL failed to initialize; the message carries the <c>SDL_GetError</c> text.</exception>
        public static void Initialize(SdlInitFlags flags)
        {
            // SDL_Init returns SDL bool (false = failure), rendered as a byte by the raw layer.
            if (PInvoke.Init(flags) == 0)
                throw SdlException.FromError("SDL_Init failed");
        }

        /// <summary>
        /// Cleans up all initialized SDL subsystems (<c>SDL_Quit</c>). Safe to call even if
        /// <see cref="Initialize"/> was never called.
        /// </summary>
        /// <remarks>
        /// This hand-written wrapper replaces the generated one so it can tear down the binding's
        /// managed state before handing control to native SDL: every registered event watch is
        /// removed and its rooting <see cref="GCHandle"/> freed, and any parked callback exceptions
        /// are discarded. <c>SDL_Quit</c> drops SDL's native watch list wholesale, so skipping this
        /// would leak the handles and leave the managed watch map out of sync with native reality —
        /// a later re-init and re-registration of the same delegate would silently do nothing.
        /// </remarks>
        public static void Quit()
        {
            Events.ClearWatches();
            Sdl.ExceptionAggregator.Clear();
            PInvoke.Quit();
        }
    }
}
