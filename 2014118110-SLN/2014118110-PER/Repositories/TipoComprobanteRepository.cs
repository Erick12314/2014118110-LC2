﻿using _2014118110_ENT;
using _2014118110_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.Repositories
{
    public class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
        public TipoComprobanteRepository(DbContext context) : base(context)
        {
        }

    }
}
