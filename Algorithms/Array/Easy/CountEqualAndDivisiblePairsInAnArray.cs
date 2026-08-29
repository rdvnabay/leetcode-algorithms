namespace Array.Easy;

public static class CountEqualAndDivisiblePairsInAnArray
{
    public static int Run(int[] nums, int k)
    {
        int counter = 0;
        Dictionary<int, List<int>> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (!dict.TryGetValue(num, out _))
                dict[num] = [i];
            else
                dict[num].Add(i);
        }

        var pairs = dict.Where(x => x.Value.Count > 1).Select(x => x.Value).ToArray();

        for (int x = 0; x < pairs.Length; x++)
        {
            for (int y = 0; y < pairs[x].Count - 1; y++)
            {
                for (int z = y + 1; z < pairs[x].Count; z++)
                {
                    if ((pairs[x][y] * pairs[x][z]) % k == 0)
                        counter++;
                }
            }
        }

        return counter;
    }
}
