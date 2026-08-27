/**
 * @id         1523
 * @title      Count Odd Numbers in an Interval Range
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
 */
namespace Math.Easy;

public static class CountOddNumbersInAnIntervalRange
{
    public static int Run(int low, int high)
    {
        bool lowIsOdd = low % 2 != 0;
        bool highIsOdd = high % 2 != 0;

        return (lowIsOdd, highIsOdd) switch
        {
            (true, true) => ((high - low) / 2) + 1,
            (true, false) => (((high - 1) - low) / 2) + 1,
            (false, true) => ((high - (low + 1)) / 2) + 1,
            _ => (high - low) / 2
        };
    }
}


