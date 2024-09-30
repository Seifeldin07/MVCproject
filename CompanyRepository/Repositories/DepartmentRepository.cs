using CompanyDate.Context;
using CompanyDate.Entitys;
using CompanyRepository.Interfaces;

namespace CompanyRepository.Repositories
{
    public class DepartmentRepository : GenericRepository<Department> ,IDepartmentRepository
    {
        //private readonly CompanyDbContext _context;

        public DepartmentRepository(CompanyDbContext context) : base(context)
        { 
            //_context = context;
        }
        //public void Add(Department department)
        //   => _context.Add(department);


        //public void Delete(Department department)
        //    => _context.Remove(department);

        //public IEnumerable<Department> GetAll()
        //    => _context.Departments.ToList();

        //public Department GetById(int id)
        //    => _context.Departments.FirstOrDefault(x => x.Id == id);

        //public void Update(Department department)
        //    => _context.Update(department);

    }
}
