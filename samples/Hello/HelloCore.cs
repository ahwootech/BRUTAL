/*
 * HelloCore
 *
 * Shows a few Brutal.Core basics: platform detection, ByteSize/ElementCount arithmetic and Ptr<T>.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Core@2026.10.4

// RIAN: This package mainly contains the absolute bare minimum types and methods we use often across our packages.

using Brutal;
using Brutal.Pointers;

Console.WriteLine($"Running on {Platform.CurrentFamily}");

var stride = ByteSize.Of<float>();
var total = stride * new ElementCount(1024);
Console.WriteLine($"1024 floats = {total}");

var alternative = ByteSize.Of<float>(1024);
Console.WriteLine($"1024 floats = {alternative}");

unsafe
{
    var raw = stackalloc int[4] { 10, 20, 30, 40 };
    Ptr<int> p = raw;
    Console.WriteLine($"p.Value = {p.Value}, p[2] = {p[2]}, p.Offset(1).Value = {p.Offset(1).Value}");
}
