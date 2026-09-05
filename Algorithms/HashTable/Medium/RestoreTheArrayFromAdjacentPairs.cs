namespace HashTable.Medium;

public static class RestoreTheArrayFromAdjacentPairs
{
    public static int[] Run(int[][] adjacentPairs)
    {
        int[] result = new int[adjacentPairs.Length + 1];

        Dictionary<int, int> dict = new();

        foreach (var adjacentPair in adjacentPairs)
        {
            foreach (var pair in adjacentPair)
            {
                dict[pair] = dict.GetValueOrDefault(pair, 0) + 1;
            }
        }

        var startAndFinish = dict.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        result[0] = startAndFinish.Min();
        result[result.Length - 1] = startAndFinish.Max();

        //[2,1],[3,4],[3,2]
        //1 [1,2]
        //2 [1,2][2,3]
        //3 [2,3][3,4]
        //3 [3,4]

        //[1,2][2,3][3,4]

        //[4, -2],[1, 4],[-3,1]
        //[-3,1][1,4][-2,4]

        return null;
    }
}
