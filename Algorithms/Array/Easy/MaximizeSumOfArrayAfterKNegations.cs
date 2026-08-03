namespace Array.Easy;

public static class MaximizeSumOfArrayAfterKNegations
{
    public static int Run(int[] nums, int k)
    {
        int total = 0;

        SortedArray(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (k > 0)
            {
                if (nums[i] < 0)
                {
                    if (i + 1 < nums.Length - 1)
                    {
                        if (nums[i + 1] > 0)
                        {
                            if (k % 2 == 1)
                                nums[i] = -nums[i];

                            k = 0;
                        }
                        else
                            nums[i] = -nums[i];
                    }
                }

                else if (nums[i] > 0)
                {
                    if (k % 2 == 1)
                    {
                        nums[i] = -nums[i];
                        k = 0;
                    }
                }

                else
                    k = 0;

                k--;
            }

            total += nums[i];
        }

        return total;
    }

    static void SortedArray(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}
