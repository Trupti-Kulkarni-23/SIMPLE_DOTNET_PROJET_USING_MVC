using Company.Data;
// using Company.Models;
using Microsoft.EntityFrameworkCore;
namespace Company.Models;

public class CompanyModels
{
        public IEnumerable<Staff> GetEmployees()
        {
            using var company =new CompanyDbContext();
            var employee = from t in company.Employee
                           where t.EmployeeId > 0
                           select new Staff
                           {
                             EmpId =  t.EmployeeId,
                             Name =  t.EmployeeName,
                             Salary= t.Salary,
                             DeptNo = t.DepartmentId,
                           };

             return employee.ToList();
        }
    

    

        public void AcceptEmployees(int employeeid, string Name ,decimal Salary , int DepartmentNo)
        {
            using var company = new CompanyDbContext();
            var employee = company.Employee.Find(employeeid);
            //if employee does not exist, add it to the database.      
            if(employee is null)
            {
               employee=new Employee {EmployeeId = employeeid , 
               EmployeeName =Name , 
               DepartmentId =DepartmentNo , 
               Salary=Salary 
               };
               company.Employee.Add(employee);
            }
            //  employee.Departments.Add(new Department());
            // else{
            //   GetEmployees();
            // }
            company.SaveChanges();
        }
}