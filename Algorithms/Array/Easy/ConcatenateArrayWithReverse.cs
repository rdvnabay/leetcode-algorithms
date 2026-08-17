namespace Array.Easy;

public static class ConcatenateArrayWithReverse
{
    //1,2,3
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[result.Length - 1 - i] = nums[i];
        }

        return result;
    }
}
