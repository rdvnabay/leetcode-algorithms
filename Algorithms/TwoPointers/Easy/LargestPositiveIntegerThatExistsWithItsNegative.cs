namespace TwoPointers.Easy;

public static class LargestPositiveIntegerThatExistsWithItsNegative
{
    public static int Run(int[] nums)
    {
        HashSet<int> set = new(nums);
        HashSet<int> result = new();

        foreach (var num in set)
        {
            if (set.Contains(num * -1))
                result.Add(Math.Abs(num));
        }

        if (result.Count == 0)
            return -1;

        return result.Max();
    }
}
