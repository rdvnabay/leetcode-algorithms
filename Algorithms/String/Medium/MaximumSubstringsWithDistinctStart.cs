namespace String.Medium;

public static class MaximumSubstringsWithDistinctStart
{
    public static int Run(string s)
    {
        return s.ToHashSet().Count;
    }
}
