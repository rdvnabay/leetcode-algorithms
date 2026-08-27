/**
 * @id         414
 * @title      Third Maximum Number
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/third-maximum-number/
 */
namespace Algorithms.Array.Easy;

public static class ThirdMaximumNumber
{
    public static int Run(int[] nums)
    {
        HashSet<int> result = new(nums);

        if (result.Count < 3)
            return result.Max();
        else
        {
            result.Remove(result.Max());
            result.Remove(result.Max());
            return result.Max();
        }
    }
}


