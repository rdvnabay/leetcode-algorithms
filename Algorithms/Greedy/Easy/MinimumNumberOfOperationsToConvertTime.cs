namespace Greedy.Easy;

public static class MinimumNumberOfOperationsToConvertTime
{
    public static int Run(string current, string correct)
    {
        int result = 0;

        var currentParts = current.Split(':');
        var correctParts = correct.Split(':');
        int currentMinute = int.Parse(currentParts[0]) * 60 + int.Parse(currentParts[1]);
        int correctMinute = int.Parse(correctParts[0]) * 60 + int.Parse(correctParts[1]);

        int totalMinute = correctMinute - currentMinute;

        while (totalMinute > 0)
        {
            int subtract = totalMinute switch
            {
                >= 60 => 60,
                >= 15 => 15,
                >= 5 => 5,
                _ => 1
            };

            totalMinute -= subtract;
            result++;
        }

        return result;
    }
}
