namespace Brutal.OpenGlApi;

public record struct GlEnum(uint Id)
{
    public static implicit operator uint(GlEnum value) => value.Id;

    public static implicit operator GlEnum(uint value) => new(value);
}
