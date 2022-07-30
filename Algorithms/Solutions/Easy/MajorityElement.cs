namespace Algorithms.Solutions.Easy;
public class MajorityElement
{
    public static int Run(int[] nums)
    {
        return Solution1(nums);
        //return Solution2(nums);
    }

    // Runtime: 124 ms
    // Memory: 45 MB
    private static int Solution1(int[] nums) => nums.GroupBy(x => x).MaxBy(x => x.Count()).Key;


    // Boyer Moore algorithms
    // Runtime: 231 ms
    // Memory: 40.8 MB 	
    private static int Solution2(int[] nums)
    {
        int output = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
                output = num;

            if (output == num)
                count++;
            else
                count--;
        }

        return output;
    }
}
