namespace Array.Easy;

public static class ShuffleTheArray
{
    //1,2,3,4,4,3,2,1  4
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
