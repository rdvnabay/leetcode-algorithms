using System.Collections.Immutable;

namespace Algorithms.Array.Easy;

public static class SquaresOfASortedArray
{
    public static int[] Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] *= nums[i];
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int current = nums[i];
                int next = nums[j];

                if (current > next)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
}
