using System.Globalization;
using CommunityToolkit.HighPerformance;
using Backend32 = System.Int32;
using Backend64 = System.Int64;
using Backend8 = System.Byte;

namespace Brutal;

/// An argument meant to be passed to a C++ variadic function,
/// in <a href="https://en.cppreference.com/w/cpp/utility/variadic/va_list.html">va_list</a> flavor, eg vprintf.
public readonly struct VariadicArgument
{
    public readonly TypeCode Type;
    public readonly Backend64 Value64;
    public readonly string? ValueString;

    private VariadicArgument(TypeCode type, Backend64 value)
    {
        Type = type;
        Value64 = value;
    }

    public VariadicArgument(string? value)
    {
        Type = TypeCode.String;
        ValueString = value;
    }

    public static implicit operator VariadicArgument(Char16 value) => new(TypeCode.Char, (Char8)value);

    public static implicit operator VariadicArgument(int value) => new(TypeCode.Int32, As<int, Backend32>(value));

    public static implicit operator VariadicArgument(uint value) => new(TypeCode.UInt32, As<uint, Backend32>(value));

    public static implicit operator VariadicArgument(long value) => new(TypeCode.Int64, As<long, Backend64>(value));

    public static implicit operator VariadicArgument(ulong value) => new(TypeCode.UInt64, As<ulong, Backend64>(value));

    public static implicit operator VariadicArgument(float value) => new(TypeCode.Single, As<double, Backend64>(value));

    public static implicit operator VariadicArgument(double value) =>
        new(TypeCode.Double, As<double, Backend64>(value));

    public static implicit operator VariadicArgument(string? arg) => new(arg);

    public static VariadicArgument Convert(object o) =>
        o switch
        {
            Char16 v => v,
            int v => v,
            uint v => v,
            long v => v,
            ulong v => v,
            float v => v,
            double v => v,
            string v => v,
            _ => throw new ArgumentException($"type {o.GetType()} not supported"),
        };

    #region debugging

    Backend8 Value8 => (Backend8)Value64;
    Backend32 Value32 => (Backend32)Value64;

    public Char16 AsChar16 => (Char16)Value8;
    public int AsInt => As<Backend32, int>(Value32);
    public uint AsUint => As<Backend32, uint>(Value32);
    public long AsLong => As<Backend64, long>(Value64);
    public ulong AsUlong => As<Backend64, ulong>(Value64);
    public float AsFloat => (float)As<Backend64, double>(Value64);
    public double AsDouble => As<Backend64, double>(Value64);
    public string? AsString => ValueString;

    int BackendSize =>
        Type switch
        {
            TypeCode.Char => sizeof(Backend8),

            TypeCode.Int32 => sizeof(Backend32),
            TypeCode.UInt32 => sizeof(Backend32),

            TypeCode.Int64 => sizeof(Backend64),
            TypeCode.UInt64 => sizeof(Backend64),
            TypeCode.Single => sizeof(Backend64),
            TypeCode.Double => sizeof(Backend64),

            TypeCode.String => sizeof(Backend64),

            _ => throw new ArgumentOutOfRangeException(),
        };

    private int StringSize => ValueString != null ? Utf8.GetByteCount(ValueString) + 1 : 0;

    public int Size => sizeof(Backend64) + StringSize;

    public string ValueToString =>
        Type switch
        {
            TypeCode.Char => AsChar16.ToString(),
            TypeCode.Int32 => AsInt.ToString(),
            TypeCode.UInt32 => AsUint.ToString(),
            TypeCode.Int64 => AsLong.ToString(),
            TypeCode.UInt64 => AsUlong.ToString(),
            TypeCode.Single => AsFloat.ToString(CultureInfo.InvariantCulture),
            TypeCode.Double => AsDouble.ToString(CultureInfo.InvariantCulture),
            TypeCode.String => AsString ?? "<null>",
            _ => throw new ArgumentOutOfRangeException(),
        };

    public override string ToString()
    {
        return $"{Type} ({BackendSize}): {ValueToString}";
    }

    #endregion

    public void CopyTo(ref Backend64 vaList, ref Span<byte> stringBuffer)
    {
        switch (Type)
        {
            case TypeCode.Char:
            case TypeCode.Int32:
            case TypeCode.UInt32:
            case TypeCode.Int64:
            case TypeCode.UInt64:
            case TypeCode.Single:
            case TypeCode.Double:
            {
                vaList = Value64;
                return;
            }
            case TypeCode.String:
            {
                if (ValueString == null)
                    return;

                // add the pointer to the string buffer
                vaList = (Backend64)stringBuffer.AsPtr();

                // add the string
                var stringSize = Utf8.GetBytes(ValueString, stringBuffer);
                stringBuffer[stringSize] = 0; // null-terminator
                stringBuffer = stringBuffer[(stringSize + 1)..];
                return;
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(Type), Type, null);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static TTo As<TFrom, TTo>(TFrom source)
        where TFrom : allows ref struct
        where TTo : allows ref struct
    {
        return Unsafe.As<TFrom, TTo>(ref source);
    }
}

/// Utility to interop variadic arguments to a C++ <a href="https://en.cppreference.com/w/cpp/utility/variadic/va_list.html">va_list</a>, eg vprintf.
/// Usage: GetSize(), stackalloc, Pack().
public static class VaList
{
    /*
     * va_list ABI layout:
     * - [VaListHeader, if Linux / System V ABI]
     *   (contains a pointer to the argument list below)
     * - 64 bits-aligned span of arguments (ints, floats, string pointers, ...)
     *   (this is the old school C ABI format)
     * - [string buffers (if any), each null-terminated]
     */

    private static readonly int headerSize = Platform.IsLinux ? Unsafe.SizeOf<VaListHeader>() : 0;

    /// Compute the size of a va_list for this set of arguments.
    /// stackalloc a byte array of the returned size, and pass it to <see cref="Pack"/>.
    /// <param name="args">The arguments to interop / compute size for.</param>
    public static int GetSize(ReadOnlySpan<VariadicArgument> args)
    {
        var argsSize = headerSize;
        foreach (var arg in args)
            argsSize += arg.Size;
        return argsSize;
    }

    /// Pack the given arguments to a va_list that can be interop'd to C++.
    /// <param name="buffer">A buffer you stackalloc'd use the size returned by <see cref="GetSize"/></param>
    /// <param name="args">The arguments to interop / pack.</param>
    /// <returns>The buffer you passed in, with arguments packed in.</returns>
    public static Span<byte> Pack(Span<byte> buffer, ReadOnlySpan<VariadicArgument> args)
    {
        // argument buffer, 64-bits aligned
        var vaListSize = args.Length * sizeof(Backend64);
        var vaList = buffer.Slice(headerSize, vaListSize).Cast<byte, Backend64>();

        // string buffers, if any
        var stringBuffer = buffer[(headerSize + vaListSize)..];

        if (headerSize > 0)
        {
            unsafe
            {
                // va_list header, if the platform ABI requires it
                ref var header = ref buffer.Cast<byte, VaListHeader>()[0];
                header = new VaListHeader(vaList.AsPointer());
            }
        }

        for (var i = 0; i < args.Length; i++)
        {
            args[i].CopyTo(ref vaList[i], ref stringBuffer);
        }

        return buffer;
    }

    /// The va_list structure of <a href="https://blog.nelhage.com/2010/10/amd64-and-va_arg/">System V ABI</a> (Linux x64).
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    private readonly unsafe struct VaListHeader
    {
        private readonly uint gp_offset;
        private readonly uint fp_offset;
        private readonly void* overflow_arg_area;
        private readonly void* reg_save_area;

        /// Wrap the given arguments in a header structure.
        /// <param name="va_list">A pointer to the arguments already packed in C ABI format.</param>
        public VaListHeader(void* va_list)
        {
            /*
             * This ABI tries to put arguments in registers if any are left, then pushes the rest on the stack.
             * We bypass the register mechanism by maxing out the offsets, then put everything in the overflow area.
             *
             * Source: https://stackoverflow.com/questions/11695237/creating-va-list-dynamically-in-gcc-can-it-be-done/30632712#30632712
             * The va_args() macro will read from the overflow area:
             * - if the gp_offset is greater than or equal to 48 (6 gp registers * 8 bytes/register)
             * - and the fp_offset is greater than or equal to 304 (gp_offset +16 fp registers * 16 bytes/register)
             */
            gp_offset = 48;
            fp_offset = 304;
            reg_save_area = null;
            overflow_arg_area = va_list;
        }
    }
}
