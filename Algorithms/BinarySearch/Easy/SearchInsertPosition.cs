/**
 * @id         35
 * @title      Search Insert Position
 * @topic      BinarySearch
 * @difficulty Easy
 * @link       https://leetcode.com/problems/search-insert-position/
 */
namespace Algorithms.BinarySearch.Easy
{
    public class SearchInsertPosition
    {
        public static int Run(int[] nums, int target)
        {
            int output = 0;
            int remainderNumber = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                {
                    output = i;
                    break;
                }
                else
                    remainderNumber--;
            }

            return remainderNumber > 0 ? output : nums.Length;
        }
    }
}


