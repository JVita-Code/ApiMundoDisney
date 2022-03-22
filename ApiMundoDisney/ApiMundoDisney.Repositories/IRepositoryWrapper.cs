using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMundoDisney.Repositories
{
    public interface IRepositoryWrapper
    {
        IGeneroRepository Genero { get; }

        void Save();
    }
}
