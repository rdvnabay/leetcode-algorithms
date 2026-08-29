namespace DynamicProgramming.Medium;

public static class MinimumCostToSplitIntoOnes
{
    public static int Run(int n)
    {
        return n * (n - 1) / 2;
    }
}
