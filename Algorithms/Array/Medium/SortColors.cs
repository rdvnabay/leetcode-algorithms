namespace Algorithms.Array.Medium;

public static class SortColors
{
    public static void Run(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;

        while (mid <= right)
        {
            if (nums[mid] == 0)
            {
                int temp = nums[left];
                nums[left] = nums[mid];
                nums[mid++] = temp;
                left++;

            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                int temp = nums[mid];
                nums[mid] = nums[right];
                nums[right--] = temp;
            }
        }
    }
}
