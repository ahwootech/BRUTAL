namespace Brutal.TextureApi;

/// <summary>
/// Represents 3 dimensions of counts of texels.
/// No semantics are applied to these values. Zero and negative values are valid
/// inside TexelCount3 even though they are not w.r.t. a mip level texture
/// </summary>
public record struct TexelCount3(int X, int Y, int Z) { }
