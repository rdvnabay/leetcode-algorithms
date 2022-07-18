namespace Algorithms.Solutions.Easy;

public class PalindromeNumber
{
    /// <summary>
    /// Given an integer x, return true if x is palindrome integer.
    /// An integer is a palindrome when it reads the same backward as forward.
    /// </summary>
   
    /// <param name="x"></param>
    /// <returns></returns>
    public static bool Run(int x)
    {
        var number = x.ToString().ToList();
        var reverseNumber = x.ToString().Reverse().ToList();

        for (int i = 0; i < number.Count; i++)
        {
            if (number[i] != reverseNumber[i])
                return false;
        }
        return true;
    }
}
