namespace HashTable.Easy;

public static class CheckIfNAndItsDoubleExist
{
    public static bool Run(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                {
                    if (arr[i] % 2 == 0 && arr[i] / 2 == arr[j])
                        return true;
                }
            }
        }

        return false;
    }

    //Other solutions (not accepted)
    static bool Solution2(int[] arr)
    {
        Dictionary<int, int> dict = new();

        foreach (var num in arr)
        {
            if (!dict.ContainsKey(num))
            {
                if (num % 2 == 0)
                {
                    if (dict.ContainsKey(num / 2))
                        return true;

                    dict.Add(num, num / 2);
                }
                else
                {
                    if (dict.ContainsKey(num * 2))
                        return true;

                    dict.Add(num, num * 2);
                }
            }
        }

        return false;
    }
}
