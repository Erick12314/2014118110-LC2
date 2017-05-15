using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class TipoViaje
    {
        public string Nombre { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}
