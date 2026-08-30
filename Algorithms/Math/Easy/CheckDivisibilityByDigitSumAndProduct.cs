namespace Math.Easy;

public static class CheckDivisibilityByDigitSumAndProduct
{
    public static bool Run(int n)
    {
        int sum = 0;
        int product = 1;
        int value = n;

        while (value > 0)
        {
            int remainder = value % 10;
            sum += remainder;
            product *= remainder;
            value /= 10;
        }

        return n % (sum + product) == 0;
    }
}
