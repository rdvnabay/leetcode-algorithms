namespace Math.Easy;

public static class PowerOfThree
{
    public static bool Run(int n)
    {
        const int X = 3;

        if (n <= 0) return false;
        if (n == 1) return true;

        while (n > 1)
        {
            if (n % X != 0)
                return false;

            n = n / X;
        }
        
        return true;
    }
}
