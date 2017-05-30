using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string NombreLugar { get; set; }

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public ICollection<TipoLugar> TipoLugar { get; set; }

        public LugarViaje()
        {
            TipoLugar = new List<TipoLugar>();
        }

    }
}
