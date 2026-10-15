namespace Brutal.Numerics;

/// <summary>
///     Manages colour globals, and some utilities
/// </summary>
public static partial class Color
{
    /// <summary>
    ///     Struct storing a default colour value in a variety of formats
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct Preset
    {
        /// <summary>
        ///     Construct a preset from a float4 colour
        /// </summary>
        /// <param name="color">color</param>
        public Preset(float4 color)
        {
            AsFloat4 = color;

            AsUShort4 = ushort4.Pack(AsFloat4, Pack.Float.Normalize);
            AsByte4 = byte4.Pack(AsFloat4, Pack.Float.Normalize);
        }

        [FieldOffset(0)]
        public readonly float4 AsFloat4;

        [FieldOffset(0)]
        public readonly float3 AsFloat3;

        [FieldOffset(16)]
        public readonly ushort4 AsUShort4;

        [FieldOffset(16)]
        public readonly ushort3 AsUShort3;

        [FieldOffset(24)]
        public readonly byte4 AsByte4;

        [FieldOffset(24)]
        public readonly byte3 AsByte3;

        public static implicit operator byte3(in Preset preset)
        {
            return preset.AsByte3;
        }

        public static implicit operator byte4(in Preset preset)
        {
            return preset.AsByte4;
        }

        public static implicit operator ushort3(in Preset preset)
        {
            return preset.AsUShort3;
        }

        public static implicit operator ushort4(in Preset preset)
        {
            return preset.AsUShort4;
        }

        public static implicit operator float3(in Preset preset)
        {
            return preset.AsFloat3;
        }

        public static implicit operator float4(in Preset preset)
        {
            return preset.AsFloat4;
        }

        public static implicit operator Preset(in float4 vector)
        {
            return new Preset(vector);
        }

        public static implicit operator Preset(in float3 vector)
        {
            return new Preset(new float4(vector, 1));
        }

        public static implicit operator Preset(in byte3 vector)
        {
            return new byte4(vector, byte.MaxValue);
        }

        public static implicit operator Preset(in byte4 vector)
        {
            return new Preset(float4.Unpack(vector, Unpack.Float.Normalize));
        }

        public static implicit operator Preset(in ushort3 vector)
        {
            return new ushort4(vector, ushort.MaxValue);
        }

        public static implicit operator Preset(in ushort4 vector)
        {
            return new Preset(float4.Unpack(vector, Unpack.Float.Normalize));
        }
    }
}
