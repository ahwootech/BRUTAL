using System.Buffers;
using Path16 = System.IO.Path;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Brutal.Strings;

public static partial class Utf8
{
    public static class Path
    {
        // Public static readonly variant of the separators. The Path implementation itself is using
        // internal const variant of the separators for better performance.
        public static readonly Char8 DirectorySeparatorChar = (Char8)Path16.DirectorySeparatorChar;
        public static readonly Char8 AltDirectorySeparatorChar = (Char8)Path16.AltDirectorySeparatorChar;
        public static readonly Char8 VolumeSeparatorChar = (Char8)Path16.VolumeSeparatorChar;
        public static readonly Char8 PathSeparator = (Char8)Path16.PathSeparator;

        /// <inheritdoc cref="Path16.ChangeExtension(String16, String16)"/>
        public static unsafe String8 ChangeExtension(String8View path, String8View extension)
        {
            if (path.IsEmpty)
                return String8.Empty;

            int subLength = path.Length;
            if (subLength == 0)
                return String8.Empty;

            for (int i = path.Length - 1; i >= 0; i--)
            {
                Char8 ch = path[i];

                if (ch == '.')
                {
                    subLength = i;
                    break;
                }

                if (IsDirectorySeparator(ch))
                {
                    break;
                }
            }

            var subpath = path[..subLength];

            if (extension.IsEmpty)
            {
                // No extension to add, just return the subpath
                return new String8(subpath);
            }

            var includesDot = extension[0] == (Char8)'.';
            var length = subLength + (includesDot ? extension.Length : extension.Length + 1);

            var bytes = new Char8[length];
            subpath.CopyTo(bytes);

            fixed (Char8* bytesPtr = bytes)
            {
                var bytesSpan = new Span<Char8>(bytesPtr, bytes.Length);

                if (includesDot)
                    extension.CopyTo(bytesSpan[subLength..]);
                else
                {
                    bytesSpan[subLength] = (Char8)'.'; // Add the dot before the extension
                    extension.CopyTo(bytesSpan[(subLength + 1)..]);
                }
            }

            return new String8(bytes);
        }

        /// <inheritdoc cref="Path16.Exists(String16)"/>
        public static bool Exists(String8View path)
        {
            return path.Length != 0 && Path16.Exists(path.ToString16());
        }

        /// <inheritdoc cref="Path16.GetDirectoryName(ReadOnlySpan{Char16})"/>
        public static String8View GetDirectoryName(String8View path)
        {
            var length = path.Length;
            if (length == 0)
                return default;

            var charCount = GetCharCount(path);
            Span<Char16> chars = stackalloc Char16[charCount];
            if (ToUtf16(path, chars, out _, out _) != OperationStatus.Done)
                throw new ArgumentException("Invalid UTF-8 path", nameof(path));

            var directoryName = Path16.GetDirectoryName(chars);

            return path[..GetByteCount(directoryName)];
        }

        /// <inheritdoc cref="Path16.GetFileName(ReadOnlySpan{Char16})"/>
        public static String8View GetFileName(String8View path)
        {
            var length = path.Length;
            if (length == 0)
                return default;

            var charCount = GetCharCount(path);
            Span<Char16> chars = stackalloc Char16[charCount];
            if (ToUtf16(path, chars, out _, out _) != OperationStatus.Done)
                throw new ArgumentException("Invalid UTF-8 path", nameof(path));

            var fileName = Path16.GetFileName(chars);
            return path[^GetByteCount(fileName)..];
        }

        /// <inheritdoc cref="Path16.GetFileNameWithoutExtension(ReadOnlySpan{Char16})"/>
        public static String8View GetFileNameWithoutExtension(String8View path)
        {
            var fileName = GetFileName(path);
            var lastPeriod = fileName.LastIndexOf((Char8)'.');
            return lastPeriod < 0 ? fileName : fileName[..lastPeriod];
        }

        /// <inheritdoc cref="Path16.GetExtension(ReadOnlySpan{Char16})"/>
        public static String8View GetExtension(String8View path)
        {
            var length = path.Length;

            for (var i = length - 1; i >= 0; i--)
            {
                var ch = path[i];
                if (ch == '.')
                {
                    return i != length - 1 ? path.Slice(i, length - i) : default;
                }

                if (IsDirectorySeparator(ch))
                    break;
            }

            return default;
        }

        /// <inheritdoc cref="Path16.HasExtension(ReadOnlySpan{Char16})"/>
        public static bool HasExtension(String8View path)
        {
            for (var i = path.Length - 1; i >= 0; i--)
            {
                var ch = path[i];
                if (ch == '.')
                {
                    return i != path.Length - 1;
                }

                if (IsDirectorySeparator(ch))
                    break;
            }

            return false;
        }

        /// <inheritdoc cref="Path16.TryJoin(ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, Span{Char16}, out int)"/>
        public static bool TryJoin(String8View path1, String8View path2, Span<Char8> destination, out int charsWritten)
        {
            charsWritten = 0;
            if (path1.IsEmpty && path2.IsEmpty)
                return true;

            if (path1.IsEmpty || path2.IsEmpty)
            {
                ref String8View pathToUse = ref path1.IsEmpty ? ref path2 : ref path1;
                if (destination.Length < pathToUse.Length)
                {
                    return false;
                }

                pathToUse.CopyTo(destination);
                charsWritten = pathToUse.Length;
                return true;
            }

            bool needsSeparator = !(EndsInDirectorySeparator(path1) || StartsWithDirectorySeparator(path2));
            int charsNeeded = path1.Length + path2.Length + (needsSeparator ? 1 : 0);
            if (destination.Length < charsNeeded)
                return false;

            path1.CopyTo(destination);
            if (needsSeparator)
                destination[path1.Length] = DirectorySeparatorChar;

            path2.CopyTo(destination.Slice(path1.Length + (needsSeparator ? 1 : 0)));

            charsWritten = charsNeeded;
            return true;
        }

        /// <inheritdoc cref="Path16.TryJoin(ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, Span{Char16}, out int)"/>
        public static bool TryJoin(
            String8View path1,
            String8View path2,
            String8View path3,
            Span<Char8> destination,
            out int charsWritten
        )
        {
            charsWritten = 0;
            if (path1.IsEmpty && path2.IsEmpty && path3.IsEmpty)
                return true;

            if (path1.IsEmpty)
                return TryJoin(path2, path3, destination, out charsWritten);
            if (path2.IsEmpty)
                return TryJoin(path1, path3, destination, out charsWritten);
            if (path3.IsEmpty)
                return TryJoin(path1, path2, destination, out charsWritten);

            int neededSeparators = EndsInDirectorySeparator(path1) || StartsWithDirectorySeparator(path2) ? 0 : 1;
            bool needsSecondSeparator = !(EndsInDirectorySeparator(path2) || StartsWithDirectorySeparator(path3));
            if (needsSecondSeparator)
                neededSeparators++;

            int charsNeeded = path1.Length + path2.Length + path3.Length + neededSeparators;
            if (destination.Length < charsNeeded)
                return false;

            bool result = TryJoin(path1, path2, destination, out charsWritten);
            Debug.Assert(result, "should never fail joining first two paths");

            if (needsSecondSeparator)
                destination[charsWritten++] = DirectorySeparatorChar;

            path3.CopyTo(destination.Slice(charsWritten));
            charsWritten += path3.Length;

            return true;
        }

        /// <inheritdoc cref="Path16.IsPathFullyQualified(ReadOnlySpan{Char16})"/>
        public static bool IsPathFullyQualified(String8View path)
        {
            var charCount = GetCharCount(path);
            if (charCount == 0)
                return false;

            Span<Char16> chars = stackalloc Char16[charCount];
            if (ToUtf16(path, chars, out _, out _) != OperationStatus.Done)
                throw new ArgumentException("Invalid UTF-8 path", nameof(path));

            return Path16.IsPathFullyQualified(chars);
        }

        /// <inheritdoc cref="Path16.Combine(String16, String16)"/>
        public static String8 Combine(String8View a, String8View b)
        {
            return String8.Move(GetBytes(Path16.Combine(a.ToString16(), b.ToString16())));
        }

        /// <inheritdoc cref="Path16.Combine(String16, String16, String16)"/>
        public static String8 Combine(String8View a, String8View b, String8View c)
        {
            return String8.Move(GetBytes(Path16.Combine(a.ToString16(), b.ToString16(), c.ToString16())));
        }

        /// <inheritdoc cref="Path16.Combine(String16, String16, String16, String16)"/>
        public static String8 Combine(String8View a, String8View b, String8View c, String8View d)
        {
            return String8.Move(
                GetBytes(Path16.Combine(a.ToString16(), b.ToString16(), c.ToString16(), d.ToString16()))
            );
        }

        /// <inheritdoc cref="Path16.Join(ReadOnlySpan{Char16}, ReadOnlySpan{Char16})"/>
        public static String8 Join(String8View a, String8View b)
        {
            return String8.Move(GetBytes(Path16.Join(a.ToString16(), b.ToString16())));
        }

        /// <inheritdoc cref="Path16.Join(ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, ReadOnlySpan{Char16})"/>
        public static String8 Join(String8View a, String8View b, String8View c)
        {
            return String8.Move(GetBytes(Path16.Join(a.ToString16(), b.ToString16(), c.ToString16())));
        }

        /// <inheritdoc cref="Path16.Join(ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, ReadOnlySpan{Char16}, ReadOnlySpan{Char16})"/>
        public static String8 Join(String8View a, String8View b, String8View c, String8View d)
        {
            return String8.Move(GetBytes(Path16.Join(a.ToString16(), b.ToString16(), c.ToString16(), d.ToString16())));
        }

        /// <inheritdoc cref="Path16.GetRelativePath(String16, String16)"/>
        public static String8 GetRelativePath(String8View relativeTo, String8View path)
        {
            return String8.Move(GetBytes(Path16.GetRelativePath(relativeTo.ToString16(), path.ToString16())));
        }

        private static bool IsDirectorySeparator(Char8 c)
        {
            return c == DirectorySeparatorChar || c == AltDirectorySeparatorChar;
        }

        private static bool StartsWithDirectorySeparator(String8View path) =>
            path.Length > 0 && IsDirectorySeparator(path[0]);

        private static bool EndsInDirectorySeparator(String8View path) =>
            path.Length > 0 && IsDirectorySeparator(path[^1]);
    }
}
