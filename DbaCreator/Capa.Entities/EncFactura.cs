using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Factura en general, contiene varios Detalles de factura
    /// </summary>
    public class EncFactura
    {
        public int IDFactura { get; set; }
        public int IDTarjeta { get; set; }
        public int IDCliente { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public string NumeroTarjeta { get; set; }

        public List<DetFactura> _ListaFacturaDetalle { get; } = new List<DetFactura>();

        /// <summary>
        /// Inserta un item comprado en la factura
        /// </summary>
        /// <param name="pFacturaDetalle">Objeto a insertar</param>
        public void AgregarDetalle(DetFactura pFacturaDetalle)
        {
            _ListaFacturaDetalle.Add(pFacturaDetalle);
        }

        /// <summary>
        /// Obtiene el total que debe pagar el cliente por todos los item comprados
        /// </summary>
        /// <returns>Retona un numero decimal en dólares</returns>
        public double ObtenerTotal()
        {
            double total = 0;
            foreach(var item in _ListaFacturaDetalle)
            {
                total += item.Monto;
            }
            return total;
        }

    }
}
