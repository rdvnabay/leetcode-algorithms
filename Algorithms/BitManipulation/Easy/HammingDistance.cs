namespace BitManipulation.Easy;

public static class HammingDistance
{
    public static int Run(int x, int y)
    {
        int diffCount = 0;
        var binaryX = Convert.ToString(x, 2);
        var binaryY = Convert.ToString(y, 2);

        int max = Math.Max(binaryX.Length, binaryY.Length);

        binaryX = binaryX.PadLeft(max, '0');
        binaryY = binaryY.PadLeft(max, '0');

        for (int i = 0; i < binaryX.Length; i++)
        {
            if (binaryX[i] != binaryY[i])
                diffCount++;
        }

        return diffCount;
    }
}
