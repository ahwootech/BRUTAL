namespace Brutal.ImGuiApi.Backends;

public interface IPlatformBackend : IDisposable
{
    public void NewFrame();
}
