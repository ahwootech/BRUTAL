using Brutal.OpenGlApi;

namespace Brutal.ImGuiApi.Backends;

public partial class OpenGlBackend
{
    internal static class Helpers
    {
        public static unsafe int GetIntegerv(GlEnum name)
        {
            var value = 0;
            OpenGl.GetIntegerv(name, new Span<int>(&value, 1));
            return value;
        }
    }
}
