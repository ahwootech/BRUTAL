namespace Brutal.SdlApi;

/// <summary>
/// A managed SDL event-watch callback registered with <see cref="Sdl.Events.AddEventWatch"/>.
/// Receives each event as it is added to the queue, by reference so the handler can inspect it.
/// </summary>
/// <remarks>
/// SDL ignores the return value of an event watch; the <c>bool</c> return exists to mirror SDL's
/// <c>SDL_EventFilter</c> shape and reserve the same signature for a future filter overload.
/// </remarks>
/// <param name="ev">The event being delivered, by reference.</param>
/// <returns><c>true</c> to indicate the event should be kept (ignored for watches).</returns>
public delegate bool SdlEventWatch(ref SdlEvent ev);

public static unsafe partial class Sdl
{
    public static unsafe partial class Events
    {
        // Registered event watches, keyed by the managed delegate the caller passed. The GCHandle
        // roots the delegate for as long as SDL holds the native function pointer, and its IntPtr is
        // the userdata SDL threads back to the trampoline so it can dispatch to the right delegate.
        // SDL_RemoveEventWatch matches on (function pointer, userdata), so the same handle value must
        // be handed back on removal — hence the map. Guarded by a lock because SDL permits adding and
        // removing watches from any thread.
        private static readonly Dictionary<SdlEventWatch, GCHandle> Watches = new();
        private static readonly Lock WatchLock = new();

        /// <summary>
        /// Polls for the next pending event, removing it from the queue.
        /// </summary>
        /// <remarks>
        /// Registered event watches fire synchronously while SDL processes the queue during this
        /// call. Any exception they raise is captured (it cannot cross the native boundary) and
        /// rethrown here, after the poll completes, via the shared
        /// <see cref="Sdl.ExceptionAggregator"/>.
        /// </remarks>
        /// <param name="ev">Receives the next event, or a zeroed event when none is pending.</param>
        /// <returns><c>true</c> if an event was dequeued; otherwise <c>false</c>.</returns>
        /// <exception cref="Exception">A single event-watch callback threw.</exception>
        /// <exception cref="AggregateException">More than one event-watch callback threw.</exception>
        public static bool PollEvent(out SdlEvent ev)
        {
            ev = default;

            bool dequeued;
            fixed (SdlEvent* p = &ev)
                dequeued = PInvoke.PollEvent(p) != 0;

            Sdl.ExceptionAggregator.CheckExceptions();
            return dequeued;
        }

        /// <summary>
        /// Registers <paramref name="callback"/> to be invoked for every event added to the queue.
        /// </summary>
        /// <remarks>
        /// The delegate is rooted for the lifetime of the registration (SDL retains the native
        /// function pointer), and its invocations are wrapped so that any exception is routed to the
        /// aggregator and rethrown from the next <see cref="PollEvent(out SdlEvent)"/> rather than
        /// unwinding across native code. Registering the same delegate twice is a no-op.
        /// </remarks>
        /// <param name="callback">The watch to register.</param>
        /// <exception cref="ArgumentNullException"><paramref name="callback"/> is <c>null</c>.</exception>
        /// <exception cref="SdlException">SDL failed to register the watch.</exception>
        public static void AddEventWatch(SdlEventWatch callback)
        {
            ArgumentNullException.ThrowIfNull(callback);

            lock (WatchLock)
            {
                if (Watches.ContainsKey(callback))
                    return;

                var handle = GCHandle.Alloc(callback);
                if (PInvoke.AddEventWatch(&EventWatchTrampoline, (void*)GCHandle.ToIntPtr(handle)) == 0)
                {
                    handle.Free();
                    throw SdlException.FromError("SDL_AddEventWatch failed");
                }

                Watches[callback] = handle;
            }
        }

        /// <summary>
        /// Unregisters a watch previously added with <see cref="AddEventWatch"/> and releases the
        /// delegate it was keeping alive. Does nothing if the delegate was not registered.
        /// </summary>
        /// <param name="callback">The watch to remove.</param>
        /// <exception cref="ArgumentNullException"><paramref name="callback"/> is <c>null</c>.</exception>
        public static void RemoveEventWatch(SdlEventWatch callback)
        {
            ArgumentNullException.ThrowIfNull(callback);

            lock (WatchLock)
            {
                if (!Watches.Remove(callback, out var handle))
                    return;

                PInvoke.RemoveEventWatch(&EventWatchTrampoline, (void*)GCHandle.ToIntPtr(handle));
                handle.Free();
            }
        }

        // Removes every registered watch and frees the GCHandle rooting each delegate. Called during
        // Sdl.Init.Quit teardown: SDL_Quit drops the native watch list wholesale, so without this the
        // GCHandles would leak and — worse — a subsequent re-init + re-AddEventWatch of the same
        // delegate would be a silent no-op (the managed map still believed it was registered). By
        // clearing the map here, add→Quit→re-init→re-add works. (F3)
        internal static void ClearWatches()
        {
            lock (WatchLock)
            {
                foreach (var (_, handle) in Watches)
                {
                    // Remove the native registration first (still valid pre-SDL_Quit), then release
                    // the managed root. Both are matched on (function pointer, userdata).
                    PInvoke.RemoveEventWatch(&EventWatchTrampoline, (void*)GCHandle.ToIntPtr(handle));
                    handle.Free();
                }

                Watches.Clear();
            }
        }

        // The single native entry point for every registered watch. SDL passes the GCHandle IntPtr
        // back as userdata; we resolve it to the managed delegate and invoke it inside a try/catch so
        // no exception ever escapes into native code. Failures are parked in the aggregator and
        // rethrown from the next PollEvent.
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static byte EventWatchTrampoline(void* userdata, SdlEvent* ev)
        {
            try
            {
                var handle = GCHandle.FromIntPtr((nint)userdata);
                if (handle.Target is SdlEventWatch filter)
                    return filter(ref *ev) ? (byte)1 : (byte)0;

                // The handle resolved but its target is not one of our watches: it was freed (dead)
                // or belongs to some other subsystem (foreign). Falling through silently would hide a
                // real lifecycle bug, so surface it through the aggregator rather than swallowing it.
                Sdl.ExceptionAggregator.Push(
                    "An SDL event watch fired with a dead or foreign GCHandle (its target was not an "
                        + "SdlEventWatch); the callback was skipped."
                );
            }
            catch (Exception ex)
            {
                Sdl.ExceptionAggregator.Push("An exception occurred in an SDL event watch callback.", ex);
            }

            // Event watches ignore the return value; permit by default.
            return 1;
        }
    }
}
