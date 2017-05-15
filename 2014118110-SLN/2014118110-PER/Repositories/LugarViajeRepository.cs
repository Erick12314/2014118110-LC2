using _2014118110_ENT;
using _2014118110_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        private readonly TransporteDbContext _Context;

        private LugarViajeRepository()
        {

        }

        public LugarViajeRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
