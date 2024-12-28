namespace Company.Data;

using System.ComponentModel.DataAnnotations.Schema;


public class Employee{
    public int EmployeeId{get;set;}
    
    public string EmployeeName{get;set;}

    public decimal Salary{get;set;}
[Column("DepartmentNo")]
    public int DepartmentId{get;set;}

//    public List<Department> Departments {get;set;}

}