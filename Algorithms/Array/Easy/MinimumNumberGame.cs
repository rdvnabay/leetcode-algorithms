namespace Array.Easy;

public static class MinimumNumberGame
{
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length];

        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
        {
            result[i + 1] = nums[i];
            result[i] = nums[i + 1];
        }

        return result;
    }
}
