using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_ENT
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }
        public string SerieMotor { get; set; }

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public ICollection<Empleado> Empleado { get; set; }

        public Bus()
        {
            Empleado = new List<Empleado>();
        }

    }
}
