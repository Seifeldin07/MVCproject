﻿using CompanyDate.Entitys;
using CompanyRepository.Interfaces;
using CompanyService.Interfaces;

namespace CompanyService.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Add(Department department)
        {
            var MappedDepartment = new Department
            { Code = department.Code, Name = department.Name ,CreateAt = DateTime.Now };
            _departmentRepository.Add(MappedDepartment);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public IEnumerable<Department> GetAll()
        {
           var departments = _departmentRepository.GetAll();
            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
                return null;
            var department = _departmentRepository.GetById(id.Value);

            if (department is null)
                return null;

            return department;
        }

        public void Update(Department department)
        {
          //var dept = GetById(department.Id);

            //if(dept.Name != department.Name)
            //{
            //    if (GetAll().Any(x => x.Name == department.Name))
            //        throw new Exception("DuplicateDepartmentName");
            //}
            //dept.Name = department.Name;
            //dept.Code = department.Code;

            _departmentRepository.Update(department);


        }
        


    }
}

