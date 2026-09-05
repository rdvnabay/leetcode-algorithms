namespace HashTable.Medium;

public static class MinimumIndexOfAValidSplit
{
    public static int Run(IList<int> nums)
    {
        //1,2,2,2
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        int dominant = dict.MaxBy(x => x.Value).Key;
        int split = 1;

        while (split < nums.Count)
        {
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < split; i++)
            {
                if (nums[i] == dominant)
                    leftCount++;
            }

            for (int i = split; i < nums.Count; i++)
            {
                if (nums[i] == dominant)
                    rightCount++;
            }


            if (leftCount * 2 > split && rightCount * 2 > (nums.Count - split))
                return split - 1;

            split++;
        }


        return -1;
    }
}
