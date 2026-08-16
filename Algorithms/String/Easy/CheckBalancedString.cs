namespace String.Easy;

public static class CheckBalancedString
{
    public static bool Run(string num)
    {
        int totalOdd = 0;
        int totalEven = 0;

        for (int i = 0; i < num.Length; i++)
        {
            int value = num[i] - '0';

            if (i % 2 == 0)
                totalEven += value;
            else
                totalOdd += value;
        }

        return totalOdd == totalEven;
    }
}
