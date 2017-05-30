using System;
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

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<TipoViaje> TipoViaje { get; set; }
        public virtual ICollection<Bus> Bus { get; set; }
        public virtual ICollection<LugarViaje> LugarViaje { get; set; }

        public Servicio()
        {
            Cliente = new List<Cliente>();
            TipoViaje = new List<TipoViaje>();
            Bus = new List<Bus>();
            LugarViaje = new List<LugarViaje>();
        }

    }
}
