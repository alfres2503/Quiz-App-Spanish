using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Diferentes item comprados en una factura
    /// </summary>
    public class DetFactura
    {
        public int IDFactura { get; set; }
        public int Secuencia { get; set; }
        public int IDExamen { get; set; }
        public double Monto{ get; set; }
        public bool ExamenRealizado { get; set; }

        public string codigoUnico { get; set; }

    }
}
