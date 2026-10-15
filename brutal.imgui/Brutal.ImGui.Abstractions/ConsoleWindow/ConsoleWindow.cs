using System.Buffers;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Brutal.ImGuiApi.Internal;
using Brutal.Strings;
using Microsoft.Extensions.Logging;

namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
/// This logger receives log messages, formats them and sends them to the ConsoleWindow
/// </summary>
public class ConsoleWindowLogger : ILogger, IDisposable
{
    private readonly ConsoleWindow _consoleWindow;
    private readonly string _categoryName;

    /// <summary>
    /// Log formatter function - users can override this, but we provide a default
    /// LogLevel: The log level
    /// string: The category name
    /// string: The log message
    /// Returns the formatted log string
    /// </summary>
    public static Func<LogLevel, string, string, string>? LogFormatter { get; set; }

    public ConsoleWindowLogger(ConsoleWindow consoleWindow, string categoryName)
    {
        _categoryName = categoryName;
        _consoleWindow = consoleWindow;
    }

    public void Dispose() { }

    /// <summary>
    /// Receive a log message, format it and send it to the ConsoleWindow
    /// </summary>
    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception?, string> formatter
    )
    {
        var formattedMessage = formatter(state, exception);
        var message = LogFormatter != null ? LogFormatter(logLevel, _categoryName, formattedMessage) : formattedMessage;

        _consoleWindow.OnLog(_categoryName, logLevel, message);
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public IDisposable? BeginScope<TState>(TState state)
        where TState : notnull
    {
        return null;
    }
}

public class ConsoleWindow : ILoggerProvider
{
    public const int DEFAULT_LOG_TIME = 5;
    public const int INITIAL_BUFFER_CAPACITY = 128;

    private readonly struct PendingMessage
    {
        public readonly int TextOffset;
        public readonly int TextLength; // -1 signals a Clear
        public readonly DateTime Timestamp;
        public readonly ImColor8 Color;
        public readonly int TimeToShow;

        public PendingMessage(int textOffset, int textLength, ImColor8 color, int timeToShow)
        {
            TextOffset = textOffset;
            TextLength = textLength;
            Timestamp = DateTime.Now;
            Color = color;
            TimeToShow = timeToShow;
        }
    }

    private readonly Lock _pendingLock = new();
    private bool _pendingClear;

    private const int BUFFER_COUNT = 2;
    private const int PENDING_TEXT_BUFFER_SIZE = 1024 * 1024; // 1MB pre-allocated for the pending text per-buffer for now, should be enough
    private int _currentActiveBuffer = 0;
    private readonly List<PendingMessage>[] _pendingMessages = new List<PendingMessage>[BUFFER_COUNT] { new(), new() };
    private readonly byte[][] _pendingText = [new byte[PENDING_TEXT_BUFFER_SIZE], new byte[PENDING_TEXT_BUFFER_SIZE]];
    private readonly int[] _pendingTextPos = new int[BUFFER_COUNT];

    private class GrowingRingBuffer<T>(int initialCapacity)
    {
        private T[] _backingArray = new T[initialCapacity];

        public int Begin;
        public int End;
        public int Capacity => _backingArray.Length;
        public int Count => End >= Begin ? End - Begin : Capacity - Begin + End;

        public ref T this[int index] => ref _backingArray[(Begin + index) % Capacity];

        public static implicit operator Span<T>(GrowingRingBuffer<T> array) => array._backingArray;

        public void Reset(int newCapacity)
        {
            if (newCapacity != Capacity)
                _backingArray = new T[newCapacity];
            Begin = 0;
            End = 0;
        }

        public void Resize(int newCapacity)
        {
            var oldCount = Count;
            var newArray = new T[newCapacity];
            if (End > Begin)
            {
                // |--BbbeeE--| |BbbeeE--------------|
                Array.Copy(_backingArray, Begin, newArray, 0, End - Begin);
            }
            else
            {
                // |eeE----Bbb| |BbbeeE--------------|
                Array.Copy(_backingArray, Begin, newArray, 0, Capacity - Begin);
                Array.Copy(_backingArray, 0, newArray, Capacity - Begin, End);
            }

            _backingArray = newArray;
            Begin = 0;
            End = oldCount;

            Debug.Assert(End != Begin);
            Debug.Assert(End < Capacity);
        }

        public void Push(T newItem)
        {
            if ((End + 1) % Capacity == Begin)
                Resize(Capacity * 2);

            _backingArray[End] = newItem;
            End = (End + 1) % Capacity;

            Debug.Assert(End != Begin);
        }
    }

    private readonly GrowingRingBuffer<ConsoleLogEntry> _consoleBuffer = new(INITIAL_BUFFER_CAPACITY);

    public void DrawStats()
    {
        ImGui.Text($"Capacity: {_consoleBuffer.Capacity}");
        ImGui.Text($"Count: {_consoleBuffer.Count}");
        ImGui.Text($"Begin: {_consoleBuffer.Begin}");
        ImGui.Text($"End: {_consoleBuffer.End}");

        var units = Math.Min(20, _consoleBuffer.Capacity);

        var region1Units = 0;
        var region2Units = 0;
        var region3Units = 0;
        var region1Char = '?';
        var region2Char = '?';
        var region3Char = '?';
        var region1Color = ConsoleColor.Float4.Magenta;
        var region2Color = ConsoleColor.Float4.Magenta;
        var region3Color = ConsoleColor.Float4.Magenta;

        if (_consoleBuffer.Begin > _consoleBuffer.End)
        {
            region1Units = (int)((float)_consoleBuffer.End / _consoleBuffer.Capacity * units);
            region2Units = (int)((float)(_consoleBuffer.Begin - _consoleBuffer.End) / _consoleBuffer.Capacity * units);

            region1Char = 'x';
            region2Char = '-';
            region3Char = 'x';
            region1Color = ConsoleColor.Float4.Green;
            region2Color = ConsoleColor.Float4.Grey;
            region3Color = ConsoleColor.Float4.Green;
        }
        else
        {
            region1Units = (int)(((float)_consoleBuffer.Begin / _consoleBuffer.Capacity) * units);

            var num = _consoleBuffer.End - _consoleBuffer.Begin;
            region2Units = (int)((float)num / _consoleBuffer.Capacity * units);
            if (region2Units == 0 && num != 0)
                region2Units = 1;

            region1Char = '-';
            region2Char = 'x';
            region3Char = '-';
            region1Color = ConsoleColor.Float4.Grey;
            region2Color = ConsoleColor.Float4.Green;
            region3Color = ConsoleColor.Float4.Grey;
        }

        region3Units = units - region1Units - region2Units;

        ImGui.Text("Buffer: |"u8);
        ImGui.SameLine();
        ImGui.TextColored(region1Color, new string(region1Char, region1Units));
        ImGui.SameLine();
        ImGui.TextColored(region2Color, new string(region2Char, region2Units));
        ImGui.SameLine();
        ImGui.TextColored(region3Color, new string(region3Char, region3Units));
        ImGui.SameLine();
        ImGui.Text("|"u8);
    }

    public TerminalInterface Terminal;

    private bool _show;
    private bool _setFocus;
    private bool _overwrite;
    private bool _scrollToBottom;
    private bool _autoScroll = false;
    private bool _fadeMessages = true;

    private readonly ImInputString _consoleInput = new(512, []);
    public readonly RingBuffer Storage;
    private bool _clearConsoleInput;

    public bool IsOpen => _show;

    // #TODO-batchmode: Implement BatchMode()

    private float2 _inputSize;
    private bool _inputLastActive;

    private readonly string[] _commandBuffer = new string[8];
    private int _commandBufferIndex;
    private int _headIndex;
    private int _tailIndex;

    private static readonly ImColor8 DefaultColor = ConsoleColor.ColorConvertFloat4ToU32(
        new float4(0.7f, 0.7f, 0.7f, 1f)
    );
    public static ImColor8 InfoColor = DefaultColor;
    public static ImColor8 DebugColor = ConsoleColor.Integer.Yellow;
    public static ImColor8 WarningColor = ConsoleColor.Integer.Orange;
    public static ImColor8 ErrorColor = ConsoleColor.Integer.Red;
    public static ImColor8 CriticalColor = ConsoleColor.Integer.Red;
    public static ImColor8 TraceColor = ConsoleColor.Integer.GreenGrey;

    /// <summary>
    /// Scale of the font in the console window.
    /// Use as a field so it can be referenced in an ImGui slider etc.
    /// </summary>
    public float FontScale = 1f;

    /// <summary>
    /// Font Pointer for rendering texting to console window
    /// <para></para>
    /// This shouldn't really be changed. Only used for more easily testing fonts for ConsoleWindow.
    /// For the sake of consistency between games. Leave this value as is.
    /// </summary>
    public ImFontPtr FontPtr;

    public ConsoleWindow()
        : this(ByteSize.FromMegabytes(2)) { }

    public ConsoleWindow(ByteSize bufferSize)
    {
        Storage = new RingBuffer(bufferSize);
        Terminal = new(this);
    }

    /// <summary>
    /// Retrieves the default font for the console window.
    /// If no fonts are available in the font atlas, a default font is added and returned.
    /// Otherwise, the first font in the font atlas is returned.
    /// </summary>
    /// <returns>The pointer to the default font in the font atlas.</returns>
    public ImFontPtr GetDefaultFont()
    {
        var fontAtlas = ImGui.GetIO().Fonts;
        var fonts = fontAtlas.Fonts;
        return fonts.Count == 0 ? fontAtlas.AddFontDefault() : fonts[0];
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new ConsoleWindowLogger(this, categoryName);
    }

    public void OnLog(string categoryName, LogLevel logLevel, string message)
    {
        // Otherwise just sort by log level
        switch (logLevel)
        {
            case LogLevel.None:
            case LogLevel.Information:
                Print(message, InfoColor);
                break;
            case LogLevel.Trace:
                Print(message, TraceColor);
                break;
            case LogLevel.Debug:
                Print(message, DebugColor);
                break;
            case LogLevel.Warning:
                Print(message, WarningColor);
                break;
            case LogLevel.Error:
                Print(message, ErrorColor);
                break;
            case LogLevel.Critical:
                Print(message, CriticalColor);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null);
        }
    }

    public void Show()
    {
        _show = true;
        _setFocus = true;
        _inputLastActive = true;
    }

    public void Hide()
    {
        _show = false;
        _inputLastActive = false;
    }

    public void EnableMessageFading()
    {
        _fadeMessages = true;
    }

    public void DisableMessageFading()
    {
        _fadeMessages = false;
    }

    private void DrawLog(float unscaledDeltaTime, bool noFade = false)
    {
        _inputSize = ImGui.GetStyle().WindowPadding;

        for (var i = 0; i < _consoleBuffer.Count; ++i)
            Draw(ref _consoleBuffer[i], ref _inputSize, _show, unscaledDeltaTime, noFade);
    }

    /// <summary>
    /// Draws the ConsoleWindow to the screen using the position and size of the current viewport
    /// </summary>
    /// <param name="viewportPosition"></param>
    /// <param name="viewportSize"></param>
    /// <param name="unscaledDeltaTime"></param>
    /// <param name="noFade"></param>
    public void Draw(float2 viewportPosition, float2 viewportSize, float unscaledDeltaTime, bool noFade = false)
    {
        // Swap the buffers before to resolve all the "pending messages"
        SwapBuffers();

        if (FontPtr.IsNull())
            FontPtr = GetDefaultFont();

        ImGui.PushFont(FontPtr, ImGui.GetStyle().FontSizeBase * FontScale);

        // PREPARE WINDOW FLAGS
        var flags =
            ImGuiWindowFlags.NoCollapse
            | ImGuiWindowFlags.NoSavedSettings
            | ImGuiWindowFlags.NoTitleBar
            | ImGuiWindowFlags.NoMove
            | ImGuiWindowFlags.NoResize
            | ImGuiWindowFlags.NoScrollbar
            | ImGuiWindowFlags.NoMouseInputs;
        if (!_show)
            flags |= ImGuiWindowFlags.NoBackground;

        // CREATE WINDOW SIZE
        var scalingSize = _inputSize.Y + ImGui.GetItemRectSize().Y;
        var ySize = _show ? Math.Min(scalingSize, viewportSize.Y / 3) : _inputSize.Y;
        ImGui.SetNextWindowSize(viewportSize with { Y = ySize }, ImGuiCond.Always);
        ImGui.SetNextWindowPos(viewportPosition + new float2(0, viewportSize.Y - ySize), ImGuiCond.Always);

        // SET STYLES FOR WINDOW
        ImGui.PushStyleVar(ImGuiStyleVar.WindowRounding, 0f);
        ImGui.PushStyleColor(ImGuiCol.WindowBg, ConsoleColor.Integer.Black);
        ImGui.PushStyleColor(ImGuiCol.Border, ConsoleColor.Integer.DarkGrey);

        // BEGIN THE DRAW PHASE
        if (ImGui.Begin("ConsoleWindow"u8, ref _show, flags))
        {
            //POP THE BORDER AND BG STYLES
            ImGui.PopStyleColor(2);
            ImGui.PopStyleVar();

            // IF CONSOLE IS OPEN
            if (_show)
            {
                // DRAW A SCROLL AREA FOR HISTORY
                var footerSize = ImGui.GetFrameHeightWithSpacing();
                if (ImGui.BeginChild("ScrollingRegion"u8, new float2(0, -footerSize)))
                {
                    DrawLog(unscaledDeltaTime, noFade);
                    if (_scrollToBottom || (_autoScroll && ImGui.GetScrollY() >= ImGui.GetScrollMaxY()))
                        ImGui.SetScrollHereY(1.0f);
                    _scrollToBottom = false;
                    ImGui.EndChild();
                }

                //ImGui.Separator();

                // PREPARE INPUT FIELD
                ImGui.Text(">"u8);
                ImGui.SameLine();
                ImGui.PushItemWidth(ImGui.GetContentRegionAvail().X);
                ImGui.PushStyleColor(ImGuiCol.Border, ConsoleColor.Integer.Transparent);
                ImGui.PushStyleColor(ImGuiCol.FrameBg, ConsoleColor.Integer.Transparent);

                // DRAW INPUT FIELD
                var id = "###ConsoleInput"u8;
                if (_overwrite)
                {
                    _overwrite = false;
                    ImGui.Internal.GetInputTextState(ImGui.GetID(id)).ReloadUserBufAndMoveToEnd();
                }

                ImGui.InputText(id, _consoleInput);
                _inputLastActive = ImGui.IsItemActive();

                // SET FOCUS ON INPUT FIELD
                ImGuiUtils.SetLastFocusOnAppearing(true);
                _inputSize += ImGui.GetItemRectSize();
                ImGui.PopStyleColor(2);
                ImGui.PopItemWidth();

                if (ImGui.IsItemVisible())
                {
                    if (_setFocus)
                    {
                        ImGui.SetWindowFocus();
                        ImGui.SetKeyboardFocusHere();
                        _setFocus = false;
                        _scrollToBottom = true;
                    }
                    else if (!ImGui.IsWindowFocused())
                    {
                        _show = false;
                        _scrollToBottom = true;
                    }
                }
            }
            // IF CONSOLE IS CLOSED
            else
            {
                // DRAW FADING CRITICAL LOG HISTORY SUCH AS ACTIONS OR ERRORS
                DrawLog(unscaledDeltaTime, noFade);
            }

            // CLEAR THE INPUT FIELD
            if (_clearConsoleInput)
            {
                _clearConsoleInput = false;
                _consoleInput.Clear();
                _scrollToBottom = true;
            }
        }

        //END THE DRAW PHASE
        ImGui.End();
        ImGui.PopFont();
    }

    public void Submit(string input)
    {
        _consoleInput.Value16 = input;
        Submit();
    }

    private void Submit()
    {
        if (_consoleInput.IsEmpty)
        {
            Hide();
            return;
        }

        Terminal.Execute(_consoleInput.ToString());

        _clearConsoleInput = true;
        _setFocus = true;
        _scrollToBottom = true;
    }

    public void ClearConsole()
    {
        // #TODO-batchmode Implement clear console for batch mode
        lock (_pendingLock)
        {
            var buf = _currentActiveBuffer;
            _pendingMessages[buf].Clear();
            _pendingTextPos[buf] = 0;
            _pendingClear = true;
        }
    }

    public void PrintMessage(string message) => Print(message, ConsoleColor.Integer.LightBlue);

    // Default colour
    public void Print(string text, int timeToShow = DEFAULT_LOG_TIME) => Print(text, DefaultColor, timeToShow);

    public void Print(ImString text, int timeToShow = DEFAULT_LOG_TIME) =>
        Print((ReadOnlySpan<byte>)text, DefaultColor, timeToShow);

    public void Print(ReadOnlySpan<char> text, int timeToShow = DEFAULT_LOG_TIME) =>
        Print(text, DefaultColor, timeToShow);

    public void Print(ReadOnlySpan<byte> text, int timeToShow = DEFAULT_LOG_TIME) =>
        Print(text, DefaultColor, timeToShow);

    // With colour
    public void Print(ImString text, ImColor8 color, int timeToShow = DEFAULT_LOG_TIME) =>
        AddPendingMessage((ReadOnlySpan<byte>)text, color, timeToShow);

    public void Print(ReadOnlySpan<byte> text, ImColor8 color, int timeToShow = DEFAULT_LOG_TIME) =>
        AddPendingMessage(text, color, timeToShow);

    public void Print(ReadOnlySpan<char> text, ImColor8 color, int timeToShow = DEFAULT_LOG_TIME) =>
        AddPendingMessage(text, color, timeToShow);

    private void AddPendingMessage(ReadOnlySpan<byte> text, ImColor8 color, int timeToShow)
    {
        // Don't show the message in the fading list if it's disabled
        if (!_fadeMessages)
            timeToShow = 0;
        lock (_pendingLock)
        {
            var bufIdx = _currentActiveBuffer;
            var offset = _pendingTextPos[bufIdx];
            Debug.Assert(
                offset + text.Length <= PENDING_TEXT_BUFFER_SIZE,
                "Pending text buffer overflow — increase PENDING_TEXT_BUFFER_SIZE"
            );
            if (offset + text.Length > PENDING_TEXT_BUFFER_SIZE)
                return;
            text.CopyTo(_pendingText[bufIdx].AsSpan(offset));
            _pendingTextPos[bufIdx] += text.Length;
            _pendingMessages[bufIdx].Add(new PendingMessage(offset, text.Length, color, timeToShow));
        }
    }

    private void AddPendingMessage(ReadOnlySpan<char> text, ImColor8 color, int timeToShow)
    {
        // Don't show the message in the fading list if it's disabled
        if (!_fadeMessages)
            timeToShow = 0;
        var byteCount = Utf8.GetByteCount(text);
        lock (_pendingLock)
        {
            var bufIdx = _currentActiveBuffer;
            var offset = _pendingTextPos[bufIdx];
            Debug.Assert(
                offset + byteCount <= PENDING_TEXT_BUFFER_SIZE,
                "Pending text buffer overflow — increase PENDING_TEXT_BUFFER_SIZE"
            );
            if (offset + byteCount > PENDING_TEXT_BUFFER_SIZE)
                return;
            var status = Utf8.FromUtf16(text, _pendingText[bufIdx].AsSpan(offset), out _, out var bytesWritten);
            if (status != OperationStatus.Done)
                throw new InvalidOperationException($"Failed to convert UTF-16 to UTF-8: {status}");
            _pendingTextPos[bufIdx] += bytesWritten;
            _pendingMessages[bufIdx].Add(new PendingMessage(offset, bytesWritten, color, timeToShow));
        }
    }

    public void SwapBuffers()
    {
        int active;
        bool clear;
        lock (_pendingLock)
        {
            active = _currentActiveBuffer;
            _currentActiveBuffer = (active + 1) % BUFFER_COUNT;
            clear = _pendingClear;
            _pendingClear = false;
        }

        if (clear)
        {
            Storage.Reset();
            _consoleBuffer.Reset(INITIAL_BUFFER_CAPACITY);
        }

        var messages = CollectionsMarshal.AsSpan(_pendingMessages[active]);
        var pendingText = _pendingText[active].AsSpan(0, _pendingTextPos[active]);
        for (var i = 0; i < messages.Length; ++i)
        {
            ref readonly var msg = ref messages[i];
            Apply(in msg, pendingText.Slice(msg.TextOffset, msg.TextLength));
        }

        _pendingMessages[active].Clear();
        _pendingTextPos[active] = 0;
    }

    private void Apply(in PendingMessage pending, ReadOnlySpan<byte> text)
    {
        var textHandle = Storage.Append(text);

        Span<byte> timeBytes = stackalloc byte[8]; // "HH:mm:ss" is always 8 bytes
        pending.Timestamp.TryFormat(timeBytes, out var timeBytesWritten, "HH:mm:ss", CultureInfo.InvariantCulture);

        _consoleBuffer.Push(
            new ConsoleLogEntry
            {
                TextSpanHandle = textHandle,
                Color = pending.Color,
                TimeSpanHandle = Storage.Append(timeBytes[..timeBytesWritten]),
                ActiveTime = pending.TimeToShow,
            }
        );

        // push the begin pointer until we find the next valid message
        while (Storage.TokenIsStale(_consoleBuffer[0].TextSpanHandle))
            _consoleBuffer.Begin = (_consoleBuffer.Begin + 1) % _consoleBuffer.Capacity;
    }

    public enum Actions
    {
        Up,
        Down,
        Submit,
        Toggle,
    }

    /// <summary>
    /// Callback for handling input actions.
    /// </summary>
    /// <param name="action">One of the supported actions.</param>
    /// <returns>True if the action was handled, false otherwise.</returns>
    public bool HandleInputAction(Actions action)
    {
        if (_inputLastActive)
        {
            if (action is Actions.Up or Actions.Down)
            {
                // save the current input if it is not already saved
                if (_commandBufferIndex == _headIndex)
                    _commandBuffer[_headIndex] = _consoleInput.ToString();

                if (action is Actions.Up)
                {
                    var next = _commandBufferIndex == 0 ? _commandBuffer.Length - 1 : _commandBufferIndex - 1;
                    if (_commandBufferIndex != _tailIndex)
                    {
                        _commandBufferIndex = next;
                        _consoleInput.Value16 = _commandBuffer[_commandBufferIndex];
                        _overwrite = true;
                    }
                }
                else
                {
                    // key is down
                    if (_commandBufferIndex != _headIndex)
                    {
                        _commandBufferIndex = (_commandBufferIndex + 1) % _commandBuffer.Length;
                        _consoleInput.Value16 = _commandBuffer[_commandBufferIndex];
                        _overwrite = true;
                    }
                }

                return true;
            }
        }

        if (!_show && action == Actions.Toggle)
        {
            Show();
            return true;
        }

        if (!_show)
            return false;

        if (action == Actions.Toggle)
        {
            Hide();
            return true;
        }

        if (action is Actions.Submit)
        {
            Submit();
            if (!_consoleInput.IsEmpty)
            {
                var inputString = _consoleInput.ToString();
                if (_commandBufferIndex == _headIndex)
                {
                    // we wrote to the head, so we need to move the head
                    _commandBuffer[_commandBufferIndex] = inputString;
                    _headIndex = (_commandBufferIndex + 1) % _commandBuffer.Length;
                }
                else
                {
                    if (inputString != _commandBuffer[_commandBufferIndex])
                    {
                        // we have edited an old command, so we need to move the head and write to the head
                        _commandBuffer[_headIndex] = inputString;
                        _headIndex = (_headIndex + 1) % _commandBuffer.Length;
                    }
                }

                _commandBufferIndex = _headIndex;

                // if the head is at the tail, we need to move the tail
                if (_headIndex == _tailIndex)
                    _tailIndex = (_tailIndex + 1) % _commandBuffer.Length;

                _consoleInput.Clear();
                _overwrite = true;
            }

            return true;
        }

        return false;
    }

    public void Draw(
        ref ConsoleLogEntry line,
        ref float2 inputSize,
        bool isShown,
        float unscaledDeltaTime,
        bool noFade = false
    )
    {
        Debug.Assert(!Storage.TokenIsStale(line.TimeSpanHandle));

        if (line.IsEmpty || !isShown && line.ActiveTime <= 0f)
            return;

        var isShowing = !isShown & line.ActiveTime <= 1f;

        if (isShowing)
        {
            float alpha;
            if (noFade)
                alpha = line.ActiveTime > 0f ? 1f : 0f;
            else
                alpha = float.Lerp(0f, 1f, line.ActiveTime);

            ImGui.PushStyleVar(ImGuiStyleVar.Alpha, alpha);
        }

        DrawTime(line, isShown);
        ImGui.SameLine();

        var textString = Storage.GetSpan(line.TextSpanHandle);

        if (!isShown)
        {
            ImGuiUtils.TextShadow(textString, line.Color);
        }
        else
        {
            ImGui.PushStyleColor(ImGuiCol.Text, line.Color);
            ImGui.TextWrapped(textString);
            ImGui.PopStyleColor();
        }

        inputSize += ImGui.GetItemRectSize() + ImGui.GetStyle().ItemSpacing;

        if (isShowing)
            ImGui.PopStyleVar();
        if (line.ActiveTime > 0)
            line.ActiveTime -= unscaledDeltaTime;
    }

    private void DrawTime(ConsoleLogEntry line, bool isShown)
    {
        var timeString = Storage.GetSpan(line.TimeSpanHandle);

        if (!isShown)
        {
            ImGuiUtils.TextShadow(timeString, ConsoleColor.Integer.Grey);
        }
        else
        {
            ImGui.PushStyleColor(ImGuiCol.Text, ConsoleColor.Integer.Grey);
            ImGui.Text(timeString);
            ImGui.PopStyleColor();
        }
    }

    public void Dispose() { }

    public class RingBuffer(ByteSize capacity)
    {
        public readonly record struct SpanHandle(int Offset, int Length, uint Generation);

        private readonly byte[] _array = new byte[capacity.Bytes];
        internal int Position;
        private int Remaining => _array.Length - Position;
        public int CurrentPosition => Position;
        public uint Generation { get; private set; }

        public Span<byte> Destination => _array.AsSpan(Position);

        private SpanHandle Advance(int bytesWritten) => Advance(bytesWritten, true, Position);

        public SpanHandle Advance(int bytesWritten, bool nullTerminate, int start)
        {
            Position += bytesWritten;
            var length = Position - start; // don't include the null terminator
            if (nullTerminate)
                _array[Position++] = 0;
            return new SpanHandle(start, length, Generation);
        }

        public void EnsureCapacity(int requiredBytes)
        {
            if (requiredBytes > _array.Length)
                throw new OutOfMemoryException(
                    $"Required bytes {requiredBytes} exceed buffer capacity {_array.Length}"
                );

            if (Remaining < requiredBytes)
            {
                Position = 0; // reset position to the beginning of the buffer if we exceed capacity
                ++Generation; // Increment the generation when we reset the position to track stale Tokens
            }
        }

        public SpanHandle Append(ReadOnlySpan<byte> value)
        {
            EnsureCapacity(value.Length + 1); // +1 for null terminator added by Advance
            value.CopyTo(_array.AsSpan(Position));
            return Advance(value.Length);
        }

        public ReadOnlySpan<byte> AppendToSpan(ReadOnlySpan<byte> value)
        {
            return GetSpan(Append(value));
        }

        private SpanHandle Append(ReadOnlySpan<char> value, int requiredBytes)
        {
            EnsureCapacity(requiredBytes + 1); // +1 for null terminator added by Advance
            var status = Utf8.FromUtf16(value, _array.AsSpan(Position), out _, out var bytesWritten);
            if (status != OperationStatus.Done)
                throw new InvalidOperationException($"Failed to convert UTF-16 to UTF-8: {status}");
            return Advance(bytesWritten);
        }

        public SpanHandle Append(ReadOnlySpan<char> value)
        {
            return Append(value, Utf8.GetByteCount(value));
        }

        public ReadOnlySpan<byte> AppendToSpan(ReadOnlySpan<char> value)
        {
            return GetSpan(Append(value));
        }

        public void Reset()
        {
            Position = 0;
            ++Generation;
        }

        public bool TokenIsStale(SpanHandle spanHandle)
        {
            if (spanHandle.Generation == Generation)
                return false; // we are the current generation
            if (spanHandle.Generation == Generation - 1)
                return Position > spanHandle.Offset;
            return true; // any older generations are always stale
        }

        public ReadOnlySpan<byte> GetSpan(SpanHandle spanHandle)
        {
            return _array.AsSpan(spanHandle.Offset, spanHandle.Length);
        }
    }
}
