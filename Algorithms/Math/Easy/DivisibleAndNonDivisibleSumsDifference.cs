namespace Math.Easy;

public static class DivisibleAndNonDivisibleSumsDifference
{
    public static int Run(int n, int m)
    {
        int sumOfDivisibles = 0;
        int sumOfNonDivisibles = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
                sumOfDivisibles += i;
            else
                sumOfNonDivisibles += i;
        }

        return sumOfNonDivisibles - sumOfDivisibles;
    }
}
