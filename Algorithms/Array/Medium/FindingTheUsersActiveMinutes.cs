/**
 * @id         1817
 * @title      Finding the Users Active Minutes
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/finding-the-users-active-minutes/
 */
namespace Array.Medium;

public static class FindingTheUsersActiveMinutes
{
    public static int[] Run(int[][] logs, int k)
    {
        int[] result = new int[k];
        Dictionary<int, HashSet<int>> dict = new();

        for (int i = 0; i < logs.Length; i++)
        {
            int userId = logs[i][0];
            int transactionMinute = logs[i][1];

            if (!dict.TryGetValue(userId, out _))
                dict[userId] = new HashSet<int> { transactionMinute };
            else
                dict[userId].Add(transactionMinute);
        }

        foreach (var value in dict.Values)
            result[value.Count - 1]++;

        return result;
    }
}
