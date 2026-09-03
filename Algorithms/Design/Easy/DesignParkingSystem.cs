/**
 * @id         1603
 * @title      Design Parking System
 * @topic      Design
 * @difficulty Easy
 * @link       https://leetcode.com/problems/design-parking-system/
 */
namespace Design.Easy;

public class DesignParkingSystem
{
    private readonly int[] _spaces;
    public DesignParkingSystem(int big, int medium, int small)
    {
        _spaces = [big, medium, small];
    }

    public bool AddCar(int carType)
    {
        if (_spaces[carType - 1] == 0)
            return false;

        _spaces[carType - 1]--;
        return true;
    }
}
