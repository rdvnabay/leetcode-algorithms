using System.Diagnostics.Metrics;

namespace Math.Easy;

public static class CalculateMoneyInLeetcodeBank
{
    //20
    //1-2-3-4-5-6-7
    //2-3-4-5-6-7-8
    //3-4-5-6-7-8
    public static int Run(int n)
    {
        int weekCount = n / 7;
        int remainder = n % 7;
        int total = 0;
        int count = weekCount;

        while (count > 0)
        {
            total += (28 + (count - 1) * 7);
            count--;
        }

        for (int i = weekCount + 1; i <= weekCount + remainder; i++)
            total += i;

        return total;
    }
}
