/**
 * @id         733
 * @title      Flood Fill
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/flood-fill/
 */
namespace Algorithms.Array.Easy;

public static class FloodFill
{
    public static int[][] Run(int[][] image, int sr, int sc, int color)
    {
        int current = image[sr][sc];
        if (current == color)
            return image;

        List<(int Row, int Col)> pixels = new();
        pixels.Add((sr, sc));


        for (int i = 0; i < pixels.Count; i++)
        {
            sr = pixels[i].Row;
            sc = pixels[i].Col;
            current = image[sr][sc];
            CheckNeighbor(current, pixels, image, sr, sc);
        }

        for (int i = 0; i < pixels.Count; i++)
        {
            int row = pixels[i].Row;
            int col = pixels[i].Col;

            image[row][col] = color;
        }

        return image;
    }

    public static void CheckNeighbor(int current, List<(int row, int col)> pixels, int[][] image, int sr, int sc)
    {
        int rows = image.Length;
        int cols = image[0].Length;

        //left control
        int leftCol = sc - 1;
        if (leftCol >= 0)
        {
            if (!pixels.Contains((sr, leftCol)))
            {
                int left = image[sr][leftCol];

                if (current == left)
                    pixels.Add((sr, leftCol));
            }
        }

        //right control
        int rightCol = sc + 1;
        if (rightCol < cols)
        {
            if (!pixels.Contains((sr, rightCol)))
            {
                int right = image[sr][rightCol];

                if (current == right)
                    pixels.Add((sr, rightCol));
            }
        }

        //up control
        int upRow = sr - 1;
        if (upRow >= 0)
        {
            if (!pixels.Contains((upRow, sc)))
            {
                int up = image[upRow][sc];

                if (current == up)
                    pixels.Add((upRow, sc));
            }
        }

        //down control
        int downRow = sr + 1;
        if (downRow < rows)
        {
            if (!pixels.Contains((downRow, sc)))
            {
                int down = image[downRow][sc];
                if (current == down)
                    pixels.Add((downRow, sc));
            }
        }
    }
}


