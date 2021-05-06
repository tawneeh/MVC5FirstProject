using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5FirstProject.Models;

namespace MVC5FirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 001,
                EmployeeName = "Tawnee Harris",
                EmployeeLocation = "Seattle"
            };

            return View();
        }
    }
}