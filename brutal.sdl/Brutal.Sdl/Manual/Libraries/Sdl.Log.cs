namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    /// <summary>
    /// Ergonomic wrappers over SDL's logging family (<c>SDL_Log</c>, <c>SDL_LogInfo</c>, …,
    /// <c>SDL_LogMessage</c>).
    /// </summary>
    /// <remarks>
    /// SDL's logging functions are variadic in C and so were skipped by the raw generator; these
    /// fixed-arity wrappers expose them safely. Each routes through <see cref="Sdl.PInvoke.LogMessage"/>
    /// (<c>SDL_LogMessage</c>), passing the caller's text as the format string with no variadic
    /// arguments. Any <c>%</c> in the message is escaped to <c>%%</c> so the text is emitted literally
    /// and SDL's printf parser never reads a non-existent argument.
    /// <para>
    /// This nested class reclaims the <c>Sdl.Log</c> name for the SDL logging surface. The per-call
    /// trace category the generated P/Invoke wrappers use is the separate internal
    /// <see cref="Sdl.TraceLog"/> field, so there is no collision.
    /// </para>
    /// </remarks>
    public static class Log
    {
        /// <summary>
        /// Logs <paramref name="message"/> with the given category and priority through SDL's logging
        /// system (<c>SDL_LogMessage</c>).
        /// </summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="priority">The message priority.</param>
        /// <param name="message">The message text (treated literally; <c>%</c> is not a format specifier).</param>
        public static void Message(SdlLogCategory category, SdlLogPriority priority, string message)
        {
            ArgumentNullException.ThrowIfNull(message);
            PInvoke.LogMessage((int)category, priority, Escape(message));
        }

        /// <summary>
        /// Logs <paramref name="message"/> at <see cref="SdlLogPriority.Info"/> under the
        /// <see cref="SdlLogCategory.Application"/> category (the <c>SDL_Log</c> default).
        /// </summary>
        /// <param name="message">The message text.</param>
        public static void Message(string message) => Message(SdlLogCategory.Application, SdlLogPriority.Info, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Trace"/> (<c>SDL_LogTrace</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Trace(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Trace, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Verbose"/> (<c>SDL_LogVerbose</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Verbose(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Verbose, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Debug"/> (<c>SDL_LogDebug</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Debug(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Debug, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Info"/> (<c>SDL_LogInfo</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Info(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Info, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Warn"/> (<c>SDL_LogWarn</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Warn(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Warn, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Error"/> (<c>SDL_LogError</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Error(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Error, message);

        /// <summary>Logs a message at <see cref="SdlLogPriority.Critical"/> (<c>SDL_LogCritical</c>).</summary>
        /// <param name="category">The SDL log category.</param>
        /// <param name="message">The message text.</param>
        public static void Critical(SdlLogCategory category, string message) =>
            Message(category, SdlLogPriority.Critical, message);

        // Escapes printf conversion specifiers so the caller's text is logged verbatim.
        private static string Escape(string message) => message.Contains('%') ? message.Replace("%", "%%") : message;
    }
}
