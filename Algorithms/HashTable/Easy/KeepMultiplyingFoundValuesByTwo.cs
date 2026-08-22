namespace HashTable.Easy;

public static class KeepMultiplyingFoundValuesByTwo
{
    public static int Run(int[] nums, int original)
    {
        HashSet<int> set = new(nums);

        while (set.Contains(original))
            original *= 2;

        return original;
    }
}
