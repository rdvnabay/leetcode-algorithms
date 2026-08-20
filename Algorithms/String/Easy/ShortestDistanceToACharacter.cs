/**
 * @id         821
 * @title      Shortest Distance to a Character
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/shortest-distance-to-a-character/
 */
namespace String.Easy;

public static class ShortestDistanceToACharacter
{
    //loveleetcode - e
    public static int[] Run(string s, char c)
    {
        int left = 0;
        int right = 0;
        List<int> indexes = new();
        int[] result = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'e')
            {
                if (right == 0)
                {
                    right = i;

                }
                indexes.Add(i);
            }

            if (left == 0 && right == 0)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    right = j;
                    result[i] = right - i;
                    if (s[i] == 'e')
                        indexes.Add(i);
                }
            }

            else if (left == 0)
            {
                result[i] = right - i;
            }


        }
        return null;
    }
}


