namespace HashTable.Easy;

public static class KeepMultiplyingFoundValuesByTwo
{
    public static int Run(int[] nums, int original)
    {
        while (nums.Contains(original))
            original *= 2;

        return original;
    }
}
