namespace Algorithms.Array.Easy.Solutions;

public static class MonotonicArray
{
    public static bool Run(int[] nums)
    {
        int current = nums[0];
        bool? asc = null;

        for (int i = 1; i < nums.Length; i++)
        {
            if (current < nums[i])
            {
                current = nums[i];

                if (asc is null)
                {
                    asc = true;
                }
                else
                {
                    if (asc == false)
                        return false;
                }
            }
            else if (current > nums[i])
            {
                current = nums[i];

                if (asc is null)
                {
                    asc = false;
                }
                else
                {
                    if (asc == true)
                        return false;
                }
            }
        }

        return true;
    }
}
