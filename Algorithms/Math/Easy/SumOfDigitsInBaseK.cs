namespace Math.Easy;

public static class SumOfDigitsInBaseK
{
    public static int Run(int n, int k)
    {
        int total = 0;

        while (n > 0)
        {
            total += n % k;
            n /= k;
        }

        return total;
    }
}
