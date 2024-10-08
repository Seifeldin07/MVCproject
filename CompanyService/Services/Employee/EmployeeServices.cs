using CompanyDate.Entitys;
using CompanyService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService.Services.Employee
{
    public class EmployeeServices(IUnitOfWork unitOfWork) : IEmployeeServices
    {
        public void Add(CompanyDate.Entitys.Employee employee)
        {

        }
         
        public void Delete(CompanyDate.Entitys.Employee employee)
        {
            unitOfWork.EmployeeRepository.Delete(employee);
            unitOfWork.complete();
        }

        public IEnumerable<CompanyDate.Entitys.Employee> GetAll()
        {
            var employee = unitOfWork.EmployeeRepository.GetAll();
            return employee;

        }

        public CompanyDate.Entitys.Employee GetById(int id)
        {
            if (id is null)
                return null;

            var employee = unitOfWork.EmployeeRepository.GetById(id.Value);

            if (employee is null)
                return null;
            return employee;
        }

        public IEnumerable<CompanyDate.Entitys.Employee> GetEmployeeByName(string name)
               => unitOfWork.EmployeeRepository.GetEmployeeByName(name);

        public void Update(CompanyDate.Entitys.Employee employee)
        {
           _uniteOfWork.EmployeesRepository.UpdateEmployee(employee);
           _uniteOfWork.complete();

        }


    }
}




