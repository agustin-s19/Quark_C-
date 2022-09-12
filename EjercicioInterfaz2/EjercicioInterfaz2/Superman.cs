using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz2
{
    internal class Superman : Ivolador
    {
        int experiencia = 0;
        public void Volador()
        {
            experiencia = experiencia + 3;
            Console.WriteLine($"Estoy volando como un campeón.\n Tengo {experiencia} puntos de experiencia");
        }
    }
}
