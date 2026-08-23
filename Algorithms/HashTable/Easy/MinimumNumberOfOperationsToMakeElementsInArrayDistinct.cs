namespace HashTable.Easy;

public static class MinimumNumberOfOperationsToMakeElementsInArrayDistinct
{
    //1,2,3  4,2,3,3,5,7
    public static int Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        int step = 0;
        while (dict.Max(x => x.Value) > 1)
        {
            step++;
            int range = nums.Length - 3 * step;
            int[] arr = new int[range];

            for (int i = 0; i < range; i++)
            {
                arr[i] = nums[i + 3 * step];
                if (i < 3)
                {
                    if (dict.TryGetValue(nums[i], out int count))
                    {
                        count -= 1;
                        if (count == 0)
                            dict.Remove(nums[i]);
                        else
                            dict[nums[i]] = count;
                    }
                }

            }
            var teset = "";

        }

        return 0;
    }

}
