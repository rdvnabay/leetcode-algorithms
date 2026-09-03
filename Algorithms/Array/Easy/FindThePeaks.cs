/**
 * @id         2951
 * @title      Find the Peaks
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-peaks/
 */
namespace Array.Easy;

public static class FindThePeaks
{
    public static IList<int> Run(int[] mountain)
    {
        List<int> result = new();

        for (int i = 1; i < mountain.Length - 1; i++)
        {
            int current = mountain[i];
            int left = mountain[i - 1];
            int right = mountain[i + 1];

            if ((current > left) && (current > right))
                result.Add(i);
        }

        return result;
    }
}
