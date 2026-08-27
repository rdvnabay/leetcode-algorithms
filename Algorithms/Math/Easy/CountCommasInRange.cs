/**
 * @id         3870
 * @title      Count Commas in Range
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-commas-in-range/
 */
namespace Math.Easy;

public static class CountCommasInRange
{
    public static int Run(int n)
    {
        const int FirstNumberWithComma = 1000;

        if (n < FirstNumberWithComma)
            return 0;

        return n - FirstNumberWithComma + 1;
    }
}


