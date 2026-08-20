/**
 * @id         1342
 * @title      Number of Steps to Reduce a Number to Zero
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
 */
namespace Algorithms.Math.Easy;

public static class NumberOfStepsToReduceANumberToZero
{
    public static int Run(int num)
    {
        int result = 0;

        while (num > 0)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;

            result++;
        }

        return result;
    }
}


