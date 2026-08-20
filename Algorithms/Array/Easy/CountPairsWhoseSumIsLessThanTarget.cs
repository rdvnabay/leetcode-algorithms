/**
 * @id         2824
 * @title      Count Pairs Whose Sum is Less than Target
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/
 */
namespace Array.Easy;

public static class CountPairsWhoseSumIsLessThanTarget
{
    public static int Run(IList<int> nums, int target)
    {
        int counter = 0;

        for (int i = 0; i < nums.Count - 1; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                    counter++;
            }
        }

        return counter;
    }
}


