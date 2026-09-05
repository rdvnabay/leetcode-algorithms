namespace Array.Medium;

public static class FindOccurrencesOfAnElementInAnArray
{
    //nums =
    //[1, 4, 3, 3, 6, 4, 8, 3, 10]
    //queries =
    //[1, 2, 1, 1, 1, 1, 2, 2, 1, 1]
    //x =
    //7
    public static int[] Run(int[] nums, int[] queries, int x)
    {
        for (int i = 0; i < queries.Length; i++)
        {
            if (i < nums.Length)
            {
                if (nums[i] == x)
                    queries[i] = i;
                else
                    queries[i] = -1;
            }
        }

        return queries;
    }
}
