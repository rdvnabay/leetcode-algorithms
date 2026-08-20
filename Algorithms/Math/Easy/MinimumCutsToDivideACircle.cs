namespace Math.Easy;

public static class MinimumCutsToDivideACircle
{
    public static int Run(int n)
    {
        if (n == 1)
            return 0;
        
        return n % 2 == 0 ? n / 2 : n;
    }
}
