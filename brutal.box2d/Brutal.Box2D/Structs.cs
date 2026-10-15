// ReSharper disable MemberCanBePrivate.Global

using Brutal.Numerics;

namespace Brutal.Box2DApi;

/// <summary>
/// Interface for Box2D objects.
/// </summary>
public interface IBox2DObject<T> : INullable, IEqualityComparer<T> { }

public partial record struct B2World : IBox2DObject<B2World>
{
    /// <inheritdoc />
    public bool IsNull()
    {
        return Index1 == 0 && Generation == 0;
    }

    /// <inheritdoc />
    public bool Equals(B2World x, B2World y)
    {
        return x.Index1 == y.Index1 && x.Generation == y.Generation;
    }

    /// <inheritdoc />
    public int GetHashCode(B2World obj)
    {
        return HashCode.Combine(obj.Index1, obj.Generation);
    }
}

public partial record struct B2Body : IBox2DObject<B2Body>
{
    /// <inheritdoc />
    public bool IsNull()
    {
        return Index1 == 0 && Generation == 0;
    }

    /// <inheritdoc />
    public bool Equals(B2Body x, B2Body y)
    {
        return x.Index1 == y.Index1 && x.Generation == y.Generation;
    }

    /// <inheritdoc />
    public int GetHashCode(B2Body obj)
    {
        return HashCode.Combine(obj.Index1, obj.Generation);
    }
}

public partial record struct B2Chain : IBox2DObject<B2Chain>
{
    /// <inheritdoc />
    public bool IsNull()
    {
        return Index1 == 0 && Generation == 0;
    }

    /// <inheritdoc />
    public bool Equals(B2Chain x, B2Chain y)
    {
        return x.Index1 == y.Index1 && x.Generation == y.Generation;
    }

    /// <inheritdoc />
    public int GetHashCode(B2Chain obj)
    {
        return HashCode.Combine(obj.Index1, obj.Generation);
    }
}

public partial record struct B2Shape : IBox2DObject<B2Shape>
{
    /// <inheritdoc />
    public bool IsNull()
    {
        return Index1 == 0 && Generation == 0;
    }

    /// <inheritdoc />
    public bool Equals(B2Shape x, B2Shape y)
    {
        return x.Index1 == y.Index1 && x.Generation == y.Generation;
    }

    /// <inheritdoc />
    public int GetHashCode(B2Shape obj)
    {
        return HashCode.Combine(obj.Index1, obj.Generation);
    }
}

public partial struct B2BodyDef
{
    /// <inheritdoc cref="Box2D.DefaultBodyDef"/>
    public static readonly B2BodyDef Default = Box2D.DefaultBodyDef();
}

public partial struct B2ChainDef
{
    /// <inheritdoc cref="Box2D.DefaultChainDef"/>
    public static readonly B2ChainDef Default = Box2D.DefaultChainDef();
}

public partial struct B2DebugDraw
{
    /// <inheritdoc cref="Box2D.DefaultDebugDraw"/>
    public static readonly B2DebugDraw Default = Box2D.DefaultDebugDraw();
}

public partial struct B2DistanceJointDef
{
    /// <inheritdoc cref="Box2D.DefaultDistanceJointDef"/>
    public static readonly B2DistanceJointDef Default = Box2D.DefaultDistanceJointDef();
}

public partial struct B2ExplosionDef
{
    /// <inheritdoc cref="Box2D.DefaultExplosionDef"/>
    public static readonly B2ExplosionDef Default = Box2D.DefaultExplosionDef();
}

public partial struct B2Filter
{
    /// <inheritdoc cref="Box2D.DefaultFilter"/>
    public static readonly B2Filter Default = Box2D.DefaultFilter();
}

public partial struct B2FilterJointDef
{
    /// <inheritdoc cref="Box2D.DefaultFilterJointDef"/>
    public static readonly B2FilterJointDef Default = Box2D.DefaultFilterJointDef();
}

public partial struct B2MotorJointDef
{
    /// <inheritdoc cref="Box2D.DefaultMotorJointDef"/>
    public static readonly B2MotorJointDef Default = Box2D.DefaultMotorJointDef();
}

public partial struct B2MouseJointDef
{
    /// <inheritdoc cref="Box2D.DefaultMouseJointDef"/>
    public static readonly B2MouseJointDef Default = Box2D.DefaultMouseJointDef();
}

public partial struct B2PrismaticJointDef
{
    /// <inheritdoc cref="Box2D.DefaultPrismaticJointDef"/>
    public static readonly B2PrismaticJointDef Default = Box2D.DefaultPrismaticJointDef();
}

public partial struct B2QueryFilter
{
    /// <inheritdoc cref="Box2D.DefaultQueryFilter"/>
    public static readonly B2QueryFilter Default = Box2D.DefaultQueryFilter();
}

public partial struct B2RevoluteJointDef
{
    /// <inheritdoc cref="Box2D.DefaultRevoluteJointDef"/>
    public static readonly B2RevoluteJointDef Default = Box2D.DefaultRevoluteJointDef();
}

public partial struct B2WheelJointDef
{
    /// <inheritdoc cref="Box2D.DefaultWheelJointDef"/>
    public static readonly B2WheelJointDef Default = Box2D.DefaultWheelJointDef();
}

public partial struct B2WeldJointDef
{
    /// <inheritdoc cref="Box2D.DefaultWeldJointDef"/>
    public static readonly B2WeldJointDef Default = Box2D.DefaultWeldJointDef();
}

public partial struct B2SurfaceMaterial
{
    /// <inheritdoc cref="Box2D.DefaultSurfaceMaterial"/>
    public static readonly B2SurfaceMaterial Default = Box2D.DefaultSurfaceMaterial();
}

public partial struct B2ShapeDef
{
    /// <inheritdoc cref="Box2D.DefaultShapeDef"/>
    public static readonly B2ShapeDef Default = Box2D.DefaultShapeDef();
}

public partial struct B2WorldDef
{
    /// <inheritdoc cref="Box2D.DefaultWorldDef"/>
    public static readonly B2WorldDef Default = Box2D.DefaultWorldDef();
}

public partial struct B2Rot
{
    /// <summary>
    /// An identity rotation.
    /// </summary>
    public static readonly B2Rot Identity = new(0);

    /// <summary>
    /// Specifies a rotation by sine and cosine values.
    /// </summary>
    public B2Rot(float sine, float cosine)
    {
        S = sine;
        C = cosine;
    }

    /// <summary>
    /// Specifies a rotation by an angle in radians.
    /// </summary>
    public B2Rot(float angle)
    {
        S = MathF.Sin(angle);
        C = MathF.Cos(angle);
    }
}

public partial struct B2Transform
{
    /// <summary>
    /// An identity transformation.
    /// </summary>
    public static readonly B2Transform Identity = new(float2.Zero, B2Rot.Identity);

    /// <summary>
    /// Specifies a transformation with a position and a rotation.
    /// </summary>
    public B2Transform(float2 p, B2Rot q)
    {
        P = p;
        Q = q;
    }
}
