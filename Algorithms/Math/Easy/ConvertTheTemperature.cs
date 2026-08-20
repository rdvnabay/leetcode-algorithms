/**
 * @id         2469
 * @title      Convert the Temperature
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/convert-the-temperature/
 */
namespace Algorithms.Math.Easy;

public static class ConvertTheTemperature
{
    public static double[] Run(double celsius)
    {
        return new double[]
        {
             celsius + 273.15,
             celsius * 1.80 + 32.00
        };
    }
}


