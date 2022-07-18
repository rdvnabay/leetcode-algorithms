namespace Algorithms.Solutions.Easy;

public static class TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>

    /// <param name="nums"> [3, 2, 4] </param>
    /// <param name="target"> 6 </param>
    /// <returns> [0,1] </returns>
    public static int[] Run(int[] nums, int target)
    {
        var resultArray = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            while (j < nums.Length)
            {
                if (nums[i] + nums[j] == target)
                {
                    resultArray[0] = i;
                    resultArray[1] = j;
                    break;
                }
                j++;
            }
        }

        return resultArray;
    }
}
