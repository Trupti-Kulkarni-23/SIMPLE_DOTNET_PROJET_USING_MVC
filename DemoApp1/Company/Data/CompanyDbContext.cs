using Microsoft.EntityFrameworkCore;
namespace Company.Data;

public class CompanyDbContext : DbContext{

    public DbSet<Employee> Employee {get;set;}
    public DbSet<Department> Departments {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=EmployeeDb;User Id=dac2;Password=Dac2@1234;Encrypt=False");
    }

}