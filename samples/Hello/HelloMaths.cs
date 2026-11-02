/*
 * HelloMaths
 *
 * Uses the Random extensions to generate numbers, points in shapes and random directions.
 */

#:package Ahwoo.Brutal.Maths@2026.10.3
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: This library will be expanded in a future release, once the System.Numerics mirror is pulled out of Brutal.Numerics into its own flavor package
//       We don't actually like the System.Numerics functions all that much, we only have them as compatibility at this stage.

using Brutal.Maths;
using Brutal.Numerics;

var random = new Random(1234); // Fixed seed so every run prints the same values.

Console.WriteLine($"Float in [5, 10):      {random.NextSingle(5f, 10f)}");
Console.WriteLine($"Point in 4x2 rect:     {random.NextSinglePointInRectangle(4f, 2f)}");
Console.WriteLine($"Point in unit circle:  {random.NextSinglePointInCircle(1f)}");
Console.WriteLine($"Point in unit sphere:  {random.NextSinglePointInSphere(1f)}");

var direction = random.NextSingleUnit3();
Console.WriteLine($"Random direction:      {direction} (length {direction.Length()})");
