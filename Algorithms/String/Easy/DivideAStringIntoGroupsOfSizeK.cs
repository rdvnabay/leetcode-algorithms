/**
 * @id         2138
 * @title      Divide a String Into Groups of Size k
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/
 */
namespace String.Easy;

public static class DivideAStringIntoGroupsOfSizeK
{
    //"abc def ghi", 3, 'x'
    public static string[] Run(string s, int k, char fill)
    {
        int divisor = s.Length / k;

        if (s.Length % k > 0)
            divisor += 1;

        List<char[]> list = new();

        int start = 0;
        int count = 1;
        int end = k * count;

        //while (divisor > 0)
        //{
        //    char[] items = new char[k];
        //    int index = 0;
        //    for (int i = start; i < end; i++)
        //    {
        //        items[index] = s[i];
        //        index++;
        //    }
        //    list.Add(items);
        //    start += k;
        //    end += k;
        //    divisor--;
        //}

        return null;
    }
}


