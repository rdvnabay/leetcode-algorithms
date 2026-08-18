namespace Array.Medium;

public static class ConvertAnArrayIntoA2DArrayWithConditions
{
    public static IList<IList<int>> Run(int[] nums)
    {
        List<IList<int>> result = new();
        Dictionary<int, int> dict = new();

        foreach (int num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
                dict[num] = 1;
            else
                dict[num] = count + 1;
        }

        while (dict.Count > 0)
        {
            List<int> output = new();

            foreach (var item in dict)
            {
                output.Add(item.Key);

                dict[item.Key]--;

                if (dict[item.Key] == 0)
                    dict.Remove(item.Key);
            }

            result.Add(output);
        }

        return result;
    }
}
