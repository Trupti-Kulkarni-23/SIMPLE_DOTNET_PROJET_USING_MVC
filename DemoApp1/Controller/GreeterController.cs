using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class GreeterController : Controller
{
     public IActionResult Clock()
      {
        return Content(DateTime.Now.ToString());
      }

     public IActionResult Meet(int id, [FromServices] IEmployee counting)
    {
        var info = new 
        {
            EmpName = id,
            GreetCount = counting.CountNext(id)
        };
        string browser = Request.Headers.UserAgent;
        if(browser.Contains("Mobile"))
            return View("~/Views/Hello.cshtml", info);
        return View("~/Views/Welcome.cshtml", info);
    }
}