using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene metodos para convertir de
    /// segundos a minutos y viceversa
    /// </summary>
    class HadaP1 
    {
        /// <summary>
        /// Metodo que convierte segundos a minutos
        /// </summary>
        /// <param name="s"> segundos a ser convertidos en minutos </param>
        /// <returns> Devuelve un doble con el contenido de la conversion </returns>
        public static double Seconds2Minutes(double s) {
            return ( s == 0 ? 0 : ( s / 60.0 ) );
        }

        /// <summary>
        /// Metodo que convierte minutos a segundos
        /// </summary>
        /// <param name="m"> minutos a ser convertidos en segundos </param>
        /// <returns> Devuelve un doble con el contenido de la conversion </returns>
        public static double Minutes2Seconds(double m)
        {
            return ( m == 0 ? 0 : ( m / 60.0 ) );
        }
    }
}
