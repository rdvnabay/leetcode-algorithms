/**
 * @id         3190
 * @title      Find Minimum Operations to Make All Elements Divisible by Three
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three/
 */
namespace Math.Easy;

public static class FindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    //1 2 3 4
    public static int Run(int[] nums)
    {
        int total = 0;

        foreach (var num in nums)
        {
            if (num % 3 != 0)
                total++;
        }

        return total;
    }
}


