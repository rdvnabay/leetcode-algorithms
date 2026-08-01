namespace Algorithms.Array.Easy;

public class FindPivotIndex
{
    public static int Run(int[] nums)
    {
        int total = nums.Sum();
        int right_total = total;
        int left_total = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            right_total -= nums[i];

            if (left_total == right_total)
                return i;

            left_total += nums[i];
        }

        return -1;
    }
}