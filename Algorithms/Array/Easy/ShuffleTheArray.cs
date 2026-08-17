namespace Array.Easy;

public static class ShuffleTheArray
{
    public static int[] Run(int[] nums, int n)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[i + n];
        }

        return result;
    }
}
