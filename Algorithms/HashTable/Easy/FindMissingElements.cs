namespace HashTable.Easy;

public static class FindMissingElements
{
    public static IList<int> Run(int[] nums)
    {
        Array.Sort(nums);
        List<int> result = new();
        HashSet<int> matches = new(nums);

        int min = nums[0];
        int max = nums[nums.Length - 1];

        for (int i = min; i <= max; i++)
        {
            if (!matches.Contains(i))
                result.Add(i);
        }

        return result;
    }

    //Alternative solutions
    static IList<int> Solution2(int[] nums)
    {
        bool[] numsMask = new bool[101];

        foreach (int num in nums)
        {
            numsMask[num] = true;
        }

        int minNum = nums.Min();
        int maxNum = nums.Max();

        return Enumerable.Range(minNum, maxNum - minNum + 1)
            .Where(num => !numsMask[num])
            .ToList();
    }
}
