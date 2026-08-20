namespace TwoPointers.Easy;

public static class ApplyOperationsToAnArray
{
    //1,2,2,1,1,0
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                nums[i] = nums[i] * 2;
                nums[i + 1] = 0;
            }
        }

        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                result[index] = nums[i];
                index++;
            }
        }

        return result;
    }
}
