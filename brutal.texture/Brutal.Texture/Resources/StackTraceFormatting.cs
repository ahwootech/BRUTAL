using System.Diagnostics;

namespace Brutal.TextureApi
{
    internal static class StackTraceFormatting
    {
        /// <summary>
        /// Takes a StackTrace and generates a string of the last X number of relevant stack frames.
        /// <para />
        /// The output starts at the first non-Brutal namespace stack frame.
        /// System functions (Those in System or Microsoft namespaces) are removed.
        /// </summary>
        /// <param name="stackTrace">The StackTrace to format</param>
        /// <param name="stackFrameCount">The number of relevant StackFrames to return in the string.</param>
        /// <returns></returns>
        public static IList<string> FriendlyStackTraceStrings(StackTrace? stackTrace, int stackFrameCount)
        {
            if (stackTrace is null)
                return ["No stack trace"];

            var stackIndent = "";
            var stackTraceEntries = new List<string>();
            var startStackFrameIndex = GetFirstClientStackFrameIndex(stackTrace);

            for (var i = startStackFrameIndex; i < stackTrace.FrameCount; i++)
            {
                var stackFrame = stackTrace.GetFrame(i)!;
                if (IsIgnoredStackFrame(stackFrame))
                    continue;

                stackTraceEntries.Add(BuildStackFrameString(stackIndent, stackFrame));
                if (--stackFrameCount == 0)
                    break;

                stackIndent += " ";
            }
            return stackTraceEntries;
        }

        #region Private

        private static string BuildStackFrameString(string stackIndent, StackFrame stackFrame)
        {
            return $"{stackIndent}{stackFrame.GetMethod()!.Name} : {stackFrame.GetFileName()} : {stackFrame.GetFileLineNumber()}";
        }

        private static int GetFirstClientStackFrameIndex(StackTrace stackTrace)
        {
            for (var i = 0; i < stackTrace.FrameCount; i++)
            {
                var stackFrameNamespace = stackTrace.GetFrame(i)?.GetMethod()?.DeclaringType?.Namespace;
                if (stackFrameNamespace is null)
                    continue;

                if (!stackFrameNamespace.StartsWith("Brutal")) // This is a temporary lame filter
                    return i;
            }
            return stackTrace.FrameCount;
        }

        private static bool IsIgnoredStackFrame(StackFrame stackFrame)
        {
            if (!stackFrame.HasSource() || !stackFrame.HasMethod())
                return true;

            var name = stackFrame.GetMethod()?.DeclaringType?.Assembly.FullName;
            return name is null || name.StartsWith("Microsoft") || name.StartsWith("System");
        }

        #endregion
    }
}
