namespace Algorithms.Solutions.Easy;

public class ContainsDuplicate
{
    public static bool Run(int[] nums)
    {
        //Solution:1
        return nums.Length != new HashSet<int>(nums).Count;

        //Solution:2
        /*
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }
        return false;
        */
    }
}
