namespace Brutal.ImGuiApi;

public class ImException(string message) : Exception(message);

public partial class ImGui
{
    /// <summary>
    /// This is an equivalent of the IM_ASSERT C++ macro, intended for similar validation in ported code.
    /// </summary>
    public static void Assert(bool condition, string? message = null)
    {
        if (!condition)
            throw new ImException(message ?? "Assertion failed");
    }
}
