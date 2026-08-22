namespace HashTable.Easy;

public static class DivideArrayIntoEqualPairs
{
    public static bool Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        return dict.All(x => x.Value % 2 == 0);
    }
}
