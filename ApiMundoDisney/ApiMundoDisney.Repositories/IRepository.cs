using ApiMundoDisney.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiMundoDisney.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T entidad);
        void Remove(T entidad);
        void Update(T entidad);
        int Count(Expression<Func<T, bool>> where);
        T GetById(int id);
        IEnumerable<T> FindBy(ParametrosDeQuery<T> parametrosDeQuery);
        void Save();        
    }
}
