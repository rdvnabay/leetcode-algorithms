/**
 * @id         2269
 * @title      Find the K-Beauty of a Number
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-k-beauty-of-a-number/
 */
namespace Math.Easy;

public static class FindTheKBeautyOfANumber
{
    //43 00 43 2

    //num = 12345
    //k = 3
    public static int Run(int num, int k)
    {
        int length = num.ToString().Length;
        char[] digits = new char[length];
        List<int> result = new();

        for (int i = 0; i <= length - k; i++)
        {
            int total = 0;

            for (int j = i; j < k + i; j++)
            {
                int pow = (int)System.Math.Pow(10, k - 1);

            }
        }


        int start = 0;
        int end = k;



        return 0;
    }
}
