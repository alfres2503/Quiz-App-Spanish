using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// DTO Para relacionar Cliente con DetFactura
    /// </summary>
    public class ClienteDetalle
    {
        public int IdCliente { get; set; }
        public int IDFactura { get; set; }
        public int Secuencia { get; set; }
        public int IDExamen { get; set; }
        public double Monto { get; set; }
        public bool ExamenRealizado { get; set; }

        public string codigoUnico { get; set; }
    }
}
