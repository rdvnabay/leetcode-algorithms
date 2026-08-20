/**
 * @id         3289
 * @title      The Two Sneaky Numbers of Digitville
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville/
 */
namespace Algorithms.Math.Easy;

public static class TheTwoSneakyNumbersOfDigitville
{
    public static int[] Run(int[] nums)
    {
        List<int> uniqueNums = new();
        List<int> duplicateNums = new();

        foreach (int num in nums)
        {
            if (!uniqueNums.Contains(num))
                uniqueNums.Add(num);
            else
                duplicateNums.Add(num);
        }

        var result = duplicateNums.ToArray();
        return result;
    }
}


