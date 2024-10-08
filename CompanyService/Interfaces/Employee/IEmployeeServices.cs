
using CompanyDate.Entitys;

namespace CompanyService.Interfaces
{
    public interface IEmployeeServices
    {
        Employee GetById (int id);
        IEnumerable<Employee> GetAll();

        void Add (Employee employee);
        void Update(Employee employee);

        void Delete (Employee employee);

        IEnumerable<Employee> GetEmployeeByName(string name);
    }

}
















