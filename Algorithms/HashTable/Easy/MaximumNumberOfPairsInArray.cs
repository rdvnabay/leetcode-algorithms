namespace HashTable.Easy;

public static class MaximumNumberOfPairsInArray
{
    //1,3,2,1,3,2,2
    //3 1
    public static int[] Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        int pairCount = 0;
        int remainderCount = 0;

        foreach (var item in dict)
        {
            pairCount += item.Value / 2;

            if (item.Value % 2 == 1)
                remainderCount++;
        }

        return [pairCount, remainderCount];
    }
}
