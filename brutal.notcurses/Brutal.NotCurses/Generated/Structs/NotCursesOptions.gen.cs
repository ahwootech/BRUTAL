using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// Configuration for notcurses_init().
    public unsafe partial struct NotCursesOptions
    {
        /// The name of the terminfo database entry describing this terminal. If NULL,
        /// the environment variable TERM is used. Failure to open the terminal
        /// definition will result in failure to initialize notcurses.
        public Ptr<byte> Termtype;
        /// Progressively higher log levels result in more logging to stderr. By
        /// default, nothing is printed to stderr once fullscreen service begins.
        public NcLogLevel Loglevel;
        /// Desirable margins. If all are 0 (default), we will render to the entirety
        /// of the screen. If the screen is too small, we do what we can--this is
        /// strictly best-effort. Absolute coordinates are relative to the rendering
        /// area ((0, 0) is always the origin of the rendering area).
        public uint MarginT;
        /// Desirable margins. If all are 0 (default), we will render to the entirety
        /// of the screen. If the screen is too small, we do what we can--this is
        /// strictly best-effort. Absolute coordinates are relative to the rendering
        /// area ((0, 0) is always the origin of the rendering area).
        public uint MarginR;
        /// Desirable margins. If all are 0 (default), we will render to the entirety
        /// of the screen. If the screen is too small, we do what we can--this is
        /// strictly best-effort. Absolute coordinates are relative to the rendering
        /// area ((0, 0) is always the origin of the rendering area).
        public uint MarginB;
        /// Desirable margins. If all are 0 (default), we will render to the entirety
        /// of the screen. If the screen is too small, we do what we can--this is
        /// strictly best-effort. Absolute coordinates are relative to the rendering
        /// area ((0, 0) is always the origin of the rendering area).
        public uint MarginL;
        /// General flags; see NCOPTION_*. This is expressed as a bitfield so that
        /// future options can be added without reshaping the struct. Undefined bits
        /// must be set to 0.
        public NotCursesOption Flags;
    }
}
