namespace Algorithms.Solutions.Easy;

public class MaximumAverageSubarrayI
{
    public static double Run(int[] nums, int k)
    {
        int total = 0;
        int end = k;
        double maxAverage = double.MinValue;

        for (int i = 0; i < k; i++)
            total += nums[i];

        double average = (double)total / k;
        maxAverage = Math.Max(maxAverage, average);

        for (int i = 0; i < nums.Length - k; i++)
        {
            total = total - nums[i] + nums[end++];
            average = (double)total / k;
            maxAverage = Math.Max(maxAverage, average);
        }

        return maxAverage;
    }
}
