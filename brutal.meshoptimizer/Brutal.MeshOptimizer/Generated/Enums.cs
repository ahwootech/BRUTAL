namespace Brutal.MeshOptimizer
{
    /// <summary>
    ///   Vertex buffer filter encoders
    ///   These functions can be used to encode data in a format that meshopt_decodeFilter can decode
    /// </summary>
    /// <remarks>
    ///   <para>
    ///     meshopt_encodeFilterOct encodes unit vectors with K-bit (2 &lt;= K &lt;= 16) signed X/Y as an output.
    ///     Each component is stored as an 8-bit or 16-bit normalized integer; stride must be equal to 4 or 8. Z will store 1.0f, W is preserved as is.
    ///     Input data must contain 4 floats for every vector (count*4 total).
    ///   </para>
    ///   <para>
    ///     meshopt_encodeFilterQuat encodes unit quaternions with K-bit (4 &lt;= K &lt;= 16) component encoding.
    ///     Each component is stored as an 16-bit integer; stride must be equal to 8.
    ///     Input data must contain 4 floats for every quaternion (count*4 total).
    ///   </para>
    ///   <para>
    ///     meshopt_encodeFilterExp encodes arbitrary (finite) floating-point data with 8-bit exponent and K-bit integer mantissa (1 &lt;= K &lt;= 24).
    ///     Exponent can be shared between all components of a given vector as defined by stride or all values of a given component; stride must be divisible by 4.
    ///     Input data must contain stride/4 floats for every vector (count*stride/4 total).
    ///   </para>
    ///   <para>
    ///     meshopt_encodeFilterColor encodes RGBA color data by converting RGB to YCoCg color space with K-bit (2 &lt;= K &lt;= 16) component encoding; A is stored using K-1 bits.
    ///     Each component is stored as an 8-bit or 16-bit integer; stride must be equal to 4 or 8.
    ///     Input data must contain 4 floats for every color (count*4 total).
    ///   </para>
    /// </remarks>
    public enum MeshOptEncodeExpMode
    {
        /// When encoding exponents, use separate values for each component (maximum quality)
        EncodeExpSeparate,

        /// When encoding exponents, use shared value for all components of each vector (better compression)
        EncodeExpSharedVector,

        /// When encoding exponents, use shared value for each component of all vectors (best compression)
        EncodeExpSharedComponent,

        /// When encoding exponents, use separate values for each component, but clamp to 0 (good quality if very small values are not important)
        EncodeExpClamped,
    }
}
