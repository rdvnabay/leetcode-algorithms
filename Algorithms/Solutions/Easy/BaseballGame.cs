namespace Algorithms.Solutions.Easy;
public class BaseballGame
{
    // Runtime: 143 ms, faster than 35.91% of C# online submissions for Baseball Game.
    // Memory Usage: 38.2 MB, less than 28.87% of C# online submissions for Baseball Game.
    public static int Run(string[] ops)
    {
        List<int> output = new List<int>();

        foreach (var item in ops)
        {
            if (int.TryParse(item, out int currentItem))
                output.Add(currentItem);

            else if (item == "C")
                output.RemoveAt(output.Count - 1);

            else if (item == "D")
                output.Add(output.Last() * 2);


            else if (item == "+")
                output.Add(output.Last() + output[output.Count - 2]);
        }

        return output.Sum();
    }
}

