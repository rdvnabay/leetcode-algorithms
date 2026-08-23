namespace Greedy.Easy;

public static class MaximizeSumOfAtMostKDistinctElements
{
    public static int[] Run(int[] nums, int k)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        HashSet<int> set = new(nums);

        return set.Take(k).ToArray();
    }
}
