/**
 * @id         661
 * @title      Image Smoother
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/image-smoother/
 */
namespace Algorithms.Array.Easy;

public class ImageSmoother
{
    public static int[][] Run(int[][] img)
    {
        int rows = img.Length;
        int cols = img[0].Length;
        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++)
            result[i] = new int[cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int total = 0;
                int neighborCount = 0;

                //current
                total += img[i][j];
                neighborCount++;

                bool isLeft = false;
                bool isRight = false;
                bool isUp = false;
                bool isDown = false;

                if (j - 1 >= 0)
                {
                    isLeft = true;
                    total += img[i][j - 1];
                    neighborCount++;
                }
                if (j + 1 < cols) 
                {
                    isRight = true;
                    total += img[i][j + 1];
                    neighborCount++;
                }

                if (i - 1 >= 0)
                {
                    isUp = true;
                    total += img[i - 1][j];
                    neighborCount++;
                }

                if (i + 1 < rows)
                {
                    isDown = true;
                    total += img[i + 1][j];
                    neighborCount++;
                }

                if (isLeft && isUp)
                {
                    total += img[i - 1][j - 1];
                    neighborCount++;
                }

                if (isRight && isUp)
                {
                    total += img[i - 1][j + 1];
                    neighborCount++;
                }

                if (isLeft && isDown)
                {
                    total += img[i + 1][j - 1];
                    neighborCount++;
                }

                if (isRight && isDown)
                {
                    total += img[i + 1][j + 1];
                    neighborCount++;
                }

                int average = total / neighborCount;
                result[i][j] = average;
            }
        }

        return result;
    }
}


