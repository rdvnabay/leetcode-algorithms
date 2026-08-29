namespace Array.Easy;

public static class ElevatorRequestsI
{
    public static int Run(int n, int[] requests)
    {
        int total = requests[0];

        for (int i = 0; i < requests.Length - 1; i++)
            total += Math.Abs(requests[i] - requests[i + 1]);
        
        return total;
    }
}
