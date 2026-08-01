
namespace Algorithms.Stack.Easy;

public static class StackEasyRunner
{
    public static void Run()
    {
        // 20: Valid Parentheses
        ValidParentheses.Run("(){}}{ ");
        // 225: Implement Stack Using Queues
        ImplementStackUsingQueues.Run();
        // 496: Next Greater Element I
        NextGreaterElementI.Run(new int[] { 4, 1, 2, 0 }, new int[] { 3, 4, 2, 0, 1 });
        // 682: Baseball Game
        BaseballGame.Run(new string[] { "5", "2", "C", "D", "+" });
    }
}