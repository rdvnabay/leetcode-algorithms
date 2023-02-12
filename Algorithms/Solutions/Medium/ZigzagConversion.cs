namespace Algorithms.Solutions.Medium;

public static class ZigzagConversion
{
    public static string Run(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        var result = new string[numRows];
        int index = 0;
        int step = 1;

        for (int i = 0; i < s.Length; i++)
        {
            result[index] += s[i];
            if (index == 0)
                step = 1;
           
            else if (index == numRows - 1)
                step = -1;
            index += step;
        }

        return string.Join("", result);
    }
}
