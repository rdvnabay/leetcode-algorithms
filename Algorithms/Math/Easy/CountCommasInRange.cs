namespace Math.Easy;

public static class CountCommasInRange
{
    public static int Run(int n)
    {
        const int FirstNumberWithComma = 1000;

        if (n < FirstNumberWithComma)
            return 0;

        return n - FirstNumberWithComma + 1;
    }
}
