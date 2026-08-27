namespace Array.Easy;

public static class MaximumValueOfAnOrderedTripletI
{
    //12,6,1,2,7
    public static long Run(int[] nums)
    {
        long maxValue = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    long value = (nums[i] - nums[j]) * nums[k];
                    if (value > maxValue)
                        maxValue = value;
                }
            }
        }

        return maxValue;
    }
}
