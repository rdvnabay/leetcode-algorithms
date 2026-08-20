/**
 * @id         1409
 * @title      Queries on a Permutation With Key
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/queries-on-a-permutation-with-key/
 */
namespace Array.Medium;

public static class QueriesOnAPermutationWithKey
{
    public static int[] Run(int[] queries, int m)
    {
        int[] result = new int[queries.Length];
        int[] p = new int[m];

        for (int i = 1; i <= m; i++)
            p[i - 1] = i;

        for (int i = 0; i < queries.Length; i++)
        {
            for (int j = 0; j < p.Length; j++)
            {
                if (queries[i] == p[j])
                {
                    result[i] = j;
                    MoveToFront(p, j);
                    break;
                }
            }
        }

        return result;
    }

    static void MoveToFront(int[] p, int j)
    {
        int last = p[j];
        for (int k = j; k > 0; k--)
        {
            p[k] = p[k - 1];
        }
        p[0] = last;
    }
}


