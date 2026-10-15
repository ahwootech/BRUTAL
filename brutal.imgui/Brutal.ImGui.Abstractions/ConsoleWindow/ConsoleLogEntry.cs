namespace Brutal.ImGuiApi.Abstractions;

public static class ConsoleLineColors
{
    public static readonly ImColor8 Default = new(178, 178, 178, 255);
}

public struct ConsoleLogEntry()
{
    public ImColor8 Color = ConsoleLineColors.Default;

    public bool IsEmpty => TextSpanHandle.Length == 0;
    public ConsoleWindow.RingBuffer.SpanHandle TextSpanHandle = new();
    public ConsoleWindow.RingBuffer.SpanHandle TimeSpanHandle = new();

    public float ActiveTime;
}
