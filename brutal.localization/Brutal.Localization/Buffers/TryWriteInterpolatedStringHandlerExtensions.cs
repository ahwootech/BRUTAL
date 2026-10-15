using System.Diagnostics;

namespace Brutal.Localization.FixedBuffers;

public static class TryWriteInterpolatedStringHandlerExtensions
{
    extension(MemoryExtensions.TryWriteInterpolatedStringHandler handler)
    {
        /// <summary>
        /// Returns the number of elements currently written to a TryWriteInterpolatedStringHandler.
        /// </summary>
        /// <returns>The number of elements written.</returns>
        public int ElementsWritten()
        {
            var shouldBeTrue = MemoryExtensions.TryWrite([], ref handler, out var elementsWritten);
            Debug.Assert(shouldBeTrue, "TryWrite with empty collection should always succeed.");

            return elementsWritten;
        }
    }
}
