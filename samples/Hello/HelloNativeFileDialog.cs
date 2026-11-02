/*
 * HelloNativeFileDialog
 *
 * Opens the operating system's native file picker and prints the file you chose.
 */

#:package Ahwoo.Brutal.NativeFileDialog@2026.10.3

// RIAN: We only use this package for tooling, we prefer in-game file pickers for games.

using Brutal.NativeFileDialogApi;

NativeFileDialog.Initialize();
try
{
    Run();
}
finally
{
    NativeFileDialog.Shutdown();
}

static void Run()
{
    var path = NativeFileDialog.OpenDialog(
        new FileDialogInfo { FilterList = [new FilterItem { Name = "Text files", Spec = "txt,md" }] },
        out var result
    );

    if (result == NativeFileDialog.Result.Okay)
        Console.WriteLine($"You picked: {path}");
    else
        Console.WriteLine($"No file picked ({result})");
}
