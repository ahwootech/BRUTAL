namespace Brutal.OpenGlApi;

public record struct GlAttribute(uint Location, int Count, GlEnum Type, GlScaling Behavior, int Stride, int Offset);
