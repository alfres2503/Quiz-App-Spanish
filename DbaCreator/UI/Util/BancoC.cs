using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class BancoC
    {
        /// <summary>
        /// Retorna el cambio del dólar actual en colones
        /// </summary>
        /// <returns></returns>
        public static double valorDolar()
        {
            string correoRegistrado = "lusuarezag@est.utn.ac.cr";
            string token = "USPC2ULCZ9";
            string nombreRegistrado = "Alfredo Suárez";
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            Agente.wsindicadoreseconomicosSoapClient cliente = new Agente.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");

            DataSet ds = cliente.ObtenerIndicadoresEconomicos("317",             /* 317 Compra / 318 Venta */
                                                                  DateTime.Now.ToShortDateString(),      /* Fecha Inicial */
                                                                  DateTime.Now.ToShortDateString(),      /* Fecha Final */
                                                                  nombreRegistrado,  /* Su Nombre Registrado BCCR */                                                          "N",
                                                                  correoRegistrado, /* Correo Registrado BCCR */
                                                                  token             /* Token enviado por el BCCR */
                                                                 );
            return (double)ds.Tables[0].Rows[0].Field<decimal>("NUM_VALOR");
        }
    }
}
