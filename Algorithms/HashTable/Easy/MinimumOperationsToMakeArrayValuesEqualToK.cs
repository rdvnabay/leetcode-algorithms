namespace HashTable.Easy;

public static class MinimumOperationsToMakeArrayValuesEqualToK
{
    public static int Run(int[] nums, int k)
    {
        int min = nums.Min();
        if (min < k)
            return -1;

        int minOperation = 0;

        while (!nums.All(x => x == k))
        {
            HashSet<int> set = new(nums);
            int max = set.Max();

            int nextValue = set.Any(x => x < max) ? set.Where(x => x < max).Max() : k;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                    nums[i] = nextValue;
            }

            minOperation++;
        }

        return minOperation;
    }
}
