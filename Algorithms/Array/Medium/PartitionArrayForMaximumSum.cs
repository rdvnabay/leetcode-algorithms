namespace Array.Medium;

public static class PartitionArrayForMaximumSum
{
    public static int Run(int[] arr, int k)
    {
        //1,15,7,9,2,5,10
        //3
        int total = 0;

        var copyArr = (int[])arr.Clone();
        System.Array.Sort(copyArr, (a, b) => b.CompareTo(a));

        HashSet<int> bigNumbers = new();
        for (int i = 0; i < k; i++)
        {
            bigNumbers.Add(copyArr[i]);
        }

        int start = 0;
        int end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (bigNumbers.Contains(arr[i]))
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (bigNumbers.Contains(arr[j]))
                    {
                        if (bigNumbers.Last() == arr[j])
                        {
                            total += arr[j];
                            start = j + 1;
                        }
                        end = j - 1;
                    }
                }
            }
        }
        return 0;
    }
}
