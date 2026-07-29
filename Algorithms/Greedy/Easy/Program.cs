using Algorithms.Greedy.Easy.Solutions;

namespace Algorithms.Greedy.Easy;

public static class GreedyEasyRunner
{
    public static void Run()
    {
        // 455: Assign Cookies
        AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
        // 495: Teemo Attacking
        TeemoAttacking.Run(new int[] { 1, 3, 8 }, 4);
    }
}