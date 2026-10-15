namespace Brutal.TextureApi;

/// <summary>
///     Extension methods library for ITexture
/// </summary>
public static class DerivedTexturePropertiesExtensions
{
    extension(ITexture texture)
    {
        /// <summary>
        /// Determines whether the specified texture represents a 3-dimensional texture.
        /// </summary>
        /// <value>true if the texture has three dimensions; otherwise, false.</value>
        public bool Is3d => texture.DimensionCount == 3;

        /// <summary>
        /// Determines whether the specified texture represents a two-dimensional texture.
        /// </summary>
        /// <value>true if the texture has exactly two dimensions; otherwise, false.</value>
        public bool Is2d => texture.DimensionCount == 2;

        /// <summary>
        /// Determines whether the specified texture is one-dimensional.
        /// </summary>
        /// <value>true if the texture has a single dimension; otherwise, false.</value>
        public bool Is1d => texture.DimensionCount == 1;

        /// <summary>
        ///     The width of this texture (in texels)
        /// </summary>
        public int Width => texture.Extent.X;

        /// <summary>
        ///     The height of this texture (in texels)
        /// </summary>
        public int Height => texture.Extent.Y;

        /// <summary>
        ///     The depth of this texture (in texels)
        /// </summary>
        public int Depth => texture.Extent.Z;

        /// <summary>
        /// Calculates the dimensions of a texture at the specified mipmap level.
        /// </summary>
        /// <param name="level">The mipmap level for which to calculate the extent. Must be greater than or equal to zero.</param>
        /// <returns>A TexelCount3 containing the width, height, and depth of the texture at the specified mipmap level. Each
        /// dimension will be at least 1.</returns>
        public TexelCount3 Extent(int level) =>
            new(
                Math.Max(1, texture.Width >> level),
                Math.Max(1, texture.Height >> level),
                Math.Max(1, texture.Depth >> level)
            );
    }
}
