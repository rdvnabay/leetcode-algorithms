namespace Array.Easy;

public static class ReplaceElementsWithGreatestElementOnRightSide
{
    public static int[] Run(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int maxValue = 0;

            for (int j = i + 1; j < arr.Length; j++)
                maxValue = Math.Max(maxValue, arr[j]);

            result[i] = maxValue;
        }

        result[result.Length - 1] = -1;
        
        return result;
    }
}
