namespace Array.Easy;

public static class FindIndicesOfStableMountains
{
    public static IList<int> Run(int[] height, int threshold)
    {
        List<int> result = new();

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
                result.Add(i);
        }

        return result;
    }
}
