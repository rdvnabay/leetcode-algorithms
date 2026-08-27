/**
 * @id         55
 * @title      Jump Game
 * @topic      Greedy
 * @difficulty Medium
 * @link       https://leetcode.com/problems/jump-game/
 */
namespace Algorithms.Greedy.Easy;

public static class JumpGame
{
    public static bool Run(int[] nums)
    {
        int i = 0;
        for (int j = nums[i]; j > 0; j--)
        {
            if (i + j >= nums.Length - 1)
                return true;

            if (nums[i + j] == 0)
                continue;
        }
        return false;
    }
}


