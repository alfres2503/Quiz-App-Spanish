using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FactoryConexion
{
    public static string CreateConnection()
    {
        // Lee la conexion default
        return ConfigurationManager.ConnectionStrings["UI.Properties.Settings.Cadena"].ConnectionString;
    }


    public static string CreateConnection(string nombre)
    {
        // Lee la conexion default
        return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
    }

    public static string CreateConnection(string pUsuario, String pContrasena)
    {

        StringBuilder conexion = new StringBuilder();
        // Lee la conexion default
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }

    public static string CreateConnection2(string pUsuario, String pContrasena)
    {

        StringBuilder conexion = new StringBuilder();
        bool existe = false;

        // Validacion de la conexion
        if (ConfigurationManager.ConnectionStrings.Count == 0)
        {
            throw new Exception("No existen registradas ConnectionStrings en el archivo app.config, revise!");
        }

        for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count - 1; i++)
        {
            if (ConfigurationManager.ConnectionStrings[i].Name.Equals("default", StringComparison.InvariantCultureIgnoreCase))
                existe = true;
        }

        if (!existe)
        {
            throw new Exception("No existe registrada en ConnectionStrings del app.config el Key default!");
        }


        // Lee la conexion default
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }

}
