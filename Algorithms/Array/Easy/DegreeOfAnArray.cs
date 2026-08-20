/**
 * @id         697
 * @title      Degree of an Array
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/degree-of-an-array/
 */
namespace Algorithms.Array.Easy;

public class DegreeOfAnArray
{
    public static int Run(int[] nums)
    {
        if (nums.Length == 1)
            return 1;

        Dictionary<int, NumberInfo> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNumber = nums[i];

            if (dict.TryGetValue(currentNumber, out NumberInfo? info))
            {
                info.Count++;
                info.LastIndex = i;
            }
            else
            {
                dict.Add(currentNumber, new NumberInfo()
                {
                    Count = 1,
                    FirstIndex = i,
                    LastIndex = i
                });
            }
        }

        int maxCount = dict.Max(x => x.Value.Count);
        int minValue = int.MaxValue;

        foreach (var item in dict)
        {
            if (item.Value.Count == maxCount)
            {
                int length = item.Value.LastIndex - item.Value.FirstIndex + 1;

                if (length < minValue)
                    minValue = length;
            }

        }

        return minValue;
    }
}


public class NumberInfo
{
    public int Count;
    public int FirstIndex;
    public int LastIndex;
}

