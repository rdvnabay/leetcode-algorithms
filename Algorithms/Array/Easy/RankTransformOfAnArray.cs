namespace Array.Easy;

public static class RankTransformOfAnArray
{
    public static int[] Run(int[] arr)
    {
        int[] result = new int[arr.Length];
        List<int> orderedList = arr.Distinct().Order().ToList();

        for (int i = 0; i < orderedList.Count; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (orderedList[i] == arr[j])
                    result[j] = i + 1;
            }
        }

        return result;
    }
}
