/**
 * @id         1995
 * @title      Count Special Quadruplets
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-special-quadruplets/
 */
namespace HashTable.Easy;

public static class CountSpecialQuadruplets
{
    //1,1,1,3,5
    public static int Run(int[] nums)
    {
        int counter = 0;

        for (int i = 0; i < nums.Length - 3; i++)
        {
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                for (int k = j + 1; i < nums.Length - 1; i++)
                {
                    for (int l = 0; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] + nums[k] == nums[l])
                            counter++;
                    }
                }
            }
        }

        return counter;
    }
}
