/**
 * @id         1394
 * @title      Find Lucky Integer in an Array
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-lucky-integer-in-an-array/
 */
namespace HashTable.Easy;

public static class FindLuckyIntegerInAnArray
{
    //1,2,2,3,3,3
    public static int Run(int[] arr)
    {
        int result = -1;
        Dictionary<int, int> dict = new();

        foreach (var item in arr)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;


        foreach (var item in dict)
        {
            if (item.Key == item.Value)
            {
                if (item.Key > result)
                    result = item.Key;
            }
        }

        return result;
    }
}
