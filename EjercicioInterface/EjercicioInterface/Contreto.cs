using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    internal class Contreto : Imprimible, Iimprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
