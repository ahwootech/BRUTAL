namespace Brutal.GltfApi;

public partial class Accessor
{
    /// <summary>
    /// Gets the size in bytes of a single element of this accessor
    /// </summary>
    /// <returns>Size in bytes of accessor element, accounting for component type, and it's vector element count</returns>
    /// <exception cref="InvalidOperationException">Unsupported type</exception>
    public ByteSize ElementSize()
    {
        var componentSize = ComponentType switch
        {
            ComponentTypeEnum.Byte => 1,
            ComponentTypeEnum.UnsignedByte => 1,
            ComponentTypeEnum.Short => 2,
            ComponentTypeEnum.UnsignedShort => 2,
            ComponentTypeEnum.UnsignedInt => 4,
            ComponentTypeEnum.Float => 4,
            _ => throw new InvalidOperationException($"Unsupported component type {ComponentType}"),
        };
        var typeCount = Type switch
        {
            TypeEnum.Scalar => 1,
            TypeEnum.Vec2 => 2,
            TypeEnum.Vec3 => 3,
            TypeEnum.Vec4 => 4,
            TypeEnum.Mat2 => 4,
            TypeEnum.Mat3 => 9,
            TypeEnum.Mat4 => 16,
            _ => throw new InvalidOperationException($"Unsupported accessor type {Type}"),
        };
        return ByteSize.Of(componentSize * typeCount);
    }
}
