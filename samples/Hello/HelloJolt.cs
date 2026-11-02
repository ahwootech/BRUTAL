/*
 * HelloJolt
 *
 * Drops a box onto the ground with Jolt Physics and prints where it is as it falls and
 * comes to rest. See Demo/DemoJolt.cs for a version that draws a pile of boxes in 3D with OpenGL.
 */

#:package Ahwoo.Brutal.Jolt@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.JoltApi;
using Brutal.Numerics;

const ushort STATIC_LAYER = 0;
const ushort MOVING_LAYER = 1;

// Jolt needs an allocator, a factory and its types registered before anything else; Run creates the
// job system and collision layers.
Jolt.RegisterDefaultAllocator();
Factory.Instance = Factory.Create();
Jolt.RegisterTypes();

try
{
    Run();
}
finally
{
    Jolt.UnregisterTypes();
    Factory.DestroyInstance();
}

static void Run()
{
    // Declared in dependency order, so they're disposed in reverse when Run returns.
    using var tempAllocator = TempAllocatorImpl.Create(10 * 1024 * 1024);
    using var jobSystem = JobSystemThreadPool.Create(2048, 8, -1);

    // One broad phase layer per object layer; moving objects collide with static ones and each other.
    using var broadPhaseLayers = BroadPhaseLayerInterfaceTable.Create(2, 2);
    broadPhaseLayers.MapObjectToBroadPhaseLayer(STATIC_LAYER, 0);
    broadPhaseLayers.MapObjectToBroadPhaseLayer(MOVING_LAYER, 1);

    using var pairFilter = ObjectLayerPairFilterTable.Create(2);
    pairFilter.EnableCollision(STATIC_LAYER, MOVING_LAYER);
    pairFilter.EnableCollision(MOVING_LAYER, MOVING_LAYER);

    using var broadPhaseFilter = ObjectVsBroadPhaseLayerFilterTable.Create(broadPhaseLayers, 2, pairFilter, 2);

    using var physicsSystem = PhysicsSystem.Create();
    physicsSystem.Init(1024, 0, 1024, 1024, broadPhaseLayers, broadPhaseFilter, pairFilter);
    var bodyInterface = physicsSystem.GetBodyInterface(); // Default gravity is (0, -9.81, 0).

    // A static ground whose top surface is at y = 0.
    using var groundShape = BoxShapeSettings.Create(new float3(5, 0.5f, 5), 0.05f, default);
    using var groundSettings = BodyCreationSettings.Create(
        groundShape,
        new float3(0, -0.5f, 0),
        floatQuat.Identity,
        MotionType.Static,
        STATIC_LAYER
    );
    var ground = bodyInterface.CreateAndAddBody(groundSettings, Activation.DontActivate);

    // A 1x1x1 dynamic box, 4 units above the ground.
    using var boxShape = BoxShapeSettings.Create(new float3(0.5f), 0.05f, default);
    using var boxSettings = BodyCreationSettings.Create(
        boxShape,
        new float3(0, 4, 0),
        floatQuat.Identity,
        MotionType.Dynamic,
        MOVING_LAYER
    );
    var box = bodyInterface.CreateAndAddBody(boxSettings, Activation.Activate);

    // Two seconds at 60 Hz; the box should land and settle with its centre near y = 0.5.
    // (Jolt allows a couple of centimetres of penetration, so expect about 0.48.)
    const float TIME_STEP = 1.0f / 60.0f;
    for (var step = 0; step <= 120; step++)
    {
        if (step > 0)
            physicsSystem.Update(TIME_STEP, 1, tempAllocator, jobSystem);

        if (step % 20 == 0)
        {
            var position = bodyInterface.GetPosition(box);
            Console.WriteLine(
                $"t = {step * TIME_STEP:F2}s  position = ({position.X:F2}, {position.Y:F2}, {position.Z:F2})  active = {bodyInterface.IsActive(box)}"
            );
        }
    }

    // Bodies are IDs, not IDisposable: remove and destroy them while the physics system still exists.
    bodyInterface.RemoveBody(box);
    bodyInterface.DestroyBody(box);
    bodyInterface.RemoveBody(ground);
    bodyInterface.DestroyBody(ground);
}
