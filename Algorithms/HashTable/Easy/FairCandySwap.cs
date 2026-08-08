namespace Algorithms.HashTable.Easy;

public static class FairCandySwap
{
    public static int[] Run(int[] aliceSizes, int[] bobSizes)
    {
        int totalAliceCandies = aliceSizes.Sum();
        int totalBobCandies = bobSizes.Sum();
        int[] result = new int[2];

        int diff = System.Math.Abs(totalBobCandies - totalAliceCandies);

        for (int i = 0; i < aliceSizes.Length; i++)
        {
            int candy = (aliceSizes[i] * 2 + diff) / 2;
            int index = Array.IndexOf(bobSizes, candy);

            if (index == -1)
                continue;

            result[0] = aliceSizes[i];
            result[1] = bobSizes[index];
            break;
        }

        return result;
    }
}
