/**
 * @id         2670
 * @title      Find the Distinct Difference Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-distinct-difference-array/
 */
namespace Array.Easy;

public static class FindTheDistinctDifferenceArray
{
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length];
        HashSet<int> diffNums = nums.ToHashSet();
        HashSet<int> setNums = new();

        for (int i = 0; i < nums.Length; i++)
        {
            setNums.Add(nums[i]);
            diffNums.Remove(nums[i]);
            result[i] = setNums.Count - diffNums.Count;

        }

        return result;
    }
}
