using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class QuickResponse
    {
        /// <summary>
        /// Método que crea el Codigo QR
        /// </summary>
        /// <param name="input">palabra(s) o número a convertir</param>
        /// <param name="qrlevel">Nivel de QR</param>
        /// <returns></returns>
        public static Image QuickResponseGenerador(string input, int qrlevel)
        {

            string toenc = input;

            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; 

            qe.QRCodeVersion = qrlevel;

            System.Drawing.Bitmap bm = qe.Encode(toenc);

            return bm;

        }
    }
}
