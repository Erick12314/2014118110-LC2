using _2014118110_ENT;
using _2014118110_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        private readonly TransporteDbContext _Context;

        private TransporteRepository()
        {

        }

        public TransporteRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
