using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class FacturaLN : IFacturaLN
    {
        /// <summary>
        /// Método que guarda el encabezado de la factura en la base de datos
        /// </summary>
        /// <param name="factura">factura de la cuál extraerá los datos </param>
        public void Guardar(EncFactura factura)
        {
            FacturaDB.Guardar(factura);
        }

        /// <summary>
        /// Obtiene el número siguiente de factura
        /// </summary>
        /// <returns>retorna el número de factura siguiente</returns>
        public int ObtenerNumeroDeFacturaActual()
        {
            return FacturaDB.ObtenerNumeroDeFacturaActual();
        }

        /// <summary>
        /// Obtiene las copras hechas por el cliente
        /// </summary>
        /// <param name="idCliente">Cliente a consultar</param>
        /// <returns>Obtiene las copras hechas por el cliente</returns>
        public static List<DetFactura> ObtenerDetallesPorCliente(int idCliente)
        {
            return FacturaDB.ObtenerDetallesPorCliente(idCliente);
        }

        /// <summary>
        /// Método usado para buscar una compra y empezar la realización de un examen
        /// </summary>
        /// <param name="idCliente">Cliente a buscar</param>
        /// <param name="codigo">Codigo de la compra</param>
        /// <returns>retorna un dto para comenzar el examen</returns>
        public static ClienteDetalle ObtenerDetallePorCodigo(int idCliente, string codigo)
        {
            return FacturaDB.ObtenerDetallePorCodigo(idCliente, codigo);
        }

        /// <summary>
        /// Marca un examen como realizado
        /// </summary>
        /// <param name="codigo">busca por código</param>
        public static void MarcarRealizado(string codigo)
        {
            FacturaDB.MarcarRealizado(codigo);
        }
    }
}
