/**
 * @id         645
 * @title      Set Mismatch
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/set-mismatch/
 */
namespace Algorithms.Array.Easy;

public class SetMismatch
{
    public static int[] Run(int[] nums)
    {
        int[] compareArr = new int[nums.Length];
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (compareArr[num - 1] != 0)
                result[0] = num;
            else
                compareArr[num - 1] = num;
        }

        int missingIndex = System.Array.IndexOf(compareArr, 0);
        result[1] = missingIndex+1;

        return result;
    }
}


