namespace Brutal.SdlApi;

/// <summary>
/// A mapping between one joystick input and a gamepad control (<c>SDL_GamepadBinding</c>).
/// </summary>
/// <remarks>
/// <para>
/// Hand-written rather than generated: the native <c>SDL_GamepadBinding</c> struct contains two
/// anonymous nested unions (<c>input</c>, <c>output</c>), which the generator's struct pass cannot
/// mirror as a flat blittable type (see <c>Generated/SKIPPED.md</c>'s "Skipped struct types"
/// section). This explicit-layout struct reproduces the native field offsets by hand instead, so
/// Task 4's <see cref="Sdl.Gamepad.GetGamepadBindings"/> can copy the native bytes directly via a
/// pointer cast.
/// </para>
/// <para>
/// Layout (verified against <c>SDL_gamepad.h</c>): <c>input_type</c> (4 bytes) at offset 0; the
/// <c>input</c> union (its largest member, the axis triple of three <c>int</c>s, is 12 bytes) at
/// offset 4; <c>output_type</c> (4 bytes) at offset 16; the <c>output</c> union (again a 12-byte
/// axis triple at its largest) at offset 20. Total size 32 bytes, 4-byte aligned, no trailing
/// padding needed.
/// </para>
/// </remarks>
[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct SdlGamepadBinding
{
    /// <summary>Which kind of joystick input <see cref="InputButton"/>/<see cref="InputAxis"/>/<see cref="InputHat"/> describes.</summary>
    [FieldOffset(0)]
    public SdlGamepadBindingType InputType;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Button"/>.</summary>
    [FieldOffset(4)]
    public int InputButton;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(4)]
    public int InputAxis;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(8)]
    public int InputAxisMin;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(12)]
    public int InputAxisMax;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Hat"/>.</summary>
    [FieldOffset(4)]
    public int InputHat;

    /// <summary>Valid when <see cref="InputType"/> is <see cref="SdlGamepadBindingType.Hat"/>.</summary>
    [FieldOffset(8)]
    public int InputHatMask;

    /// <summary>Which kind of gamepad control <see cref="OutputButton"/>/<see cref="OutputAxis"/> describes.</summary>
    [FieldOffset(16)]
    public SdlGamepadBindingType OutputType;

    /// <summary>Valid when <see cref="OutputType"/> is <see cref="SdlGamepadBindingType.Button"/>.</summary>
    [FieldOffset(20)]
    public SdlGamepadButton OutputButton;

    /// <summary>Valid when <see cref="OutputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(20)]
    public SdlGamepadAxis OutputAxis;

    /// <summary>Valid when <see cref="OutputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(24)]
    public int OutputAxisMin;

    /// <summary>Valid when <see cref="OutputType"/> is <see cref="SdlGamepadBindingType.Axis"/>.</summary>
    [FieldOffset(28)]
    public int OutputAxisMax;
}
