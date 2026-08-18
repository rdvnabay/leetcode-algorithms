namespace Array.Medium;

public static class MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    public static int[] Run(string boxes)
    {
        int[] result = new int[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            int total = 0;

            for (int j = 0; j < boxes.Length; j++)
            {
                if (boxes[j] == '1')
                    total += Math.Abs(i - j);
            }

            result[i] = total;
        }

        return result;
    }
}
