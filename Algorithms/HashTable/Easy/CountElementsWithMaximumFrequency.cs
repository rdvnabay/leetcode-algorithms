/**
 * @id         3005
 * @title      Count Elements With Maximum Frequency
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-elements-with-maximum-frequency/
 */
namespace HashTable.Easy;

public static class CountElementsWithMaximumFrequency
{
    public static int Run(int[] nums)
    {
        Dictionary<int, int> dict = new();
        int max = 0;

        foreach (var num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
            {
                count = 1;
                dict[num] = count;
            }
            else
            {
                count = count + 1;
                dict[num] = count;
            }

            if (count > max)
                max = count;
        }

        int total = 0;
        foreach (var item in dict)
        {
            if (item.Value == max)
                total += item.Value;
        }


        return total;
    }


    //Alternative solutions
    public static int Solution2(int[] nums)
    {
        var freq = new Dictionary<int, int>();

        foreach (var n in nums)
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;

        int maxFreq = freq.Values.Max();

        return freq.Values.Where(v => v == maxFreq).Sum();
    }
}
