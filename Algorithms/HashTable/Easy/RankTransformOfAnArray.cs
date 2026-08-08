namespace Algorithms.HashTable.Easy;

public static class RankTransformOfAnArray
{
    public static int[] Run(int[] arr)
    {
        var orderedArr = arr.Order().ToArray();
        Dictionary<int, int> dict = new();

        int rank = 1;
        int currentNumber = arr[0];
        arr[0] = rank;

        for (int i = 1; i < arr.Length; i++)
        {
            if (currentNumber < arr[i])
            {
                currentNumber = arr[i];
                rank++;
            }

            arr[i] = rank;

            if (!dict.ContainsKey(currentNumber))
                dict.Add(currentNumber, rank);
        }

        return arr;
    }
}
