/**
 * @id         1313
 * @title      Decompress Run-Length Encoded List
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/decompress-run-length-encoded-list/
 */
namespace Array.Easy;

public static class DecompressRunLengthEncodedList
{
    //1 2 3 4
    public static int[] Run(int[] nums)
    {
        List<int> result = new();

        for (int i = 0; i < nums.Length; i += 2)
            result.AddRange(Enumerable.Repeat(nums[i + 1], nums[i]));

        return result.ToArray();
    }

    //Other solutions:
    public static int[] Solution2(int[] nums)
    {
        int resultLength = 0;

        for (int i = 0; i < nums.Length; i += 2)
            resultLength += nums[i];

        int[] result = new int[resultLength];
        int index = 0;

        for (int i = 0; i < nums.Length; i += 2)
        {
            int frequency = nums[i];
            int value = nums[i + 1];

            for (int j = 0; j < frequency; j++)
            {
                result[index] = value;
                index++;
            }
        }

        return result;
    }
}


