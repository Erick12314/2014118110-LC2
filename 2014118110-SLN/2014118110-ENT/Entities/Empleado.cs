using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public abstract class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }
        public decimal Sueldo { get; set; }

        public virtual int BusId { get; set; }
        public virtual Bus Bus { get; set; }

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public virtual ICollection<TipoTripulacion> TipoTripulacion { get; set; }

        public Empleado()
        {
            TipoTripulacion = new List<TipoTripulacion>();
        }
    }
}
