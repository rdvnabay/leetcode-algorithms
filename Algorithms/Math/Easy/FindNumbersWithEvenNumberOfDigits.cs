namespace Math.Easy;

public static class FindNumbersWithEvenNumberOfDigits
{
    public static int Run(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int digitCount = 0;
            int number = nums[i];

            while (number > 0)
            {
                number = number / 10;
                digitCount++;
            }

            if (digitCount % 2 == 0)
                result++;
        }

        return result;
    }
}
