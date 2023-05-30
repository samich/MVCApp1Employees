using Microsoft.AspNetCore.Mvc;
using MVCApp1Employees.Models;

namespace MVCApp1Employees.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        
    }
}
