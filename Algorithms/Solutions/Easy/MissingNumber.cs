namespace Algorithms.Solutions.Easy;

public static class MissingNumber
{
    public static int Run(int[] nums)
    {
        int numsTotal = nums.Sum();
        int allNumberTotal = Enumerable.Range(0, nums.Length + 1).Sum();

        return allNumberTotal - numsTotal;
    }
}
