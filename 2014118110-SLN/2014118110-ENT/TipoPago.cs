﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }
        public string MetodoPago { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

    }
}
