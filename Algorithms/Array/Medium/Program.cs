
using Array.Easy;
using Array.Medium;

namespace Algorithms.Array.Medium;

public static class ArrayMediumRunner
{
    public static void Run()
    {
        _3Sum.Run(new int[] { -1, 0, 1, 2, -1, -4 });
        NextPermutation.Run(new int[] { 3, 2, 1 });
        RotateImage.Run(new int[][] { [5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16] });
        SortColors.Run(new int[] { 2, 0, 2, 1, 1, 0 });
        SetMatrixZeroes.Run(new int[][] { [1, 1, 1], [1, 0, 0], [1, 1, 1] });
        Subsets.Run(new int[] { 1, 2, 3 });
    }
}