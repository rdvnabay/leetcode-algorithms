/**
 * @id         2119
 * @title      A Number After a Double Reversal
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/a-number-after-a-double-reversal/
 */
namespace Algorithms.Math.Easy;

public static class ANumberAfterADoubleReversal
{
    public static bool Run(int num)
    {
        if (num == 0)
            return true;

        if (num % 10 != 0)
            return true;

        return false;
    }
}


