namespace String.Easy;

public static class CellsInARangeOnAnExcelSheet
{
    //K1:L2
    public static IList<string> Run(string s)
    {
        List<string> result = new();

        int startColumn = s[0];
        int endColumn = s[3];
        int startRow = s[1] - '0';
        int endRow = s[4] - '0';

        for (int i = startColumn; i <= endColumn; i++)
        {
            for (int j = startRow; j <= endRow; j++)
                result.Add($"{(char)i}{j}");
        }

        return result;
    }
}
