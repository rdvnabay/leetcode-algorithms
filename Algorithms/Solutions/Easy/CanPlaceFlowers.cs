namespace Algorithms.Solutions.Easy;

public class CanPlaceFlowers
{
    public static bool Run(int[] flowerbed, int n)
    {
        int changeCount = 0;

        if (flowerbed.Length == 1)
        {
            if (flowerbed[0] == 0)
            {
                flowerbed[0] = 1;
                changeCount++;
                return changeCount >= n ? true : false;
            }
        }

        //first
        if (flowerbed[0] == 0)
        {
            if (flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                changeCount++;
            }
        }

        //mid
        for (int i = 1; i < flowerbed.Length - 1; i++)
        {
            if (flowerbed[i] == 0)
            {
                int left = flowerbed[i - 1];
                int right = flowerbed[i + 1];
                if (left == 0 && right == 0)
                {
                    flowerbed[i] = 1;
                    changeCount++;
                }
            }
        }

        //last
        int lastIndex = flowerbed.Length - 1;
        if (flowerbed[lastIndex] == 0)
        {
            if (flowerbed[lastIndex - 1] == 0)
            {
                flowerbed[lastIndex] = 1;
                changeCount++;
            }
        }
        return changeCount >= n ? true : false;
    }
}
