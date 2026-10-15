using System.Collections;
using System.Diagnostics;
using System.Resources;
using Brutal.Localization.ResX;

namespace Brutal.Localization.ResX;

/// <summary>
/// A ResX reader to replace the defunct ResXResourceReader that no longer works in
/// .NET Core. Supports only strings at present.
/// </summary>
public class ResXReader : IResourceReader
{
    /// <summary>
    /// Create a ResXReader from a file path to a .resx file.
    /// </summary>
    /// <param name="filePath">Path to the file. Can be relative or absolute.</param>
    public ResXReader(string filePath)
    {
        _data = [];
        _reader = new StreamReader(filePath);
    }

    /// <summary>
    /// Create a ResX reader that reads from a TextReader.
    /// </summary>
    /// <param name="reader"></param>
    public ResXReader(TextReader reader)
    {
        _data = [];
        _reader = reader;
    }

    /// <summary>
    /// Returns a read-only collection of the current resource data.
    /// </summary>
    public IReadOnlyDictionary<string, ResXData> Data
    {
        get
        {
            if (IsClosed)
                throw new InvalidOperationException("Reader is already closed");

            EnsureLoaded();
            return _data;
        }
    }

    #region System.Resources.IResourceReader

    /// <summary>
    /// Close the reader
    /// </summary>
    public void Close()
    {
        if (IsClosed)
            return;

        _reader!.Close();
        _reader = null;
    }

    /// <summary>
    /// Return the IDictionaryEnumerator of the currently loaded data.
    /// </summary>
    /// <returns>The IDictionaryEnumerator of the currently loaded data.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the ResXReader is closed.</exception>
    public IDictionaryEnumerator GetEnumerator()
    {
        if (IsClosed)
            throw new InvalidOperationException("Reader is already closed");

        EnsureLoaded();
        return _data.GetEnumerator();
    }

    /// <summary>
    /// Dispose of the ResXReader, closing the file in the process.
    /// </summary>
    public void Dispose()
    {
        Close();
        GC.SuppressFinalize(this);
    }

    #endregion

    #region IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        if (IsClosed)
            throw new InvalidOperationException("Reader is already closed");

        return GetEnumerator();
    }
    #endregion

    private void EnsureLoaded()
    {
        Debug.Assert(_reader is not null);
        Debug.Assert(!IsClosed);

        if (_loaded)
            return;

        _data = ResXFile.Parse(_reader.ReadToEnd());
        _loaded = true;
    }

    private bool IsClosed => _reader is null;
    private bool _loaded;
    private Dictionary<string, ResXData> _data;
    private TextReader? _reader;
}
