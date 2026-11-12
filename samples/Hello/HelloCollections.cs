/*
 * HelloCollections
 *
 * Uses NativeList<T>, a growable list backed by unmanaged memory: add, insert,
 * remove, iterate and edit it as a span.
 */

#:package Ahwoo.Brutal.Collections@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4

// RIAN: This package will be greatly improved in an upcoming release of custom allocators, and collections that use them.

using Brutal.Collections;

Run();

static void Run()
{
    // A List<T>-like collection backed by unmanaged memory, freed when Run returns.
    using var list = new NativeList<int>();

    list.Add(1);
    list.AddRange([2, 3, 4, 5]);
    list.Insert(0, 0);
    list.RemoveAt(3);

    Console.WriteLine($"Count = {(int)list.Count}, Capacity = {(int)list.Capacity}");

    foreach (var value in list)
        Console.WriteLine(value);

    var span = list.AsSpan();
    span.Reverse();
    Console.WriteLine($"Reversed in place: {string.Join(", ", span.ToArray())}");
}
