/*
 * HelloMemory
 *
 * Allocates, uses and frees unmanaged memory with Mem, and owns a pointer with PtrOwner.
 */

#:package Ahwoo.Brutal.Memory@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4

// RIAN: This package is due for a big update for custom allocators.

using Brutal;
using Brutal.Memory;

Run();

static void Run()
{
    // Allocate 8 ints of unmanaged memory and use it as a Span. It isn't owned by anything, so free it yourself.
    var numbers = Mem.AllocZeroed<int>(new ElementCount(8));
    for (var i = 0; i < numbers.Length; i++)
        numbers[i] = i * i;

    Console.WriteLine($"Squares: {string.Join(", ", numbers.ToArray())}");
    Console.WriteLine($"Allocated {ByteSize.Of(numbers)} unmanaged");
    Mem.Free(numbers);

    // PtrOwner frees its allocation when disposed.
    using var pi = new PtrOwner<double>(Math.PI);
    Console.WriteLine($"PtrOwner holds {pi.Value}");
}
