
using Microsoft.AspNetCore.Mvc;
using Company.Models;

// using Company.Models;

namespace DemoApp.Controllers;
// public class DepartmentController(DepartmentModel dept) : Controller
// {
    public class DepartmentController : Controller
    {
        private readonly DepartmentModel dept;

        // Constructor with dependency injection
        public DepartmentController(DepartmentModel dept)
        {
            this.dept = dept;
        }

     [HttpGet]
    public IActionResult Departments()
    {
        var dep = dept.GetDepartments();
        return View(dep); //renders ~/Views/{current-controller-name}/{current-method-name}.cshtml
    }


     public IActionResult RDepartment()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RDepartment(int DeptId,string DeptName,string Location )
    {
        dept.AcceptDepartments(DeptId, DeptName,Location);
        return RedirectToAction("Departments");
    }
}