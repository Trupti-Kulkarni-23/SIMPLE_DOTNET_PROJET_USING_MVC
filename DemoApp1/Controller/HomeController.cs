using Microsoft.AspNetCore.Mvc;
using Company.Models;

// using Company.Models;

namespace DemoApp.Controllers;
public class HomeController(CompanyModels model) : Controller
{
    public IActionResult Index()
    {
        var emp = model.GetEmployees();
        return View(emp); //renders ~/Views/{current-controller-name}/{current-method-name}.cshtml
    }
//    public IActionResult Department()
//     {
//         var dep = model.GetDepartments();
//         return View(dep); //renders ~/Views/{current-controller-name}/{current-method-name}.cshtml
//     }
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(int employeeid, string employeeName , decimal Salary , int DepartmentNo)
    {
        model.AcceptEmployees(employeeid, employeeName, Salary , DepartmentNo);
        return RedirectToAction("Index");
    }

    // public IActionResult RDepartment()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public IActionResult RDepartment(int  DeptId, string    DeptName , string  Location )
    // {
    //     model.GetDepartments( DeptId, DeptName,Location);
    //     return RedirectToAction("Department");
    // }
} 
                         