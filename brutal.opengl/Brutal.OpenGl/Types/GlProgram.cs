using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using Brutal.Numerics;

namespace Brutal.OpenGlApi;

using static OpenGl;

public readonly record struct GlProgram(uint Id) : IDisposable
{
    private enum Property : uint
    {
        DeleteStatus = GL_DELETE_STATUS,
        LinkStatus = GL_LINK_STATUS,
        ValidateStatus = GL_VALIDATE_STATUS,
        InfoLogLength = GL_INFO_LOG_LENGTH,
        AttachedShaders = GL_ATTACHED_SHADERS,
        ActiveAtomicCounterBuffers = GL_ACTIVE_ATOMIC_COUNTER_BUFFERS,
        ActiveAttributes = GL_ACTIVE_ATTRIBUTES,
        ActiveAttributeMaxLength = GL_ACTIVE_ATTRIBUTE_MAX_LENGTH,
        ActiveUniforms = GL_ACTIVE_UNIFORMS,
        ActiveUniformBlocks = GL_ACTIVE_UNIFORM_BLOCKS,
        ActiveUniformBlockMaxNameLength = GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH,
        ActiveUniformMaxLength = GL_ACTIVE_UNIFORM_MAX_LENGTH,
        ComputeWorkGroupSize = GL_COMPUTE_WORK_GROUP_SIZE,
        ProgramBinaryLength = GL_PROGRAM_BINARY_LENGTH,
        TransformFeedbackBufferMode = GL_TRANSFORM_FEEDBACK_BUFFER_MODE,
        TransformFeedbackVaryings = GL_TRANSFORM_FEEDBACK_VARYINGS,
        TransformFeedbackVaryingMaxLength = GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH,
        GeometryVerticesOut = GL_GEOMETRY_VERTICES_OUT,
        GeometryInputType = GL_GEOMETRY_INPUT_TYPE,
        GeometryOutputType = GL_GEOMETRY_OUTPUT_TYPE,
    }

    public class LinkException(GlProgram program) : Exception(program.GetProgramInfoLog());

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlProgram Use()
    {
        Native.glUseProgram(this);
        return this;
    }

    #region ProgramUniform

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, int value)
    {
        Native.glProgramUniform1i(this, location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<int> values)
    {
        fixed (int* valuePtr = values)
            Native.glProgramUniform1iv(this, startLocation, values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, float value)
    {
        Native.glProgramUniform1f(this, location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float> values)
    {
        fixed (float* valuePtr = values)
            Native.glProgramUniform1fv(this, startLocation, values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, double v0)
    {
        Native.glProgramUniform1d(this, location, v0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double> value)
    {
        fixed (double* valuePtr = value)
            Native.glProgramUniform1dv(this, startLocation, value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, uint value)
    {
        Native.glProgramUniform1ui(this, location, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<uint> value)
    {
        fixed (uint* valuePtr = value)
            Native.glProgramUniform1uiv(this, startLocation, value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, int2 value)
    {
        Native.glProgramUniform2i(this, location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<int2> values)
    {
        fixed (int2* valuePtr = values)
            Native.glProgramUniform2iv(this, startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, float2 value)
    {
        Native.glProgramUniform2f(this, location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float2> values)
    {
        fixed (float2* valuePtr = values)
            Native.glProgramUniform2fv(this, startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, double2 value)
    {
        Native.glProgramUniform2d(this, location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double2> values)
    {
        fixed (double2* valuePtr = values)
            Native.glProgramUniform2dv(this, startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, uint2 value)
    {
        Native.glProgramUniform2ui(this, location, value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<uint2> value)
    {
        fixed (uint2* valuePtr = value)
            Native.glProgramUniform2uiv(this, startLocation, value.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, int3 value)
    {
        Native.glProgramUniform3i(this, location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<int3> values)
    {
        fixed (int3* valuePtr = values)
            Native.glProgramUniform3iv(this, startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, float3 value)
    {
        Native.glProgramUniform3f(this, location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float3> values)
    {
        fixed (float3* valuePtr = values)
            Native.glProgramUniform3fv(this, startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, double3 value)
    {
        Native.glProgramUniform3d(this, location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double3> values)
    {
        fixed (double3* valuePtr = values)
            Native.glProgramUniform3dv(this, startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, uint3 value)
    {
        Native.glProgramUniform3ui(this, location, value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<uint3> values)
    {
        fixed (uint3* valuePtr = values)
            Native.glProgramUniform3uiv(this, startLocation, values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, int4 value)
    {
        Native.glProgramUniform4i(this, location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<int4> values)
    {
        fixed (int4* valuePtr = values)
            Native.glProgramUniform4iv(this, startLocation, values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, float4 value)
    {
        Native.glProgramUniform4f(this, location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float4> values)
    {
        fixed (float4* valuePtr = values)
            Native.glProgramUniform4fv(this, startLocation, values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, double4 value)
    {
        Native.glProgramUniform4d(this, location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double4> values)
    {
        fixed (double4* valuePtr = values)
            Native.glProgramUniform4dv(this, startLocation, values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, uint4 value)
    {
        Native.glProgramUniform4ui(this, location, value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<uint4> values)
    {
        fixed (uint4* valuePtr = values)
            Native.glProgramUniform4uiv(this, startLocation, values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float2x2 value, Bool8 transpose = default)
    {
        fixed (float2x2* valuePtr = &value)
            Native.glProgramUniformMatrix2fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float3x3 value, Bool8 transpose = default)
    {
        fixed (float3x3* valuePtr = &value)
            Native.glProgramUniformMatrix3fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float4x4 value, Bool8 transpose = default)
    {
        fixed (float4x4* valuePtr = &value)
            Native.glProgramUniformMatrix4fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double2x2 value, Bool8 transpose = default)
    {
        fixed (double2x2* valuePtr = &value)
            Native.glProgramUniformMatrix2dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double3x3 value, Bool8 transpose = default)
    {
        fixed (double3x3* valuePtr = &value)
            Native.glProgramUniformMatrix3dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double4x4 value, Bool8 transpose = default)
    {
        fixed (double4x4* valuePtr = &value)
            Native.glProgramUniformMatrix4dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float2x3 value, Bool8 transpose = default)
    {
        fixed (float2x3* valuePtr = &value)
            Native.glProgramUniformMatrix2x3fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float3x2 value, Bool8 transpose = default)
    {
        fixed (float3x2* valuePtr = &value)
            Native.glProgramUniformMatrix3x2fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float2x4 value, Bool8 transpose = default)
    {
        fixed (float2x4* valuePtr = &value)
            Native.glProgramUniformMatrix2x4fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float4x2 value, Bool8 transpose = default)
    {
        fixed (float4x2* valuePtr = &value)
            Native.glProgramUniformMatrix4x2fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float3x4 value, Bool8 transpose = default)
    {
        fixed (float3x4* valuePtr = &value)
            Native.glProgramUniformMatrix3x4fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in float4x3 values, Bool8 transpose = default)
    {
        fixed (float4x3* valuePtr = &values)
            Native.glProgramUniformMatrix4x3fv(this, location, 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double2x3 value, Bool8 transpose = default)
    {
        fixed (double2x3* valuePtr = &value)
            Native.glProgramUniformMatrix2x3dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double3x2 value, Bool8 transpose = default)
    {
        fixed (double3x2* valuePtr = &value)
            Native.glProgramUniformMatrix3x2dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double2x4 value, Bool8 transpose = default)
    {
        fixed (double2x4* valuePtr = &value)
            Native.glProgramUniformMatrix2x4dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double4x2 value, Bool8 transpose = default)
    {
        fixed (double4x2* valuePtr = &value)
            Native.glProgramUniformMatrix4x2dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double3x4 value, Bool8 transpose = default)
    {
        fixed (double3x4* valuePtr = &value)
            Native.glProgramUniformMatrix3x4dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(int location, in double4x3 value, Bool8 transpose = default)
    {
        fixed (double4x3* valuePtr = &value)
            Native.glProgramUniformMatrix4x3dv(this, location, 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x2> values, Bool8 transpose = default)
    {
        fixed (float2x2* valuePtr = values)
            Native.glProgramUniformMatrix2fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x3> values, Bool8 transpose = default)
    {
        fixed (float3x3* valuePtr = values)
            Native.glProgramUniformMatrix3fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x4> values, Bool8 transpose = default)
    {
        fixed (float4x4* valuePtr = values)
            Native.glProgramUniformMatrix4fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x2> values, Bool8 transpose = default)
    {
        fixed (double2x2* valuePtr = values)
            Native.glProgramUniformMatrix2dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double3x3> values, Bool8 transpose = default)
    {
        fixed (double3x3* valuePtr = values)
            Native.glProgramUniformMatrix3dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x4> values, Bool8 transpose = default)
    {
        fixed (double4x4* valuePtr = values)
            Native.glProgramUniformMatrix4dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x3> values, Bool8 transpose = default)
    {
        fixed (float2x3* valuePtr = values)
            Native.glProgramUniformMatrix2x3fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x2> values, Bool8 transpose = default)
    {
        fixed (float3x2* valuePtr = values)
            Native.glProgramUniformMatrix3x2fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float2x4> values, Bool8 transpose = default)
    {
        fixed (float2x4* valuePtr = values)
            Native.glProgramUniformMatrix2x4fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x2> values, Bool8 transpose = default)
    {
        fixed (float4x2* valuePtr = values)
            Native.glProgramUniformMatrix4x2fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float3x4> values, Bool8 transpose = default)
    {
        fixed (float3x4* valuePtr = values)
            Native.glProgramUniformMatrix3x4fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<float4x3> values, Bool8 transpose = default)
    {
        fixed (float4x3* valuePtr = values)
            Native.glProgramUniformMatrix4x3fv(this, startLocation, values.Length, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x3> values, Bool8 transpose = default)
    {
        fixed (double2x3* valuePtr = values)
            Native.glProgramUniformMatrix2x3dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, Bool8 transpose, ReadOnlySpan<double3x2> values)
    {
        fixed (double3x2* valuePtr = values)
            Native.glProgramUniformMatrix3x2dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double2x4> values, Bool8 transpose = default)
    {
        fixed (double2x4* valuePtr = values)
            Native.glProgramUniformMatrix2x4dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x2> values, Bool8 transpose = default)
    {
        fixed (double4x2* valuePtr = values)
            Native.glProgramUniformMatrix4x2dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double3x4> values, Bool8 transpose = default)
    {
        fixed (double3x4* valuePtr = values)
            Native.glProgramUniformMatrix3x4dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(int startLocation, ReadOnlySpan<double4x3> values, Bool8 transpose = default)
    {
        fixed (double4x3* valuePtr = values)
            Native.glProgramUniformMatrix4x3dv(this, startLocation, values.Length, transpose, (double*)valuePtr);
    }

    #endregion

    #region GetUniform

    public unsafe void GetUniform(int location, out float value)
    {
        fixed (float* valuePtr = &value)
            Native.glGetUniformfv(this, location, valuePtr);
    }

    public unsafe void GetUniform(int location, out float2 value)
    {
        fixed (float2* valuePtr = &value)
            Native.glGetUniformfv(this, location, (float*)valuePtr);
    }

    public unsafe void GetUniform(int location, out float3 value)
    {
        fixed (float3* valuePtr = &value)
            Native.glGetUniformfv(this, location, (float*)valuePtr);
    }

    public unsafe void GetUniform(int location, out float4 value)
    {
        fixed (float4* valuePtr = &value)
            Native.glGetUniformfv(this, location, (float*)valuePtr);
    }

    public unsafe void GetUniform(int location, out double value)
    {
        fixed (double* valuePtr = &value)
            Native.glGetUniformdv(this, location, valuePtr);
    }

    public unsafe void GetUniform(int location, out double2 value)
    {
        fixed (double2* valuePtr = &value)
            Native.glGetUniformdv(this, location, (double*)valuePtr);
    }

    public unsafe void GetUniform(int location, out double3 value)
    {
        fixed (double3* valuePtr = &value)
            Native.glGetUniformdv(this, location, (double*)valuePtr);
    }

    public unsafe void GetUniform(int location, out double4 value)
    {
        fixed (double4* valuePtr = &value)
            Native.glGetUniformdv(this, location, (double*)valuePtr);
    }

    public unsafe void GetUniform(int location, out int value)
    {
        fixed (int* valuePtr = &value)
            Native.glGetUniformiv(this, location, valuePtr);
    }

    public unsafe void GetUniform(int location, out int2 value)
    {
        fixed (int2* valuePtr = &value)
            Native.glGetUniformiv(this, location, (int*)valuePtr);
    }

    public unsafe void GetUniform(int location, out int3 value)
    {
        fixed (int3* valuePtr = &value)
            Native.glGetUniformiv(this, location, (int*)valuePtr);
    }

    public unsafe void GetUniform(int location, out int4 value)
    {
        fixed (int4* valuePtr = &value)
            Native.glGetUniformiv(this, location, (int*)valuePtr);
    }

    public unsafe void GetUniform(int location, out uint value)
    {
        fixed (uint* valuePtr = &value)
            Native.glGetUniformuiv(this, location, valuePtr);
    }

    public unsafe void GetUniform(int location, out uint2 value)
    {
        fixed (uint2* valuePtr = &value)
            Native.glGetUniformuiv(this, location, (uint*)valuePtr);
    }

    public unsafe void GetUniform(int location, out uint3 value)
    {
        fixed (uint3* valuePtr = &value)
            Native.glGetUniformuiv(this, location, (uint*)valuePtr);
    }

    public unsafe void GetUniform(int location, out uint4 value)
    {
        fixed (uint4* valuePtr = &value)
            Native.glGetUniformuiv(this, location, (uint*)valuePtr);
    }

    #endregion

    #region ProgramUniform

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, int value)
    {
        Native.glProgramUniform1i(this, GetUniformLocation(name), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<int> values)
    {
        fixed (int* valuePtr = values)
            Native.glProgramUniform1iv(this, GetUniformLocation(startName), values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, float value)
    {
        Native.glProgramUniform1f(this, GetUniformLocation(name), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<float> values)
    {
        fixed (float* valuePtr = values)
            Native.glProgramUniform1fv(this, GetUniformLocation(startName), values.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, double v0)
    {
        Native.glProgramUniform1d(this, GetUniformLocation(name), v0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<double> value)
    {
        fixed (double* valuePtr = value)
            Native.glProgramUniform1dv(this, GetUniformLocation(startName), value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, uint value)
    {
        Native.glProgramUniform1ui(this, GetUniformLocation(name), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<uint> value)
    {
        fixed (uint* valuePtr = value)
            Native.glProgramUniform1uiv(this, GetUniformLocation(startName), value.Length, valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, int2 value)
    {
        Native.glProgramUniform2i(this, GetUniformLocation(name), value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<int2> values)
    {
        fixed (int2* valuePtr = values)
            Native.glProgramUniform2iv(this, GetUniformLocation(startName), values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, float2 value)
    {
        Native.glProgramUniform2f(this, GetUniformLocation(name), value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<float2> values)
    {
        fixed (float2* valuePtr = values)
            Native.glProgramUniform2fv(this, GetUniformLocation(startName), values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, double2 value)
    {
        Native.glProgramUniform2d(this, GetUniformLocation(name), value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<double2> values)
    {
        fixed (double2* valuePtr = values)
            Native.glProgramUniform2dv(this, GetUniformLocation(startName), values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, uint2 value)
    {
        Native.glProgramUniform2ui(this, GetUniformLocation(name), value.X, value.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<uint2> value)
    {
        fixed (uint2* valuePtr = value)
            Native.glProgramUniform2uiv(this, GetUniformLocation(startName), value.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, int3 value)
    {
        Native.glProgramUniform3i(this, GetUniformLocation(name), value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<int3> values)
    {
        fixed (int3* valuePtr = values)
            Native.glProgramUniform3iv(this, GetUniformLocation(startName), values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, float3 value)
    {
        Native.glProgramUniform3f(this, GetUniformLocation(name), value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<float3> values)
    {
        fixed (float3* valuePtr = values)
            Native.glProgramUniform3fv(this, GetUniformLocation(startName), values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, double3 value)
    {
        Native.glProgramUniform3d(this, GetUniformLocation(name), value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<double3> values)
    {
        fixed (double3* valuePtr = values)
            Native.glProgramUniform3dv(this, GetUniformLocation(startName), values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, uint3 value)
    {
        Native.glProgramUniform3ui(this, GetUniformLocation(name), value.X, value.Y, value.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<uint3> values)
    {
        fixed (uint3* valuePtr = values)
            Native.glProgramUniform3uiv(this, GetUniformLocation(startName), values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, int4 value)
    {
        Native.glProgramUniform4i(this, GetUniformLocation(name), value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<int4> values)
    {
        fixed (int4* valuePtr = values)
            Native.glProgramUniform4iv(this, GetUniformLocation(startName), values.Length, (int*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, float4 value)
    {
        Native.glProgramUniform4f(this, GetUniformLocation(name), value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<float4> values)
    {
        fixed (float4* valuePtr = values)
            Native.glProgramUniform4fv(this, GetUniformLocation(startName), values.Length, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, double4 value)
    {
        Native.glProgramUniform4d(this, GetUniformLocation(name), value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<double4> values)
    {
        fixed (double4* valuePtr = values)
            Native.glProgramUniform4dv(this, GetUniformLocation(startName), values.Length, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, uint4 value)
    {
        Native.glProgramUniform4ui(this, GetUniformLocation(name), value.X, value.Y, value.Z, value.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(ReadOnlySpan<byte> startName, ReadOnlySpan<uint4> values)
    {
        fixed (uint4* valuePtr = values)
            Native.glProgramUniform4uiv(this, GetUniformLocation(startName), values.Length, (uint*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float2x2 value, Bool8 transpose = default)
    {
        fixed (float2x2* valuePtr = &value)
            Native.glProgramUniformMatrix2fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float3x3 value, Bool8 transpose = default)
    {
        fixed (float3x3* valuePtr = &value)
            Native.glProgramUniformMatrix3fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float4x4 value, Bool8 transpose = default)
    {
        fixed (float4x4* valuePtr = &value)
            Native.glProgramUniformMatrix4fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double2x2 value, Bool8 transpose = default)
    {
        fixed (double2x2* valuePtr = &value)
            Native.glProgramUniformMatrix2dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double3x3 value, Bool8 transpose = default)
    {
        fixed (double3x3* valuePtr = &value)
            Native.glProgramUniformMatrix3dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double4x4 value, Bool8 transpose = default)
    {
        fixed (double4x4* valuePtr = &value)
            Native.glProgramUniformMatrix4dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float2x3 value, Bool8 transpose = default)
    {
        fixed (float2x3* valuePtr = &value)
            Native.glProgramUniformMatrix2x3fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float3x2 value, Bool8 transpose = default)
    {
        fixed (float3x2* valuePtr = &value)
            Native.glProgramUniformMatrix3x2fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float2x4 value, Bool8 transpose = default)
    {
        fixed (float2x4* valuePtr = &value)
            Native.glProgramUniformMatrix2x4fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float4x2 value, Bool8 transpose = default)
    {
        fixed (float4x2* valuePtr = &value)
            Native.glProgramUniformMatrix4x2fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float3x4 value, Bool8 transpose = default)
    {
        fixed (float3x4* valuePtr = &value)
            Native.glProgramUniformMatrix3x4fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in float4x3 values, Bool8 transpose = default)
    {
        fixed (float4x3* valuePtr = &values)
            Native.glProgramUniformMatrix4x3fv(this, GetUniformLocation(name), 1, transpose, (float*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double2x3 value, Bool8 transpose = default)
    {
        fixed (double2x3* valuePtr = &value)
            Native.glProgramUniformMatrix2x3dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double3x2 value, Bool8 transpose = default)
    {
        fixed (double3x2* valuePtr = &value)
            Native.glProgramUniformMatrix3x2dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double2x4 value, Bool8 transpose = default)
    {
        fixed (double2x4* valuePtr = &value)
            Native.glProgramUniformMatrix2x4dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double4x2 value, Bool8 transpose = default)
    {
        fixed (double4x2* valuePtr = &value)
            Native.glProgramUniformMatrix4x2dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double3x4 value, Bool8 transpose = default)
    {
        fixed (double3x4* valuePtr = &value)
            Native.glProgramUniformMatrix3x4dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Uniform(ReadOnlySpan<byte> name, in double4x3 value, Bool8 transpose = default)
    {
        fixed (double4x3* valuePtr = &value)
            Native.glProgramUniformMatrix4x3dv(this, GetUniformLocation(name), 1, transpose, (double*)valuePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float2x2> values,
        Bool8 transpose = default
    )
    {
        fixed (float2x2* valuePtr = values)
            Native.glProgramUniformMatrix2fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float3x3> values,
        Bool8 transpose = default
    )
    {
        fixed (float3x3* valuePtr = values)
            Native.glProgramUniformMatrix3fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float4x4> values,
        Bool8 transpose = default
    )
    {
        fixed (float4x4* valuePtr = values)
            Native.glProgramUniformMatrix4fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double2x2> values,
        Bool8 transpose = default
    )
    {
        fixed (double2x2* valuePtr = values)
            Native.glProgramUniformMatrix2dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double3x3> values,
        Bool8 transpose = default
    )
    {
        fixed (double3x3* valuePtr = values)
            Native.glProgramUniformMatrix3dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double4x4> values,
        Bool8 transpose = default
    )
    {
        fixed (double4x4* valuePtr = values)
            Native.glProgramUniformMatrix4dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float2x3> values,
        Bool8 transpose = default
    )
    {
        fixed (float2x3* valuePtr = values)
            Native.glProgramUniformMatrix2x3fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float3x2> values,
        Bool8 transpose = default
    )
    {
        fixed (float3x2* valuePtr = values)
            Native.glProgramUniformMatrix3x2fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float2x4> values,
        Bool8 transpose = default
    )
    {
        fixed (float2x4* valuePtr = values)
            Native.glProgramUniformMatrix2x4fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float4x2> values,
        Bool8 transpose = default
    )
    {
        fixed (float4x2* valuePtr = values)
            Native.glProgramUniformMatrix4x2fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float3x4> values,
        Bool8 transpose = default
    )
    {
        fixed (float3x4* valuePtr = values)
            Native.glProgramUniformMatrix3x4fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<float4x3> values,
        Bool8 transpose = default
    )
    {
        fixed (float4x3* valuePtr = values)
            Native.glProgramUniformMatrix4x3fv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (float*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double2x3> values,
        Bool8 transpose = default
    )
    {
        fixed (double2x3* valuePtr = values)
            Native.glProgramUniformMatrix2x3dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double3x2> values,
        Bool8 transpose = default
    )
    {
        fixed (double3x2* valuePtr = values)
            Native.glProgramUniformMatrix3x2dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double2x4> values,
        Bool8 transpose = default
    )
    {
        fixed (double2x4* valuePtr = values)
            Native.glProgramUniformMatrix2x4dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double4x2> values,
        Bool8 transpose = default
    )
    {
        fixed (double4x2* valuePtr = values)
            Native.glProgramUniformMatrix4x2dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double3x4> values,
        Bool8 transpose = default
    )
    {
        fixed (double3x4* valuePtr = values)
            Native.glProgramUniformMatrix3x4dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void UniformArray(
        ReadOnlySpan<byte> startName,
        ReadOnlySpan<double4x3> values,
        Bool8 transpose = default
    )
    {
        fixed (double4x3* valuePtr = values)
            Native.glProgramUniformMatrix4x3dv(
                this,
                GetUniformLocation(startName),
                values.Length,
                transpose,
                (double*)valuePtr
            );
    }

    #endregion

    #region GetUniform

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out float value)
    {
        fixed (float* valuePtr = &value)
            Native.glGetUniformfv(this, GetUniformLocation(name), valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out float2 value)
    {
        fixed (float2* valuePtr = &value)
            Native.glGetUniformfv(this, GetUniformLocation(name), (float*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out float3 value)
    {
        fixed (float3* valuePtr = &value)
            Native.glGetUniformfv(this, GetUniformLocation(name), (float*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out float4 value)
    {
        fixed (float4* valuePtr = &value)
            Native.glGetUniformfv(this, GetUniformLocation(name), (float*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out double value)
    {
        fixed (double* valuePtr = &value)
            Native.glGetUniformdv(this, GetUniformLocation(name), valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out double2 value)
    {
        fixed (double2* valuePtr = &value)
            Native.glGetUniformdv(this, GetUniformLocation(name), (double*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out double3 value)
    {
        fixed (double3* valuePtr = &value)
            Native.glGetUniformdv(this, GetUniformLocation(name), (double*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out double4 value)
    {
        fixed (double4* valuePtr = &value)
            Native.glGetUniformdv(this, GetUniformLocation(name), (double*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out int value)
    {
        fixed (int* valuePtr = &value)
            Native.glGetUniformiv(this, GetUniformLocation(name), valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out int2 value)
    {
        fixed (int2* valuePtr = &value)
            Native.glGetUniformiv(this, GetUniformLocation(name), (int*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out int3 value)
    {
        fixed (int3* valuePtr = &value)
            Native.glGetUniformiv(this, GetUniformLocation(name), (int*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out int4 value)
    {
        fixed (int4* valuePtr = &value)
            Native.glGetUniformiv(this, GetUniformLocation(name), (int*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out uint value)
    {
        fixed (uint* valuePtr = &value)
            Native.glGetUniformuiv(this, GetUniformLocation(name), valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out uint2 value)
    {
        fixed (uint2* valuePtr = &value)
            Native.glGetUniformuiv(this, GetUniformLocation(name), (uint*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out uint3 value)
    {
        fixed (uint3* valuePtr = &value)
            Native.glGetUniformuiv(this, GetUniformLocation(name), (uint*)valuePtr);
    }

    public unsafe void GetUniform(ReadOnlySpan<byte> name, out uint4 value)
    {
        fixed (uint4* valuePtr = &value)
            Native.glGetUniformuiv(this, GetUniformLocation(name), (uint*)valuePtr);
    }

    #endregion

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlProgram Attach(GlShader shader)
    {
        Native.glAttachShader(this, shader);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlProgram Attach(params Span<GlShader> shaders)
    {
        foreach (var glShader in shaders)
            Native.glAttachShader(this, glShader);

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlProgram Link()
    {
        Native.glLinkProgram(this);

        if (GetProgram(Property.LinkStatus) != GL_TRUE)
            throw new LinkException(this);

        return this;
    }

    private unsafe string GetProgramInfoLog()
    {
        var logSize = GetProgram(Property.InfoLogLength);
        if (logSize <= 0)
            return string.Empty;

        var infoLogPtr = stackalloc byte[logSize];
        Native.glGetProgramInfoLog(this, logSize, null, infoLogPtr);

        return Utf8StringMarshaller.ConvertToManaged(infoLogPtr) ?? string.Empty;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private unsafe int GetProgram(Property property)
    {
        int outValue;
        Native.glGetProgramiv(this, (uint)property, &outValue);
        return outValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe int GetUniformLocation(ReadOnlySpan<byte> name)
    {
        fixed (byte* namePtr = name)
            return Native.glGetUniformLocation(this, namePtr);
    }

    public unsafe void Dispose()
    {
        Native.glDeleteProgram(this);
    }
}
