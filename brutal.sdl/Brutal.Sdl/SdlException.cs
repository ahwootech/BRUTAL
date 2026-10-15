namespace Brutal.SdlApi;

/// <summary>
/// The exception thrown when an SDL call fails. Its <see cref="Exception.Message"/> carries the
/// human-readable error text SDL reported through <c>SDL_GetError</c> at the point of failure.
/// </summary>
public class SdlException : Exception
{
    /// <summary>
    /// Initializes a new <see cref="SdlException"/> with the given message.
    /// </summary>
    /// <param name="message">The failure description, typically the <c>SDL_GetError</c> text.</param>
    public SdlException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="SdlException"/> with the given message and inner exception.
    /// </summary>
    /// <param name="message">The failure description, typically the <c>SDL_GetError</c> text.</param>
    /// <param name="innerException">The underlying exception that caused this failure.</param>
    public SdlException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <summary>
    /// Creates an <see cref="SdlException"/> whose message is the current <c>SDL_GetError</c> text,
    /// copied immediately into managed memory (SDL owns the returned pointer). The
    /// <paramref name="context"/> prefixes the SDL message so the failing operation is identifiable.
    /// </summary>
    /// <param name="context">A short description of the operation that failed.</param>
    /// <returns>A new <see cref="SdlException"/> carrying <paramref name="context"/> and the SDL error text.</returns>
    public static SdlException FromError(string context)
    {
        var error = Sdl.PInvoke.GetError();
        return string.IsNullOrEmpty(error) ? new SdlException(context) : new SdlException($"{context}: {error}");
    }
}
