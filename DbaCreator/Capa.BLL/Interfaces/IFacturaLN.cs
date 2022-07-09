using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    /// <summary>
    /// Interfaz factura, la documentación de los métodos está en la clase hijo
    /// </summary>
    public interface IFacturaLN
    {
        void Guardar(EncFactura factura);
        int ObtenerNumeroDeFacturaActual();
    }
}
