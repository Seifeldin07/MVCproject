﻿using CompanyDate.Entitys;
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
        [HttpGet]
        public IActionResult Create()
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
                return View(department);


            }

            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);

            }

        }

        public IActionResult Details(int? id, string viewName = "Details")
        {
            var department = _departmentService.GetById(id);

            if (department is null)
                return RedirectToAction("NotFoundPage", null, "Home");

            return View(viewName,department);
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Update(int? id , Department department)
        {
            if(department.Id != id.Value)
                return RedirectToAction("NotFoundPage", null, "Home");

            _departmentService.Update(department);

            return View(department); 

        }

       
        public IActionResult Delete(int id) 
        {
            var department = _departmentService.GetById(id);

            if (department is null)
                return RedirectToAction("NotFoundPage", null, "Home");

            _departmentService.Delete(department);
            return RedirectToAction(nameof(Index));

        }


    }
}


