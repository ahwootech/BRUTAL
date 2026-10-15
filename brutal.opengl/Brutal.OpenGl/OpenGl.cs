using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Brutal.Numerics;

namespace Brutal.OpenGlApi;

public static partial class OpenGl
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void ClearColor(float4 color)
    {
        Native.glClearColor(color.X, color.Y, color.Z, color.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Clear(GlClearBit mask)
    {
        Native.glClear((uint)mask);
    }

    public static unsafe GlProgram CreateShaderProgram(GlEnum type, ReadOnlySpan<string> strings)
    {
        var byteArrays = stackalloc byte*[strings.Length];

        for (var i = 0; i < strings.Length; i++)
            byteArrays[i] = Utf8StringMarshaller.ConvertToUnmanaged(strings[i]);

        try
        {
            return Native.glCreateShaderProgramv(type, strings.Length, byteArrays);
        }
        finally
        {
            for (var i = 0; i < strings.Length; i++)
                Utf8StringMarshaller.Free(byteArrays[i]);
        }
    }

    #region VertexAttrib

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, double value)
    {
        Native.glVertexAttrib1d(index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, float value)
    {
        Native.glVertexAttrib1f(index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, short value)
    {
        Native.glVertexAttrib1s(index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, double2 value)
    {
        fixed (double* ptr = value.AsSpan())
            Native.glVertexAttrib2dv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, float2 value)
    {
        fixed (float* ptr = value.AsSpan())
            Native.glVertexAttrib2fv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, short2 value)
    {
        fixed (short* ptr = value.AsSpan())
            Native.glVertexAttrib2sv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, double3 value)
    {
        fixed (double* ptr = value.AsSpan())
            Native.glVertexAttrib3dv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, float3 value)
    {
        fixed (float* ptr = value.AsSpan())
            Native.glVertexAttrib3fv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, short3 value)
    {
        fixed (short* ptr = value.AsSpan())
            Native.glVertexAttrib3sv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, sbyte4 value)
    {
        fixed (sbyte* ptr = value.AsSpan())
            Native.glVertexAttrib4Nbv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, int4 value)
    {
        fixed (int* ptr = value.AsSpan())
            Native.glVertexAttrib4Niv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, short4 value)
    {
        fixed (short* ptr = value.AsSpan())
            Native.glVertexAttrib4Nsv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, byte4 value)
    {
        fixed (byte* ptr = value.AsSpan())
            Native.glVertexAttrib4Nubv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, uint4 value)
    {
        fixed (uint* ptr = value.AsSpan())
            Native.glVertexAttrib4Nuiv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeNormalize(uint index, ushort4 value)
    {
        fixed (ushort* ptr = value.AsSpan())
            Native.glVertexAttrib4Nusv(index, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, sbyte4 v)
    {
        fixed (sbyte* vPtr = v.AsSpan())
            Native.glVertexAttrib4bv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, double4 value)
    {
        fixed (double* vPtr = value.AsSpan())
            Native.glVertexAttrib4dv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, float4 value)
    {
        fixed (float* vPtr = value.AsSpan())
            Native.glVertexAttrib4fv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, int4 value)
    {
        fixed (int* vPtr = value.AsSpan())
            Native.glVertexAttrib4iv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, short4 value)
    {
        fixed (short* vPtr = value.AsSpan())
            Native.glVertexAttrib4sv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, byte4 value)
    {
        fixed (byte* vPtr = value.AsSpan())
            Native.glVertexAttrib4ubv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, uint4 value)
    {
        fixed (uint* vPtr = value.AsSpan())
            Native.glVertexAttrib4uiv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeFloat(uint index, ushort4 value)
    {
        fixed (ushort* vPtr = value.AsSpan())
            Native.glVertexAttrib4usv(index, vPtr);
    }

    public static unsafe void VertexAttribute(GlAttribute attribute)
    {
        if (attribute.Behavior == GlScaling.Integer)
        {
            Native.glVertexAttribIPointer(
                attribute.Location,
                attribute.Count,
                attribute.Type,
                attribute.Stride,
                (void*)attribute.Offset
            );
        }
        else
        {
            Native.glVertexAttribPointer(
                attribute.Location,
                attribute.Count,
                attribute.Type,
                attribute.Behavior == GlScaling.Normalized,
                attribute.Stride,
                (void*)attribute.Offset
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, int value)
    {
        Native.glVertexAttribI1iv(index, &value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, int2 value)
    {
        fixed (int* vPtr = value.AsSpan())
            Native.glVertexAttribI2iv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, int3 value)
    {
        fixed (int* vPtr = value.AsSpan())
            Native.glVertexAttribI3iv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, int4 value)
    {
        fixed (int* vPtr = value.AsSpan())
            Native.glVertexAttribI4iv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, uint value)
    {
        Native.glVertexAttribI1uiv(index, &value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, uint2 value)
    {
        fixed (uint* vPtr = value.AsSpan())
            Native.glVertexAttribI2uiv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, uint3 value)
    {
        fixed (uint* vPtr = value.AsSpan())
            Native.glVertexAttribI3uiv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, uint4 v)
    {
        fixed (uint* vPtr = v.AsSpan())
            Native.glVertexAttribI4uiv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, sbyte4 value)
    {
        fixed (sbyte* vPtr = value.AsSpan())
            Native.glVertexAttribI4bv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeInt(uint index, short4 value)
    {
        fixed (short* vPtr = value.AsSpan())
            Native.glVertexAttribI4sv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, byte4 value)
    {
        fixed (byte* vPtr = value.AsSpan())
            Native.glVertexAttribI4ubv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void VertexAttributeUInt(uint index, ushort4 value)
    {
        fixed (ushort* vPtr = value.AsSpan())
            Native.glVertexAttribI4usv(index, vPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void VertexAttributes(ReadOnlySpan<GlAttribute> attributes)
    {
        foreach (var attribute in attributes)
            VertexAttribute(attribute);
    }

    #endregion

    #region GetVertexAttribute

    public static unsafe int GetVertexAttribute(uint index, GlVertexAttribute attribute)
    {
        int4 value = new();
        Native.glGetVertexAttribiv(index, (uint)attribute, (int*)&value);
        return value.X;
    }

    public static void GetVertexAttributeFloat(uint index, out double value)
    {
        GetVertexAttributeFloat(index, out double4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeFloat(uint index, out double2 value)
    {
        GetVertexAttributeFloat(index, out double4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeFloat(uint index, out double3 value)
    {
        GetVertexAttributeFloat(index, out double4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeFloat(uint index, out double4 value)
    {
        fixed (double4* valuePtr = &value)
            Native.glGetVertexAttribdv(index, GL_CURRENT_VERTEX_ATTRIB, (double*)valuePtr);
    }

    public static void GetVertexAttributeDouble(uint index, out double value)
    {
        GetVertexAttributeDouble(index, out double4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeDouble(uint index, out double2 value)
    {
        GetVertexAttributeDouble(index, out double4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeDouble(uint index, out double3 value)
    {
        GetVertexAttributeDouble(index, out double4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeDouble(uint index, out double4 value)
    {
        fixed (double4* valuePtr = &value)
            Native.glGetVertexAttribLdv(index, GL_CURRENT_VERTEX_ATTRIB, (double*)valuePtr);
    }

    public static void GetVertexAttributeFloat(uint index, out float value)
    {
        GetVertexAttributeFloat(index, out float4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeFloat(uint index, out float2 value)
    {
        GetVertexAttributeFloat(index, out float4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeFloat(uint index, out float3 value)
    {
        GetVertexAttributeFloat(index, out float4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeFloat(uint index, out float4 value)
    {
        fixed (float4* valuePtr = &value)
            Native.glGetVertexAttribfv(index, GL_CURRENT_VERTEX_ATTRIB, (float*)valuePtr);
    }

    public static void GetVertexAttributeFloat(uint index, out int value)
    {
        GetVertexAttributeFloat(index, out int4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeFloat(uint index, out int2 value)
    {
        GetVertexAttributeFloat(index, out int4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeFloat(uint index, out int3 value)
    {
        GetVertexAttributeFloat(index, out int4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeFloat(uint index, out int4 value)
    {
        fixed (int4* valuePtr = &value)
            Native.glGetVertexAttribiv(index, GL_CURRENT_VERTEX_ATTRIB, (int*)valuePtr);
    }

    public static void GetVertexAttributeInt(uint index, out int value)
    {
        GetVertexAttributeInt(index, out int4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeInt(uint index, out int2 value)
    {
        GetVertexAttributeInt(index, out int4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeInt(uint index, out int3 value)
    {
        GetVertexAttributeInt(index, out int4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeInt(uint index, out int4 value)
    {
        fixed (int4* valuePtr = &value)
            Native.glGetVertexAttribIiv(index, GL_CURRENT_VERTEX_ATTRIB, (int*)valuePtr);
    }

    public static void GetVertexAttributeUInt(uint index, out uint value)
    {
        GetVertexAttributeUInt(index, out uint4 value4);
        value = value4.X;
    }

    public static void GetVertexAttributeUInt(uint index, out uint2 value)
    {
        GetVertexAttributeUInt(index, out uint4 value4);
        value = value4.XY;
    }

    public static void GetVertexAttributeUInt(uint index, out uint3 value)
    {
        GetVertexAttributeUInt(index, out uint4 value4);
        value = value4.XYZ;
    }

    public static unsafe void GetVertexAttributeUInt(uint index, out uint4 value)
    {
        fixed (uint4* valuePtr = &value)
            Native.glGetVertexAttribIuiv(index, GL_CURRENT_VERTEX_ATTRIB, (uint*)valuePtr);
    }

    #endregion

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void BindFragDataLocation(GlProgram program, uint color, ReadOnlySpan<byte> name)
    {
        fixed (byte* namePtr = name)
            Native.glBindFragDataLocation(program, color, namePtr);
    }

    public static GlBuffer GenBuffer()
    {
        Span<GlBuffer> value = stackalloc GlBuffer[1];
        GenBuffers(value);
        return value[0];
    }

    public static GlVertexArray GenVertexArray()
    {
        Span<GlVertexArray> value = stackalloc GlVertexArray[1];
        GenVertexArrays(value);
        return value[0];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void BufferData<T>(GlBindTarget target, T data, GlBufferUsage usage)
        where T : unmanaged
    {
        BufferData(target, [data], usage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void BufferData<T>(GlBindTarget target, T[] data, GlBufferUsage usage)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
            Native.glBufferData((uint)target, sizeof(T) * data.Length, dataPtr, (uint)usage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void BufferData<T>(GlBindTarget target, Span<T> data, GlBufferUsage usage)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
            Native.glBufferData((uint)target, sizeof(T) * data.Length, dataPtr, (uint)usage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void BufferData<T>(GlBindTarget target, ReadOnlySpan<T> data, GlBufferUsage usage)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
            Native.glBufferData((uint)target, sizeof(T) * data.Length, dataPtr, (uint)usage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetAttachedShaders(GlProgram program, out int count, ReadOnlySpan<GlShader> shaders)
    {
        fixed (GlShader* shadersPtr = shaders)
        {
            int countValue;
            Native.glGetAttachedShaders(program, shaders.Length, &countValue, shadersPtr);
            count = countValue;
        }
    }

    #region TexParameter

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterFloat(GlEnum target, GlEnum pname, float param)
    {
        Native.glTexParameterf(target, pname, param);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterFloat(GlEnum target, GlEnum pname, ReadOnlySpan<float> @params)
    {
        fixed (float* @paramsPtr = @params)
            Native.glTexParameterfv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterFloat(GlEnum target, GlEnum pname, int param)
    {
        Native.glTexParameteri(target, pname, param);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterFloat(GlEnum target, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glTexParameteriv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterInt(GlEnum target, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glTexParameterIiv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TexParameterInt(GlEnum target, GlEnum pname, ReadOnlySpan<uint> @params)
    {
        fixed (uint* @paramsPtr = @params)
            Native.glTexParameterIuiv(target, pname, @paramsPtr);
    }

    #endregion

    #region TextureParameter

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterFloat(uint texture, GlEnum pname, float param)
    {
        Native.glTextureParameterf(texture, pname, param);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterFloat(uint texture, GlEnum pname, ReadOnlySpan<float> param)
    {
        fixed (float* paramPtr = param)
            Native.glTextureParameterfv(texture, pname, paramPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterFloat(uint texture, GlEnum pname, int param)
    {
        Native.glTextureParameteri(texture, pname, param);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterInt(uint texture, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glTextureParameterIiv(texture, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterInt(uint texture, GlEnum pname, ReadOnlySpan<uint> @params)
    {
        fixed (uint* @paramsPtr = @params)
            Native.glTextureParameterIuiv(texture, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void TextureParameterFloat(uint texture, GlEnum pname, ReadOnlySpan<int> param)
    {
        fixed (int* paramPtr = param)
            Native.glTextureParameteriv(texture, pname, paramPtr);
    }

    #endregion

    #region GetTexParameter

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTexParameterFloat(GlEnum target, GlEnum pname, ReadOnlySpan<float> @params)
    {
        fixed (float* @paramsPtr = @params)
            Native.glGetTexParameterfv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTexParameterFloat(GlEnum target, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glGetTexParameteriv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTexParameterInt(GlEnum target, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glGetTexParameterIiv(target, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTexParameterInt(GlEnum target, GlEnum pname, ReadOnlySpan<uint> @params)
    {
        fixed (uint* @paramsPtr = @params)
            Native.glGetTexParameterIuiv(target, pname, @paramsPtr);
    }

    #endregion

    #region GetTextureParameter

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTextureParameterFloat(uint texture, GlEnum pname, ReadOnlySpan<float> @params)
    {
        fixed (float* @paramsPtr = @params)
            Native.glGetTextureParameterfv(texture, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTextureParameterInt(uint texture, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glGetTextureParameterIiv(texture, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTextureParameterInt(uint texture, GlEnum pname, ReadOnlySpan<uint> @params)
    {
        fixed (uint* @paramsPtr = @params)
            Native.glGetTextureParameterIuiv(texture, pname, @paramsPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void GetTextureParameterFloat(uint texture, GlEnum pname, ReadOnlySpan<int> @params)
    {
        fixed (int* @paramsPtr = @params)
            Native.glGetTextureParameteriv(texture, pname, @paramsPtr);
    }

    #endregion

    #region Draw

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Draw(
        GlTopology mode,
        int vertexCount,
        int instanceCount,
        int vertexOffset,
        int firstInstance
    )
    {
        if (firstInstance != 0)
        {
            Native.glDrawArraysInstancedBaseInstance(
                (uint)mode,
                vertexOffset,
                vertexCount,
                instanceCount,
                (uint)firstInstance
            );
        }
        else if (instanceCount > 1)
        {
            Native.glDrawArraysInstanced((uint)mode, vertexOffset, vertexCount, instanceCount);
        }
        else
        {
            Native.glDrawArrays((uint)mode, vertexOffset, vertexCount);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawIndexed(
        GlTopology mode,
        GlIndexType indexType,
        int indexCount,
        int instanceCount,
        int firstIndex,
        int vertexOffset,
        int firstInstance
    )
    {
        if (firstInstance != 0)
        {
            Native.glDrawElementsInstancedBaseVertexBaseInstance(
                (uint)mode,
                indexCount,
                (uint)indexType,
                (void*)firstIndex,
                instanceCount,
                vertexOffset,
                (uint)firstInstance
            );
        }
        else if (vertexOffset != 0)
        {
            Native.glDrawElementsInstancedBaseVertex(
                (uint)mode,
                indexCount,
                (uint)indexType,
                (void*)firstIndex,
                instanceCount,
                vertexOffset
            );
        }
        else
        {
            Native.glDrawElementsInstanced((uint)mode, indexCount, (uint)indexType, (void*)firstIndex, instanceCount);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDraw(
        GlTopology mode,
        ReadOnlySpan<int> vertexCounts,
        ReadOnlySpan<int> firstVertices
    )
    {
        Debug.Assert(firstVertices.Length == vertexCounts.Length, "First and count arrays must have the same length.");
        if (firstVertices.Length == 0)
            return;
        fixed (int* firstPtr = firstVertices)
        fixed (int* countPtr = vertexCounts)
            Native.glMultiDrawArrays((uint)mode, firstPtr, countPtr, firstVertices.Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDrawIndexed(
        GlTopology mode,
        GlIndexType indexType,
        ReadOnlySpan<int> indexCounts,
        ReadOnlySpan<int> firstIndices,
        ReadOnlySpan<int> baseVertices = default
    )
    {
        Debug.Assert(
            firstIndices.Length == indexCounts.Length,
            "First indices and index counts arrays must have the same length."
        );

        if (firstIndices.Length == 0)
            return;

        fixed (int* firstIndicesPtr = firstIndices)
        fixed (int* indexCountsPtr = indexCounts)
        {
            if (baseVertices.Length == 0)
            {
                Native.glMultiDrawElements(
                    (uint)mode,
                    indexCountsPtr,
                    (uint)indexType,
                    (void**)firstIndicesPtr,
                    firstIndices.Length
                );
            }
            else
            {
                Debug.Assert(
                    firstIndices.Length == baseVertices.Length,
                    "Base vertices arrays must have the same length as first indices, or be empty."
                );

                fixed (int* baseVerticesPtr = baseVertices)
                {
                    Native.glMultiDrawElementsBaseVertex(
                        (uint)mode,
                        indexCountsPtr,
                        (uint)indexType,
                        (void**)firstIndicesPtr,
                        firstIndices.Length,
                        baseVerticesPtr
                    );
                }
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawIndirect(GlTopology mode, nint byteOffset)
    {
        Native.glDrawArraysIndirect((uint)mode, (void*)byteOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawIndexedIndirect(GlEnum mode, GlEnum indexType, nint byteOffset)
    {
        Native.glDrawElementsIndirect(mode, indexType, (void*)byteOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawTransformFeedbackInstanced(GlTopology mode, uint id, int instanceCount)
    {
        Native.glDrawTransformFeedbackInstanced((uint)mode, id, instanceCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawTransformFeedbackStreamInstanced(
        GlTopology mode,
        uint id,
        uint stream,
        int instanceCount
    )
    {
        Native.glDrawTransformFeedbackStreamInstanced((uint)mode, id, stream, instanceCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDrawIndirect(GlTopology mode, nint byteOffset, int drawCount, int indirectStride)
    {
        Native.glMultiDrawArraysIndirect((uint)mode, (void*)byteOffset, drawCount, indirectStride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDrawIndexedIndirect(
        GlTopology mode,
        GlIndexType type,
        nint byteOffset,
        int drawCount,
        int stride
    )
    {
        Native.glMultiDrawElementsIndirect((uint)mode, (uint)type, (void*)byteOffset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDrawIndirectCount(
        GlEnum mode,
        nint byteOffset,
        nint drawCountByteOffset,
        int maxDrawCount,
        int stride
    )
    {
        Native.glMultiDrawArraysIndirectCount(mode, (void*)byteOffset, drawCountByteOffset, maxDrawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void MultiDrawIndexedIndirectCount(
        GlEnum mode,
        GlEnum type,
        nint byteOffset,
        nint drawCountByteOffset,
        int maxDrawCount,
        int stride
    )
    {
        Native.glMultiDrawElementsIndirectCount(
            mode,
            type,
            (void*)byteOffset,
            drawCountByteOffset,
            maxDrawCount,
            stride
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawTransformFeedback(GlTopology mode, uint id)
    {
        Native.glDrawTransformFeedback((uint)mode, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void DrawTransformFeedbackStream(GlTopology mode, uint id, uint stream)
    {
        Native.glDrawTransformFeedbackStream((uint)mode, id, stream);
    }

    #endregion

    #region Uniform

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, int value)
    {
        Native.glUniform1i(location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<int> values)
    {
        fixed (int* valuePtr = values)
            Native.glUniform1iv(startLocation, values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, float value)
    {
        Native.glUniform1f(location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float> values)
    {
        fixed (float* valuePtr = values)
            Native.glUniform1fv(startLocation, values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, double v0)
    {
        Native.glUniform1d(location, v0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double> value)
    {
        fixed (double* valuePtr = value)
            Native.glUniform1dv(startLocation, value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, uint value)
    {
        Native.glUniform1ui(location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<uint> value)
    {
        fixed (uint* valuePtr = value)
            Native.glUniform1uiv(startLocation, value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, int2 value)
    {
        Native.glUniform2i(location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<int2> values)
    {
        fixed (int2* valuePtr = values)
            Native.glUniform2iv(startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, float2 value)
    {
        Native.glUniform2f(location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float2> values)
    {
        fixed (float2* valuePtr = values)
            Native.glUniform2fv(startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, double2 value)
    {
        Native.glUniform2d(location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double2> values)
    {
        fixed (double2* valuePtr = values)
            Native.glUniform2dv(startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, uint2 value)
    {
        Native.glUniform2ui(location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<uint2> value)
    {
        fixed (uint2* valuePtr = value)
            Native.glUniform2uiv(startLocation, value.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, int3 value)
    {
        Native.glUniform3i(location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<int3> values)
    {
        fixed (int3* valuePtr = values)
            Native.glUniform3iv(startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, float3 value)
    {
        Native.glUniform3f(location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float3> values)
    {
        fixed (float3* valuePtr = values)
            Native.glUniform3fv(startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, double3 value)
    {
        Native.glUniform3d(location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double3> values)
    {
        fixed (double3* valuePtr = values)
            Native.glUniform3dv(startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, uint3 value)
    {
        Native.glUniform3ui(location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<uint3> values)
    {
        fixed (uint3* valuePtr = values)
            Native.glUniform3uiv(startLocation, values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, int4 value)
    {
        Native.glUniform4i(location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<int4> values)
    {
        fixed (int4* valuePtr = values)
            Native.glUniform4iv(startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, float4 value)
    {
        Native.glUniform4f(location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float4> values)
    {
        fixed (float4* valuePtr = values)
            Native.glUniform4fv(startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, double4 value)
    {
        Native.glUniform4d(location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double4> values)
    {
        fixed (double4* valuePtr = values)
            Native.glUniform4dv(startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, uint4 value)
    {
        Native.glUniform4ui(location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<uint4> values)
    {
        fixed (uint4* valuePtr = values)
            Native.glUniform4uiv(startLocation, values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float2x2 value, Bool8 transpose = default)
    {
        fixed (float2x2* valuePtr = &value)
            Native.glUniformMatrix2fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float3x3 value, Bool8 transpose = default)
    {
        fixed (float3x3* valuePtr = &value)
            Native.glUniformMatrix3fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float4x4 value, Bool8 transpose = default)
    {
        fixed (float4x4* valuePtr = &value)
            Native.glUniformMatrix4fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double2x2 value, Bool8 transpose = default)
    {
        fixed (double2x2* valuePtr = &value)
            Native.glUniformMatrix2dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double3x3 value, Bool8 transpose = default)
    {
        fixed (double3x3* valuePtr = &value)
            Native.glUniformMatrix3dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double4x4 value, Bool8 transpose = default)
    {
        fixed (double4x4* valuePtr = &value)
            Native.glUniformMatrix4dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float2x3 value, Bool8 transpose = default)
    {
        fixed (float2x3* valuePtr = &value)
            Native.glUniformMatrix2x3fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float3x2 value, Bool8 transpose = default)
    {
        fixed (float3x2* valuePtr = &value)
            Native.glUniformMatrix3x2fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float2x4 value, Bool8 transpose = default)
    {
        fixed (float2x4* valuePtr = &value)
            Native.glUniformMatrix2x4fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float4x2 value, Bool8 transpose = default)
    {
        fixed (float4x2* valuePtr = &value)
            Native.glUniformMatrix4x2fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float3x4 value, Bool8 transpose = default)
    {
        fixed (float3x4* valuePtr = &value)
            Native.glUniformMatrix3x4fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in float4x3 values, Bool8 transpose = default)
    {
        fixed (float4x3* valuePtr = &values)
            Native.glUniformMatrix4x3fv(location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double2x3 value, Bool8 transpose = default)
    {
        fixed (double2x3* valuePtr = &value)
            Native.glUniformMatrix2x3dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double3x2 value, Bool8 transpose = default)
    {
        fixed (double3x2* valuePtr = &value)
            Native.glUniformMatrix3x2dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double2x4 value, Bool8 transpose = default)
    {
        fixed (double2x4* valuePtr = &value)
            Native.glUniformMatrix2x4dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double4x2 value, Bool8 transpose = default)
    {
        fixed (double4x2* valuePtr = &value)
            Native.glUniformMatrix4x2dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double3x4 value, Bool8 transpose = default)
    {
        fixed (double3x4* valuePtr = &value)
            Native.glUniformMatrix3x4dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void Uniform(int location, in double4x3 value, Bool8 transpose = default)
    {
        fixed (double4x3* valuePtr = &value)
            Native.glUniformMatrix4x3dv(location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x2> values, Bool8 transpose = default)
    {
        fixed (float2x2* valuePtr = values)
            Native.glUniformMatrix2fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x3> values, Bool8 transpose = default)
    {
        fixed (float3x3* valuePtr = values)
            Native.glUniformMatrix3fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x4> values, Bool8 transpose = default)
    {
        fixed (float4x4* valuePtr = values)
            Native.glUniformMatrix4fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x2> values, Bool8 transpose = default)
    {
        fixed (double2x2* valuePtr = values)
            Native.glUniformMatrix2dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double3x3> values, Bool8 transpose = default)
    {
        fixed (double3x3* valuePtr = values)
            Native.glUniformMatrix3dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x4> values, Bool8 transpose = default)
    {
        fixed (double4x4* valuePtr = values)
            Native.glUniformMatrix4dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x3> values, Bool8 transpose = default)
    {
        fixed (float2x3* valuePtr = values)
            Native.glUniformMatrix2x3fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x2> values, Bool8 transpose = default)
    {
        fixed (float3x2* valuePtr = values)
            Native.glUniformMatrix3x2fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x4> values, Bool8 transpose = default)
    {
        fixed (float2x4* valuePtr = values)
            Native.glUniformMatrix2x4fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x2> values, Bool8 transpose = default)
    {
        fixed (float4x2* valuePtr = values)
            Native.glUniformMatrix4x2fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x4> values, Bool8 transpose = default)
    {
        fixed (float3x4* valuePtr = values)
            Native.glUniformMatrix3x4fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x3> values, Bool8 transpose = default)
    {
        fixed (float4x3* valuePtr = values)
            Native.glUniformMatrix4x3fv(startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x3> values, Bool8 transpose = default)
    {
        fixed (double2x3* valuePtr = values)
            Native.glUniformMatrix2x3dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double3x2> values, Bool8 transpose = default)
    {
        fixed (double3x2* valuePtr = values)
            Native.glUniformMatrix3x2dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x4> values, Bool8 transpose = default)
    {
        fixed (double2x4* valuePtr = values)
            Native.glUniformMatrix2x4dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x2> values, Bool8 transpose = default)
    {
        fixed (double4x2* valuePtr = values)
            Native.glUniformMatrix4x2dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double3x4> values, Bool8 transpose = default)
    {
        fixed (double3x4* valuePtr = values)
            Native.glUniformMatrix3x4dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x3> values, Bool8 transpose = default)
    {
        fixed (double4x3* valuePtr = values)
            Native.glUniformMatrix4x3dv(startLocation, values.Length, transpose, (double*)valuePtr);
    }

    #endregion
}
