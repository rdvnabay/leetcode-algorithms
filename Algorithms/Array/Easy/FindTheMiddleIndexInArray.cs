/**
 * @id         1991
 * @title      Find the Middle Index in Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-middle-index-in-array/
 */
namespace Array.Easy;

public static class FindTheMiddleIndexInArray
{
    //2,3,-1,8,4
    //^3
    public static int Run(int[] nums)
    {
        int left = 0;
        int right = nums.Sum();
        //int right = nums.Length - 1;
        int mid = 0;

        int total = nums.Sum();

        //while (left < right)
        //{


        //}
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                right -= nums[i];
                if (left == right)
                    return i;
            }
            else
            {
                left += nums[i];
                right -= nums[i];
                if (left == right)
                    return i;
            }

            //else if (i == nums.Length - 1)
            //{

            //}
        }
        return 0;
    }
}
