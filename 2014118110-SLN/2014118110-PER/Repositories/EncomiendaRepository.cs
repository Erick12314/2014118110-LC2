using _2014118110_ENT;
using _2014118110_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private readonly TransporteDbContext _Context;

        private EncomiendaRepository()
        {

        }

        public EncomiendaRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
