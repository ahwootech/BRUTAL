namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    public static unsafe partial class Gamepad
    {
        // SDL_GetGamepadTouchpadFinger's generated ergonomic wrapper (Phase 1 Task 5) promoted the
        // `float* x`/`y`/`pressure` out-parameters but left `bool* down` as a raw `byte*`: the
        // generic out-promotion in Generator.Libraries.cs deliberately excludes a bool pointee
        // (IsPureOutPointer's Bool case) because SDL's 1-byte C bool needs a shadow-byte-then-`!= 0`
        // conversion on the way back out, not the direct address-of-out that pipeline does for
        // scalar/enum pointees. This hand-written wrapper finishes the job: a fully `out bool`
        // signature, calling the existing raw `PInvoke.GetGamepadTouchpadFinger` (no new
        // `[LibraryImport]` here — the raw layer already binds `SDL_GetGamepadTouchpadFinger`).
        /// <summary>
        /// Gets the current state of a finger on a touchpad on a gamepad.
        /// </summary>
        /// <param name="gamepad">A gamepad.</param>
        /// <param name="touchpad">A touchpad.</param>
        /// <param name="finger">A finger.</param>
        /// <param name="down">Filled with <see langword="true"/> if the finger is down, <see langword="false"/> otherwise.</param>
        /// <param name="x">Filled with the x position, normalized 0 to 1, with the origin in the upper left.</param>
        /// <param name="y">Filled with the y position, normalized 0 to 1, with the origin in the upper left.</param>
        /// <param name="pressure">Filled with the pressure value.</param>
        /// <returns><see langword="true"/> on success, <see langword="false"/> on failure; call <see cref="Sdl.PInvoke.GetError"/> for more information.</returns>
        public static bool GetGamepadTouchpadFinger(
            SdlGamepad gamepad,
            int touchpad,
            int finger,
            out bool down,
            out float x,
            out float y,
            out float pressure
        )
        {
            // Pre-zero the bool shadow byte alongside the three float out-params: on failure SDL writes
            // NONE of *down/*x/*y/*pressure (verified in SDL_gamepad.c's SDL_GetGamepadTouchpadFinger —
            // every failure path returns false before touching the out-pointers), so an uninitialized
            // downByte would leave `out down` reading stack garbage. `= 0` makes it deterministically
            // false on the failure path, mirroring the `= default` treatment of the floats.
            byte downByte = 0;
            bool result;
            x = default;
            y = default;
            pressure = default;
            fixed (float* xPtr = &x)
            fixed (float* yPtr = &y)
            fixed (float* pressurePtr = &pressure)
            {
                result =
                    PInvoke.GetGamepadTouchpadFinger(gamepad, touchpad, finger, &downByte, xPtr, yPtr, pressurePtr)
                    != 0;
            }
            down = downByte != 0;
            return result;
        }
    }
}
