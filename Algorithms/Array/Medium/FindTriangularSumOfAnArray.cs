namespace Array.Medium;

public class FindTriangularSumOfAnArray
{
    public static int Run(int[] nums)
    {
        int counter = 0;

        while (counter < nums.Length - 1)
        {
            counter++;

            for (int i = 0; i < nums.Length - counter; i++)
                nums[i] = (nums[i] + nums[i + 1]) % 10;
        }

        return nums[0];
    }
}
