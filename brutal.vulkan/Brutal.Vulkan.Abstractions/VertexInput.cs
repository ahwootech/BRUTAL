using System.Collections.Concurrent;
using System.Reflection;

namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Controls how <c>(s)byte</c> or <c>(u)short</c> types are mapped to shader-compatible types.
/// </summary>
public enum Behavior
{
    /// <summary>
    /// Small integer types should map to a 32-bit integer type, potentially signed.
    /// </summary>
    /// <example>
    /// <list type="bullet">
    ///     <item><c>sbyte</c> will map to <c>int</c></item>
    ///     <item><c>sbyte3</c> will map to <c>ivec3</c></item>
    ///     <item><c>byte</c> will map to <c>uint</c></item>
    ///     <item><c>byte3</c> will map to <c>uvec3</c></item>
    /// </list>
    /// </example>
    None,

    /// <summary>
    /// Small integer types should map to a normalized floating point range, potentially signed.
    /// </summary>
    /// <example>
    /// <list type="bullet">
    ///     <item><c>sbyte</c> components will be mapped onto a [<c>-1.0f</c> - <c>1.0f</c>] floating point range</item>
    ///     <item><c>byte</c> components will be mapped onto a [<c>0.0f</c> - <c>1.0f</c>] floating point range</item>
    /// </list>
    /// </example>
    Normalize,

    /// <summary>
    /// Small integer types should convert directly to a 32-bit floating point value, maintaining the original value.
    /// </summary>
    /// <example>
    /// <list type="bullet">
    ///     <item><c>byte</c> components will be mapped to a [<c>0.0f</c> - <c>255.0f</c>] floating point range</item>
    ///     <item><c>sbyte</c> components will be mapped to a [<c>-128.0f</c> - <c>127.0f</c>] floating point range</item>
    /// </list>
    /// </example>
    Scale,
}

/// <summary>
/// Controls how <c>(s)byte</c> or <c>(u)short</c> types are mapped to shader-compatible types.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class FixedPointConversionAttribute(Behavior mode) : Attribute
{
    public Behavior Mode = mode;
}

/// <summary>
/// A builder for PipelineVertexInputStateCreateInfo
/// </summary>
public class VertexInput
{
    // csharpier-ignore
    private static readonly Dictionary<Type, AttributeInfo> FormatMap =
        new()
        {
            [typeof(sbyte)] = AttributeInfo.Make<sbyte>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8SInt,
                    NormalizedFormat = VkFormat.R8SNorm,
                        ScaledFormat = VkFormat.R8SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(sbyte2)] = AttributeInfo.Make<sbyte2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8SInt,
                    NormalizedFormat = VkFormat.R8G8SNorm,
                        ScaledFormat = VkFormat.R8G8SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(sbyte3)] = AttributeInfo.Make<sbyte3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8B8SInt,
                    NormalizedFormat = VkFormat.R8G8B8SNorm,
                        ScaledFormat = VkFormat.R8G8B8SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(sbyte4)] = AttributeInfo.Make<sbyte4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8B8A8SInt,
                    NormalizedFormat = VkFormat.R8G8B8A8SNorm,
                        ScaledFormat = VkFormat.R8G8B8A8SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(byte)] = AttributeInfo.Make<byte>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8UInt,
                    NormalizedFormat = VkFormat.R8UNorm,
                        ScaledFormat = VkFormat.R8UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(byte2)] = AttributeInfo.Make<byte2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8UInt,
                    NormalizedFormat = VkFormat.R8G8UNorm,
                        ScaledFormat = VkFormat.R8G8UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(byte3)] = AttributeInfo.Make<byte3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8B8UInt,
                    NormalizedFormat = VkFormat.R8G8B8UNorm,
                        ScaledFormat = VkFormat.R8G8B8UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(byte4)] = AttributeInfo.Make<byte4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R8G8B8A8UInt,
                    NormalizedFormat = VkFormat.R8G8B8A8UNorm,
                        ScaledFormat = VkFormat.R8G8B8A8UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(short)] = AttributeInfo.Make<short>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16SInt,
                    NormalizedFormat = VkFormat.R16SNorm,
                        ScaledFormat = VkFormat.R16SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(short2)] = AttributeInfo.Make<short2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16SInt,
                    NormalizedFormat = VkFormat.R16G16SNorm,
                        ScaledFormat = VkFormat.R16G16SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(short3)] = AttributeInfo.Make<short3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16B16SInt,
                    NormalizedFormat = VkFormat.R16G16B16SNorm,
                        ScaledFormat = VkFormat.R16G16B16SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(short4)] = AttributeInfo.Make<short4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16B16A16SInt,
                    NormalizedFormat = VkFormat.R16G16B16A16SNorm,
                        ScaledFormat = VkFormat.R16G16B16A16SScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(ushort)] = AttributeInfo.Make<ushort>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16UInt,
                    NormalizedFormat = VkFormat.R16UNorm,
                        ScaledFormat = VkFormat.R16UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(ushort2)] = AttributeInfo.Make<ushort2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16UInt,
                    NormalizedFormat = VkFormat.R16G16UNorm,
                        ScaledFormat = VkFormat.R16G16UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(ushort3)] = AttributeInfo.Make<ushort3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16B16UInt,
                    NormalizedFormat = VkFormat.R16G16B16UNorm,
                        ScaledFormat = VkFormat.R16G16B16UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(ushort4)] = AttributeInfo.Make<ushort4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R16G16B16A16UInt,
                    NormalizedFormat = VkFormat.R16G16B16A16UNorm,
                        ScaledFormat = VkFormat.R16G16B16A16UScaled,
                         LayoutCount = 1
                }
            ),
            [typeof(int)] = AttributeInfo.Make<int>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32SInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(int2)] = AttributeInfo.Make<int2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32SInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(int3)] = AttributeInfo.Make<int3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32SInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(int4)] = AttributeInfo.Make<int4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32A32SInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(uint)] = AttributeInfo.Make<uint>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32UInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(uint2)] = AttributeInfo.Make<uint2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32UInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(uint3)] = AttributeInfo.Make<uint3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32UInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(uint4)] = AttributeInfo.Make<uint4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32A32UInt,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(float)] = AttributeInfo.Make<float>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32SFloat,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(float2)] = AttributeInfo.Make<float2>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32SFloat,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(float3)] = AttributeInfo.Make<float3>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32SFloat,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(float4)] = AttributeInfo.Make<float4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32A32SFloat,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 1
                }
            ),
            [typeof(float4x4)] = AttributeInfo.Make<float4>(
                new CreateAttributeInfo
                {
                       DefaultFormat = VkFormat.R32G32B32A32SFloat,
                    NormalizedFormat = VkFormat.Undefined,
                        ScaledFormat = VkFormat.Undefined,
                         LayoutCount = 4
                }
            )
        };

    /// <summary>
    /// Error codes for vertex input validation
    /// </summary>
    public enum Error
    {
        /// <summary>
        /// Vertex input is valid
        /// </summary>
        Ok,

        /// <summary>
        /// A binding has been declared more than once
        /// </summary>
        DuplicateBinding,

        /// <summary>
        /// An attribute has been declared more than once to a single location
        /// </summary>
        DuplicateLocation,

        /// <summary>
        /// An attribute's offset exceeds the stride of the binding
        /// </summary>
        OffsetExceedsStride,

        /// <summary>
        /// An attribute references a binding that has not been declared
        /// </summary>
        AttributeReferencesNonExistentBinding,

        /// <summary>
        /// A binding has a stride of zero
        /// </summary>
        BindingHasZeroStride,
    }

    /// <summary>
    /// The list of bindings that can be used by the vertex input
    /// </summary>
    public NativeList<VkVertexInputBindingDescription> Bindings;

    /// <summary>
    /// The list of attributes that can be used by the vertex input across all bindings
    /// </summary>
    public NativeList<VkVertexInputAttributeDescription> Attributes;

    private PtrOwner<VkPipelineVertexInputStateCreateInfo> _createInfo = new(
        new VkPipelineVertexInputStateCreateInfo { }
    );

    /// <summary>
    /// The list of attributes that can be used by the vertex input across all bindings
    /// </summary>
    PtrOwner<VkPipelineVertexInputStateCreateInfo> GetCreateInfo()
    {
        _createInfo.Value = _createInfo.Value with
        {
            VertexBindingDescriptions = Bindings.Ptr,
            VertexAttributeDescriptions = Attributes.Ptr,
            VertexBindingDescriptionCount = Bindings.Count,
            VertexAttributeDescriptionCount = Attributes.Count,
        };

        return _createInfo;
    }

    /// <summary>
    /// Construct a new VertexInput builder
    /// </summary>
    /// <param name="bindingCapacity">Preallocate with this many bindings</param>
    /// <param name="attributeCapacity">Preallocate with this many attributes</param>
    public VertexInput(int bindingCapacity, int attributeCapacity)
    {
        Bindings = new NativeList<VkVertexInputBindingDescription>(bindingCapacity);
        Attributes = new NativeList<VkVertexInputAttributeDescription>(attributeCapacity);
    }

    /// <summary>
    /// Construct with a complete input layout structure
    /// </summary>
    public VertexInput(
        Span<VkVertexInputBindingDescription> bindings,
        Span<VkVertexInputAttributeDescription> attributes
    )
    {
        Bindings = new NativeList<VkVertexInputBindingDescription>(bindings);
        Attributes = new NativeList<VkVertexInputAttributeDescription>(attributes);
    }

    /// <summary>
    /// Reset for reuse
    /// </summary>
    public void Reset()
    {
        Bindings.Count = 0;
        Attributes.Count = 0;
    }

    /// <summary>
    /// Clone this vertex input
    /// </summary>
    public VertexInput Clone()
    {
        return new VertexInput(Bindings.AsSpan(), Attributes.AsSpan());
    }

    /// <summary>
    /// Implicit cast to the <see cref="VkPipelineVertexInputStateCreateInfo">PipelineVertexInputStateCreateInfo</see> structure
    /// </summary>
    public static unsafe implicit operator VkPipelineVertexInputStateCreateInfo*(VertexInput inValue) =>
        inValue.GetCreateInfo();

    /// <summary>
    /// Add a binding to the vertex input
    /// </summary>
    /// <param name="binding">The buffer slot</param>
    /// <param name="stride">The size of one vertex</param>
    /// <param name="vertexInputRate">Whether this binding will be per vertex or per instance</param>
    /// <returns>The builder</returns>
    public VertexInput AddBinding(int binding, ByteSize stride, VkVertexInputRate vertexInputRate)
    {
        return AddBinding(
            new VkVertexInputBindingDescription
            {
                Binding = binding,
                Stride = stride,
                InputRate = vertexInputRate,
            }
        );
    }

    /// <summary>
    /// Add a binding to the vertex input, inferring the stride from the templated type
    /// </summary>
    /// <param name="binding">The buffer slot</param>
    /// <param name="vertexInputRate">Whether this binding will be per vertex or per instance</param>
    /// <typeparam name="T">The type of the vertex</typeparam>
    /// <returns>The builder</returns>
    public VertexInput AddBinding<T>(int binding, VkVertexInputRate vertexInputRate)
    {
        if (FormatMap.TryGetValue(typeof(T), out var typeInfo))
        {
            return AddBinding(binding, typeInfo.GetTotalSize(Behavior.None), vertexInputRate);
        }

        var size = 0;

        foreach (var field in GetFieldLayout(typeof(T)))
            size += (int)field.Info.GetTotalSize(field.Mode);

        return AddBinding(binding, ByteSize.Of(size), vertexInputRate);
    }

    /// <summary>
    /// Add a binding to the vertex input
    /// </summary>
    /// <param name="binding">The buffer slot</param>
    /// <returns>The builder</returns>
    public VertexInput AddBinding(VkVertexInputBindingDescription binding)
    {
        Bindings.Add(binding);
        return this;
    }

    /// <summary>
    /// Add an attribute to the vertex input for a given binding
    /// </summary>
    /// <param name="location">The index of this attribute</param>
    /// <param name="binding">The buffer slot this attribute will be read from</param>
    /// <param name="format">The format of the attribute</param>
    /// <param name="offset">The offset into the buffer to find this attribute</param>
    /// <returns>The builder</returns>
    public VertexInput AddAttribute(int location, int binding, VkFormat format, ByteSize offset)
    {
        return AddAttribute(
            new VkVertexInputAttributeDescription
            {
                Location = location,
                Binding = binding,
                Format = format,
                Offset = offset,
            }
        );
    }

    /// <summary>
    /// Add an attribute to the vertex input for a given binding
    /// </summary>
    /// <param name="location">The index of this attribute</param>
    /// <param name="binding">The buffer slot this attribute will be read from</param>
    /// <param name="offset">The offset into the buffer to find this attribute</param>
    /// <param name="mode">The behaviour of the attribute</param>
    /// <returns>The builder</returns>
    public VertexInput AddAttribute<T>(int location, int binding, ByteSize offset, Behavior mode)
    {
        var info = FormatMap[typeof(T)];
        var format = info.GetFormat(mode);

        for (var j = 0; j < info.Num; ++j)
        {
            AddAttribute(location, binding, format, offset);
            offset += info.GetBehaviourStride(mode);
            location += 1;
        }

        return this;
    }

    /// <summary>
    /// Add an attribute to the vertex input
    /// </summary>
    /// <param name="attribute">The attibute to add</param>
    /// <returns>The builder</returns>
    public VertexInput AddAttribute(VkVertexInputAttributeDescription attribute)
    {
        Attributes.Add(attribute);
        return this;
    }

    /// <summary>
    /// Create a new binding containing a single attribute for the templated type
    /// </summary>
    /// <param name="location">The index</param>
    /// <param name="binding">The buffer slot</param>
    /// <param name="vertexInputRate">Whether this binding will be per vertex or per instance</param>
    /// <param name="mode">The behaviour of certain formats</param>
    /// <typeparam name="T">The type of the vertex</typeparam>
    public VertexInput AddAttributeBinding<T>(
        int location,
        int binding,
        VkVertexInputRate vertexInputRate,
        Behavior mode = Behavior.None
    )
    {
        return AddBinding<T>(binding, vertexInputRate).AddAttribute<T>(location, binding, ByteSize.Zero, mode);
    }

    /// <summary>
    /// Create a new binding and add attributes for the templated type
    /// </summary>
    /// <param name="firstLocation">The starting index</param>
    /// <param name="binding">The buffer slot</param>
    /// <param name="vertexInputRate">Whether this binding will be per vertex or per instance</param>
    /// <typeparam name="T">The type of the vertex</typeparam>
    public VertexInput AddBindingWithAttributes<T>(int firstLocation, int binding, VkVertexInputRate vertexInputRate)
    {
        return AddBinding<T>(binding, vertexInputRate).AddAttributes<T>(firstLocation, binding, ByteSize.Zero);
    }

    /// <summary>
    /// Add attributes for the templated type, for some existing binding
    /// </summary>
    /// <param name="firstLocation">The starting index</param>
    /// <param name="binding">The buffer slot</param>
    /// <param name="firstOffset">The starting byte offset</param>
    /// <typeparam name="T">The type of the vertex</typeparam>
    public VertexInput AddAttributes<T>(int firstLocation, int binding, ByteSize firstOffset)
    {
        var location = firstLocation;
        var offset = firstOffset;

        foreach (var field in GetFieldLayout(typeof(T)))
        {
            var info = field.Info;
            var format = info.GetFormat(field.Mode);

            for (var j = 0; j < info.Num; ++j)
            {
                AddAttribute(location, binding, format, offset);
                offset += info.GetBehaviourStride(field.Mode);
                location += 1;
            }
        }

        return this;
    }

    /// <summary>
    /// Cached per-type field layout so reflection runs once per vertex type instead of on every call.
    /// </summary>
    private readonly record struct FieldLayout(AttributeInfo Info, Behavior Mode);

    private static readonly ConcurrentDictionary<Type, FieldLayout[]> LayoutCache = new();

    private static FieldLayout[] GetFieldLayout(Type type)
    {
        return LayoutCache.GetOrAdd(
            type,
            static t =>
            {
                var fields = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                var layout = new FieldLayout[fields.Length];
                for (var i = 0; i < fields.Length; i++)
                {
                    var info = FormatMap[fields[i].FieldType];
                    var mode =
                        (
                            Attribute.GetCustomAttribute(fields[i], typeof(FixedPointConversionAttribute))
                            as FixedPointConversionAttribute
                        )?.Mode ?? Behavior.None;
                    layout[i] = new FieldLayout(info, mode);
                }
                return layout;
            }
        );
    }

    /// <summary>
    /// Test that the vertex input is valid
    /// </summary>
    /// <returns></returns>
    public Error Test()
    {
        for (var i = 0; i < Bindings.Count; ++i)
        {
            if (Bindings[i].Stride == 0)
                return Error.BindingHasZeroStride;

            for (var j = 0; j < Bindings.Count; ++j)
            {
                if (i == j)
                    continue;

                if (Bindings[i].Binding == Bindings[j].Binding)
                    return Error.DuplicateBinding;
            }
        }

        for (var i = 0; i < Attributes.Count; ++i)
        {
            for (var j = 0; j < Attributes.Count; ++j)
            {
                if (i == j)
                    continue;

                if (Attributes[i].Location == Attributes[j].Location)
                    return Error.DuplicateLocation;
            }

            var foundBinding = false;
            for (var j = 0; j < Bindings.Count; j++)
            {
                if (Attributes[i].Binding == Bindings[j].Binding)
                {
                    foundBinding = true;

                    if (Attributes[i].Offset >= Bindings[j].Stride)
                        return Error.OffsetExceedsStride;

                    break;
                }
            }

            if (!foundBinding)
                return Error.AttributeReferencesNonExistentBinding;
        }

        return Error.Ok;
    }

    public struct CreateAttributeInfo()
    {
        public required int LayoutCount = 1;
        public required VkFormat DefaultFormat;
        public required VkFormat NormalizedFormat = VkFormat.Undefined;
        public required VkFormat ScaledFormat = VkFormat.Undefined;
    }

    public class AttributeInfo(CreateAttributeInfo info, ByteSize inStride)
    {
        public readonly int Num = info.LayoutCount;

        // Stride with default behaviour
        public readonly ByteSize Stride = inStride;

        public ByteSize GetBehaviourStride(Behavior mode) => mode == Behavior.None ? Stride : ByteSize.Of<float>();

        public ByteSize GetTotalSize(Behavior mode) => GetBehaviourStride(mode) * Num;

        public VkFormat GetFormat(Behavior mode)
        {
            var format = GetFormatInternal(mode);
            if (format == VkFormat.Undefined)
                throw new InvalidOperationException($"Format {mode} not supported for this type!");
            return format;
        }

        private VkFormat GetFormatInternal(Behavior mode)
        {
            return mode switch
            {
                Behavior.None => info.DefaultFormat,
                Behavior.Normalize => info.NormalizedFormat,
                Behavior.Scale => info.ScaledFormat,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
            };
        }

        public static AttributeInfo Make<T>(CreateAttributeInfo info)
            where T : unmanaged
        {
            var size = ByteSize.Of<T>();
            return new AttributeInfo(info, size);
        }
    }

    // Binary-compat shim for assemblies compiled against the old params Type[] signature
    public static int Count(params Type[] types) => Count((ReadOnlySpan<Type>)types);

    /// <summary>
    /// Count the number of rendering attributes for the given type(s).
    /// </summary>
    /// <remarks>
    /// Counts every instance field (public and non-public) exactly as <see cref="AddBinding{T}"/> and
    /// <see cref="AddAttributes{T}"/> lay them out, via the shared field-layout cache. Static fields are
    /// not counted. This differs from the historical behaviour, which counted public fields including
    /// static ones; the two are now consistent so a count always matches the emitted binding.
    /// </remarks>
    public static int Count(params ReadOnlySpan<Type> types)
    {
        var count = 0;

        foreach (var type in types)
        foreach (var field in GetFieldLayout(type))
            count += field.Info.Num;

        return count;
    }

    /// <summary>
    /// Check the validity of the vertex input structure
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public VertexInput Check()
    {
        var error = Test();

        if (error != Error.Ok)
            throw new InvalidOperationException($"Invalid vertex input: {error}");

        return this;
    }
}
