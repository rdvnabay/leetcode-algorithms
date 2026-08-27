/**
 * @id         3921
 * @title      Score Validator
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/score-validator/
 */
namespace String.Easy;

public static class ScoreValidator
{
    public static int[] Run(string[] events)
    {
        int score = 0;
        int counter = 0;

        foreach (var @event in events)
        {
            if (@event == "W")
            {
                counter++;

                if (counter == 10)
                    return [score, counter];

                continue;
            }

            score += @event switch
            {
                "1" => 1,
                "2" => 2,
                "3" => 3,
                "4" => 4,
                "6" => 6,
                "WD" => 1,
                "NB" => 1,
                _ => 0,
            };
        }
        return [score, counter];
    }
}


