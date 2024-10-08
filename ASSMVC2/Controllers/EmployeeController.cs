using CompanyService.Interfaces;
using CompanyService.Interfaces;
using CompanyService.Services;
using CompanyService.Services.Employee;
using Microsoft.AspNetCore.Mvc;

namespace ASSMVC2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _employeeServices;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }
        [HttpGet]
        public IActionResult  Index (string searchInp)
        {
            if (string.IsNullOrEmpty(searchInp))
            { 
            var employee = _employeeServices.GetAll();
            return View(employee);
            }
            else
            {
                var employee = _employeeServices.GetEmployeeByName(searchInp);
                return View(employee);
            }
        }
        //[HttpGet]   
        //public IActionResult Create()
        //{

        //}
        //[HttpPost]
        //public IActionResult Index()
        //{

        //}


    }
}
