using CompanyDate.Context;
using CompanyDate.Entitys;
using CompanyRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRepository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyDbContext _context;
        public GenericRepository(CompanyDbContext context)
        {
            _context = context;
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
            
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
         
        public IEnumerable<T> GetAll()
            =>_context.Set<T>().ToList();
        
        public T GetById(int id)
            => _context.Set<T>().FirstOrDefault( x=> x.Id ==id);
      
        public void Update(T entity)
         => _context.Set<T>().Update(entity);
    }
}
