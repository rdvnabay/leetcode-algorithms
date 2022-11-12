namespace Algorithms.Solutions.Easy;

public static class FizzBuzz
{
    public static IList<string> Run(int n)
    {
        List<string> result = new();

        foreach (var number in Enumerable.Range(1, n))
        {
            if (number % 3 == 0 && number % 5 == 0)
                result.Add("FizzBuzz");

            else if (number % 3 == 0)
                result.Add("Fizz");

            else if (number % 5 == 0)
                result.Add("Buzz");
            else
                result.Add(number.ToString());
        }

        return result;
    }
}
