/**
 * @id         3248
 * @title      Snake in Matrix
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/snake-in-matrix/
 */
namespace String.Easy;

public static class SnakeInMatrix
{
    public static int Run(int n, IList<string> commands)
    {
        int value = 0;

        foreach (var command in commands)
        {
            value += command switch
            {
                "UP" => -n,
                "DOWN" => +n,
                "LEFT" => -1,
                "RIGHT" => +1,
                _ => 0
            };
        }

        return value;
    }
}

