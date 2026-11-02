/*
 * HelloStrings
 *
 * Works with UTF-8 text using String8 and StringBuilder<byte>, which are designed to avoid
 * allocations.
 */

#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal.Strings;

var greeting = new String8("Hello, café!");

Console.WriteLine($"Text: {greeting.ToString16()}");
Console.WriteLine($"UTF-8 bytes: {greeting.Length}, code points: {Unicode.GetRuneCount(greeting.AsSpan())}");
Console.WriteLine($"Starts with \"Hello\": {greeting.StartsWith("Hello"u8)}");

// A StringBuilder that writes UTF-8 bytes directly.
var builder = new StringBuilder<byte>();
builder.Append($"Pi is roughly {Math.PI:F3}");
builder.AppendLine();
builder.Append("Built as UTF-8"u8);

Console.WriteLine(builder.ToString());
Console.WriteLine($"Builder holds {builder.WrittenSpan.Length} UTF-8 bytes");
