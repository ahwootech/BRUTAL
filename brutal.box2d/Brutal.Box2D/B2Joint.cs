using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Brutal.Box2DApi;

[NativeMarshalling(typeof(B2JointMarshaller<B2Joint>))]
public partial class B2Joint : IBox2DObject<B2Joint>
{
    [FieldOffset(0)]
    internal ulong InteropValue;

    /// <inheritdoc />
    public bool IsNull()
    {
        return InteropValue == 0;
    }

    /// <inheritdoc />
    public bool Equals(B2Joint? x, B2Joint? y)
    {
        if (x is null && y is null)
            return true;

        if (x is null || y is null)
            return false;

        return x.InteropValue == y.InteropValue;
    }

    /// <inheritdoc />
    public int GetHashCode(B2Joint obj)
    {
        if (obj.IsNull())
            return 0;

        return obj.InteropValue.GetHashCode();
    }
}

[CustomMarshaller(typeof(B2Joint), MarshalMode.Default, typeof(B2JointMarshaller<B2Joint>))]
[CustomMarshaller(typeof(B2DistanceJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2DistanceJoint>))]
[CustomMarshaller(typeof(B2FilterJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2FilterJoint>))]
[CustomMarshaller(typeof(B2MotorJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2MotorJoint>))]
[CustomMarshaller(typeof(B2MouseJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2MouseJoint>))]
[CustomMarshaller(typeof(B2PrismaticJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2PrismaticJoint>))]
[CustomMarshaller(typeof(B2RevoluteJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2RevoluteJoint>))]
[CustomMarshaller(typeof(B2WeldJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2WeldJoint>))]
[CustomMarshaller(typeof(B2WheelJoint), MarshalMode.Default, typeof(B2JointMarshaller<B2WheelJoint>))]
internal static class B2JointMarshaller<T>
    where T : B2Joint, new()
{
    internal static ulong ConvertToUnmanaged(T? managed)
    {
        if (managed is null)
            return 0;

        return managed.InteropValue;
    }

    internal static T? ConvertToManaged(ulong unmanaged)
    {
        if (unmanaged == 0)
            return null;

        return new T { InteropValue = unmanaged };
    }
}
