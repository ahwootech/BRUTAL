using System.Text;

namespace Brutal.ImGuiApi.Abstractions;

public class TableString
{
    private readonly List<Row> _rows = new();

    private readonly List<int> _columnWidths = new();

    public readonly struct Row
    {
        public readonly String[] Values;

        public Row(string[] values)
        {
            Values = values;
        }

        public static Row Create(params string[] values) => new(values);

        public void ToConsole(ConsoleWindow console)
        {
            foreach (var value in Values)
                console.Print(value);
        }
    }

    public void AddRow(params string[] values) => _rows.Add(new Row(values));

    public void ToConsole(ConsoleWindow console)
    {
        // populate column widths
        foreach (var row in _rows)
        {
            for (var i = 0; i < row.Values.Length; i++)
            {
                if (i >= _columnWidths.Count)
                    _columnWidths.Add(0);
                var rowColumnValue = row.Values[i].Length + 1;
                if (rowColumnValue > _columnWidths[i])
                    _columnWidths[i] = rowColumnValue;
            }
        }

        foreach (var row in _rows)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < row.Values.Length; i++)
            {
                var value = row.Values[i];
                switch (i)
                {
                    case > 0:
                        sb.Append(' ');
                        break;
                    case 0:
                        sb.Append("| ");
                        break;
                }

                sb.Append(value.PadRight(_columnWidths[i]));
                sb.Append(" |");
            }
            console.Print(sb.ToString());
        }
    }

    public void AddRow(Row toRow) => _rows.Add(toRow);

    public void Sort()
    {
        // sort rows by first column
        _rows.Sort((a, b) => string.Compare(a.Values[0], b.Values[0], StringComparison.Ordinal));
    }
}
