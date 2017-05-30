using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Servicio> Servicio { get; set; }
        public virtual ICollection<TipoPago> TipoPago { get; set; }
        public virtual ICollection<TipoComprobante> TipoComprobante { get; set; }

        public Venta()
        {
            Empleado = new List<Empleado>();
            Cliente = new List<Cliente>();
            Servicio = new List<Servicio>();
            TipoPago = new List<TipoPago>();
            TipoComprobante = new List<TipoComprobante>();
        }

    }
}
