namespace Algorithms.Math.Easy;

public static class DifferenceBetweenElementSumAndDigitSumOfAnArray
{
    //1,15,6,3
    public static int Run(int[] nums)
    {
        int numberTotal = 0;
        int digitTotal = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            numberTotal += num;

            while (num > 0)
            {
                int remainder = num % 10;
                digitTotal += remainder;
                num = num / 10;
            }
        }

        return System.Math.Abs(numberTotal - digitTotal);
    }
}
