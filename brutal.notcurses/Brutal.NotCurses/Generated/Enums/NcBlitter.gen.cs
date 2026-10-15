using System;
namespace Brutal.NotCursesApi
{
    /// we never blit full blocks, but instead spaces (more efficient) with the
    /// background set to the desired foreground. these need be kept in the same
    /// order as the blitters[] definition in lib/blit.c.
    public enum NcBlitter
    {
        Default, // let the ncvisual pick
        _1x1, // space, compatible with ASCII
        _2x1, // halves + 1x1 (space)     ▄▀
        _2x2, // quadrants + 2x1          ▗▐ ▖▀▟▌▙
        _3x2, // sextants + 2x1           🬀🬁🬂🬃🬄🬅🬆🬇🬈🬉🬊🬋🬌🬍🬎🬏🬐🬑🬒🬓🬔🬕🬖🬗🬘🬙🬚🬛🬜🬝🬞
        _4x2, // octants + 2x2            there are a great many octants
        Braille, // 4 rows, 2 cols (braille) ⡀⡄⡆⡇⢀⣀⣄⣆⣇⢠⣠⣤⣦⣧⢰⣰⣴⣶⣷⢸⣸⣼⣾⣿
        Pixel, // pixel graphics
        _4x1, // four vertical levels     █▆▄▂
        _8x1, // eight vertical levels    █▇▆▅▄▃▂▁
    }
}
