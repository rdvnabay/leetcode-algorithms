/**
 * @id         2553
 * @title      Separate the Digits in an Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/separate-the-digits-in-an-array/
 */
namespace Array.Easy;

public static class SeparateTheDigitsInAnArray
{
    //13,25,83,77
    //[1,3,2,5,8,3,7,7]
    public static int[] Run(int[] nums)
    {
        List<int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            Stack<int> stack = new();

            while (num > 0)
            {
                int remainder = num % 10;

                stack.Push(remainder);
                num /= 10;
            }

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }
        }

        return result.ToArray();
    }
}
