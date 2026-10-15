namespace Brutal.ImGuiApi.Backends;

public interface IRendererBackend : IDisposable
{
    public void NewFrame();
}
