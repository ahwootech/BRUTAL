namespace Brutal.Numerics;

/// <summary>Defines a generic matrix type.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="T">The component type.</typeparam>
public interface IMatrix<TSelf, T> : IEquatable<TSelf>, IFormattable
    where TSelf : IMatrix<TSelf, T>
{
    /// <summary>Gets the stride of one component in bytes.</summary>
    static abstract int ComponentSize { get; }

    /// <summary>Gets the number of rows.</summary>
    static abstract int RowCount { get; }

    /// <summary>Gets the number of columns.</summary>
    static abstract int ColumnCount { get; }

    /// <summary>Gets or sets the element at the specified row and column.</summary>
    /// <param name="row">The row of the element to get or set.</param>
    /// <param name="column">The column of the element to get or set.</param>
    /// <returns>The element at <paramref name="row" />, <paramref name="column" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <paramref name="row" /> was less than zero or greater than the number of
    ///     rows.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <paramref name="column" /> was less than zero or greater than the number
    ///     of columns.
    /// </exception>
    T this[int row, int column] { get; set; }

    /// <summary>Gets the identity matrix.</summary>
    static abstract TSelf Identity { get; }

    /// <summary>Returns true if this matrix is the identity matrix.</summary>
    bool IsIdentity { get; }

    /// <summary>Construct a matrix of this type from a span</summary>
    static abstract TSelf Create(ReadOnlySpan<T> span);

    /// <summary>Cast this value to a span</summary>
    Span<T> AsSpan();

    /// <summary>A read-only view over the elements, safe in the readonly contexts where <see cref="AsSpan" /> would view a defensive copy.</summary>
    ReadOnlySpan<T> AsReadOnlySpan();
}

/// <summary>Everything a 3x2 (2D affine) floating-point matrix can do.
/// Multiplying by a <typeparamref name="TVector2" /> yields a <typeparamref name="TVector3" />.</summary>
public interface IFloatingMatrix3x2<TSelf, TComponent, TVector2, TVector3>
    : IMatrix<TSelf, TComponent>,
        IMultiplyOperators<TSelf, TVector2, TVector3>
    where TSelf : IFloatingMatrix3x2<TSelf, TComponent, TVector2, TVector3>
{
    /// <summary>Static-method twin of the <c>matrix * vector2</c> operator (expands to 3 components).</summary>
    static abstract TVector3 Multiply(TSelf matrix, TVector2 vector);

    /// <inheritdoc cref="Matrix3x2.Translation" />
    TVector2 Translation { get; }

    /// <inheritdoc cref="Matrix3x2.GetDeterminant" />
    TComponent GetDeterminant();

    /// <inheritdoc cref="Matrix3x2.Invert" />
    static abstract bool Invert(TSelf matrix, out TSelf result);

    /// <inheritdoc cref="Matrix3x2.CreateRotation(float)" />
    static abstract TSelf CreateRotation(TComponent radians);

    /// <inheritdoc cref="Matrix3x2.CreateSkew(float, float)" />
    static abstract TSelf CreateSkew(TComponent radiansX, TComponent radiansY);

    /// <inheritdoc cref="Matrix3x2.CreateSkew(float, float, Vector2)" />
    static abstract TSelf CreateSkew(TComponent radiansX, TComponent radiansY, TVector2 centerPoint);
}

/// <summary>Everything a 4x4 floating-point matrix can do.
/// The operators and factories are declared inline for the same CS0695 reason as the vector bundles.
/// CreateReflection/CreateShadow are absent: they take a plane, and planes have no interface yet.</summary>
public interface IFloatingMatrix4x4<TSelf, TComponent, TVector3, TVector4, TQuaternion> : IMatrix<TSelf, TComponent>
    where TSelf : IFloatingMatrix4x4<TSelf, TComponent, TVector3, TVector4, TQuaternion>
{
    /// <inheritdoc cref="Matrix4x4.Translation" />
    TVector3 Translation { get; }

    /// <inheritdoc cref="Matrix4x4.GetDeterminant" />
    TComponent GetDeterminant();

    /// <inheritdoc cref="Matrix4x4.op_Addition" />
    static abstract TSelf operator +(TSelf left, TSelf right);

    /// <inheritdoc cref="Matrix4x4.op_Subtraction" />
    static abstract TSelf operator -(TSelf left, TSelf right);

    /// <inheritdoc cref="Matrix4x4.op_UnaryNegation" />
    static abstract TSelf operator -(TSelf value);

    /// <inheritdoc cref="Matrix4x4.op_Multiply(Matrix4x4, Matrix4x4)" />
    static abstract TSelf operator *(TSelf left, TSelf right);

    /// <inheritdoc cref="Matrix4x4.op_Multiply(Matrix4x4, float)" />
    static abstract TSelf operator *(TSelf left, TComponent right);

    /// <summary>Multiplies a matrix by a column vector: each result component is the dot of a row with the vector.</summary>
    /// <remarks>The W-row translation is not applied; transform points with vector-times-matrix, which is the row-vector product.</remarks>
    static abstract TVector4 operator *(TSelf matrix, TVector4 vector);

    /// <inheritdoc cref="operator *(TSelf, TVector4)" />
    static abstract TVector4 Multiply(TSelf matrix, TVector4 vector);

    /// <inheritdoc cref="Matrix4x4.Lerp" />
    static abstract TSelf Lerp(TSelf a, TSelf b, TComponent amount);

    /// <inheritdoc cref="Matrix4x4.Transpose" />
    static abstract TSelf Transpose(TSelf matrix);

    /// <inheritdoc cref="Matrix4x4.Transform" />
    static abstract TSelf Transform(TSelf value, TQuaternion rotation);

    /// <inheritdoc cref="Matrix4x4.Invert" />
    static abstract bool Invert(TSelf matrix, out TSelf result);

    /// <inheritdoc cref="Matrix4x4.Decompose" />
    static abstract bool Decompose(
        TSelf matrix,
        out TVector3 scale,
        out TQuaternion rotation,
        out TVector3 translation
    );

    /// <inheritdoc cref="Matrix4x4.CreateBillboard" />
    static abstract TSelf CreateBillboard(
        TVector3 objectPosition,
        TVector3 cameraPosition,
        TVector3 cameraUpVector,
        TVector3 cameraForwardVector
    );

    /// <inheritdoc cref="Matrix4x4.CreateConstrainedBillboard" />
    static abstract TSelf CreateConstrainedBillboard(
        TVector3 objectPosition,
        TVector3 cameraPosition,
        TVector3 rotateAxis,
        TVector3 cameraForwardVector,
        TVector3 objectForwardVector
    );

    /// <inheritdoc cref="Matrix4x4.CreateFromAxisAngle" />
    static abstract TSelf CreateFromAxisAngle(TVector3 axis, TComponent angle);

    /// <inheritdoc cref="Matrix4x4.CreateFromQuaternion" />
    static abstract TSelf CreateFromQuaternion(TQuaternion quaternion);

    /// <inheritdoc cref="Matrix4x4.CreateFromYawPitchRoll" />
    static abstract TSelf CreateFromYawPitchRoll(TComponent yaw, TComponent pitch, TComponent roll);

    /// <inheritdoc cref="Matrix4x4.CreateLookAt" />
    static abstract TSelf CreateLookAt(TVector3 cameraPosition, TVector3 cameraTarget, TVector3 cameraUpVector);

    /// <inheritdoc cref="Matrix4x4.CreateLookAtLeftHanded" />
    static abstract TSelf CreateLookAtLeftHanded(
        TVector3 cameraPosition,
        TVector3 cameraTarget,
        TVector3 cameraUpVector
    );

    /// <inheritdoc cref="Matrix4x4.CreateLookTo" />
    static abstract TSelf CreateLookTo(TVector3 cameraPosition, TVector3 cameraDirection, TVector3 cameraUpVector);

    /// <inheritdoc cref="Matrix4x4.CreateLookToLeftHanded" />
    static abstract TSelf CreateLookToLeftHanded(
        TVector3 cameraPosition,
        TVector3 cameraDirection,
        TVector3 cameraUpVector
    );

    /// <inheritdoc cref="Matrix4x4.CreateOrthographic" />
    static abstract TSelf CreateOrthographic(
        TComponent width,
        TComponent height,
        TComponent zNearPlane,
        TComponent zFarPlane
    );

    /// <inheritdoc cref="Matrix4x4.CreateOrthographicOffCenter" />
    static abstract TSelf CreateOrthographicOffCenter(
        TComponent left,
        TComponent right,
        TComponent bottom,
        TComponent top,
        TComponent zNearPlane,
        TComponent zFarPlane
    );

    /// <inheritdoc cref="Matrix4x4.CreateOrthographicOffCenterLeftHanded" />
    static abstract TSelf CreateOrthographicOffCenterLeftHanded(
        TComponent left,
        TComponent right,
        TComponent bottom,
        TComponent top,
        TComponent zNearPlane,
        TComponent zFarPlane
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspective" />
    static abstract TSelf CreatePerspective(
        TComponent width,
        TComponent height,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspectiveLeftHanded" />
    static abstract TSelf CreatePerspectiveLeftHanded(
        TComponent width,
        TComponent height,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspectiveFieldOfView" />
    static abstract TSelf CreatePerspectiveFieldOfView(
        TComponent fieldOfView,
        TComponent aspectRatio,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspectiveFieldOfViewLeftHanded" />
    static abstract TSelf CreatePerspectiveFieldOfViewLeftHanded(
        TComponent fieldOfView,
        TComponent aspectRatio,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspectiveOffCenter" />
    static abstract TSelf CreatePerspectiveOffCenter(
        TComponent left,
        TComponent right,
        TComponent bottom,
        TComponent top,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreatePerspectiveOffCenterLeftHanded" />
    static abstract TSelf CreatePerspectiveOffCenterLeftHanded(
        TComponent left,
        TComponent right,
        TComponent bottom,
        TComponent top,
        TComponent nearPlaneDistance,
        TComponent farPlaneDistance
    );

    /// <inheritdoc cref="Matrix4x4.CreateRotationX(float)" />
    static abstract TSelf CreateRotationX(TComponent radians);

    /// <inheritdoc cref="Matrix4x4.CreateRotationX(float, Vector3)" />
    static abstract TSelf CreateRotationX(TComponent radians, TVector3 centerPoint);

    /// <inheritdoc cref="Matrix4x4.CreateRotationY(float)" />
    static abstract TSelf CreateRotationY(TComponent radians);

    /// <inheritdoc cref="Matrix4x4.CreateRotationY(float, Vector3)" />
    static abstract TSelf CreateRotationY(TComponent radians, TVector3 centerPoint);

    /// <inheritdoc cref="Matrix4x4.CreateRotationZ(float)" />
    static abstract TSelf CreateRotationZ(TComponent radians);

    /// <inheritdoc cref="Matrix4x4.CreateRotationZ(float, Vector3)" />
    static abstract TSelf CreateRotationZ(TComponent radians, TVector3 centerPoint);

    /// <inheritdoc cref="Matrix4x4.CreateScale(float, float, float)" />
    static abstract TSelf CreateScale(TComponent xScale, TComponent yScale, TComponent zScale);

    /// <inheritdoc cref="Matrix4x4.CreateScale(float, float, float, Vector3)" />
    static abstract TSelf CreateScale(TComponent xScale, TComponent yScale, TComponent zScale, TVector3 centerPoint);

    /// <inheritdoc cref="Matrix4x4.CreateScale(Vector3)" />
    static abstract TSelf CreateScale(TVector3 scales);

    /// <inheritdoc cref="Matrix4x4.CreateScale(float)" />
    static abstract TSelf CreateScale(TComponent scale);

    /// <inheritdoc cref="Matrix4x4.CreateScale(float, Vector3)" />
    static abstract TSelf CreateScale(TComponent scale, TVector3 centerPoint);

    /// <inheritdoc cref="Matrix4x4.CreateTranslation(float, float, float)" />
    static abstract TSelf CreateTranslation(TComponent xPosition, TComponent yPosition, TComponent zPosition);

    /// <inheritdoc cref="Matrix4x4.CreateTranslation(Vector3)" />
    static abstract TSelf CreateTranslation(TVector3 position);

    /// <inheritdoc cref="Matrix4x4.CreateViewport" />
    static abstract TSelf CreateViewport(
        TComponent x,
        TComponent y,
        TComponent width,
        TComponent height,
        TComponent minDepth,
        TComponent maxDepth
    );

    /// <inheritdoc cref="Matrix4x4.CreateViewportLeftHanded" />
    static abstract TSelf CreateViewportLeftHanded(
        TComponent x,
        TComponent y,
        TComponent width,
        TComponent height,
        TComponent minDepth,
        TComponent maxDepth
    );

    /// <inheritdoc cref="Matrix4x4.CreateWorld" />
    static abstract TSelf CreateWorld(TVector3 position, TVector3 forward, TVector3 up);
}
