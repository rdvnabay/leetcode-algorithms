
using Math.Easy;

namespace Algorithms.Math.Easy;

public static class MathEasyRunner
{
    public static void Run()
    {
        PalindromeNumber.Run(123);
        RomanToInteger.Run("III");
        HappyNumber.Run(19);
        PowerOfTwo.Run(-16);
        AddDigits.Run(3);
        MissingNumber.Run(new int[] { 0, 1, 3 });
        PowerOfFour.Run(0);
        SelfDividingNumbers.Run(1, 22);
        TheTwoSneakyNumbersOfDigitville.Run(new int[] { 0, 3, 2, 1, 3, 2 });
        UglyNumber.Run(30);
        ValidPerfectSquare.Run(400);
        AddStrings.Run("11", "123");
        ArrangingCoins.Run(5);
        Base7.Run(-7);
        PerfectNumber.Run(7);
        DayOfTheYear.Run("2016-02-09");
        CellsWithOddValuesInAMatrix.Run(2, 3, new int[][] { [0, 1], [1, 1] });
        SubtractTheProductAndSumOfDigitsOfAnInteger.Run(4421);
        FindNumbersWithEvenNumberOfDigits.Run(new int[] { 12, 345, 2, 6, 7896 });
    }
}