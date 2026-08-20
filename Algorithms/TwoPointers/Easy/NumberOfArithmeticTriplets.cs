namespace TwoPointers.Easy;

public static class NumberOfArithmeticTriplets
{
    public static int Run(int[] nums, int diff)
    {
        int counter = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if ((nums[k] - nums[j] == diff) && (nums[j] - nums[i] == diff))
                        counter++;
                }
            }
        }

        return counter;
    }
}
