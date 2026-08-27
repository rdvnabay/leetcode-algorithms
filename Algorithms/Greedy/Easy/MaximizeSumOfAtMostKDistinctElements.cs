/**
 * @id         3684
 * @title      Maximize Sum of At Most K Distinct Elements
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximize-sum-of-at-most-k-distinct-elements/
 */
namespace Greedy.Easy;

public static class MaximizeSumOfAtMostKDistinctElements
{
    public static int[] Run(int[] nums, int k)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        HashSet<int> set = new(nums);

        return set.Take(k).ToArray();
    }
}
