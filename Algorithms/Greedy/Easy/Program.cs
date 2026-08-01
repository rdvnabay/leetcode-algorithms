using Algorithms.Greedy.Easy.Solutions;

namespace Algorithms.Greedy.Easy;

public static class GreedyEasyRunner
{
    public static void Run()
    {
        AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
        TeemoAttacking.Run(new int[] { 1, 3, 8 }, 4);
        JumpGame.Run(new int[] { 3, 2, 1, 0, 4 });
    }
}