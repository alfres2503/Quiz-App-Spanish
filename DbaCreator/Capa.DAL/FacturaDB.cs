using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
    public class FacturaDB
    {
        /// <summary>
        /// Método que guarda el encabezado de la factura en la base de datos
        /// </summary>
        /// <param name="factura">factura de la cuál extraerá los datos </param>
        public static void Guardar(EncFactura factura)
        {
            //EncFactura encFactura = factura;
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarEncFactura";
                comando.Parameters.AddWithValue("@idFactura", factura.IDFactura);
                comando.Parameters.AddWithValue("@idTarjeta", factura.IDTarjeta);
                comando.Parameters.AddWithValue("@idCliente", factura.IDCliente);
                comando.Parameters.AddWithValue("@numeroTarjeta", factura.NumeroTarjeta);
                comando.Parameters.AddWithValue("@total", factura.ObtenerTotal());

                db.ExecuteNonQuery(comando);

                foreach (DetFactura det in factura._ListaFacturaDetalle)
                {
                    InsertarDetalleFactura(det);
                }
            }
        }

        /// <summary>
        /// Metodo que inserta un detalle de factura en la base de datos
        /// </summary>
        /// <param name="detallefactura">objeto del que obtiene los datos</param>
        public static void InsertarDetalleFactura(DetFactura detallefactura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarDetFactura";
                comando.Parameters.AddWithValue("@idFactura", detallefactura.IDFactura);
                comando.Parameters.AddWithValue("@secuencia", detallefactura.Secuencia);
                comando.Parameters.AddWithValue("@idExamen", detallefactura.IDExamen);
                comando.Parameters.AddWithValue("@monto", detallefactura.Monto);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene el número siguiente de factura
        /// </summary>
        /// <returns>retorna el número de factura siguiente</returns>
        public static int ObtenerNumeroDeFacturaActual()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                int id;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_UltimoIDFactura";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    id = (int)dr["IDFactura"];
                    return id + 1;
                }
            }
            return 1;
        }

        /// <summary>
        /// Obtiene las copras hechas por el cliente
        /// </summary>
        /// <param name="idCliente">Cliente a consultar</param>
        /// <returns>Obtiene las copras hechas por el cliente</returns>
        public static List<DetFactura> ObtenerDetallesPorCliente(int idCliente)
        {
            List<DetFactura> lista = new List<DetFactura>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarDetallesPorCliente";
                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DetFactura d = new DetFactura();
                    d.IDFactura = (int)dr["IDFactura"];
                    d.Secuencia = (int)dr["Secuencia"];
                    d.IDExamen = (int)dr["IDExamen"];
                    d.codigoUnico = dr["CodigoUnico"].ToString();
                    d.Monto = Convert.ToDouble(dr["Monto"]);
                    d.ExamenRealizado = Convert.ToBoolean(dr["ExamenRealizado"]);

                    lista.Add(d);
                }
            }
            return lista;
        }

        /// <summary>
        /// Método usado para buscar una compra y empezar la realización de un examen
        /// </summary>
        /// <param name="idCliente">Cliente a buscar</param>
        /// <param name="codigo">Codigo de la compra</param>
        /// <returns>retorna un dto para comenzar el examen</returns>
        public static ClienteDetalle ObtenerDetallePorCodigo(int idCliente, string codigo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarDetallePorCodigo";
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Parameters.AddWithValue("@codigo", codigo);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ClienteDetalle c = new ClienteDetalle();
                    c.IdCliente = (int)dr["IDCliente"];
                    c.IDFactura = (int)dr["IDFactura"];
                    c.Secuencia = (int)dr["Secuencia"];
                    c.IDExamen = (int)dr["IDExamen"];
                    c.codigoUnico = dr["CodigoUnico"].ToString();
                    c.Monto = Convert.ToDouble(dr["Monto"]);
                    c.ExamenRealizado = Convert.ToBoolean(dr["ExamenRealizado"]);

                    return c;
                }
            }
            return null;
        }

        /// <summary>
        /// Marca un examen como realizado
        /// </summary>
        /// <param name="codigo">busca por código</param>
        public static void MarcarRealizado(string codigo)
        {
            //EncFactura encFactura = factura;
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_MarcarExamenRealizado";
                comando.Parameters.AddWithValue("@codigo", codigo);

                db.ExecuteNonQuery(comando);

            }
        }


    }
}
