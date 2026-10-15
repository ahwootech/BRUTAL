// ReSharper disable InconsistentNaming

namespace Brutal.Numerics;

/// <summary>Defines a generic quaternion type.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
/* A quaternion IS a component tuple - four lanes of T, indexable, spannable, constructible from a
 * span - and used to restate ComponentSize, ComponentCount, the indexer, Create, AsSpan, IEquatable
 * and IFormattable verbatim rather than inherit them.
 *
 * It reaches the function axis the same way, by inheriting rather than redeclaring: a quaternion
 * has a dot product and a magnitude, which is exactly why those interfaces carry no family in their
 * names. It has NO IDistance, and that omission is the point - Euclidean distance is not the metric
 * on rotations. */
public interface IQuaternion<TSelf, T> : IComponentTuple<TSelf, T>, IDotProduct<TSelf, T>, IMagnitude<TSelf, T>
    where TSelf : IQuaternion<TSelf, T>
{
    /// <inheritdoc cref="Quaternion.Zero" />
    static abstract TSelf Zero { get; }

    /// <inheritdoc cref="Quaternion.Identity" />
    static abstract TSelf Identity { get; }

    /// <inheritdoc cref="Quaternion.IsIdentity" />
    bool IsIdentity { get; }

    /* The static algebra surface: exposes the statics that already exist on every quaternion
     * type, so generic code can call them through the interface (satisfied implicitly).
     * Cross-type members (CreateFromAxisAngle and friends) live on IQuaternionFactories below,
     * which is where the axis and matrix type parameters they need are paid for. */

    /// <inheritdoc cref="Quaternion.Add" />
    static abstract TSelf Add(TSelf left, TSelf right);

    /// <inheritdoc cref="Quaternion.Subtract" />
    static abstract TSelf Subtract(TSelf left, TSelf right);

    /// <inheritdoc cref="Quaternion.Multiply(Quaternion, Quaternion)" />
    static abstract TSelf Multiply(TSelf left, TSelf right);

    /// <inheritdoc cref="Quaternion.Multiply(Quaternion, float)" />
    static abstract TSelf Multiply(TSelf left, T right);

    /// <inheritdoc cref="Quaternion.Negate" />
    static abstract TSelf Negate(TSelf value);

    /// <inheritdoc cref="Quaternion.Concatenate" />
    static abstract TSelf Concatenate(TSelf first, TSelf second);

    /// <inheritdoc cref="Quaternion.Conjugate" />
    static abstract TSelf Conjugate(TSelf value);

    /// <inheritdoc cref="Quaternion.Inverse" />
    static abstract TSelf Inverse(TSelf value);

    /// <inheritdoc cref="Quaternion.Normalize" />
    static abstract TSelf Normalize(TSelf value);

    /// <inheritdoc cref="Quaternion.Normalize" />
    /// <remarks>Returns a zero quaternion if the input quaternion is zero</remarks>
    static abstract TSelf NormalizeOrZero(TSelf value);

    /// <inheritdoc cref="Quaternion.Lerp" />
    static abstract TSelf Lerp(TSelf a, TSelf b, T t);

    /// <inheritdoc cref="Quaternion.Slerp" />
    static abstract TSelf Slerp(TSelf a, TSelf b, T t);
}

internal class QuaternionDebugView<TSelf, T>(IQuaternion<TSelf, T> q)
    where TSelf : IQuaternion<TSelf, T>
{
    public T X => q[0];
    public T Y => q[1];
    public T Z => q[2];
    public T W => q[3];

    public override string? ToString()
    {
        return q.ToString();
    }
}

/// <summary>The named ways of constructing a rotation.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
/// <typeparam name="TVector3">The axis type of <see cref="CreateFromAxisAngle" />.</typeparam>
/// <typeparam name="TMatrix4x4">The matrix type of <see cref="CreateFromRotationMatrix" />.</typeparam>
/* One interface for the three factories rather than one per verb: they are quaternion-only, so by
 * family they belong on IQuaternion itself - but they drag in two more type parameters, and making
 * every caller that just wants a quaternion name four types is the wrong trade. So they group by
 * CONCERN, construction, and the extra parameters are paid only by whoever wants them.
 *
 * Its one consumer is the quaternion differential suite, which is also why the three interfaces it
 * replaces existed - so a suite could reach the members generically. That remains the open question
 * about whether "so a test can reach it" justifies an interface; grouping them at least means the
 * answer costs one name rather than three. */
public interface IQuaternionFactories<TSelf, T, TVector3, TMatrix4x4>
    where TSelf : IQuaternionFactories<TSelf, T, TVector3, TMatrix4x4>
{
    /// <inheritdoc cref="Quaternion.CreateFromAxisAngle" />
    static abstract TSelf CreateFromAxisAngle(TVector3 axis, T angle);

    /// <inheritdoc cref="Quaternion.CreateFromYawPitchRoll" />
    static abstract TSelf CreateFromYawPitchRoll(T yaw, T pitch, T roll);

    /// <inheritdoc cref="Quaternion.CreateFromRotationMatrix" />
    static abstract TSelf CreateFromRotationMatrix(TMatrix4x4 matrix);
}
