namespace String.Easy;

public static class RemoveTrailingZerosFromAString
{
    public static string Run(string num)
    {
        if (num[num.Length - 1] != '0')
            return num;

        int zeroCount = 0;

        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] == '0')
                zeroCount++;
            else
                break;
        }

        return num.Substring(0, num.Length - zeroCount);
    }
}
