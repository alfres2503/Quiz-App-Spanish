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
    public class CertificacionDB
    {
        /// <summary>
        /// Método que guarda la certificacion en la base de datos
        /// </summary>
        /// <param name="c">Certificación del cuál extraerá los datos </param>
        public static void AgregarCertificacion(Certificacion c)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarCertificacion";
                comando.Parameters.AddWithValue("@id", c.Id);
                comando.Parameters.AddWithValue("@descripcion", c.Descripcion);
                comando.Parameters.AddWithValue("@precio", c.Precio);

                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// Método para obtener todos los datos de la tabla Certificación
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Certificacion</returns>
        public static List<Certificacion> ObtenerTodos()
        {
            List<Certificacion> lista = new List<Certificacion>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCertificaciones";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Certificacion c = new Certificacion();
                    c.Id = (int)dr["IDCertificacion"];
                    c.Descripcion = dr["Descripcion"].ToString();
                    c.Precio = Convert.ToDouble(dr["Precio"]);

                    lista.Add(c);
                }
            }
            return lista;
        }

        /// <summary>
        /// Retorna de la tabla Certificación el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns></returns>
        public static Certificacion SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCertificacionPorID";
                comando.Parameters.AddWithValue("@Id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Certificacion c = new Certificacion();
                    c.Id = (int)dr["IDCertificacion"];
                    c.Descripcion = dr["Descripcion"].ToString();
                    c.Precio = Convert.ToDouble(dr["Precio"]);
                    return c;
                }
            }
            return null;
        }

        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public static void Borrar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_BorrarCertificacion";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// Método que actualiza un dato en la tabla
        /// </summary>
        /// <param name="c">Objeto del que extrae los datos</param>
        public static void Actualizar(Certificacion c)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCertificacion";

                comando.Parameters.AddWithValue("@descripcion", c.Descripcion);
                comando.Parameters.AddWithValue("@precio", c.Precio);
                comando.Parameters.AddWithValue("@id", c.Id);

                db.ExecuteNonQuery(comando);
            }
        }



    }
}
