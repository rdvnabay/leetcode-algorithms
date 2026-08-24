namespace Array.Easy;

public static class NumberOfDistinctAverages
{
    public static int Run(int[] nums)
    {
        HashSet<double> result = new();

        System.Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;
        int index = 0;

        while (left < right)
        {
            int min = nums[left];
            int max = nums[right];
            result.Add((double)(max + min) / 2);
            left++;
            right--;
            index++;
        }

        return result.Count;
    }


    //Alternative solutions
    public static int Solution2(int[] nums)
    {
        HashSet<double> result = new();

        System.Array.Sort(nums);

        int index = 0;

        while (nums.Length > 0)
        {
            int min = nums[0];
            int max = nums[nums.Length - 1];
            result.Add((double)(max + min) / 2);

            nums = nums[1..^1];
            index++;
        }

        return result.Count;
    }
}
