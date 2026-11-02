/*
 * HelloBox2D
 *
 * Drops a box onto the ground with Box2D and prints where it is as it falls and comes to rest.
 * See Demo/DemoBox2D.cs for a version that draws a stack of boxes with OpenGL.
 */

#:package Ahwoo.Brutal.Box2D@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.Box2DApi;
using Brutal.Numerics;

Run();

static void Run()
{
    // Default gravity is (0, -10). Disposing the world also destroys its bodies and shapes.
    using var world = Box2D.CreateWorld(B2WorldDef.Default);

    // A static ground whose top surface is at y = 0.
    var ground = world.CreateBody(new B2BodyDef { Position = new float2(0, -0.5f) });
    ground.CreatePolygonShape(B2ShapeDef.Default, Box2D.MakeBox(5, 0.5f));

    // A 1x1 dynamic box, 4 units above the ground.
    var box = world.CreateBody(new B2BodyDef { Type = B2BodyType.Dynamic, Position = new float2(0, 4) });
    box.CreatePolygonShape(B2ShapeDef.Default, Box2D.MakeBox(0.5f, 0.5f));

    // Two seconds at 60 Hz; the box should land and settle with its centre at y = 0.5.
    const float TIME_STEP = 1.0f / 60.0f;
    for (var step = 0; step <= 120; step++)
    {
        if (step > 0)
            world.Step(TIME_STEP, 4);

        if (step % 20 == 0)
        {
            var position = box.GetPosition();
            Console.WriteLine(
                $"t = {step * TIME_STEP:F2}s  position = ({position.X:F2}, {position.Y:F2})  awake = {box.IsAwake()}"
            );
        }
    }
}
