using ApiMundoDisney.Data;
using ApiMundoDisney.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiMundoDisney.Repositories
{
    class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public GeneroRepository(ApplicationDbContext context)
            : base(context)
        {

        }        
    }
}
