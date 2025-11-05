namespace Algorithms.Solutions.Easy;

public static class PowerOfFour
{
    public static bool Run(int n)
    {
        if (n <= 0)
            return false;

        if (n == 1)
            return true;

        int quotient = 0;

        while (n % 4 == 0)
        {
            quotient = n / 4;

            if (quotient == 1)
                return true;

            n = quotient;
        }

        return false;
    }
}
