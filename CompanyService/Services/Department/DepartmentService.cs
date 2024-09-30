using CompanyDate.Entitys;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
           var departments = _departmentRepository.GetAll();
            return departments;
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
