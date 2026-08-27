/**
 * @id         2455
 * @title      Average Value of Even Numbers That Are Divisible by Three
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/average-value-of-even-numbers-that-are-divisible-by-three/
 */
namespace Math.Easy;

public static class AverageValueOfEvenNumbersThatAreDivisibleByThree
{
    public static int Run(int[] nums)
    {
        int total = 0;
        int matchCount = 0;

        foreach (int num in nums)
        {
            if (num % 6 == 0)
            {
                total += num;
                matchCount++;
            }
        }

        if (matchCount == 0)
            return 0;

        return total / matchCount;
    }
}
