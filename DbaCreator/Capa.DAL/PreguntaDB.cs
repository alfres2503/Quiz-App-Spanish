using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Capa.DAL
{
    public class PreguntaDB
    {

        /// <summary>
        /// Guarda una pregunta en su tabla de la base de datos
        /// </summary>
        /// <param name="p">Objeto del que extrae los datos</param>
        public static void Agregar(Pregunta p)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarPregunta";
                comando.Parameters.AddWithValue("@idExamen", p.IDExamen);
                comando.Parameters.AddWithValue("@idCertificacion", p.IDCertificacion);
                comando.Parameters.AddWithValue("@Enunciado", p.Enunciado);
                comando.Parameters.AddWithValue("@respuesta1", p.Respuesta1);
                comando.Parameters.AddWithValue("@respuesta2", p.Respuesta2);
                comando.Parameters.AddWithValue("@respuesta3", p.Respuesta3);
                comando.Parameters.AddWithValue("@correcta", p.Correcta);
                comando.Parameters.AddWithValue("@imagen", p.Imagen);
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Actualiza una pregunta en su tabla de la base de datos
        /// </summary>
        /// <param name="p">Objeto del que extrae los datos</param>
        public static void Actualizar(Pregunta p)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarPregunta";

                comando.Parameters.AddWithValue("@idPregunta", p.ID);
                comando.Parameters.AddWithValue("@idExamen", p.IDExamen);
                comando.Parameters.AddWithValue("@idCertificacion", p.IDCertificacion);
                comando.Parameters.AddWithValue("@Enunciado", p.Enunciado);
                comando.Parameters.AddWithValue("@respuesta1", p.Respuesta1);
                comando.Parameters.AddWithValue("@respuesta2", p.Respuesta2);
                comando.Parameters.AddWithValue("@respuesta3", p.Respuesta3);
                comando.Parameters.AddWithValue("@correcta", p.Correcta);
                comando.Parameters.AddWithValue("@imagen", p.Imagen);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Sirve para buscar por ID una pregunta en específico 
        /// </summary>
        /// <param name="id">Pregunta a consultar</param>
        /// <returns>Retorna la pregunta cuyo Id sea igual al parámetro</returns>
        public static Pregunta SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPreguntaPorID";
                comando.Parameters.AddWithValue("@Id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pregunta p = new Pregunta();
                    p.ID = (int)dr["IDPregunta"];
                    p.IDCertificacion = (int)dr["IDCertificacion"];
                    p.IDExamen = (int)dr["IDExamen"];
                    p.Enunciado = dr["Enunciado"].ToString();
                    p.Correcta = dr["Correcta"].ToString();
                    p.Respuesta1 = dr["Respuesta1"].ToString();
                    p.Respuesta2 = dr["Respuesta2"].ToString();
                    p.Respuesta3 = dr["Respuesta3"].ToString();
                    p.Imagen = (Byte[])dr["Imagen"];
                    return p;
                }
            }
            return null;
        }

        /// <summary>
        /// Borra la pregunta cuyo id sea igual al parámetro
        /// </summary>
        /// <param name="id">Id de pregunta a consultar</param>
        public static void Borrar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_BorrarPregunta";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método para ver las preguntas de un examen
        /// </summary>
        /// <param name="idExamen">Examen a consultar</param>
        /// <returns> Retorna una lista de preguntas asignada a un Id de Examen</returns>
        public static List<Pregunta> SeleccionarPorExamen(int idExamen)
        {
            List<Pregunta> lista = new List<Pregunta>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPreguntasPorExamen";
                comando.Parameters.AddWithValue("@IdExamen", idExamen);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pregunta p = new Pregunta();
                    p.ID = (int)dr["IDPregunta"];
                    p.IDCertificacion = (int)dr["IDCertificacion"];
                    p.IDExamen = (int)dr["IDExamen"];
                    p.Enunciado = dr["Enunciado"].ToString();
                    p.Correcta = dr["Correcta"].ToString();
                    p.Respuesta1 = dr["Respuesta1"].ToString();
                    p.Respuesta2 = dr["Respuesta2"].ToString();
                    p.Respuesta3 = dr["Respuesta3"].ToString();
                    p.Imagen = (Byte[])dr["Imagen"];
                    lista.Add(p);
                }               
            }
            return lista;
        }



    }
}
