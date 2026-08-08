namespace Algorithms.Math.Easy;

public static class XOROperationInAnArray
{
    public static int Run(int n, int start)
    {
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int value = start + i * 2;
            result ^= value;
        }

        return result;
    }
}
