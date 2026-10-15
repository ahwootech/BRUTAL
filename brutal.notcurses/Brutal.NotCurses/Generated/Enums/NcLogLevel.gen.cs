using System;
namespace Brutal.NotCursesApi
{
    /// These log levels consciously map cleanly to those of libav; Notcurses itself
    /// does not use this full granularity. The log level does not affect the opening
    /// and closing banners, which can be disabled via the notcurses_option struct's
    /// 'suppress_banner'. Note that if stderr is connected to the same terminal on
    /// which we're rendering, any kind of logging will disrupt the output (which is
    /// undesirable). The "default" zero value is NCLOGLEVEL_PANIC.
    public enum NcLogLevel
    {
        Silent = -1, // default. print nothing once fullscreen service begins
        Panic = 0, // print diagnostics related to catastrophic failure
        Fatal = 1, // we're hanging around, but we've had a horrible fault
        Error = 2, // we can't keep doing this, but we can do other things
        Warning = 3, // you probably don't want what's happening to happen
        Info = 4, // "standard information"
        Verbose = 5, // "detailed information"
        Debug = 6, // this is honestly a bit much
        Trace = 7, // there's probably a better way to do what you want
    }
}
