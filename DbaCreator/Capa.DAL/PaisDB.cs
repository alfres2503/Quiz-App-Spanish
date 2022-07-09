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
    public class PaisDB
    {
        /// <summary>
        /// Usado para ver todos los países
        /// </summary>
        /// <returns>retorna una lista con todos los países</returns>
        public static List<Pais> ObtenerTodos()
        {
            List<Pais> lista = new List<Pais>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPaises";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pais p = new Pais();
                    p.Nombre = dr["Nombre"].ToString();

                    lista.Add(p);
                }
            }
            return lista;
        }
    }
}
