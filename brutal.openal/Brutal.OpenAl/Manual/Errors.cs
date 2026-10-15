// The per-category error model. OpenAL has no per-call return code; errors are read from:
//
//   AL   (alGetError)            : per-context, per-thread, first error wins. With no current context,
//                                  openal-soft returns AL_INVALID_OPERATION (not AL_NO_ERROR).
//   ALC  (alcGetError(device))   : per-device, last error wins. Valid only while the device is open -
//                                  never query a device after a successful close (it is freed).
//   ALC  (alcGetError(NULL))     : global, for failures not attributable to an open device.
//
// GetError(...) reads without throwing; ThrowIfError(...) reads and throws. Wrapper methods never check
// errors automatically - the consumer decides when. The exception is lifetime operations whose failure
// is signaled by a return value (open/create/close/make-current): they check and throw internally, but
// only once, on that failure path.

namespace Brutal.OpenAlApi
{
    /// <summary>An error reported by the core AL error state (<c>alGetError</c>).</summary>
    public sealed class AlException : Exception
    {
        /// <summary>Creates an AL exception carrying the error code.</summary>
        public AlException(AlError error, string message)
            : base(message) => Error = error;

        /// <summary>The AL error code.</summary>
        public AlError Error { get; }
    }

    public static partial class Al
    {
        /// <summary>
        ///     Reads and clears the AL error for the current thread/context (<c>alGetError</c>),
        ///     without throwing. With no context current, openal-soft returns
        ///     <see cref="AlError.InvalidOperation"/> rather than <see cref="AlError.NoError"/>.
        /// </summary>
        public static AlError GetError() => (AlError)PInvoke.GetError();

        /// <summary>
        ///     Reads and clears the AL error, throwing <see cref="AlException"/> if one was set.
        ///     Never called automatically by wrapper methods - call it yourself, for example after
        ///     initialization, after loading a resource, and per-frame in debug builds.
        /// </summary>
        public static void ThrowIfError()
        {
            var e = GetError();
            if (e != AlError.NoError)
                throw new AlException(e, Describe(e));
        }

        private static string Describe(AlError e) =>
            e switch
            {
                AlError.InvalidName => "AL_INVALID_NAME: a bad object name was passed.",
                AlError.InvalidEnum => "AL_INVALID_ENUM: an invalid enum was passed.",
                AlError.InvalidValue => "AL_INVALID_VALUE: an invalid value was passed.",
                AlError.InvalidOperation => "AL_INVALID_OPERATION: not allowed in the current state "
                    + "(this is also what a checked AL call reports when no context is current).",
                AlError.OutOfMemory => "AL_OUT_OF_MEMORY: the driver ran out of memory.",
                _ => $"AL error 0x{(int)e:X4}.",
            };
    }

    /// <summary>An error reported by the ALC error state (<c>alcGetError</c>).</summary>
    public sealed class AlcException : Exception
    {
        /// <summary>Creates an ALC exception carrying the error code.</summary>
        public AlcException(AlcError error, string message)
            : base(message) => Error = error;

        /// <summary>The ALC error code.</summary>
        public AlcError Error { get; }
    }

    public static unsafe partial class Alc
    {
        /// <summary>
        ///     Reads and clears the global ALC error (<c>alcGetError(NULL)</c>), without throwing.
        ///     The global latch records failures not attributable to an open device; per-device
        ///     errors are read with <see cref="Device.GetError"/> /
        ///     <see cref="CaptureDevice.GetError"/>.
        /// </summary>
        public static AlcError GetError() => (AlcError)PInvoke.GetError(AlcDevice.Null);

        /// <summary>
        ///     Reads and clears the global ALC error, throwing <see cref="AlcException"/> if one was
        ///     set. Never called automatically by wrapper methods, as with <see cref="Al.ThrowIfError"/>.
        /// </summary>
        public static void ThrowIfError()
        {
            var e = GetError();
            if (e != AlcError.NoError)
                throw new AlcException(e, Describe(e));
        }

        // Per-device latch reads, as plumbing for the wrapper layer: the public forms are the
        // instance methods on Device/CaptureDevice, which also guard disposed handles (alcGetError
        // on a closed device reads freed memory). Raw-interop callers use Alc.PInvoke directly.
        internal static AlcError GetError(AlcDevice device) => (AlcError)PInvoke.GetError(device);

        internal static AlcError GetError(AlcCaptureDevice capture) =>
            (AlcError)PInvoke.GetError((void*)capture.Pointer.Value);

        internal static void ThrowIfError(AlcDevice device)
        {
            var e = GetError(device);
            if (e != AlcError.NoError)
                throw new AlcException(e, Describe(e));
        }

        internal static void ThrowIfError(AlcCaptureDevice capture)
        {
            var e = GetError(capture);
            if (e != AlcError.NoError)
                throw new AlcException(e, Describe(e));
        }

        private static string Describe(AlcError e) =>
            e switch
            {
                AlcError.InvalidDevice => "ALC_INVALID_DEVICE: an invalid or closed device handle was used.",
                AlcError.InvalidContext => "ALC_INVALID_CONTEXT: an invalid context handle was used.",
                AlcError.InvalidEnum => "ALC_INVALID_ENUM: an invalid enum was passed.",
                AlcError.InvalidValue => "ALC_INVALID_VALUE: an invalid value was passed.",
                AlcError.OutOfMemory => "ALC_OUT_OF_MEMORY: the driver ran out of memory.",
                _ => $"ALC error 0x{(int)e:X4}.",
            };
    }
}
