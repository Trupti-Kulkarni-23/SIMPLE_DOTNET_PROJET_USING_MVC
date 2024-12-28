namespace DemoApp.Services;

public class CommonCounter : IEmployee
{
    private int current = 0;

    public int CountNext(int EmployeeId)
    {
        return Interlocked.Increment(ref current);
    }
}