namespace Brutal.OpenGlApi;

using static OpenGl;

public record struct GlBitfield(uint Id)
{
    public static implicit operator uint(GlBitfield value) => value.Id;

    public static implicit operator GlBitfield(uint value) => new(value);
}
