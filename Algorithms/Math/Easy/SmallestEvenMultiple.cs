namespace Math.Easy;

public static class SmallestEvenMultiple
{
    public static int Run(int n)
    {
        return n % 2 == 0 ? n : n * 2;
    }
}
