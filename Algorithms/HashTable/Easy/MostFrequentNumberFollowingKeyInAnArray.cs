namespace HashTable.Easy;

public static class MostFrequentNumberFollowingKeyInAnArray
{
    public static int Run(int[] nums, int key)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == key)
            {
                int target = nums[i + 1];
                dict[target] = dict.GetValueOrDefault(target, 0) + 1;
            }
        }

        return dict.MaxBy(x => x.Value).Key;
    }
}
