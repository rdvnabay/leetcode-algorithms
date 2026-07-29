using Algorithms.Math.Easy.Solutions;

namespace Algorithms.Math.Easy;

public static class MathEasyRunner
{
    public static void Run()
    {
        // 9: Palindrome Number
        PalindromeNumber.Run(123);
        // 13: Roman to Integer
        RomanToInteger.Run("III");
        // 202: Happy Number
        HappyNumber.Run(19);
        // 231: Power of Two
        PowerOfTwo.Run(-16);
        // 258: Add Digits
        AddDigits.Run(3);
        // 268: Missing Number
        MissingNumber.Run(new int[] { 0, 1, 3 });
        // 342: Power of Four
        PowerOfFour.Run(0);
        // 728: Self Dividing Numbers
        SelfDividingNumbers.Run(1, 22);
        // 3289: The Two Sneaky Numbers of Digitville
        TheTwoSneakyNumbersOfDigitville.Run(new int[] { 0, 3, 2, 1, 3, 2 });
    }
}