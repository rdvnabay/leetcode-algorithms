namespace Algorithms.Array.Easy;

public static class UniqueNumberOfOccurrences
{
    public static bool Run(int[] arr)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
                dict.Add(arr[i], 1);
            else
                dict[arr[i]]++;
        }

        if (dict.Count == 1)
            return true;


        //foreach (var item in dict.Values)
        //{

        //}

        for (int i = 0; i < dict.Count - 1; i++)
        {
            for (int j = i + 1; j < dict.Count; j++)
            {
                
            }
        }

        return false;
    }
}
