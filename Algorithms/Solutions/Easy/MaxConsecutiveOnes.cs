namespace Algorithms.Solutions.Easy;

public static class MaxConsecutiveOnes
{
    public static int Run(int[] nums)
    {
        int max = 0;
        int counter = 0;
        int lenght = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                counter++;
            }
            else
            {
                if (counter > max)
                {
                    max = counter;
                }
                counter = 0;
            }
        }

        if (counter > max)
            return counter;

        return max;
    }
}
