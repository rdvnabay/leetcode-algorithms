/**
 * @id         2154
 * @title      Keep Multiplying Found Values by Two
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/keep-multiplying-found-values-by-two/
 */
namespace HashTable.Easy;

public static class KeepMultiplyingFoundValuesByTwo
{
    public static int Run(int[] nums, int original)
    {
        while (nums.Contains(original))
            original *= 2;

        return original;
    }
}
