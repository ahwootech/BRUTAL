namespace Brutal.ImGuiApi.Abstractions;

public static class ConsoleColor
{
    public static class Float4
    {
        public static readonly float4 Grey = float4.Rgb(0.4f, 0.4f, 0.4f);
        public static readonly float4 DarkGrey = float4.Rgb(0.1f, 0.1f, 0.1f);
        public static readonly float4 Orange = float4.Rgb(1f, 0.4f, 0f);
        public static readonly float4 Red = float4.Rgb(1f, 0f, 0f);
        public static readonly float4 RedTransparent = float4.Rgba(1f, 0f, 0f, 0.4f);
        public static readonly float4 DarkRed = float4.Rgb(0.6f, 0f, 0f);
        public static readonly float4 Black = float4.Rgb(0f, 0f, 0f);
        public static readonly float4 Yellow = float4.Rgb(1f, 0.7f, 0f);
        public static readonly float4 YellowTransparent = float4.Rgba(1f, 0.5f, 0f, 0.4f);
        public static readonly float4 Blue = float4.Rgb(0f, 0.3f, 1f);
        public static readonly float4 BlueTransparent = float4.Rgba(0f, 0.3f, 1f, 0.4f);
        public static readonly float4 Green = float4.Rgb(0f, 1f, 0f);
        public static readonly float4 GreenTransparent = float4.Rgba(0f, 1f, 0f, 0.4f);
        public static readonly float4 GreenGrey = float4.Rgb(0.1f, 0.5f, 0.1f);
        public static readonly float4 HalfTransparent = float4.Rgba(1f, 1f, 1f, 0.5f);
        public static readonly float4 Transparent = float4.Rgba(0f, 0f, 0f, 0f);
        public static readonly float4 Cyan = float4.Rgb(0f, 1f, 1f);
        public static readonly float4 Magenta = float4.Rgb(1f, 0f, 1);
        public static readonly float4 White = float4.Rgb(1f, 1f, 1);
        public static readonly float4 WhiteTransparent = float4.Rgba(1f, 1f, 1, 0.4f);
        public static readonly float4 DarkGreyTransparent = float4.Rgba(0.1f, 0.1f, 0.1f, 0.4f);
        public static readonly float4 LightBlue = float4.Unpack(byte4.Rgb(66, 200, 245), Unpack.Float.Normalize);
        public static readonly float4 GreyTransparent = float4.Rgba(0.4f, 0.4f, 0.4f, 0.4f);
        //public static float4 Border => ImGui.GetStyle().Colors[(int)ImGuiCol.Border];
        //public static float4 TabHovered => ImGui.GetStyle().Colors[(int)ImGuiCol.TabHovered];
        //public static float4 PlotHistogramHovered => ImGui.GetStyle().Colors[(int)ImGuiCol.PlotHistogramHovered];
    }

    public static uint ColorConvertFloat4ToU32(float4 inVector)
    {
        uint outColor = 0;

        var r = inVector.X;
        var g = inVector.Y;
        var b = inVector.Z;
        var a = inVector.W;

        outColor += (uint)(255 * r / 1.0f) << 0;
        outColor += (uint)(255 * g / 1.0f) << 8;
        outColor += (uint)(255 * b / 1.0f) << 16;
        outColor += (uint)(255 * a / 1.0f) << 24;

        return outColor;
    }

    public static class Integer
    {
        public static readonly uint White = ColorConvertFloat4ToU32(Float4.White);
        public static readonly uint WhiteTransparent = ColorConvertFloat4ToU32(Float4.WhiteTransparent);
        public static readonly uint Black = ColorConvertFloat4ToU32(Float4.Black);
        public static readonly uint Grey = ColorConvertFloat4ToU32(Float4.Grey);
        public static readonly uint DarkGrey = ColorConvertFloat4ToU32(Float4.DarkGrey);
        public static readonly uint Yellow = ColorConvertFloat4ToU32(Float4.Yellow);
        public static readonly uint YellowTransparent = ColorConvertFloat4ToU32(Float4.YellowTransparent);
        public static readonly uint GreenTransparent = ColorConvertFloat4ToU32(Float4.GreenTransparent);
        public static readonly uint Orange = ColorConvertFloat4ToU32(Float4.Orange);
        public static readonly uint Red = ColorConvertFloat4ToU32(Float4.Red);
        public static readonly uint RedTransparent = ColorConvertFloat4ToU32(Float4.RedTransparent);
        public static readonly uint Green = ColorConvertFloat4ToU32(Float4.Green);
        public static readonly uint GreenGrey = ColorConvertFloat4ToU32(Float4.GreenGrey);
        public static readonly uint Blue = ColorConvertFloat4ToU32(Float4.Blue);
        public static readonly uint LightBlue = ColorConvertFloat4ToU32(Float4.LightBlue);
        public static readonly uint BlueTransparent = ColorConvertFloat4ToU32(Float4.BlueTransparent);

        //public static readonly uint TabHovered = ColorConvertFloat4ToU32(Float4.TabHovered);
        //public static readonly uint Border = ColorConvertFloat4ToU32(Float4.Border);
        public static readonly uint HalfTransparent = ColorConvertFloat4ToU32(Float4.HalfTransparent);
        public static readonly uint Transparent = ColorConvertFloat4ToU32(Float4.Transparent);
        public static readonly uint DarkGreyTransparent = ColorConvertFloat4ToU32(Float4.DarkGreyTransparent);
        public static readonly uint GreyTransparent = ColorConvertFloat4ToU32(Float4.GreyTransparent);
    }
}
