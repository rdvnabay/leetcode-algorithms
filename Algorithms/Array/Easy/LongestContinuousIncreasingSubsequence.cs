namespace Algorithms.Array.Easy;

public class LongestContinuousIncreasingSubsequence
{
    public static int Run(int[] nums)
    {
        int counter = 1;
        int result = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int left = nums[i];
            int right = nums[i + 1];

            if (left < right)
            {
                counter++;
            }
            else
            {
                result = System.Math.Max(result, counter);
                counter = 1;
            }
        }

        return System.Math.Max(result, counter);
    }
}
