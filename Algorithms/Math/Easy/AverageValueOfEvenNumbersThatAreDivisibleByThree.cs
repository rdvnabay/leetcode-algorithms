namespace Math.Easy;

public static class AverageValueOfEvenNumbersThatAreDivisibleByThree
{
    public static int Run(int[] nums)
    {
        int total = 0;
        int matchCount = 0;

        foreach (int num in nums)
        {
            if (num % 6 == 0)
            {
                total += num;
                matchCount++;
            }
        }

        if (matchCount == 0)
            return 0;

        return total / matchCount;
    }
}
