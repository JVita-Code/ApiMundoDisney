using ApiMundoDisney.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiMundoDisney.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;        

        public Repository(ApplicationDbContext context)
        {
            _context = context;            
        }

        public void Create(T entidad)
        {
            _context.Set<T>().Add(entidad);
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Data.ParametrosDeQuery<T> parametrosDeQuery)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {           
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entidad)
        {
            _context.Set<T>().Remove(entidad);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entidad)
        {
            _context.Set<T>().Update(entidad);
        }
    }
}
