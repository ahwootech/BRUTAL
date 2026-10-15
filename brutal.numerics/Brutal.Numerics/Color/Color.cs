namespace Brutal.Numerics;

/// <summary>
///     Manages colour globals, and some utilities
/// </summary>
public static partial class Color
{
    public static readonly Preset Black = byte3.Grayscale(0);
    public static readonly Preset White = byte3.Grayscale(0xFF);
    public static readonly Preset Gray = float3.Grayscale(0.5f);
    public static readonly Preset Clear = byte4.HexColor(0x000000000);

    public static readonly Preset Red = byte3.HexColor(0xFF0000);
    public static readonly Preset Green = byte3.HexColor(0x00FF00);
    public static readonly Preset Blue = byte3.HexColor(0x0000FF);

    public static readonly Preset Cyan = byte3.HexColor(0x00FFFF);
    public static readonly Preset Magenta = byte3.HexColor(0xFF00FF);
    public static readonly Preset Yellow = byte3.HexColor(0xFFFF00);
}
