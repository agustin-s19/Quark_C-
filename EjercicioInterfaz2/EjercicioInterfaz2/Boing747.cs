using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz2
{
    internal class Boing747 : Ivolador
    {
        int horasVuelo = 0;
        public void Volador()
        {
            horasVuelo = horasVuelo + 13;
            Console.WriteLine( $"Estoy volando como un avión.\n  Cuento con "+ horasVuelo+ " horas de vuelo");
        }
    }
}
