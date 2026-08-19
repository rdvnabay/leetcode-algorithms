namespace Array.Medium;

public static class DivideArrayIntoArraysWithMaxDifference
{
    public static int[][] Run(int[] nums, int k)
    {
        const int Divisor = 3;

        System.Array.Sort(nums);

        var parts = nums.Chunk(Divisor).ToArray();

        foreach (var part in parts)
        {
            int min = part[0];
            int max = part[2];

            if (max - min > k)
                return new int[][] { };
        }

        return parts;
    }
}
