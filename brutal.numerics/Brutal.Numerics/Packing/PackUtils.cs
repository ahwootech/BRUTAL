namespace Brutal.Numerics;

/// <summary>
///     TODO
/// </summary>
public static class PackModes
{
    /// <summary>
    ///     Will simply cast the value into the new target type, maintaining the original value.
    /// </summary>
    public const int Cast = 0;

    /// <summary>
    ///     Will clamp the original value onto the range of the target type before casting.
    /// </summary>
    public const int Clamp = 1;

    /// <summary>
    ///     Will map the value to the range [0, 1] and then multiply by the max value of the target type.
    ///     The value should be in the range [0, 1] for unsigned conversions, and [-1, 1] for signed conversions.
    ///     Invalid for integer to integer conversions.
    /// </summary>
    public const int Normalize = 2;

    /// <summary>
    ///     For floating-point to integer conversions, we will round to the nearest integer.
    ///     Invalid for integer to integer conversions.
    /// </summary>
    public const int Round = 3;

    /// <summary>
    ///     For floating-point to integer conversions, we will clamp to the target range and then truncate the decimal part.
    ///     Invalid for integer to integer conversions.
    /// </summary>
    public const int Floor = 4;
}

public static class Pack
{
    /// <summary>
    ///     TODO
    /// </summary>
    public enum Float
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Truncate = PackModes.Cast,

        /// <inheritdoc cref="PackModes.Clamp" />
        Clamp = PackModes.Clamp,

        /// <inheritdoc cref="PackModes.Normalize" />
        Normalize = PackModes.Normalize,

        /// <inheritdoc cref="PackModes.Round" />
        Round = PackModes.Round,

        /// <inheritdoc cref="PackModes.Floor" />
        Floor = PackModes.Floor,
    }

    /// <summary>
    ///     TODO
    /// </summary>
    public enum Integer
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Cast = PackModes.Cast,

        /// <inheritdoc cref="PackModes.Clamp" />
        Clamp = PackModes.Clamp,

        /// <inheritdoc cref="PackModes.Normalize" />
        Scale = PackModes.Normalize,
    }

    /// <summary>
    ///     TODO
    /// </summary>
    public enum IntegerMixed
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Cast = PackModes.Cast,

        /// <inheritdoc cref="PackModes.Clamp" />
        Clamp = PackModes.Clamp,
    }
}

public static class Unpack
{
    /// <summary>
    ///     TODO
    /// </summary>
    public enum Float
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Cast = PackModes.Cast,

        /// <inheritdoc cref="PackModes.Normalize" />
        Normalize = PackModes.Normalize,
    }

    /// <summary>
    ///     TODO
    /// </summary>
    public enum Integer
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Cast = PackModes.Cast,

        /// <inheritdoc cref="PackModes.Normalize" />
        Scale = PackModes.Normalize,
    }

    /// <summary>
    ///     TODO
    /// </summary>
    public enum IntegerMixed
    {
        /// <inheritdoc cref="PackModes.Cast" />
        Cast = PackModes.Cast,
    }
}

public static class PackUtils
{
    public static class SByte
    {
        public static Func<sbyte, byte> ToByte(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (byte)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, short> ToShort(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => (byte)input,
                Unpack.Integer.Scale => static input =>
                    input > 0
                        ? (short)float.Round(input * (float)short.MaxValue / sbyte.MaxValue)
                        : (short)float.Round(input * (float)short.MinValue / sbyte.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, ushort> ToUShort(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (ushort)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, int> ToInt(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => input,
                Unpack.Integer.Scale => static input => (int)float.Round(input * (float)int.MaxValue / sbyte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, uint> ToUInt(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (byte)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input =>
                    input >= 0 ? input / (float)sbyte.MaxValue : -(input / (float)sbyte.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<sbyte, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input =>
                    input >= 0 ? input / (double)sbyte.MaxValue : -(input / (double)sbyte.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static byte ToByte(sbyte value, Unpack.IntegerMixed mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(sbyte value, Unpack.Integer mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(sbyte value, Unpack.IntegerMixed mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(sbyte value, Unpack.Integer mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(sbyte value, Unpack.IntegerMixed mode)
        {
            return ToUInt(mode)(value);
        }

        public static float ToFloat(sbyte value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(sbyte value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class Byte
    {
        public static Func<byte, sbyte> ToSByte(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (sbyte)input,
                Pack.IntegerMixed.Clamp => static input =>
                    (sbyte)byte.Clamp(input, byte.MinValue, (byte)sbyte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, short> ToShort(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, ushort> ToUShort(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => input,
                Unpack.Integer.Scale => static input =>
                    (ushort)float.Round(input * (float)ushort.MaxValue / byte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, int> ToInt(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, uint> ToUInt(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => input,
                Unpack.Integer.Scale => static input => (uint)float.Round(input * (float)uint.MaxValue / byte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (float)byte.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<byte, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (double)byte.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(byte value, Pack.IntegerMixed mode)
        {
            return ToSByte(mode)(value);
        }

        public static short ToShort(byte value, Unpack.IntegerMixed mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(byte value, Unpack.Integer mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(byte value, Unpack.IntegerMixed mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(byte value, Unpack.Integer mode)
        {
            return ToUInt(mode)(value);
        }

        public static float ToFloat(byte value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(byte value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class Short
    {
        public static Func<short, sbyte> ToSByte(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (sbyte)input,
                Pack.Integer.Clamp => static input => (sbyte)short.Clamp(input, sbyte.MinValue, sbyte.MaxValue),
                Pack.Integer.Scale => static input =>
                    input > 0
                        ? (sbyte)float.Round(input * (float)sbyte.MaxValue / short.MaxValue)
                        : (sbyte)float.Round(input * (float)sbyte.MinValue / short.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, byte> ToByte(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (byte)input,
                Pack.IntegerMixed.Clamp => static input => (byte)short.Clamp(input, byte.MinValue, byte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, ushort> ToUShort(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (ushort)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, int> ToInt(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => input,
                Unpack.Integer.Scale => static input => (int)float.Round(input * (float)int.MaxValue / short.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, uint> ToUInt(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (uint)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (float)short.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<short, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (double)short.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(short value, Pack.Integer mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(short value, Pack.IntegerMixed mode)
        {
            return ToByte(mode)(value);
        }

        public static ushort ToUShort(short value, Unpack.IntegerMixed mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(short value, Unpack.Integer mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(short value, Unpack.IntegerMixed mode)
        {
            return ToUInt(mode)(value);
        }

        public static float ToFloat(short value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(short value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class UShort
    {
        public static Func<ushort, sbyte> ToSByte(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (sbyte)input,
                Pack.IntegerMixed.Clamp => static input => (sbyte)float.Clamp(input, ushort.MinValue, sbyte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, byte> ToByte(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (byte)input,
                Pack.Integer.Clamp => static input => (byte)ushort.Min(input, byte.MaxValue),
                Pack.Integer.Scale => static input => (byte)float.Round(input * (float)byte.MaxValue / ushort.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, short> ToShort(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (short)input,
                Pack.IntegerMixed.Clamp => static input => (short)float.Clamp(input, ushort.MinValue, short.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, int> ToInt(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, uint> ToUInt(Unpack.Integer mode)
        {
            return mode switch
            {
                Unpack.Integer.Cast => static input => input,
                Unpack.Integer.Scale => static input =>
                    (uint)float.Round(input * (float)uint.MaxValue / ushort.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (float)ushort.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<ushort, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                Unpack.Float.Normalize => static input => input / (double)ushort.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(ushort value, Pack.IntegerMixed mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(ushort value, Pack.Integer mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(ushort value, Pack.IntegerMixed mode)
        {
            return ToShort(mode)(value);
        }

        public static int ToInt(ushort value, Unpack.IntegerMixed mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(ushort value, Unpack.Integer mode)
        {
            return ToUInt(mode)(value);
        }

        public static float ToFloat(ushort value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(ushort value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class Int
    {
        public static Func<int, sbyte> ToSByte(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (sbyte)input,
                Pack.Integer.Clamp => static input => (sbyte)int.Clamp(input, sbyte.MinValue, sbyte.MaxValue),
                Pack.Integer.Scale => static input =>
                    input > 0
                        ? (sbyte)float.Round(input * (float)sbyte.MaxValue / int.MaxValue)
                        : (sbyte)float.Round(input * (float)sbyte.MinValue / int.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, byte> ToByte(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (byte)input,
                Pack.IntegerMixed.Clamp => static input => (byte)int.Clamp(input, byte.MinValue, byte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, short> ToShort(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (short)input,
                Pack.Integer.Clamp => static input => (short)int.Clamp(input, short.MinValue, short.MaxValue),
                Pack.Integer.Scale => static input =>
                    input > 0
                        ? (short)float.Round(input * (float)short.MaxValue / int.MaxValue)
                        : (short)float.Round(input * (float)short.MinValue / int.MinValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, ushort> ToUShort(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (ushort)input,
                Pack.IntegerMixed.Clamp => static input => (ushort)int.Clamp(input, ushort.MinValue, ushort.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, uint> ToUInt(Unpack.IntegerMixed mode)
        {
            return mode switch
            {
                Unpack.IntegerMixed.Cast => static input => (uint)input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static i => i,
                Unpack.Float.Normalize => static i => i / (float)int.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<int, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static i => i,
                Unpack.Float.Normalize => static i => i / (double)int.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(int value, Pack.Integer mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(int value, Pack.IntegerMixed mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(int value, Pack.Integer mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(int value, Pack.IntegerMixed mode)
        {
            return ToUShort(mode)(value);
        }

        public static uint ToUInt(int value, Unpack.IntegerMixed mode)
        {
            return ToUInt(mode)(value);
        }

        public static float ToFloat(int value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(int value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class UInt
    {
        public static Func<uint, sbyte> ToSByte(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (sbyte)input,
                Pack.IntegerMixed.Clamp => static input => (sbyte)float.Clamp(input, uint.MinValue, sbyte.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, byte> ToByte(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (byte)input,
                Pack.Integer.Clamp => static input => (byte)float.Clamp(input, byte.MinValue, byte.MaxValue),
                Pack.Integer.Scale => static input => (byte)float.Round(input * (float)byte.MaxValue / uint.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, short> ToShort(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (short)input,
                Pack.IntegerMixed.Clamp => static input => (short)float.Clamp(input, uint.MinValue, short.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, ushort> ToUShort(Pack.Integer mode)
        {
            return mode switch
            {
                Pack.Integer.Cast => static input => (ushort)input,
                Pack.Integer.Clamp => static input => (ushort)float.Clamp(input, ushort.MinValue, ushort.MaxValue),
                Pack.Integer.Scale => static input =>
                    (ushort)float.Round(input * (float)ushort.MaxValue / uint.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, int> ToInt(Pack.IntegerMixed mode)
        {
            return mode switch
            {
                Pack.IntegerMixed.Cast => static input => (int)input,
                Pack.IntegerMixed.Clamp => static input => (int)float.Clamp(input, uint.MinValue, int.MaxValue),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, float> ToFloat(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static i => i,
                Unpack.Float.Normalize => static i => i / (float)int.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<uint, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static i => i,
                Unpack.Float.Normalize => static i => i / (double)int.MaxValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(uint value, Pack.IntegerMixed mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(uint value, Pack.Integer mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(uint value, Pack.IntegerMixed mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(uint value, Pack.Integer mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(uint value, Pack.IntegerMixed mode)
        {
            return ToInt(mode)(value);
        }

        public static float ToFloat(uint value, Unpack.Float mode)
        {
            return ToFloat(mode)(value);
        }

        public static double ToDouble(uint value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class Float
    {
        public static Func<float, sbyte> ToSByte(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (sbyte)input,
                Pack.Float.Normalize => static input =>
                    (sbyte)float.Min(sbyte.MaxValue, float.Floor(float.Clamp(input, 0, 1) * (sbyte.MaxValue + 1))),
                Pack.Float.Clamp => static input => (sbyte)float.Clamp(input, sbyte.MinValue, sbyte.MaxValue),
                Pack.Float.Round => static input =>
                    (sbyte)float.Round(float.Clamp(input, sbyte.MinValue, sbyte.MaxValue)),
                Pack.Float.Floor => static input =>
                    (sbyte)float.Floor(float.Clamp(input, sbyte.MinValue, sbyte.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, byte> ToByte(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (byte)input,
                Pack.Float.Normalize => static input =>
                    (byte)float.Min(byte.MaxValue, float.Floor(float.Clamp(input, 0, 1) * (byte.MaxValue + 1))),
                Pack.Float.Clamp => static input => (byte)float.Clamp(input, byte.MinValue, byte.MaxValue),
                Pack.Float.Round => static input => (byte)float.Round(float.Clamp(input, byte.MinValue, byte.MaxValue)),
                Pack.Float.Floor => static input => (byte)float.Floor(float.Clamp(input, byte.MinValue, byte.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, short> ToShort(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (short)input,
                Pack.Float.Normalize => static input =>
                    (short)float.Min(short.MaxValue, float.Floor(float.Clamp(input, 0, 1) * (short.MaxValue + 1))),
                Pack.Float.Clamp => static input => (short)float.Clamp(input, short.MinValue, short.MaxValue),
                Pack.Float.Round => static input =>
                    (short)float.Round(float.Clamp(input, short.MinValue, short.MaxValue)),
                Pack.Float.Floor => static input =>
                    (short)float.Floor(float.Clamp(input, short.MinValue, short.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, ushort> ToUShort(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (ushort)input,
                Pack.Float.Normalize => static input =>
                    (ushort)float.Min(ushort.MaxValue, float.Floor(float.Clamp(input, 0, 1) * (ushort.MaxValue + 1))),
                Pack.Float.Clamp => static input => (ushort)float.Clamp(input, ushort.MinValue, ushort.MaxValue),
                Pack.Float.Round => static input =>
                    (ushort)float.Round(float.Clamp(input, ushort.MinValue, ushort.MaxValue)),
                Pack.Float.Floor => static input =>
                    (ushort)float.Floor(float.Clamp(input, ushort.MinValue, ushort.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, int> ToInt(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (int)input,
                Pack.Float.Normalize => static input =>
                    (int)float.Min(int.MaxValue, float.Floor(float.Clamp(input, 0, 1) * ((long)int.MaxValue + 1))),
                Pack.Float.Clamp => static input => (int)float.Clamp(input, int.MinValue, int.MaxValue),
                Pack.Float.Round => static input => (int)float.Round(float.Clamp(input, int.MinValue, int.MaxValue)),
                Pack.Float.Floor => static input => (int)float.Floor(float.Clamp(input, int.MinValue, int.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, uint> ToUInt(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (uint)input,
                Pack.Float.Normalize => static input =>
                    (uint)float.Min(uint.MaxValue, float.Floor(float.Clamp(input, 0, 1) * ((ulong)uint.MaxValue + 1))),
                Pack.Float.Clamp => static input => (uint)float.Clamp(input, uint.MinValue, uint.MaxValue),
                Pack.Float.Round => static input => (uint)float.Round(float.Clamp(input, uint.MinValue, uint.MaxValue)),
                Pack.Float.Floor => static input => (uint)float.Floor(float.Clamp(input, uint.MinValue, uint.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<float, double> ToDouble(Unpack.Float mode)
        {
            return mode switch
            {
                Unpack.Float.Cast => static input => input,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(float value, Pack.Float mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(float value, Pack.Float mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(float value, Pack.Float mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(float value, Pack.Float mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(float value, Pack.Float mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(float value, Pack.Float mode)
        {
            return ToUInt(mode)(value);
        }

        public static double ToDouble(float value, Unpack.Float mode)
        {
            return ToDouble(mode)(value);
        }
    }

    public static class Double
    {
        public static Func<double, sbyte> ToSByte(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (sbyte)input,
                Pack.Float.Normalize => static input => (sbyte)double.Floor(input * sbyte.MaxValue),
                Pack.Float.Clamp => static input => (sbyte)double.Clamp(input, sbyte.MinValue, sbyte.MaxValue),
                Pack.Float.Round => static input =>
                    (sbyte)double.Round(double.Clamp(input, sbyte.MinValue, sbyte.MaxValue)),
                Pack.Float.Floor => static input =>
                    (sbyte)double.Floor(double.Clamp(input, sbyte.MinValue, sbyte.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, byte> ToByte(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (byte)input,
                Pack.Float.Normalize => static input => (byte)double.Floor(input * byte.MaxValue),
                Pack.Float.Clamp => static input => (byte)double.Clamp(input, byte.MinValue, byte.MaxValue),
                Pack.Float.Round => static input =>
                    (byte)double.Round(double.Clamp(input, byte.MinValue, byte.MaxValue)),
                Pack.Float.Floor => static input =>
                    (byte)double.Floor(double.Clamp(input, byte.MinValue, byte.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, short> ToShort(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (short)input,
                Pack.Float.Normalize => static input => (short)double.Floor(input * short.MaxValue),
                Pack.Float.Clamp => static input => (short)double.Clamp(input, short.MinValue, short.MaxValue),
                Pack.Float.Round => static input =>
                    (short)double.Round(double.Clamp(input, short.MinValue, short.MaxValue)),
                Pack.Float.Floor => static input =>
                    (short)double.Floor(double.Clamp(input, short.MinValue, short.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, ushort> ToUShort(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (ushort)input,
                Pack.Float.Normalize => static input => (ushort)double.Floor(input * ushort.MaxValue),
                Pack.Float.Clamp => static input => (ushort)double.Clamp(input, ushort.MinValue, ushort.MaxValue),
                Pack.Float.Round => static input =>
                    (ushort)double.Round(double.Clamp(input, ushort.MinValue, ushort.MaxValue)),
                Pack.Float.Floor => static input =>
                    (ushort)double.Floor(double.Clamp(input, ushort.MinValue, ushort.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, int> ToInt(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (int)input,
                Pack.Float.Normalize => static input => (int)double.Floor(input * int.MaxValue),
                Pack.Float.Clamp => static input => (int)double.Clamp(input, int.MinValue, int.MaxValue),
                Pack.Float.Round => static input => (int)double.Round(double.Clamp(input, int.MinValue, int.MaxValue)),
                Pack.Float.Floor => static input => (int)double.Floor(double.Clamp(input, int.MinValue, int.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, uint> ToUInt(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (uint)input,
                Pack.Float.Normalize => static input => (uint)double.Floor(input * uint.MaxValue),
                Pack.Float.Clamp => static input => (uint)double.Clamp(input, uint.MinValue, uint.MaxValue),
                Pack.Float.Round => static input =>
                    (uint)double.Round(double.Clamp(input, uint.MinValue, uint.MaxValue)),
                Pack.Float.Floor => static input =>
                    (uint)double.Floor(double.Clamp(input, uint.MinValue, uint.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static Func<double, float> ToFloat(Pack.Float mode)
        {
            return mode switch
            {
                Pack.Float.Truncate => static input => (float)input,
                Pack.Float.Normalize => static input => (float)input,
                Pack.Float.Clamp => static input => (float)double.Clamp(input, float.MinValue, float.MaxValue),
                Pack.Float.Round => static input =>
                    (float)double.Round(double.Clamp(input, float.MinValue, float.MaxValue)),
                Pack.Float.Floor => static input =>
                    (float)double.Floor(double.Clamp(input, float.MinValue, float.MaxValue)),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static sbyte ToSByte(double value, Pack.Float mode)
        {
            return ToSByte(mode)(value);
        }

        public static byte ToByte(double value, Pack.Float mode)
        {
            return ToByte(mode)(value);
        }

        public static short ToShort(double value, Pack.Float mode)
        {
            return ToShort(mode)(value);
        }

        public static ushort ToUShort(double value, Pack.Float mode)
        {
            return ToUShort(mode)(value);
        }

        public static int ToInt(double value, Pack.Float mode)
        {
            return ToInt(mode)(value);
        }

        public static uint ToUInt(double value, Pack.Float mode)
        {
            return ToUInt(mode)(value);
        }

        public static double ToFloat(double value, Pack.Float mode)
        {
            return ToFloat(mode)(value);
        }
    }
}
