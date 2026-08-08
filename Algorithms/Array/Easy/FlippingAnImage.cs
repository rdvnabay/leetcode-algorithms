using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Array.Easy;

public static class FlippingAnImage
{
    public static int[][] Run(int[][] image)
    {
        int rows = image.Length;
        int cols = image[0].Length;

        for (int i = 0; i < rows; i++)
        {
            int left = 0;
            int right = cols - 1;

            while (left <= right)
            {
                if (left != right)
                {
                    int temp = image[i][left];
                    image[i][left] = image[i][right];
                    image[i][right] = temp;

                    image[i][left] = 1 - image[i][left];
                    image[i][right] = 1 - image[i][right];
                }

                else
                    image[i][left] = 1 - image[i][left];

                left++;
                right--;
            }
        }

        return image;
    }
}
