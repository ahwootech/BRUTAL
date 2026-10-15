namespace Brutal.ImGuiApi;

public partial struct ImGuiListClipper : IDisposable
{
    /// <inheritdoc cref="ImGuiListClipperExtensions.End"/>
    public void Dispose() => this.End();
}
