/**
 * @id         3304
 * @title      Find the K-th Character in String Game I
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-k-th-character-in-string-game-i/
 */
namespace Math.Easy;

public static class FindTheKThCharacterInStringGameI
{
    public static char Run(int k)
    {
        int exponent = (int)System.Math.Ceiling(System.Math.Log2(k));
        int length = (int)System.Math.Pow(2, exponent);
        char[] chars = new char[length];

        chars[0] = 'a';
        chars[1] = (char)('a' + 1);

        for (int i = 2; i < chars.Length; i += 2)
        {
            chars[i] = (char)(chars[i - 2] + 1);
            chars[i + 1] = (char)(chars[i - 1] + 1);

        }
        return ' ';
    }
}


