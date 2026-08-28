namespace Array.Easy;

public static class SumOfSquaresOfSpecialElements
{
    public static int Run(int[] nums)
    {
        int n = nums.Length;
        int total = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int position = i + 1;

            if (n % position == 0)
                total += nums[i] * nums[i];
        }

        return total;
    }
}
