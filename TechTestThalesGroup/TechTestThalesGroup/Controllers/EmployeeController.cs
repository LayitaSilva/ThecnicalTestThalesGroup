using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Controllers;
using DAL;
using TechTestThalesGroup.Models;
using BLL;


namespace TechTestThalesGroup.Controllers
{
    public class EmployeeController : Controller
    {
        public List<EmployeeModel> _employeesListInformation { get; private set; }

        public IActionResult Index()
        {
            ViewData.Model = new EmployeeDataModel();
            return View();
        }

        public async Task<ActionResult> GetEmployeeAsync()
        {
            int id = -1;
            ApiHelper.InitializeClient();
            EmployeeLogicBusiness EmployeeBLL = new EmployeeLogicBusiness();
            EmployeesDataModel employees = new EmployeesDataModel();
            string Emplid = Request.Form["IdEmployeeText"];
            if (Emplid != "")
            {
                try
                {
                    id = Int32.Parse(Emplid);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{Emplid}'");
                }
            }
            try
            {
                employees = await EmployeeBLL.GetInformationEmployees(id);
                ViewData.Model = employees;
                return View("Views/Employee/Employee.cshtml", employees.data);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View("Views/Employee/ErrorEmployee.cshtml");
            }
        }
    }
}
