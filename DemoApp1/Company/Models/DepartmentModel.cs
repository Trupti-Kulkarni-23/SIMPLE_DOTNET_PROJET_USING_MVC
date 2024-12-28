using Company.Data;
// using Company.Models;
// using Microsoft.EntityFrameworkCore;


namespace Company.Models;

public class DepartmentModel
{
    public IEnumerable<Division>GetDepartments()
        {
            using var company =new CompanyDbContext();
            var Department = from t in company.Departments
                           where t.DepartmentId > 0
                           select new Division
                           {

                             DeptId =  t. DepartmentId,
                             DeptName =  t.DepartmentName,
                             Location = t.Location,
                            
                           };

            return Department.ToList();
        }

    public void AcceptDepartments(int DeptId, string DeptName ,string Location)
        {
            using var company = new CompanyDbContext();
            var department = company.Departments.Find(DeptId);
            //if employee does not exist, add it to the database.      
            if(department is null)
            {
               department=new Department {DepartmentId= DeptId , 
            //    DepartmentId =DeptId , 
               DepartmentName =DeptName , 
               Location =Location 
               };
               company.Departments.Add(department);
            }
            //  employee.Departments.Add(new Department());
            // else{
            //   GetEmployees();
            // }
            company.SaveChanges();
        }
}    