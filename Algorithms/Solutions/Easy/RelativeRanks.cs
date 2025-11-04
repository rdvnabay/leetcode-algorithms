namespace Algorithms.Solutions.Easy;

public static class RelativeRanks
{
    public static string[] Run(int[] score)
    {
        string[] outputArr = new string[score.Length];
        var sortedScore = BubbleSort(score);

        for (int i = 0; i < score.Length; i++)
        {
            int index = Array.IndexOf(sortedScore, score[i]);

            outputArr[i] = index switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (index + 1).ToString()
            };
        }
        return outputArr;
    }

    public static int[] BubbleSort(int[] score)
    {
        int[] scoreCopy = (int[])score.Clone();
        int n = scoreCopy.Length - 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                if (scoreCopy[j] < scoreCopy[j + 1])
                {
                    int temp = scoreCopy[j];
                    scoreCopy[j] = scoreCopy[j + 1];
                    scoreCopy[j + 1] = temp;
                }
            }
        }
        return scoreCopy;
    }
}
