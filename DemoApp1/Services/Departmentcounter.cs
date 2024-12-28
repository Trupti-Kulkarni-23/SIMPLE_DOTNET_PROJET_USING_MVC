namespace DemoApp.Services;

public class DepartmentCounter : IEmployee
{
    private static Dictionary <int, int> store = new();

    public int CountNext(int EmployeeId)
    {
        lock(store)
        {
            store.TryGetValue(EmployeeId, out int current);
          
            store[EmployeeId] = ++current;
            return current;
        }    
    }
}