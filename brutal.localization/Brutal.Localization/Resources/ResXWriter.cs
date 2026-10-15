using Brutal.Localization.ResX;

namespace Brutal.Localization.ResX;

/// <summary>
/// A ResX writer to replace the defunct ResXResourceWriter that no longer works in
/// .NET Core. Supports only strings at present.
/// </summary>
public class ResXWriter : IDisposable
{
    /// <summary>
    /// Create a ResXWriter that writes to a file.
    /// </summary>
    /// <param name="filePath">Path to the file. Can be relative or absolute.</param>
    public ResXWriter(string filePath)
    {
        _writer = new StreamWriter(filePath);
        _resXFile = new();
    }

    /// <summary>
    /// Create a ResX writer that writes to a TextWriter.
    /// </summary>
    /// <param name="writer">The writer to write ResX data to.</param>
    public ResXWriter(TextWriter writer)
    {
        _writer = writer;
        _resXFile = new();
    }

    /// <summary>
    /// Adds a string along with a value and options comment.
    /// </summary>
    /// <param name="name">The key for the value in the ResX.</param>
    /// <param name="value">The value of the string</param>
    /// <param name="comment">A user supplied comment</param>
    public void AddString(string name, string value, string? comment = null)
    {
        _resXFile.DataDictionary.Add(name, new ResXData(name, value, comment));
    }

    /// <summary>
    /// Close a ResXWriter, writing all content first.
    /// </summary>
    public void Close()
    {
        if (_closed)
            return;

        Generate();
        _writer!.Flush();
        _writer.Close();
        _closed = true;
    }

    /// <summary>
    /// Close and dispose of the ResXWriter.
    /// </summary>
    public void Dispose()
    {
        Close();
        _writer?.Dispose();
        GC.SuppressFinalize(this);
    }

    private void Generate()
    {
        if (_writer is null)
            throw new InvalidOperationException("ResXWriter already closed");

        var content = _resXFile.Build();
        _writer.Write(content);
    }

    private readonly ResXFile _resXFile;
    private readonly TextWriter? _writer;
    private bool _closed;
}
