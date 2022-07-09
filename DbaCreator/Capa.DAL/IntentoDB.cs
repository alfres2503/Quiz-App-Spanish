using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
    public class IntentoDB
    {
        /// <summary>
        /// Inserta un intento en la base de datos
        /// </summary>
        /// <param name="i">Intento del que extraerá los datos</param>
        public static void Insertar(Intento i)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarIntento";
                comando.Parameters.AddWithValue("@idIntento", i.IDIntento);
                comando.Parameters.AddWithValue("@idCliente", i.IDCliente);
                comando.Parameters.AddWithValue("@idExamen", i.IDExamen);
                comando.Parameters.AddWithValue("@Exitoso", i.Exitoso);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Usado para saber que numero de intento va y asignar un id
        /// </summary>
        /// <returns> Retorna el id máximo en la tabla + 1 </returns>
        public static int ObtenerNumeroDeIntentoActual()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                int id;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_UltimoIDIntento";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    id = (int)dr["IDIntento"];
                    return id + 1;
                }
            }
            return 1;
        }

        /// <summary>
        /// Si el cliente gana el examen se marca como exitoso
        /// </summary>
        /// <param name="idIntento"> ID a buscar</param>
        public static void MarcarIntentoExitoso(int idIntento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarIntento";
                comando.Parameters.AddWithValue("@idIntento", idIntento);

                db.ExecuteNonQuery(comando);
            }
        }


    }
}
