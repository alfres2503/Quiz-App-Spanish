using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Intento de hacer el examen que realizan los clientes
    /// </summary>
    public class Intento
    {
        public int IDIntento { get; set; }
        public int IDCliente { get; set; }
        public int IDExamen { get; set; }
        public bool Exitoso { get; set; }
    }
}
