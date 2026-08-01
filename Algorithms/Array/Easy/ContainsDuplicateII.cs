namespace Algorithms.Array.Easy;

public static class ContainsDuplicateII
{
    public static bool Run(int[] nums, int k)
    {
        Dictionary<int, List<int>> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = new List<int> { i };
            }
            else
            {
                foreach (var index in dict[nums[i]])
                {
                    if (System.Math.Abs(i - index) <= k)
                        return true;
                }
                dict[nums[i]].Add(i);
            }
        }

        return false;
    }
}
