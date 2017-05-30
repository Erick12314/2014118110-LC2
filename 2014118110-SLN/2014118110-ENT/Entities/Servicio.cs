﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public abstract class Servicio
    {
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public decimal Tarifa { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<TipoViaje> TipoViaje { get; set; }
        public ICollection<Bus> Bus { get; set; }
        public ICollection<LugarViaje> LugarViaje { get; set; }

        public Servicio()
        {
            Cliente = new List<Cliente>();
            TipoViaje = new List<TipoViaje>();
            Bus = new List<Bus>();
            LugarViaje = new List<LugarViaje>();
        }

    }
}
