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
        Dictionary<int, int> dict = new();
        HashSet<int> setNums = new();
        int[] result = new int[nums.Length];

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;


        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            setNums.Add(num);
            dict[num]--;

            if (dict[num] == 0)
                dict.Remove(num);

            result[i] = setNums.Count - dict.Count;
        }

        return result;
    }
}
