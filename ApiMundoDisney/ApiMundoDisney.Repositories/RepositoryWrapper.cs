using ApiMundoDisney.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMundoDisney.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IGeneroRepository _genero;

        public IGeneroRepository Genero 
        {
            get
            {
                if (_genero == null)
                {
                    _genero = new GeneroRepository(_context);
                }

                return _genero;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
