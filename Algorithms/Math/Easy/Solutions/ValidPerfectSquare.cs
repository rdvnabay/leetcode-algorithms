namespace Algorithms.Math.Easy.Solutions;

public static class ValidPerfectSquare
{
    public static bool Run(int num)
    {
        if (num == 1) return true;

        int counter = 2;
        Dictionary<int, int> dict = new();

        while (num > 1)
        {
            if (num % counter != 0)
            {
                counter++;
            }
            else
            {
                num = num / counter;

                if (!dict.ContainsKey(counter))
                    dict.Add(counter, 1);
                else
                    dict[counter]++;
            }
        }

        return dict.All(x => x.Value % 2 == 0);
    }
}
