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
    public class TarjetaDB
    {
        /// <summary>
        /// Sirve para ver todas las tarjetas
        /// </summary>
        /// <returns>Retorna una lista con todas las tarjetas disponibles</returns>
        public static List<Tarjeta> ObtenerTodos()
        {
            List<Tarjeta> lista = new List<Tarjeta>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTarjetas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Tarjeta t = new Tarjeta();
                    t.ID = (int)dr["IDTarjeta"];
                    t.Nombre = dr["Nombre"].ToString();

                    lista.Add(t);
                }
            }
            return lista;
        }
    }
}
