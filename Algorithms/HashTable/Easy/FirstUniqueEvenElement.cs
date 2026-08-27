/**
 * @id         3866
 * @title      First Unique Even Element
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/first-unique-even-element/
 */
namespace HashTable.Easy;

public static class FirstUniqueEvenElement
{
    //3,4,2,5,4,6  -> 2
    public static int Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                bool isUnique = true;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                    return nums[i];
            }
        }

        return -1;
    }
}
