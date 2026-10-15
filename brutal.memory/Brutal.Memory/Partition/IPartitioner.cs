namespace Brutal.Memory;

/// <summary>
/// Interface for an object that has a size (Eg: a buffer)
/// </summary>
public interface ISize
{
    /// <summary>
    /// Size of the object's internals
    /// </summary>
    public int Size { get; }
}

/// <summary>
/// Interface for an object that has a 2D size (Eg: a texture)
/// </summary>
public interface ISize2D
{
    /// <summary>
    /// Width of the object
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// Height of the object
    /// </summary>
    public int Height { get; }
}
