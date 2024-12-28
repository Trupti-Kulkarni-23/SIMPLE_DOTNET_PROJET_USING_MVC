using System.ComponentModel.DataAnnotations.Schema;
namespace Company.Data;
[Table("Department")]
public class Department{

    public int DepartmentId{get;set;}
 
    public string DepartmentName{get;set;}

    public string Location{get;set;}
     public List<Employee> Employees{get;set;}

}