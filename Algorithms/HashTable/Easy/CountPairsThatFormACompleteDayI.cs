namespace HashTable.Easy;

public static class CountPairsThatFormACompleteDayI
{
    public static int Run(int[] hours)
    {
        int matchCount = 0;

        for (int i = 0; i < hours.Length - 1; i++)
        {
            for (int j = i + 1; j < hours.Length; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0)
                    matchCount++;
            }
        }

        return matchCount;
    }
}
