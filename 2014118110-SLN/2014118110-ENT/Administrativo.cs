﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class Administrativo : Empleado
    {
        public int AdministrativoId { get; set; }

        public string Cargo { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
