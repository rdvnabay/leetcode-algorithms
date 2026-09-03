/**
 * @id         3184
 * @title      Count Pairs That Form a Complete Day I
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-pairs-that-form-a-complete-day-i/
 */
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
