/**
 * @id         3736
 * @title      Minimum Moves to Equal Array Elements III
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-moves-to-equal-array-elements-iii/
 */
namespace Math.Easy;

public static class MinimumMovesToEqualArrayElementsIII
{
    public static int Run(int[] nums)
    {
        int total = 0;
        int max = nums.Max();

        foreach (var num in nums)
            total += max - num;

        return total;
    }
}


