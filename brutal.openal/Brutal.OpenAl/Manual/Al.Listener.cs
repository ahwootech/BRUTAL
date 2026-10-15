// The hand-written half of Al.Listener: only Orientation, the 6-float fv pair (two float3s in one
// native array - no generated property shape). The scalar/3f properties (Gain, Position, Velocity,
// MetersPerUnit) are generated - see Generated/Al/Al.Listener.Properties.gen.cs.

namespace Brutal.OpenAlApi;

public static unsafe partial class Al
{
    /// <summary>
    ///     The listener - the single per-context point OpenAL renders audio for. Accessors act on the
    ///     context current on the calling thread.
    /// </summary>
    /// <remarks>
    ///     For parameter access keyed by enum, see
    ///     <see cref="Brutal.OpenAlApi.Params.ListenerParams"/>.
    /// </remarks>
    public static partial class Listener
    {
        /// <summary>
        ///     Gets/sets the listener's orientation (<c>AL_ORIENTATION</c>): an "at" (forward)
        ///     vector and an "up" vector.
        /// </summary>
        public static (float3 At, float3 Up) Orientation
        {
            get
            {
                var v = stackalloc float[6];
                PInvoke.GetListenerfv(Constants.AL_ORIENTATION, v);
                return (new float3(v[0], v[1], v[2]), new float3(v[3], v[4], v[5]));
            }
            set
            {
                var v = stackalloc float[6] { value.At.X, value.At.Y, value.At.Z, value.Up.X, value.Up.Y, value.Up.Z };
                PInvoke.Listenerfv(Constants.AL_ORIENTATION, v);
            }
        }
    }
}
