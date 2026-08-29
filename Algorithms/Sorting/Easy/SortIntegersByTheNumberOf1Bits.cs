namespace Sorting.Easy;

public static class SortIntegersByTheNumberOf1Bits
{
    //0,1,2,3,4,5,6,7,8
    public static int[] Run(int[] arr)
    {
        int[] result = new int[arr.Length];
        Dictionary<int, List<int>> dict = new();

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            int onesCount = 0;

            while (num > 0)
            {
                int remainder = num % 2;
                if (remainder == 1)
                    onesCount++;

                num /= 2;
            }

            if (!dict.TryGetValue(onesCount, out _))
                dict[onesCount] = new List<int>() { arr[i] };
            else
                dict[onesCount].Add(arr[i]);
        }

        int index = 0;
        foreach (var item in dict)
        {
            item.Value.Sort();
            foreach (var value in item.Value)
            {
                result[index] = value;
                index++;
            }
        }

        return result;
    }
}
