namespace Math.Easy;

public static class CheckGoodInteger
{
    public static bool Run(int n)
    {
        int digitSum = 0;
        int squareSum = 0;

        while (n > 0)
        {
            int remainder = n % 10;
            digitSum += remainder;
            squareSum += remainder * remainder;

            n /= 10;
        }

        return squareSum - digitSum >= 50;
    }
}
