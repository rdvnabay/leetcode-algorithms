namespace Algorithms.Solutions.Easy;
public class MajorityElement
{
    public static int Run(int[] nums)
    {
        // Solution 1:
        // Runtime: 124 ms
        // Memory: 45 MB
        return nums.GroupBy(x => x).MaxBy(x => x.Count()).Key;

        // Solution 2: Boyer Moore algorithms
        // Runtime: 231 ms
        // Memory: 40.8 MB 	
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
