using System;
using System.Data;
using System.Text;

namespace HRMS.CLI
{
    // Small collection of console helpers shared by AdminMenu / EmployeeMenu.
    // Kept separate from Program.cs so the menu classes stay focused on
    // calling into HRMS.Library rather than formatting console output.
    public static class ConsoleUI
    {
        public static void Header(string title)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', title.Length + 4));
            Console.WriteLine("  " + title);
            Console.WriteLine(new string('=', title.Length + 4));
        }

        public static void Error(string message)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ForegroundColor = prev;
        }

        public static void Success(string message)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = prev;
        }

        public static string Prompt(string label)
        {
            Console.Write(label + ": ");
            return (Console.ReadLine() ?? "").Trim();
        }

        // Like Prompt, but does not trim (useful for passwords where
        // leading/trailing spaces should be preserved/rejected as typed).
        public static string PromptRaw(string label)
        {
            Console.Write(label + ": ");
            return Console.ReadLine() ?? "";
        }

        // Reads a password from the console, masking each character with '*'.
        // Falls back to a plain ReadLine if input is redirected (e.g. when
        // piping input in from a file/CI), since Console.ReadKey needs a
        // real console.
        public static string ReadPassword(string label)
        {
            Console.Write(label + ": ");

            if (Console.IsInputRedirected)
            {
                return Console.ReadLine() ?? "";
            }

            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        sb.Length--;
                        Console.Write("\b \b");
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    sb.Append(key.KeyChar);
                    Console.Write('*');
                }
            }
            return sb.ToString();
        }

        public static int PromptInt(string label)
        {
            while (true)
            {
                string raw = Prompt(label);
                int value;
                if (int.TryParse(raw, out value)) return value;
                Error("Please enter a whole number.");
            }
        }

        public static double PromptDouble(string label)
        {
            while (true)
            {
                string raw = Prompt(label);
                double value;
                if (double.TryParse(raw, out value)) return value;
                Error("Please enter a valid number.");
            }
        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }

        // Confirms with the user (y/n), defaulting to 'no' on empty input.
        public static bool Confirm(string label)
        {
            string raw = Prompt(label + " (y/N)").Trim().ToLowerInvariant();
            return raw == "y" || raw == "yes";
        }

        // Renders a DataTable (what every DL.GetAll()/GetByID() returns)
        // as a simple, readable, column-aligned console table.
        public static void PrintTable(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                Console.WriteLine("(no records found)");
                return;
            }

            int colCount = dt.Columns.Count;
            int[] widths = new int[colCount];

            for (int c = 0; c < colCount; c++)
                widths[c] = dt.Columns[c].ColumnName.Length;

            foreach (DataRow row in dt.Rows)
            {
                for (int c = 0; c < colCount; c++)
                {
                    string val = row[c]?.ToString() ?? "";
                    if (val.Length > widths[c]) widths[c] = val.Length;
                }
            }

            // Cap absurdly wide columns (e.g. long addresses) so the table
            // stays readable in a normal terminal window.
            for (int c = 0; c < colCount; c++)
                if (widths[c] > 40) widths[c] = 40;

            PrintRow(dt.Columns, widths);
            Console.WriteLine(new string('-', SumWidths(widths) + colCount * 3 - 1));

            foreach (DataRow row in dt.Rows)
                PrintDataRow(row, widths, colCount);

            Console.WriteLine($"({dt.Rows.Count} row(s))");
        }

        private static int SumWidths(int[] widths)
        {
            int total = 0;
            foreach (int w in widths) total += w;
            return total;
        }

        private static void PrintRow(DataColumnCollection cols, int[] widths)
        {
            var sb = new StringBuilder();
            for (int c = 0; c < cols.Count; c++)
                sb.Append(Pad(cols[c].ColumnName, widths[c])).Append(" | ");
            Console.WriteLine(sb.ToString());
        }

        private static void PrintDataRow(DataRow row, int[] widths, int colCount)
        {
            var sb = new StringBuilder();
            for (int c = 0; c < colCount; c++)
            {
                string val = row[c]?.ToString() ?? "";
                if (val.Length > widths[c]) val = val.Substring(0, widths[c] - 3) + "...";
                sb.Append(Pad(val, widths[c])).Append(" | ");
            }
            Console.WriteLine(sb.ToString());
        }

        private static string Pad(string s, int width)
        {
            return s.Length >= width ? s : s + new string(' ', width - s.Length);
        }
    }
}
