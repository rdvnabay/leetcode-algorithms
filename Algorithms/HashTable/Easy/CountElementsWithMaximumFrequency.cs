namespace HashTable.Easy;

public static class CountElementsWithMaximumFrequency
{
    public static int Run(int[] nums)
    {
        Dictionary<int, int> dict = new();
        int max = 0;

        foreach (var num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
            {
                count = 1;
                dict[num] = count;
            }
            else
            {
                count = count + 1;
                dict[num] = count;
            }

            if (count > max)
                max = count;
        }

        int total = 0;
        foreach (var item in dict)
        {
            if (item.Value == max)
                total += item.Value;
        }


        return total;
    }
}
