using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlDeleteStatus : uint
{
    NotDeleted = GL_FALSE,
    Deleted = GL_TRUE,
}

public readonly record struct GlShader(uint Id) : IDisposable
{
    public class CompileException(GlShader shader) : Exception(shader.GetInfoLog());

    private enum Property : uint
    {
        ShaderType = GL_SHADER_TYPE,
        DeleteStatus = GL_DELETE_STATUS,
        CompileStatus = GL_COMPILE_STATUS,
        InfoLogLength = GL_INFO_LOG_LENGTH,
        ShaderSourceLength = GL_SHADER_SOURCE_LENGTH,
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private unsafe int Get(Property property)
    {
        int outValue;
        Native.glGetShaderiv(this, (uint)property, &outValue);
        return outValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDeleted() => Get(Property.DeleteStatus) != 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetShaderType() => Get(Property.ShaderType);

    private unsafe string GetInfoLog()
    {
        var logSize = Get(property: Property.InfoLogLength);
        if (logSize <= 0)
            return string.Empty;

        var infoLogPtr = stackalloc byte[logSize];
        Native.glGetShaderInfoLog(this, logSize, null, infoLogPtr);

        return Utf8StringMarshaller.ConvertToManaged(infoLogPtr) ?? string.Empty;
    }

    public unsafe string GetSource()
    {
        var length = Get(Property.ShaderSourceLength);
        if (length <= 0)
            return string.Empty;

        var sourcePtr = stackalloc byte[length];
        Native.glGetShaderSource(this, length, null, sourcePtr);

        return Utf8StringMarshaller.ConvertToManaged(sourcePtr) ?? string.Empty;
    }

    public unsafe GlShader SetSource(string source)
    {
        var exactByteCount = Encoding.UTF8.GetByteCount(source);
        var mem = (byte*)Marshal.AllocCoTaskMem(exactByteCount);
        Span<byte> buffer = new(mem, exactByteCount);

        var byteCount = Encoding.UTF8.GetBytes(source, buffer);

        try
        {
            Native.glShaderSource(this, 1, &mem, &byteCount);
        }
        finally
        {
            Marshal.FreeCoTaskMem((IntPtr)mem);
        }

        return this;
    }

    public unsafe GlShader SetSource(ReadOnlySpan<byte> source)
    {
        fixed (byte* mem = source)
        {
            var byteCount = source.Length;
            Native.glShaderSource(this, 1, &mem, &byteCount);
        }

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlShader Compile()
    {
        Native.glCompileShader(this);
        var status = Get(Property.CompileStatus);

        if (status == GL_FALSE)
            throw new CompileException(this);

        return this;
    }

    public unsafe void Dispose()
    {
        Native.glDeleteShader(this);
    }
}
