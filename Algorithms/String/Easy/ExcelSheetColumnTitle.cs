using System.Text;

namespace Algorithms.String.Easy;

public static class ExcelSheetColumnTitle
{
    public static string Run(int columnNumber)
    {
        StringBuilder sb = new();
        Recursive(columnNumber, sb);

        return sb.ToString();
    }

    static void Recursive(int dividend, StringBuilder sb)
    {
        int divisor = 26;
        dividend--;

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        sb.Insert(0, (char)('A' + remainder));

        if (quotient == 0)
            return;

        Recursive(quotient, sb);
    }
}
