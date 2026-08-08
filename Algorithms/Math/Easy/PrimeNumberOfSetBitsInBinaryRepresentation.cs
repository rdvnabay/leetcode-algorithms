namespace Algorithms.Math.Easy;

public static class PrimeNumberOfSetBitsInBinaryRepresentation
{
    public static int Run(int left, int right)
    {
        int result = 0;

        for (int i = left; i <= right; i++)
        {
            int number = i;
            int setBitCount = 0;

            while (number > 0)
            {
                if (number % 2 == 1)
                    setBitCount++;

                number = number / 2;
            }

            if (setBitCount == 2)
            {
                result += 1;
                continue;
            }

            if (setBitCount < 2 || setBitCount % 2 == 0)
                continue;

            int n = 3;
            while (setBitCount >= n)
            {
                if (setBitCount % n != 0)
                {
                    n += 2;
                    continue;
                }

                else if (setBitCount / n != 1)
                    break;

                result++;
                break;
            }

        }
        return result;
    }
}
