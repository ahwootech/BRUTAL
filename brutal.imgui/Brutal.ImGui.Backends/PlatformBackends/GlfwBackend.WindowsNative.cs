using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi.Backends;

using BOOL = int;
using LONG = int;
using UINT = uint;
using HANDLE = nint;
using HWND = nint;
using LONG_PTR = nint;
using LPARAM = nint;
using LPCSTR = ReadOnlySpan<byte>;
using LRESULT = nint;
using WNDPROC = nint;
using WPARAM = nuint;

public partial class GlfwBackend
{
    private static partial class WindowsNative
    {
        [LibraryImport("user32.dll")]
        public static partial LONG_PTR GetWindowLongPtrW(HWND hWnd, int nIndex);

        [LibraryImport("user32.dll")]
        public static partial LONG_PTR SetWindowLongPtrW(HWND hWnd, int nIndex, LONG_PTR dwNewLong);

        [LibraryImport("user32.dll", EntryPoint = "GetWindowLongW")]
        public static partial LONG GetWindowLong(HWND hWnd, int nIndex);

        [LibraryImport("user32.dll", EntryPoint = "SetWindowLongW")]
        public static partial LONG SetWindowLong(HWND hWnd, int nIndex, LONG dwNewLong);

        [LibraryImport("user32.dll")]
        public static partial BOOL SetPropA(HWND hWnd, LPCSTR lpString, LONG_PTR lParam);

        [LibraryImport("user32.dll")]
        public static partial HANDLE GetPropA(HWND hWnd, LPCSTR lpString);

        [LibraryImport("user32.dll")]
        public static partial LPARAM GetMessageExtraInfo();

        [LibraryImport("user32.dll")]
        public static partial LRESULT CallWindowProcW(
            WNDPROC lpPrevWndFunc,
            HWND hWnd,
            UINT msg,
            WPARAM wParam,
            LPARAM lParam
        );

        [LibraryImport("user32.dll")]
        public static partial LRESULT DefWindowProc(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);

        public static class Constants
        {
            public const int GWL_EXSTYLE = -20;
            public const int GWLP_WNDPROC = -4;
            public const int WS_EX_APPWINDOW = 0x00040000;
            public const int WS_EX_TOOLWINDOW = 0x00000080;

            public const int WM_MOUSEMOVE = 0x0200;
            public const int WM_NCMOUSEMOVE = 0x00A0;
            public const int WM_LBUTTONDOWN = 0x0201;
            public const int WM_LBUTTONDBLCLK = 0x0203;
            public const int WM_LBUTTONUP = 0x0202;
            public const int WM_RBUTTONDOWN = 0x0204;
            public const int WM_RBUTTONDBLCLK = 0x0206;
            public const int WM_RBUTTONUP = 0x0205;
            public const int WM_MBUTTONDOWN = 0x0207;
            public const int WM_MBUTTONDBLCLK = 0x0209;
            public const int WM_MBUTTONUP = 0x0208;
            public const int WM_XBUTTONDOWN = 0x020B;
            public const int WM_XBUTTONDBLCLK = 0x020D;
            public const int WM_XBUTTONUP = 0x020C;
        }

        public static unsafe delegate* unmanaged[Cdecl]<HWND, UINT, WPARAM, LPARAM, LRESULT> WndProcDelegate = &WndProc;

        // WndProc hook
        public static ImGuiMouseSource GetMouseSourceFromMessageExtraInfo()
        {
            LPARAM extra_info = GetMessageExtraInfo();
            if ((extra_info & 0xFFFFFF80) == 0xFF515700)
                return ImGuiMouseSource.Pen;
            if ((extra_info & 0xFFFFFF80) == 0xFF515780)
                return ImGuiMouseSource.TouchScreen;
            return ImGuiMouseSource.Mouse;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe LRESULT WndProc(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam)
        {
            var backendHandle = GetPropA(hWnd, "IMGUI_BACKEND_DATA"u8);
            if (GCHandle.FromIntPtr(backendHandle).Target is not GlfwBackend backend)
                throw new Exception("Failed to retrieve backend");

            var io = GetIO(backend._context);

            var prevWndProc = backend._prevWndProc;
            var viewport = (ImGuiViewport*)GetPropA(hWnd, "IMGUI_VIEWPORT"u8);
            if (viewport is not null)
            {
                var viewportData = (ViewportData*)viewport->PlatformUserData;
                if (viewportData is not null)
                    prevWndProc = viewportData->PrevWndProc;
            }

            switch (msg)
            {
                // GLFW doesn't allow to distinguish Mouse vs TouchScreen vs Pen.
                // Add support for Win32 (based on imgui_impl_win32), because we rely on _TouchScreen info to trickle inputs differently.
                case Constants.WM_MOUSEMOVE:
                case Constants.WM_NCMOUSEMOVE:
                case Constants.WM_LBUTTONDOWN:
                case Constants.WM_LBUTTONDBLCLK:
                case Constants.WM_LBUTTONUP:
                case Constants.WM_RBUTTONDOWN:
                case Constants.WM_RBUTTONDBLCLK:
                case Constants.WM_RBUTTONUP:
                case Constants.WM_MBUTTONDOWN:
                case Constants.WM_MBUTTONDBLCLK:
                case Constants.WM_MBUTTONUP:
                case Constants.WM_XBUTTONDOWN:
                case Constants.WM_XBUTTONDBLCLK:
                case Constants.WM_XBUTTONUP:
                    io.AddMouseSourceEvent(GetMouseSourceFromMessageExtraInfo());
                    break;
                default:
                    break;
            }

            return CallWindowProcW(prevWndProc, hWnd, msg, wParam, lParam);
        }
    }
}
