// ReSharper disable InconsistentNaming

namespace Brutal.Numerics;

/// <summary>Shape shared by every numerics value: a fixed-width run of identically-typed components.</summary>
/* Non-generic, so shape can be asked about without naming a component type. Says nothing about
 * vectors or numbers - a matrix, a plane and a rect are component tuples too. */
public interface IComponentTuple
{
    /// <summary>Gets the stride of one component in bytes.</summary>
    static abstract int ComponentSize { get; }

    /// <summary>Gets the number of components.</summary>
    static abstract int ComponentCount { get; }
}

/// <inheritdoc cref="IComponentTuple" />
/// <typeparam name="T">The component type.</typeparam>
public interface IComponentTuple<T> : IComponentTuple
{
    /// <summary>Gets or sets the element at the specified index.</summary>
    /// <param name="index">The index of the element to get or set.</param>
    /// <returns>The element at <paramref name="index" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <paramref name="index" /> was less than zero or greater than the number
    ///     of elements.
    /// </exception>
    T this[int index] { get; set; }

    /// <summary>A mutable view over the components.</summary>
    /// <remarks>
    ///     Deliberately NOT a readonly member, because it hands out a writable view. The consequence is that
    ///     calling it on a readonly field or an <see langword="in" /> parameter gets you a span over a
    ///     defensive COPY, so writes there are silently lost - reach for <see cref="AsReadOnlySpan" /> instead.
    /// </remarks>
    Span<T> AsSpan();

    /// <summary>A read-only view over the components, safe in the readonly contexts where <see cref="AsSpan" /> would view a copy.</summary>
    ReadOnlySpan<T> AsReadOnlySpan();

    /// <summary>
    ///     Copies the vector to the given <see cref="Span{T}" />.The length of the destination span must be at least
    ///     as long as there are elements in the source vector.
    /// </summary>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <exception cref="ArgumentException">
    ///     If number of elements in source vector is greater than those available in
    ///     destination span.
    /// </exception>
    void CopyTo(Span<T> destination);

    /// <summary>
    ///     Attempts to copy the vector to the given <see cref="Span{Single}" />. The length of the destination span must
    ///     be at least as long as there are elements in the source vector.
    /// </summary>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <returns>
    ///     <see langword="true" /> if the source vector was successfully copied to <paramref name="destination" />.
    ///     <see langword="false" /> if <paramref name="destination" /> is not large enough to hold the source vector.
    /// </returns>
    bool TryCopyTo(Span<T> destination);
}

/// <inheritdoc cref="IComponentTuple{T}" />
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
/* The rung where a component tuple knows its own type, so it can be constructed and compared.
 * Everything above this point is layout and says nothing about being a vector. */
public interface IComponentTuple<TSelf, T> : IComponentTuple<T>, IEquatable<TSelf>, IFormattable
    where TSelf : IComponentTuple<TSelf, T>
{
    /// <summary>Constructs a value from the leading components of a span.</summary>
    /// <param name="span">A span of at least <see cref="IComponentTuple.ComponentCount" /> components.</param>
    static abstract TSelf Create(ReadOnlySpan<T> span);
}

/* ---------------------------------------------------------------------------
 * FUNCTION. Reductions collapse lanes, so they are not layout - which is why they moved off
 * IComponentTuple. Split where PRESENCE differs rather than per verb: a quaternion has Dot,
 * LengthSquared and Length, and deliberately has no Distance, because Euclidean distance is not the
 * metric on rotations. Each carries its own result type, since a squared reduction and a square root
 * cannot agree on one.
 * --------------------------------------------------------------------------- */

/// <summary>The dot product.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="TResult">What the reduction returns; wider than the component where the
/// component cannot carry the result.</typeparam>
/* No family in the name: quaternions have a dot product too, and are not vectors. LengthSquared
 * lives here rather than beside Length because it is the SELF-dot - the same reduction, so it cannot
 * have a different result type. */
public interface IDotProduct<TSelf, TResult>
    where TSelf : IDotProduct<TSelf, TResult>
{
    /// <summary>The dot product.</summary>
    static abstract TResult Dot(TSelf a, TSelf b);

    /// <summary>The squared magnitude, avoiding the square root.</summary>
    TResult LengthSquared();
}

/// <summary>The magnitude: a square root, so its result type is its own.</summary>
public interface IMagnitude<TSelf, TRoot>
    where TSelf : IMagnitude<TSelf, TRoot>
{
    /// <summary>The magnitude.</summary>
    TRoot Length();
}

/// <summary>Distance between two values, where a Euclidean metric is the right one.</summary>
public interface IDistance<TSelf, TSquared, TRoot>
    where TSelf : IDistance<TSelf, TSquared, TRoot>
{
    /// <summary>The distance between two values.</summary>
    static abstract TRoot Distance(TSelf a, TSelf b);

    /// <summary>The squared distance, avoiding the square root.</summary>
    static abstract TSquared DistanceSquared(TSelf a, TSelf b);
}

/* INumber forces scalar <, <=, > and >= into existence; R^n has no total order, so ours throw.
 * The componentwise forms here are the answers that exist - one bool per lane, reduced by the
 * caller with Any/All, as every shader language spells it. Only one of the two occupies the
 * public slot: the throwing pair is an EXPLICIT implementation of IComparisonOperators, reachable
 * only from code that asked for a total order by naming it.
 * INHERITING IComparisonOperators is load-bearing: without it, constraining on BOTH this
 * interface and INumber makes every comparison CS9342-ambiguous (measured); with it, the
 * redeclarations HIDE the scalar pair and the mask form wins. Pinned in ComparisonDispatchTests. */

/// <summary>Defines componentwise relational operators, each returning a per-component mask.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="TMask">The boolean vector of matching arity.</typeparam>
public interface IComponentwiseComparison<TSelf, TMask> : IComparisonOperators<TSelf, TSelf, bool>
    where TSelf : IComponentwiseComparison<TSelf, TMask>
{
    /// <summary>Compares each pair of components for less-than.</summary>
    static abstract TMask operator <(TSelf a, TSelf b);

    /// <summary>Compares each pair of components for less-than-or-equal.</summary>
    static abstract TMask operator <=(TSelf a, TSelf b);

    /// <summary>Compares each pair of components for greater-than.</summary>
    static abstract TMask operator >(TSelf a, TSelf b);

    /// <summary>Compares each pair of components for greater-than-or-equal.</summary>
    static abstract TMask operator >=(TSelf a, TSelf b);
}

/// <summary>Defines a generic vector type.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
/* Inherits IEqualityOperators so the ==/!= below are REDECLARATIONS that hide it - the same
 * CS9342 cure as IComponentwiseComparison, needed the moment any second route brings
 * IEqualityOperators into a constraint closure alongside this interface (the bundles do, through
 * IComparisonOperators; INumberBase does for any caller naming both). */
public interface IVector<TSelf, T> : IComponentTuple<TSelf, T>, IEqualityOperators<TSelf, TSelf, bool>
    where TSelf : IVector<TSelf, T>
{
    /// <summary>Gets the zero vector.</summary>
    static abstract TSelf Zero { get; }

    /// <summary>Gets the one vector.</summary>
    static abstract TSelf One { get; }

    /// <summary>Returns a value that indicates whether each pair of elements in two specified vectors is equal.</summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    public static abstract bool operator ==(TSelf left, TSelf right);

    /// <summary>Returns a value that indicates whether two specified vectors are not equal.</summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    public static abstract bool operator !=(TSelf left, TSelf right);
}

/// <summary>Defines a integer vector type.</summary>
public interface INumericVector<TSelf, in T>
    where TSelf : INumericVector<TSelf, T>
{
    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector to add.</param>
    /// <param name="right">The second vector to add.</param>
    /// <returns>The summed vector.</returns>
    public static abstract TSelf operator +(TSelf left, TSelf right);

    /// <summary>Subtracts the second vector from the first.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    public static abstract TSelf operator -(TSelf left, TSelf right);

    /// <summary>Returns a new vector whose values are the product of each pair of elements in two specified vectors.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The element-wise product vector.</returns>
    public static abstract TSelf operator *(TSelf left, TSelf right);

    /// <summary>Divides the first vector by the second.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    public static abstract TSelf operator /(TSelf left, TSelf right);

    /// <summary>Multiplies the specified vector by the specified scalar value.</summary>
    /// <param name="left">The vector.</param>
    /// <param name="right">The scalar value.</param>
    /// <returns>The scaled vector.</returns>
    public static abstract TSelf operator *(TSelf left, T right);

    /// <summary>Divides the specified vector by a specified scalar value.</summary>
    /// <param name="value1">The vector.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The result of the division.</returns>
    public static abstract TSelf operator /(TSelf value1, T value2);

    /// <summary>Multiplies the scalar value by the specified vector.</summary>
    /// <param name="left">The vector.</param>
    /// <param name="right">The scalar value.</param>
    /// <returns>The scaled vector.</returns>
    public static abstract TSelf operator *(T left, TSelf right);

    /// <summary>Negates the specified vector.</summary>
    /// <param name="value">The vector to negate.</param>
    /// <returns>The negated vector.</returns>
    public static abstract TSelf operator -(TSelf value);
}

/// <summary>Defines a integer vector type.</summary>
public interface IBooleanVector<TSelf, T> : IVector<TSelf, T>
    where TSelf : IBooleanVector<TSelf, T>
{
    /// <summary>OR operation</summary>
    public static abstract TSelf operator |(TSelf a, TSelf b);

    /// <summary>AND operation</summary>
    public static abstract TSelf operator &(TSelf a, TSelf b);

    /// <summary>Whether any component is true.</summary>
    bool Any { get; }

    /// <summary>Whether every component is true.</summary>
    bool All { get; }
}

/* TResult is what C# promotion gives the component: int for sbyte, byte, short and ushort, and the
 * component itself for int, uint, long and ulong. The square roots are TRoot, since a sqrt has no
 * integer answer: float for the 4-byte-and-under components, double for the 8-byte ones, whose
 * magnitude float cannot hold.
 * T is no longer contravariant, because the magnitude returns TRoot and the reductions return
 * TResult; variance never applied to the struct implementers anyway. */

/// <summary>Defines a integer vector type.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
/// <typeparam name="TResult">What a reduction returns: the C# promotion of <typeparamref name="T" />.</typeparam>
/// <typeparam name="TRoot">What a square root returns: float, or double for the 8-byte components.</typeparam>
public interface IIntegerVector<TSelf, T, TResult, TRoot>
    : INumericVector<TSelf, T>,
        IDotProduct<TSelf, TResult>,
        IMagnitude<TSelf, TRoot>,
        IDistance<TSelf, TResult, TRoot>
    where TSelf : IIntegerVector<TSelf, T, TResult, TRoot>
{
    /* The half of IBinaryInteger that means something for a vector. The other ten members are the
     * scalar wire-encoding suite and are undefined here - nothing says whether a big-endian int3
     * byte-swaps each component, reverses component order, or both - so taking the whole interface
     * would mean inventing a contract to satisfy something nothing constrains on. Every integer
     * family has all five, so it is a family trait and belongs here rather than in a name of its
     * own. */

    /// <inheritdoc cref="IBinaryInteger{TSelf}.PopCount" />
    static abstract TSelf PopCount(TSelf value);

    /// <inheritdoc cref="IBinaryInteger{TSelf}.LeadingZeroCount" />
    static abstract TSelf LeadingZeroCount(TSelf value);

    /// <inheritdoc cref="IBinaryInteger{TSelf}.TrailingZeroCount" />
    static abstract TSelf TrailingZeroCount(TSelf value);

    /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateLeft" />
    static abstract TSelf RotateLeft(TSelf value, int rotateAmount);

    /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateRight" />
    static abstract TSelf RotateRight(TSelf value, int rotateAmount);
}

/// <inheritdoc cref="IIntegerVector{TSelf,T,TResult,TRoot}" />
/* Inherits rather than paralleling it: a signed integer vector IS an integer vector, and the two
 * were siblings only because neither declared anything to share. Now that the bit-counting members
 * live on the base, the difference is exactly Abs. */
public interface ISignedIntegerVector<TSelf, T, TResult, TRoot> : IIntegerVector<TSelf, T, TResult, TRoot>
    where TSelf : ISignedIntegerVector<TSelf, T, TResult, TRoot>
{
    /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
    /// <param name="value">A vector.</param>
    /// <returns>The absolute value vector.</returns>
    public static abstract TSelf Abs(TSelf value);
}

/// <summary>Defines a floating vector type.</summary>
/* Named for the FAMILY, not for a BCL rung: it carries the family's math, and the rung the concrete
 * types reach (IFloatingPointIeee754) is declared on them, not here. "Floating" rather than
 * "FloatingPoint" so the four family names share one shape - IIntegerVector, ISignedIntegerVector,
 * IBooleanVector, IFloatingVector - and so the only one colliding with a real BCL interface name
 * stops doing so. */
public interface IFloatingVector<TSelf, T>
    : INumericVector<TSelf, T>,
        IDotProduct<TSelf, T>,
        IMagnitude<TSelf, T>,
        IDistance<TSelf, T, T>
    where TSelf : IFloatingVector<TSelf, T>
{
    /// <summary>Reflects a vector about a surface normal.</summary>
    /* Every floating vector has one at every arity, so it is a family trait. It was its own name
     * only while arity 4 lacked it - Vector4 has no Reflect, which looked like a rule and was an
     * omission. */
    static abstract TSelf Reflect(TSelf vector, TSelf normal);

    /// <inheritdoc cref="Vector3.Normalize" />
    /// <exception cref="DivideByZeroException">Thrown when the input vector is a zero vector.</exception>
    static abstract TSelf Normalize(TSelf value);

    /// <inheritdoc cref="Vector3.Normalize" />
    /// <remarks>Will return a zero vector if the input vector is a zero vector.</remarks>
    static abstract TSelf NormalizeOrZero(TSelf value);

    /* The static algebra surface: exposes the statics that already exist on every floating-point
     * vector type, so generic code can call them through the interface (satisfied implicitly).
     * Dot, Distance and DistanceSquared are no longer here - they are inherited from the reduction
     * interfaces above, which quaternions share and which carry their own result types. */

    /// <inheritdoc cref="Vector3.Add" />
    static abstract TSelf Add(TSelf left, TSelf right);

    /// <inheritdoc cref="Vector3.Subtract" />
    static abstract TSelf Subtract(TSelf left, TSelf right);

    /// <inheritdoc cref="Vector3.Multiply(Vector3, Vector3)" />
    static abstract TSelf Multiply(TSelf left, TSelf right);

    /// <inheritdoc cref="Vector3.Multiply(Vector3, float)" />
    static abstract TSelf Multiply(TSelf left, T right);

    /// <inheritdoc cref="Vector3.Multiply(float, Vector3)" />
    static abstract TSelf Multiply(T left, TSelf right);

    /// <inheritdoc cref="Vector3.Divide(Vector3, Vector3)" />
    static abstract TSelf Divide(TSelf left, TSelf right);

    /// <inheritdoc cref="Vector3.Divide(Vector3, float)" />
    static abstract TSelf Divide(TSelf left, T divisor);

    /// <inheritdoc cref="Vector3.Negate" />
    static abstract TSelf Negate(TSelf value);

    /// <inheritdoc cref="Vector3.Abs" />
    static abstract TSelf Abs(TSelf value);

    /// <inheritdoc cref="Vector3.SquareRoot" />
    static abstract TSelf SquareRoot(TSelf value);

    /// <inheritdoc cref="Vector3.Min" />
    static abstract TSelf Min(TSelf a, TSelf b);

    /// <inheritdoc cref="Vector3.Max" />
    static abstract TSelf Max(TSelf a, TSelf b);

    /// <inheritdoc cref="Vector3.Clamp" />
    static abstract TSelf Clamp(TSelf value, TSelf min, TSelf max);

    /// <inheritdoc cref="Vector3.Lerp(Vector3,Vector3,float)" />
    static abstract TSelf Lerp(TSelf a, TSelf b, T t);
}

/* The arities are SIBLINGS, not a chain. They used to inherit - IVector4 : IVector3 : IVector2 -
 * which meant a float4 satisfied `where TSelf : IVector2<TSelf, T>`, so arity stopped being a proof
 * of anything and a two-component constraint silently accepted four. Each one now states its own
 * full axis set instead of collecting them on the way down. */

/// <summary>Defines a vector2 type.</summary>
public interface IVector2<TSelf, T> : IVector<TSelf, T>
    where TSelf : IVector2<TSelf, T>
{
    /* The components by name. They are FIELDS on the concrete types, and a field cannot
     * implement a property, so each type carries an explicit forwarder - generated, one line
     * each. Worth it because X/Y/Z is how the domain spells a component; the indexer stays for
     * code that walks them. */
    /// <summary>Gets or sets the x component.</summary>
    T X { get; set; }

    /// <summary>Gets or sets the y component.</summary>
    T Y { get; set; }

    /// <summary>Gets the unit x vector.</summary>
    static abstract TSelf UnitX { get; }

    /// <summary>Gets the unit y vector.</summary>
    static abstract TSelf UnitY { get; }
}

/// <summary>Defines a vector3 type.</summary>
public interface IVector3<TSelf, T> : IVector<TSelf, T>
    where TSelf : IVector3<TSelf, T>
{
    /// <summary>Gets or sets the x component.</summary>
    T X { get; set; }

    /// <summary>Gets or sets the y component.</summary>
    T Y { get; set; }

    /// <summary>Gets or sets the z component.</summary>
    T Z { get; set; }

    /// <inheritdoc cref="IVector2{TSelf,T}.UnitX" />
    static abstract TSelf UnitX { get; }

    /// <inheritdoc cref="IVector2{TSelf,T}.UnitY" />
    static abstract TSelf UnitY { get; }

    /// <summary>Gets the unit z vector.</summary>
    static abstract TSelf UnitZ { get; }
}

/// <summary>Defines a vector4 type.</summary>
public interface IVector4<TSelf, T> : IVector<TSelf, T>
    where TSelf : IVector4<TSelf, T>
{
    /// <summary>Gets or sets the x component.</summary>
    T X { get; set; }

    /// <summary>Gets or sets the y component.</summary>
    T Y { get; set; }

    /// <summary>Gets or sets the z component.</summary>
    T Z { get; set; }

    /// <summary>Gets or sets the w component.</summary>
    T W { get; set; }

    /// <inheritdoc cref="IVector2{TSelf,T}.UnitX" />
    static abstract TSelf UnitX { get; }

    /// <inheritdoc cref="IVector2{TSelf,T}.UnitY" />
    static abstract TSelf UnitY { get; }

    /// <inheritdoc cref="IVector3{TSelf,T}.UnitZ" />
    static abstract TSelf UnitZ { get; }

    /// <summary>Gets the unit w vector.</summary>
    static abstract TSelf UnitW { get; }
}

internal class VectorDebugView2<TSelf, T, TRoot>(TSelf v)
    where TSelf : IVector2<TSelf, T>, IMagnitude<TSelf, TRoot>
{
    public T X => v[0];
    public T Y => v[1];
    public TRoot Length => v.Length();

    public override string? ToString()
    {
        return v.ToString();
    }
}

internal class VectorDebugView3<TSelf, T, TRoot>(TSelf v)
    where TSelf : IVector3<TSelf, T>, IMagnitude<TSelf, TRoot>
{
    public T X => v[0];
    public T Y => v[1];
    public T Z => v[2];
    public TRoot Length => v.Length();

    public override string? ToString()
    {
        return v.ToString();
    }
}

internal class VectorDebugView4<TSelf, T, TRoot>(TSelf v)
    where TSelf : IVector4<TSelf, T>, IMagnitude<TSelf, TRoot>
{
    public T X => v[0];
    public T Y => v[1];
    public T Z => v[2];
    public T W => v[3];
    public TRoot Length => v.Length();

    public override string? ToString()
    {
        return v.ToString();
    }
}

/// <summary>Defines the cross product.</summary>
public interface ICrossProduct<TSelf>
    where TSelf : ICrossProduct<TSelf>
{
    /// <inheritdoc cref="Vector3.Cross" />
    static abstract TSelf Cross(TSelf left, TSelf right);
}

/* ----------------------------------------------------------------------------
 * Per-arity floating bundles. Each composes the two axes - the arity interface for layout, the
 * family interface for math - and adds only what neither can carry: the transforms, which name a
 * matrix or a quaternion the vector itself knows nothing about.
 *
 * WHY THE TRANSFORMS ARE DECLARED INLINE rather than composed from ITransform<TSelf, TInput, TBy>
 * capability interfaces. CS0695: a generic type cannot inherit two instantiations of one generic
 * interface if they MAY unify under substitution, and nothing proves TMatrix4x4 != TQuaternion.
 * Probed 2026-08-24, all three cases:
 *
 *   inherit ONE generic instantiation      ITransform<TSelf, TSelf, TMatrix>          compiles
 *   inherit TWO generic instantiations     ... TMatrix and ... TQuat                  CS0695
 *   inherit TWO CONCRETE instantiations    ... float4x4 and ... floatQuat             compiles
 *
 * So the escape hatch is real but useless here: a bundle hardcoding float4x4 cannot serve double3,
 * and the differential suites are one generic body over float and double. Every vector needs at
 * least two transforms (by matrix and by rotation), so no generic bundle can compose them.
 *
 * The alternative was measured rather than assumed: attaching the capabilities to the concrete
 * types instead works and keeps this file free of members it does not own, but moves the cost to
 * every consumer - the arity-4 differential constraint went from one name to ten. Overloads within
 * one interface are fine, so the bundle pays once, here.
 * ---------------------------------------------------------------------------- */

/// <summary>Everything a 2-component floating-point vector can do.</summary>
public interface IFloatingVector2<TSelf, TComponent, TQuaternion, TMatrix3x2, TMatrix4x4>
    : IVector2<TSelf, TComponent>,
        IFloatingVector<TSelf, TComponent>,
        IComponentwiseComparison<TSelf, bool2>
    where TSelf : IFloatingVector2<TSelf, TComponent, TQuaternion, TMatrix3x2, TMatrix4x4>
{
    /// <inheritdoc cref="Vector2.Transform(Vector2, Matrix3x2)" />
    static abstract TSelf Transform(TSelf position, TMatrix3x2 matrix);

    /// <inheritdoc cref="Vector2.Transform(Vector2, Matrix4x4)" />
    static abstract TSelf Transform(TSelf position, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector2.Transform(Vector2, Quaternion)" />
    static abstract TSelf Transform(TSelf value, TQuaternion rotation);

    /// <inheritdoc cref="Vector2.TransformNormal(Vector2, Matrix3x2)" />
    static abstract TSelf TransformNormal(TSelf normal, TMatrix3x2 matrix);

    /// <inheritdoc cref="Vector2.TransformNormal(Vector2, Matrix4x4)" />
    static abstract TSelf TransformNormal(TSelf normal, TMatrix4x4 matrix);
}

/// <summary>Everything a 3-component floating-point vector can do.
/// <typeparamref name="TVector2" /> is the result of the matrix3x2 projection.</summary>
public interface IFloatingVector3<TSelf, TComponent, TVector2, TQuaternion, TMatrix3x2, TMatrix4x4>
    : IVector3<TSelf, TComponent>,
        IFloatingVector<TSelf, TComponent>,
        ICrossProduct<TSelf>,
        IComponentwiseComparison<TSelf, bool3>,
        IMultiplyOperators<TSelf, TMatrix3x2, TVector2>
    where TSelf : IFloatingVector3<TSelf, TComponent, TVector2, TQuaternion, TMatrix3x2, TMatrix4x4>
{
    /// <summary>Static-method twin of the <c>vector * matrix3x2</c> operator (projects to 2 components).</summary>
    static abstract TVector2 Multiply(TSelf vector, TMatrix3x2 matrix);

    /// <inheritdoc cref="Vector3.Transform(Vector3, Matrix4x4)" />
    static abstract TSelf Transform(TSelf position, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector3.Transform(Vector3, Quaternion)" />
    static abstract TSelf Transform(TSelf value, TQuaternion rotation);

    /// <inheritdoc cref="Vector3.TransformNormal(Vector3, Matrix4x4)" />
    static abstract TSelf TransformNormal(TSelf normal, TMatrix4x4 matrix);
}

/// <summary>Everything a 4-component floating-point vector can do.
/// <typeparamref name="TVector2" /> / <typeparamref name="TVector3" /> are the cross-dimension transform inputs.</summary>
public interface IFloatingVector4<TSelf, TComponent, TVector2, TVector3, TQuaternion, TMatrix4x4>
    : IVector4<TSelf, TComponent>,
        IFloatingVector<TSelf, TComponent>,
        IComponentwiseComparison<TSelf, bool4>,
        IMultiplyOperators<TSelf, TMatrix4x4, TSelf>
    where TSelf : IFloatingVector4<TSelf, TComponent, TVector2, TVector3, TQuaternion, TMatrix4x4>
{
    /// <summary>Static-method twin of the <c>vector * matrix4x4</c> operator.</summary>
    static abstract TSelf Multiply(TSelf vector, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector4.Transform(Vector4, Matrix4x4)" />
    static abstract TSelf Transform(TSelf vector, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector4.Transform(Vector4, Quaternion)" />
    static abstract TSelf Transform(TSelf value, TQuaternion rotation);

    // cross-dimension: 2/3-component input transformed up to a 4-component result

    /// <inheritdoc cref="Vector4.Transform(Vector2, Matrix4x4)" />
    static abstract TSelf Transform(TVector2 position, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector4.Transform(Vector2, Quaternion)" />
    static abstract TSelf Transform(TVector2 value, TQuaternion rotation);

    /// <inheritdoc cref="Vector4.Transform(Vector3, Matrix4x4)" />
    static abstract TSelf Transform(TVector3 position, TMatrix4x4 matrix);

    /// <inheritdoc cref="Vector4.Transform(Vector3, Quaternion)" />
    static abstract TSelf Transform(TVector3 value, TQuaternion rotation);
}
