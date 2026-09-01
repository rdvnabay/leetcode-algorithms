namespace Array.Easy;

public static class MinimumAbsoluteDifference
{
    public static IList<IList<int>> Run(int[] arr)
    {
        List<IList<int>> result = new();

        System.Array.Sort(arr);

        int minDifference = int.MaxValue;

        for (int i = 0; i < arr.Length - 1; i++)
            minDifference = Math.Min(minDifference, arr[i + 1] - arr[i]);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] == minDifference)
                result.Add([arr[i], arr[i + 1]]);
        }

        return result;
    }
}
