namespace Greedy.Easy;

public static class MinimumSubsequenceInNonIncreasingOrder
{
    public static IList<int> Run(int[] nums)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        int total = nums.Sum();
        int value = 0;
        List<int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            value += nums[i];
            total -= nums[i];
            result.Add(nums[i]);

            if (value > total)
                return result;
        }

        return result;
    }
}
