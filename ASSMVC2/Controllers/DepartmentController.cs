using CompanyDate.Entitys;
using CompanyRepository.Interfaces;
using CompanyService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASSMVC2.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
        [HttpPost]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _departmentService.Add(department);

                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("DepartmentError", "validationError");
                return View();


            }

            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View();

            }



        }

    }
}


