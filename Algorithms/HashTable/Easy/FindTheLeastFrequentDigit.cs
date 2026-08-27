/**
 * @id         3663
 * @title      Find The Least Frequent Digit
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-least-frequent-digit/
 */
namespace HashTable.Easy;

public static class FindTheLeastFrequentDigit
{
    public static int Run(int n)
    {
        Dictionary<int, int> dict = new();

        while (n > 0)
        {
            int remainder = n % 10;
            dict[remainder] = dict.GetValueOrDefault(remainder, 0) + 1;

            n /= 10;
        }

        return dict.OrderBy(x => x.Value).ThenBy(x => x.Key).First().Key;
    }
}
