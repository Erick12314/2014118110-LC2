using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }
        public string Nombre { get; set; }

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }
    }
}
