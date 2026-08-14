namespace Math.Easy;

public static class MinimumOperationsToMakeArraySumDivisibleByK
{
    //3,9,7
    public static int Run(int[] nums, int k)
    {
        int total = 0;

        foreach (int num in nums)
            total += num;

        return total % k;
    }
}
