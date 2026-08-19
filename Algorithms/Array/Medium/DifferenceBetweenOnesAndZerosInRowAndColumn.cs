namespace Array.Medium;

public static class DifferenceBetweenOnesAndZerosInRowAndColumn
{
    //[0,1,1],
    //[1,0,1],
    //[0,0,1]

    //[0, 0, 4],[0, 0, 4],[-2,-2,2]
    public static int[][] Run(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            int zeroCount = 0;
            int oneCount = 0;

            for (int j = 0; j < cols; j++)
            {
                //satır kontrolü
                for (int k = i; k < rows; k++)
                {

                }
           
            }
        }
        return null;
    }
}
