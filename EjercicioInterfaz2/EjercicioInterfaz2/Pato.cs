using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz2
{
     class Pato : Ivolador
    {
        int energia = 10;
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un pato... cuak;");
            energia = energia - 5;
            Console.WriteLine(energia);
        }
    }
}
