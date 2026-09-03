/**
 * @id         1791
 * @title      Find Center of Star Graph
 * @topic      GraphTheory
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-center-of-star-graph/
 */
namespace GraphTheory.Easy;

public static class FindCenterOfStarGraph
{
    public static int Run(int[][] edges)
    {
        int left = edges[0][0];
        int right = edges[0][1];

        return edges[1][0] == left || edges[1][1] == left
            ? left
            : right;
    }
}
