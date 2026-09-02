namespace Array.Easy;

public static class SmallestIndexWithDigitSumEqualToIndex
{
    public static int Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int digitTotal = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                digitTotal += remainder;
                num /= 10;
            }

            if (digitTotal == i)
                return i;
        }

        return -1;
    }
}
