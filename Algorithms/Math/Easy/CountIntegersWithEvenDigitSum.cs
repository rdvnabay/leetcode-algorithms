/**
 * @id         2180
 * @title      Count Integers With Even Digit Sum
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-integers-with-even-digit-sum/
 */
namespace Math.Easy;

public static class CountIntegersWithEvenDigitSum
{
    public static int Run(int num)
    {
        int result = 0;

        for (int i = 1; i <= num; i++)
        {
            int digitSum = 0;
            int currentNumber = i;

            while (currentNumber > 0)
            {
                digitSum += currentNumber % 10;
                currentNumber /= 10;
            }

            if (digitSum % 2 == 0)
                result++;
        }

        return result;
    }
}


