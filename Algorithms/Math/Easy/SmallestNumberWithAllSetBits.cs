namespace Math.Easy;

public static class SmallestNumberWithAllSetBits
{
    public static int Run(int n)
    {
        int exponent = (int)System.Math.Ceiling(System.Math.Sqrt(n));
        return (int)System.Math.Pow(2, exponent) - 1;
    }
}
