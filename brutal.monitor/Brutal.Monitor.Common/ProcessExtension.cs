using System.Diagnostics;

namespace Brutal.Monitor.Common
{
    internal static class ProcessExtension
    {
        public static void WriteLineSync(this Process process, string line)
        {
            // Called from crash handlers, so a dead child's broken pipe must never throw
            try
            {
                lock (process.StandardInput)
                    process.StandardInput.WriteLine(line);
            }
            catch (IOException) { }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }
        }
    }
}
