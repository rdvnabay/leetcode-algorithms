namespace Algorithms.Solutions.Easy;

public class MoveZeroes
{
    public static void Run(int[] nums)
    {
        int zeroCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zeroCount++;
            else
            {
                nums[i - zeroCount] = nums[i];
            }
        }

        for (int i = nums.Length - zeroCount; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
