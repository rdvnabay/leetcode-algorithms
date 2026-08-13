namespace Math.Easy;

public static class FindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    //1 2 3 4
    public static int Run(int[] nums)
    {
        int total = 0;

        foreach (var num in nums)
        {
            if (num % 3 != 0)
                total++;
        }

        return total;
    }
}
