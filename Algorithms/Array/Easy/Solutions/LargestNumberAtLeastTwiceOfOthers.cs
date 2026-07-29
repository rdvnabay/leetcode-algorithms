namespace Algorithms.Array.Easy.Solutions;

public static class LargestNumberAtLeastTwiceOfOthers
{
    public static int Run(int[] nums)
    {
        int maxNumber = nums[0];
        int maxNumberIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maxNumber)
            {
                maxNumber = nums[i];
                maxNumberIndex = i;
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (j == maxNumberIndex)
                continue;

            if (maxNumber < nums[j] * 2)
                return -1;

        }
        return maxNumberIndex;
    }
}
